using Slipe.Shared.IO;
using System;
using System.Collections.Generic;
using Slipe.Shared.Utilities;
using System.Text;

namespace Slipe.Server.IO
{
    public class MtaDebug: SharedMtaDebug
    {
        internal MtaDebug()
        {

        }

        internal void HandleMessage(string message, DebugMessageLevel level, string file, int line, Color color)
        {
            OnMessage?.Invoke(message, level, file, line, color);
        }

        public delegate void OnMessageHandler(string message, DebugMessageLevel level, string file, int line, Color color);
        public static event OnMessageHandler OnMessage;
    }
}
