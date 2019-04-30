using Slipe.MtaDefinitions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Shared.Elements
{
    [AttributeUsage(AttributeTargets.Constructor, Inherited = false, AllowMultiple = true)]
    public sealed class DefaultElementConstructorAttribute : Attribute
    {

    }
}
