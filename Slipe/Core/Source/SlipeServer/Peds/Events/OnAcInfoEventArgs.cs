using Slipe.MtaDefinitions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.Peds.Events
{
    public class OnAcInfoEventArgs
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

        internal OnAcInfoEventArgs(dynamic detectedAcList, dynamic d3d9Size, dynamic d3d9Md5, dynamic d3d9Sha256)
        {
            DetectedAcList = MtaShared.GetArrayFromTable<string>(detectedAcList, "System.String");
            D3d9Size = (int) d3d9Size;
            D3d9Md5 = (string) d3d9Md5;
            D3d9Sha256 = (string) d3d9Sha256;
        }
    }
}
