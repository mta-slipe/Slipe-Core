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
        private List<Tuple<int, bool>> modelsToApply;

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
            this.modelsToApply = new List<Tuple<int, bool>>();
        }

        /// <summary>
        /// Creates a new mod using TXD, DFF and COL filepaths
        /// </summary>
        /// <param name="txdFilepath"></param>
        /// <param name="dffFilepath"></param>
        /// <param name="colFilepath"></param>
        public Mod(string txdFilepath = null, string dffFilepath = null, string colFilepath = null)
        {
            if(txdFilepath != null)
            {
                this.txd = new Txd(txdFilepath);
            }            
            if (dffFilepath != null)
            {
                this.dff = new Dff(dffFilepath);
            }
            if (colFilepath != null)
            {
                this.col = new Col(colFilepath);
            }
            this.state = DownloadState.Default;
            this.modelsToApply = new List<Tuple<int, bool>>();
        }

        /// <summary>
        /// Downloads, loads and applies all files required for this mod.
        /// </summary>
        public void ApplyTo(int model, bool supportsAlpha = false)
        {
            if (this.state == DownloadState.Downloaded)
            {
                ApplyFiles(model, supportsAlpha);
                return;
            } else if(this.state == DownloadState.Downloading)
            {
                modelsToApply.Add(new Tuple<int, bool>(model, supportsAlpha));
                return;
            }

            this.state = DownloadState.Downloading;
            modelsToApply.Add(new Tuple<int, bool>(model, supportsAlpha));

            if (this.txd != null)
            {
                this.txd.OnDownloadComplete += OnFileDownload;
                this.txd.Download();
            }

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
                this.txd != null && this.txd.State != DownloadState.Downloaded ||
                this.dff != null && this.dff.State != DownloadState.Downloaded ||
                this.col != null && this.col.State != DownloadState.Downloaded
            )
            {
                return;
            }
            this.state = DownloadState.Downloaded;
            this.OnDownloadComplete?.Invoke();
            ApplyFiles();
        }

        private void ApplyFiles(int model = -1, bool supportsAlpha = false)
        {
            if (model == -1)
            {
                foreach(var mod in modelsToApply)
                {
                    ApplyFiles(mod.Item1, supportsAlpha || mod.Item2);
                }
                return;
            }
            if (this.txd != null)
            {
                this.txd.Load();
                this.txd.ApplyTo(model);
            }
            if (this.dff != null)
            {
                this.dff.Load();
                this.dff.ApplyTo(model, supportsAlpha);
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

        public delegate void OnDownloadCompleteHandler();
        /// <summary>
        /// Event that is called after the file has been downloaded
        /// </summary>
        public event OnDownloadCompleteHandler OnDownloadComplete;
    }
}
