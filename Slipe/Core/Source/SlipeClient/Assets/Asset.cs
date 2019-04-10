using Slipe.Client.Elements;
using Slipe.MtaDefinitions;
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

            Element.Root.ListenForEvent("onClientFileDownloadComplete");
            ResourceRootElement.OnFileDownloadComplete += HandleDownloadComplete;

        }

        private void HandleDownloadComplete(string path, bool success)
        {
            if (path == filepath)
            {
                this.state = success == true ? DownloadState.Downloaded : DownloadState.Failed;
                ResourceRootElement.OnFileDownloadComplete -= HandleDownloadComplete;
                OnDownloadComplete?.Invoke();
            }
        }


        /// <summary>
        /// Starts a download of the file
        /// </summary>
        public void Download()
        {
            this.state = DownloadState.Downloading;
            MtaClient.DownloadFile(this.filepath);
        }

        public delegate void OnDownloadCompleteHandler();
        /// <summary>
        /// Event that is called after the file has been downloaded
        /// </summary>
        public event OnDownloadCompleteHandler OnDownloadComplete;

    }
}
