using Slipe.Client.Elements;
using Slipe.Client.IO.Events;
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
        public static bool Active
        {
            get
            {
                return MtaClient.IsDebugViewActive();
            }
        }

#pragma warning disable 67

        public delegate void OnMessageHandler(RootElement source, OnDebugMessageEventArgs eventArgs);
        public static event OnMessageHandler OnMessage;

#pragma warning enable 67
    }
}
