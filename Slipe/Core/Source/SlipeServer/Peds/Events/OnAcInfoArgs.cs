using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.Peds.Events
{
    public class OnAcInfoArgs
    {
        /// <summary>
        /// An array of anti-cheat codes the player has triggered.
        /// </summary>
        public string[] DetectedAcList { get; }

        /// <summary>
        /// A number representing the file size of any custom d3d9.dll the player may have installed.
        /// </summary>
        public int D3d9Size { get; }

        /// <summary>
        /// A string containing the MD5 of any custom d3d9.dll the player may have installed.
        /// </summary>
        public string D3d9Md5 { get; }

        /// <summary>
        /// A string containing the SHA256 of any custom d3d9.dll the player may have installed.
        /// </summary>
        public string D3d9Sha256 { get; }

        internal OnAcInfoArgs(string[] detectedAcList, int d3d9Size, string d3d9Md5, string d3d9Sha256)
        {
            DetectedAcList = detectedAcList;
            D3d9Size = d3d9Size;
            D3d9Md5 = d3d9Md5;
            D3d9Sha256 = d3d9Sha256;
        }
    }
}
