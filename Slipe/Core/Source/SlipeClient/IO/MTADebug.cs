using SlipeLua.Client.Elements;
using SlipeLua.Client.IO.Events;
using SlipeLua.MtaDefinitions;
using SlipeLua.Shared.IO;
using SlipeLua.Shared.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Client.IO
{
    public class MtaDebug : SharedMtaDebug
    {
        public static bool Active
        {
            get
            {
                return MtaClient.IsDebugViewActive();
            }
            set
            {
                MtaClient.SetDebugViewActive(value);
            }
        }

#pragma warning disable 67

        public delegate void OnMessageHandler(RootElement source, OnDebugMessageEventArgs eventArgs);
        public static event OnMessageHandler OnMessage;

#pragma warning enable 67
    }
}
