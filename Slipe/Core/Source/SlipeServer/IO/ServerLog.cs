using Slipe.MtaDefinitions;
using Slipe.Server.Peds;
using Slipe.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.IO
{
    public class ServerLog
    {
        internal ServerLog()
        {

        }

        public void WriteLine(string line)
        {
            MtaServer.OutputServerLog(line);
        }
    }
}
