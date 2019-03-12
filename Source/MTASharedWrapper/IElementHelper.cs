using MultiTheftAuto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTASharedWrapper
{
    public interface IElementHelper
    {
        Element InstantiateElement(string type, MTAElement element);
    }
}
