﻿using SlipeLua.MtaDefinitions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Client.Browsers.Events
{
    public class OnWhiteListChangeEventArgs
    {
        /// <summary>
        /// All the domains that were changed
        /// </summary>
        public string[] ChangedDomains { get; }

        internal OnWhiteListChangeEventArgs(dynamic list)
        {
            ChangedDomains = MtaShared.GetArrayFromTable(list, "System.String");
        }
    }
}
