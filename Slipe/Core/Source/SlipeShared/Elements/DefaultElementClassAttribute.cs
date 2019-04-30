using Slipe.MtaDefinitions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Shared.Elements
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
    public sealed class DefaultElementClassAttribute : Attribute
    {
        readonly string elementType;

        public DefaultElementClassAttribute(string elementType)
        {
            this.elementType = elementType;
        }

        public string ElementType
        {
            get { return elementType; }
        }

    }
}
