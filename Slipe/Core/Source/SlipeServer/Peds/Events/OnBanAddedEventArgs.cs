using Slipe.MtaDefinitions;
using Slipe.Server.Accounts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.Peds.Events
{
    public class OnBanAddedEventArgs
    {
        /// <summary>
        /// The ban which was added.
        /// </summary>
        public Ban Ban { get; }

        internal OnBanAddedEventArgs(MtaBan ban)
        {
            Ban = new Ban(ban);
        }        
    }
}
