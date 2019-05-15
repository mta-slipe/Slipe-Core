using Slipe.Server.Accounts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.Peds.Events
{
    public class OnBanAddedArgs
    {
        /// <summary>
        /// The ban which was added.
        /// </summary>
        public Ban Ban { get; }

        internal OnBanAddedArgs(Ban ban)
        {
            Ban = ban;
        }        
    }
}
