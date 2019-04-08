using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client.Assets
{
    public class CustomAnimation
    {
        private Ifp ifp;
        private string filepath;
        private string animationBlock;

        public CustomAnimation(string filepath)
        {
            this.ifp = new Ifp(filepath);
            this.filepath = filepath;
        }

        /// <summary>
        /// Downloads and loads the .ifp files into the specified animation block.
        /// </summary>
        public void ApplyTo(string animationBlock)
        {
            this.animationBlock = animationBlock;
            this.ifp.OnDownloadComplete += OnFileDownload;
            this.ifp.Download();
        }

        private void OnFileDownload()
        {
            ifp.Load(this.animationBlock);
        }
    }
}
