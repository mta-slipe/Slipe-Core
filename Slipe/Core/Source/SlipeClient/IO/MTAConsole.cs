using SlipeLua.MtaDefinitions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Client.IO
{
    public class MtaConsole
    {
        internal MtaConsole()
        {

        }

        public bool Active
        {
            get
            {
                return MtaClient.IsConsoleActive();
            }
        }

        public void WriteLine(string line)
        {
            MtaClient.OutputConsole(line);
        }
    }
}
