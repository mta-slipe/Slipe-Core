using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Slipe.Client.Assets
{
    /// <summary>
    /// A single mod, consisting of a .txd and optionally a .dff and .col
    /// </summary>
    public class Mod
    {
        private Dff dff;
        private Txd txd;
        private Col col;
        private List<int> modelsToApply;

        private DownloadState state;

        /// <summary>
        /// Creates a new Mod using TXD, DFF and COL instances
        /// </summary>
        /// <param name="txd"></param>
        /// <param name="dff"></param>
        /// <param name="col"></param>
        public Mod(Txd txd = null, Dff dff = null, Col col = null)
        {
            this.txd = txd;
            this.dff = dff;
            this.col = col;
            this.state = DownloadState.Default;
            this.modelsToApply = new List<int>();
        }

        /// <summary>
        /// Creates a new mod using TXD, DFF and COL filepaths
        /// </summary>
        /// <param name="txdFilepath"></param>
        /// <param name="dffFilepath"></param>
        /// <param name="colFilepath"></param>
        public Mod(string txdFilepath, string dffFilepath = null, string colFilepath = null)
        {
            this.txd = new Txd(txdFilepath);
            if (dffFilepath != null)
            {
                this.dff = new Dff(dffFilepath);
            }
            if (colFilepath != null)
            {
                this.col = new Col(colFilepath);
            }
            this.state = DownloadState.Default;
            this.modelsToApply = new List<int>();
        }

        /// <summary>
        /// Downloads, loads and applies all files required for this mod.
        /// </summary>
        public void ApplyTo(int model)
        {
            if (this.state == DownloadState.Downloaded)
            {
                ApplyFiles(model);
                return;
            } else if(this.state == DownloadState.Downloading)
            {
                modelsToApply.Add(model);
                return;
            }

            this.state = DownloadState.Downloading;
            modelsToApply.Add(model);

            this.txd.OnDownloadComplete += OnFileDownload;
            this.txd.Download();

            if (this.dff != null)
            {
                this.dff.OnDownloadComplete += OnFileDownload;
                this.dff.Download();
            }

            if (this.col != null)
            {
                this.col.OnDownloadComplete += OnFileDownload;
                this.col.Download();
            }
        }

        private void OnFileDownload()
        {
            if (
                this.txd.State != DownloadState.Downloaded ||
                this.dff != null && this.dff.State != DownloadState.Downloaded ||
                this.col != null && this.col.State != DownloadState.Downloaded
            )
            {
                return;
            }
            this.state = DownloadState.Downloaded;
            ApplyFiles();
        }

        private void ApplyFiles(int model = -1)
        {
            if (model == -1)
            {
                foreach(int numericModel in modelsToApply)
                {
                    ApplyFiles(numericModel);
                }
                return;
            }
            this.txd.Load();
            this.txd.ApplyTo(model);
            if (this.dff != null)
            {
                this.dff.Load();
                this.dff.ApplyTo(model);
            }

            if (this.col != null)
            {
                this.col.Load();
                this.col.ApplyTo(model);
            }
        }

        public void Restore(int model)
        {
            if (this.dff != null)
            {
                Dff.Restore(model);
            }
            if (this.col != null)
            {
                Col.Restore(model);
            }
        }
    }
}
