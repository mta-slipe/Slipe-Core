using Slipe.MTADefinitions;
using Slipe.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Slipe.Client.Assets
{
    /// <summary>
    /// Represents a single asset file.
    /// </summary>
    public class Asset
    {
        protected string filepath;
        /// <summary>
        /// Filepath of the asset
        /// </summary>
        public string Filepath { get => filepath; }

        protected DownloadState state;
        /// <summary>
        /// Current download state of the asset
        /// </summary>
        public DownloadState State { get { return state; } }

        /// <summary>
        /// Creates a new asset with a specific filepath;
        /// </summary>
        /// <param name="filepath"></param>
        public Asset(string filepath)
        {
            this.state = DownloadState.Default;
            this.filepath = filepath;

            Element.Root.AddEventHandler("onClientFileDownloadComplete");
            Element.OnRootEvent += HandleRootEvent;
        }

        private void HandleRootEvent(string eventName, MTAElement source, dynamic p1, dynamic p2, dynamic p3, dynamic p4, dynamic p5, dynamic p6, dynamic p7, dynamic p8)
        {
            if (eventName == "onClientFileDownloadComplete")
            {
                if ((string) p1 == filepath)
                {
                    this.state = (bool)p2 == true ? DownloadState.Downloaded : DownloadState.Failed;
                    Element.OnRootEvent -= HandleRootEvent;
                    OnDownloadComplete?.Invoke();
                }
            }
        }


        /// <summary>
        /// Starts a download of the file
        /// </summary>
        public void Download()
        {
            this.state = DownloadState.Downloading;
            MTAClient.DownloadFile(this.filepath);
        }

        public delegate void OnDownloadCompleteHandler();
        /// <summary>
        /// Event that is called after the file has been downloaded
        /// </summary>
        public event OnDownloadCompleteHandler OnDownloadComplete;

    }
}
