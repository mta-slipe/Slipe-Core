using Slipe.MtaDefinitions;
using Slipe.Server.Peds;
using Slipe.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.IO
{
    public class MtaConsole
    {
        internal MtaConsole()
        {

        }

        public void WriteLine(string line, Player player)
        {
            MtaServer.OutputConsole(line, player.MTAElement);
        }

        public void WriteLine(string line)
        {
            MtaServer.OutputConsole(line, Element.Root.MTAElement);
        }
    }
}
