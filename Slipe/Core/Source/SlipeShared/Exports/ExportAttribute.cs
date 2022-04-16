using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Shared.Exports
{
    [AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
    public sealed class ExportAttribute : Attribute
    {
        public string Name { get; set; }
        public bool IsHttp { get; set; }

        public ExportAttribute(string name = null, bool isHttp = false)
        {
            this.Name = name;
            this.IsHttp = isHttp;
        }
    }
}
