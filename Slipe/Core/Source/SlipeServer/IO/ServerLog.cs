using SlipeLua.MtaDefinitions;
using SlipeLua.Server.Peds;
using SlipeLua.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Server.IO
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
