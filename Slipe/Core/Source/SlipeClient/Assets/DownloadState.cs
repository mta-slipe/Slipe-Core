using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Client.Assets
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
