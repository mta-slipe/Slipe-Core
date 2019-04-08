using Slipe.MTADefinitions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Shared.Elements
{
    public interface IElementHelper
    {
        Element InstantiateElement(string type, MTAElement element);
    }
}
