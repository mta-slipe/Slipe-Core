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
        /// This function returns an element from the specified ID. If more than one element with the same ID exists, only the first one in the order it appears in the XML tree will be returned by this function.
        /// </summary>
        public static Element GetByID(string id, int index = 0)
        {
            return ElementManager.Instance.GetElement(MTAShared.GetElementByID(id, index));
        }

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
        /// Create a dummy element in the element tree
        /// </summary>
        public Element(string elementType, string elementID = null)
        {
            element = MTAShared.CreateElement(elementType, elementID);
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
        /// This function returns one of the child elements of a given parent element. The child element is selected by its index (0 for the first child, 1 for the second and so on).
        /// </summary>
        public Element GetChild(int index = 0)
        {
            return ElementManager.Instance.GetElement(MTAShared.GetElementChild(element, index));
        }

        /// <summary>
        /// This function is used to retrieve a list of the child elements of a given parent element. Note that it will only return direct children and not elements that are further down the element tree.
        /// </summary>
        public Element[] GetChildren(string ofType = null)
        {
            MTAElement[] mtaElements = MTAShared.GetArrayFromTable(MTAShared.GetElementChildren(element, ofType), "MTAElement");
            Element[] elements = new Element[mtaElements.Length];
            for (int i = 0; i < mtaElements.Length; i++)
            {
                elements[i] = new Element(mtaElements[i]);
            }
            return elements;
        }

        /// <summary>
        /// Get the number of children an element has. Note that only the direct children are counted and not elements that are further down the element tree.
        /// </summary>
        public int ChildCount
        {
            get
            {
                return MTAShared.GetElementChildrenCount(element);
            }
        }

        /// <summary>
        /// Get and set the parent of this element
        /// </summary>
        public Element Parent
        {
            get
            {
                return ElementManager.Instance.GetElement(MTAShared.GetElementParent(element));
            }
            set
            {
                MTAShared.SetElementParent(element, value.MTAElement);
            }
        }

        /// <summary>
        /// This function gets the ID of an element. This is the "id" attribute of the element and is a string, NOT a number like a model ID, weapons ID or similar.
        /// </summary>
        public string ID
        {
            get
            {
                return MTAShared.GetElementID(element);
            }
            set
            {
                MTAShared.SetElementID(element, value);
            }
        }

        /// <summary>
        /// This function enables/disables call propagation on a certain element down to its children
        /// </summary>
        public bool CallPropagationEnabled
        {
            get
            {
                return MTAShared.IsElementCallPropagationEnabled(element);
            }
            set
            {
                MTAShared.SetElementCallPropagationEnabled(element, value);
            }
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
