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
        internal MtaDebug() { }

#pragma warning disable 67
        public delegate void OnMessageHandler(Element source, OnDebugMessageEventArgs eventArgs);
        public static event OnMessageHandler OnMessage;
#pragma warning enable 67
    }
}
