using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.Peds.Events
{
    public class OnModInfoArgs
    {
        /// <summary>
        /// The filename of the modified file.
        /// </summary>
        public string FileName { get; }

        /// <summary>
        /// Details of each modification within the file
        /// See https://wiki.multitheftauto.com/wiki/OnPlayerModInfo
        /// </summary>
        public dynamic[] Items { get; }

        internal OnModInfoArgs(string fileName, dynamic[] items)
        {
            FileName = fileName;
            Items = items;
        }
    }
}
