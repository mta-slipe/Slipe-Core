using SlipeLua.Shared.IO;
using System;
using System.Collections.Generic;
using SlipeLua.Shared.Utilities;
using System.Text;
using SlipeLua.Server.IO.Events;
using SlipeLua.Server.Elements;
using SlipeLua.Shared.Elements;

namespace SlipeLua.Server.IO
{
    public class MtaDebug: SharedMtaDebug
    {
        internal MtaDebug() { }

#pragma warning disable 67
        public delegate void OnMessageHandler(Element source, OnDebugMessageEventArgs eventArgs);
        public static event OnMessageHandler OnMessage;
#pragma warning enable 67
    }
}
