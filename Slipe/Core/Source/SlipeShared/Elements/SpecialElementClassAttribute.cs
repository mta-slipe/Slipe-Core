using Slipe.MtaDefinitions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Shared.Elements
{
    [System.AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
    public sealed class SpecialElementClass : Attribute
    {
        public SpecialElementClass(Func<MtaElement, bool> condition)
        {
            Condition = condition;
        }

        public Func<MtaElement, bool> Condition { get; }
    }
}
