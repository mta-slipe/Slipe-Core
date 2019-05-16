using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Shared.Exports
{
    [AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
    public sealed class ExportAttribute : Attribute
    {
        public string Name { get; set; }

        public ExportAttribute(string name = null)
        {
            this.Name = name;
        }
    }
}
