using Slipe.MtaDefinitions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.Accounts.Events
{
    public class OnAddedEventArgs
    {
        /// <summary>
        /// The ban that was added
        /// </summary>
        public Ban Ban { get; }

        internal OnAddedEventArgs(MtaBan ban)
        {
            Ban = new Ban(ban);
        }
    }
}
