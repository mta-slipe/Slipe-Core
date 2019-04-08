using Slipe.MtaDefinitions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Shared.Elements
{
    public interface IElementHelper
    {
        Element InstantiateElement(string type, MtaElement element);
    }
}
