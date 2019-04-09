using Slipe.MtaDefinitions;
using Slipe.Shared.IO;
using Slipe.Shared.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client.IO
{
    public class MTADebug : SharedMTADebug
    {
        protected internal MTADebug()
        {

        }

        public bool Active
        {
            get
            {
                return MtaClient.IsDebugViewActive();
            }
        }
    }
}
