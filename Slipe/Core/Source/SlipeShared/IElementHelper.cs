using Slipe.MTADefinitions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Shared
{
    public interface IElementHelper
    {
        Element InstantiateElement(string type, MTAElement element);
    }
}
