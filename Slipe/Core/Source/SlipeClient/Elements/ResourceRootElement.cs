using Slipe.MtaDefinitions;
using Slipe.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client.Elements
{
    public class ResourceRootElement : Element
    {
        public ResourceRootElement(MtaElement element) : base(element)
        {

        }

        public delegate void OnFileDownloadCompleteHandler(string path, bool success);
        public static event OnFileDownloadCompleteHandler OnFileDownloadComplete;
    }
}
