using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client.Assets
{
    /// <summary>
    /// Indicates the download state of an asset file
    /// </summary>
    public enum DownloadState
    {
        Default,
        Downloading,
        Downloaded,
        Failed
    }
}
