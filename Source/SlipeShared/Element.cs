using System;
using System.Collections.Generic;
using System.Text;
using Slipe.Shared.CollisionShapes;
using Slipe.MTADefinitions;
using System.Numerics;
using System.Diagnostics;

namespace Slipe.Shared
{
    public class Element
    {
        protected internal MTAElement element;

        public static Element Root { get { return ElementManager.Instance.Root; } }

        public MTAElement MTAElement
        {
            get
            {
                return element;
            }
        }

        public string Type { get { return MTAShared.GetElementType(element); } }

        public Element()
        {
        }

        public Element(MTAElement mtaElement)
        {
            element = mtaElement;
            ElementManager.Instance.RegisterElement(this);
        }

        public bool Destroy()
        {
            return MTAShared.DestroyElement(element);
        }

        public bool AttachTo(Element element, Vector3 offset, Vector3 rotationOffset)
        {
            return MTAShared.AttachElements(this.element, element.element, offset.X, offset.Y, offset.Z, rotationOffset.X, rotationOffset.Y, rotationOffset.Z);
        }

        public bool AttachTo(Element element, Vector3 offset)
        {
            return AttachTo(element, offset, new Vector3(0, 0, 0));
        }

        public void AddEventHandler(string eventName, bool propagated = true, string priorty = "normal") {
            ElementManager.Instance.AddEventHandler(this, eventName, propagated, priorty);
        }

        public virtual void HandleEvent(string eventName, MTAElement source, dynamic p1, dynamic p2, dynamic p3, dynamic p4, dynamic p5, dynamic p6, dynamic p7, dynamic p8)
        {
            Debug.WriteLine(eventName + " has been triggered");

            if (this == Root)
            {
                OnRootEvent?.Invoke(eventName, source, p1, p2, p3, p4, p5, p6, p7, p8);
            }
        }

        public delegate void OnRootEventHandler(string eventName, MTAElement source, dynamic p1, dynamic p2, dynamic p3, dynamic p4, dynamic p5, dynamic p6, dynamic p7, dynamic p8);
        public static event OnRootEventHandler OnRootEvent;
    }
}
