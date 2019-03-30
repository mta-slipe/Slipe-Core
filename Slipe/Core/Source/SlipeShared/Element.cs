using System;
using System.Collections.Generic;
using System.Text;
using Slipe.Shared.CollisionShapes;
using Slipe.MTADefinitions;
using System.Numerics;
using System.Diagnostics;

namespace Slipe.Shared
{
    /// <summary>
    /// The main Element class representing an OO version of MTA elements
    /// </summary>
    public class Element
    {
        protected internal MTAElement element;

        /// <summary>
        /// Get the root element
        /// </summary>
        public static Element Root { get { return ElementManager.Instance.Root; } }

        /// <summary>
        /// Get the MTAElement instance of this class instance
        /// </summary>
        public MTAElement MTAElement
        {
            get
            {
                return element;
            }
        }

        /// <summary>
        /// Get the type of the element
        /// </summary>
        public string Type { get { return MTAShared.GetElementType(element); } }

        public Element()
        {
        }

        /// <summary>
        /// Create an element from a MTA element instance
        /// </summary>
        public Element(MTAElement mtaElement)
        {
            element = mtaElement;
            ElementManager.Instance.RegisterElement(this);
        }

        /// <summary>
        /// Desetroys the element
        /// </summary>
        /// <returns></returns>
        public bool Destroy()
        {
            return MTAShared.DestroyElement(element);
        }

        /// <summary>
        /// Adds an eventhandler to this element
        /// </summary>
        public void AddEventHandler(string eventName, bool propagated = true, string priorty = "normal") {
            ElementManager.Instance.AddEventHandler(this, eventName, propagated, priorty);
        }

        /// <summary>
        /// Used to handle events that are triggered on the attached MTA element
        /// </summary>
        public virtual void HandleEvent(string eventName, MTAElement source, dynamic p1, dynamic p2, dynamic p3, dynamic p4, dynamic p5, dynamic p6, dynamic p7, dynamic p8)
        {
            if (this == Root)
            {
                OnRootEvent?.Invoke(eventName, source, p1, p2, p3, p4, p5, p6, p7, p8);
            }
        }

        public delegate void OnRootEventHandler(string eventName, MTAElement source, dynamic p1, dynamic p2, dynamic p3, dynamic p4, dynamic p5, dynamic p6, dynamic p7, dynamic p8);
        public static event OnRootEventHandler OnRootEvent;
    }
}
