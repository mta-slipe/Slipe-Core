using SlipeLua.MtaDefinitions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Shared.Elements
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
    public sealed class DefaultElementClassAttribute : Attribute
    {
        readonly string elementType;

        /// <summary>
        /// Designate a class to always be the default class when Mta elements are wrapped in Slipe classes
        /// </summary>
        /// <param name="elementType">A string representation of a custom element type</param>
        public DefaultElementClassAttribute(string type)
        {
            elementType = type;
        }

        /// <summary>
        /// Designate a class to always be the default class when Mta elements are wrapped in Slipe classes
        /// </summary>
        /// <param name="type">An enum representing the element type</param>
        public DefaultElementClassAttribute(ElementType type)
        {
            elementType = type.ToString().ToLower();
            elementType = elementType.Replace("gui", "gui-");
        }

        public string ElementType
        {
            get { return elementType; }
        }

    }
}
