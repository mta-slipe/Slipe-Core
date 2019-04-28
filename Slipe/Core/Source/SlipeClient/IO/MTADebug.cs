using Slipe.MtaDefinitions;
using Slipe.Shared.IO;
using Slipe.Shared.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client.IO
{
    public class MtaDebug : SharedMtaDebug
    {
        protected internal MtaDebug()
        {

        }

        public bool Active
        {
            get
            {
                return MtaClient.IsDebugViewActive();
            }
        }

        internal void HandleMessage(string message, DebugMessageLevel level, string file, int line, Color color)
        {
            OnMessage?.Invoke(message, level, file, line, color);
        }

        public delegate void OnMessageHandler(string message, DebugMessageLevel level, string file, int line, Color color);
        public static event OnMessageHandler OnMessage;
    }
}
