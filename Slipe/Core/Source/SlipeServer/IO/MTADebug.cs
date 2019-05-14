using Slipe.Shared.IO;
using System;
using System.Collections.Generic;
using Slipe.Shared.Utilities;
using System.Text;
using Slipe.Server.IO.Events;
using Slipe.Server.Elements;
using Slipe.Shared.Elements;

namespace Slipe.Server.IO
{
    public class MtaDebug: SharedMtaDebug
    {
        internal MtaDebug()
        {

        }

        internal void HandleMessage(string message, DebugMessageLevel level, string file, int line, Color color)
        {
            OnMessage?.Invoke((RootElement)Element.Root, new OnDebugMessageArgs(message, level, file, line, color));
        }

        public delegate void OnMessageHandler(Element source, OnDebugMessageArgs eventArgs);
        public static event OnMessageHandler OnMessage;
    }
}
