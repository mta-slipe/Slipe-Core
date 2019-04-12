using Slipe.MtaDefinitions;
using Slipe.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;
using Slipe.Client.Resources;

namespace Slipe.Client.Elements
{
    public class ResourceRootElement : Element
    {
        public ResourceRootElement(MtaElement element) : base(element)
        {

        }

        #pragma warning disable 67

        public delegate void OnFileDownloadCompleteHandler(string path, bool success);
        public static event OnFileDownloadCompleteHandler OnFileDownloadComplete;

        public delegate void OnStartHandler(Resource resource);
        public event OnStartHandler OnStart;

        public delegate void OnStopHandler(Resource resource);
        public event OnStopHandler OnStop;

        #pragma warning restore 67

    }
}
