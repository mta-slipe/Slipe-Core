using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Server.Peds.Events
{
    public class OnModInfoEventArgs
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

        internal OnModInfoEventArgs(dynamic fileName, dynamic[] items)
        {
            FileName = (string) fileName;
            Items = items;
        }
    }
}
