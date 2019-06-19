using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Slipe.MtaDefinitions;
using Slipe.Shared.Elements.Events;
using Slipe.Shared.IO;

namespace Slipe.Shared.Elements
{
    /// <summary>
    /// The main Element class representing an OO version of MTA elements
    /// </summary>
    [DefaultElementClass(ElementType.Element)]
    public class Element
    {
        protected internal MtaElement element;

        #region Properties

        /// <summary>
        /// Get the root element
        /// </summary>
        public static Element Root { get { return ElementManager.Instance.Root; } }

        /// <summary>
        /// Get the MTAElement instance of this class instance
        /// </summary>
        public MtaElement MTAElement
        {
            get
            {
                return element;
            }
        }

        /// <summary>
        /// Get the type of the element
        /// </summary>
        public string Type { get { return MtaShared.GetElementType(element); } }

        /// <summary>
        /// This function gets the ID of an element. This is the "id" attribute of the element and is a string, NOT a number like a model ID, weapons ID or similar.
        /// </summary>
        public string ID
        {
            get
            {
                return MtaShared.GetElementID(element);
            }
            set
            {
                MtaShared.SetElementID(element, value);
            }
        }

        #endregion

        #region Family Properties

        /// <summary>
        /// Get the number of children an element has. Note that only the direct children are counted and not elements that are further down the element tree.
        /// </summary>
        public int ChildCount
        {
            get
            {
                return MtaShared.GetElementChildrenCount(element);
            }
        }

        /// <summary>
        /// Get and set the parent of this element
        /// </summary>
        public Element Parent
        {
            get
            {
                return ElementManager.Instance.GetElement(MtaShared.GetElementParent(element));
            }
            set
            {
                MtaShared.SetElementParent(element, value.MTAElement);
            }
        }

        /// <summary>
        /// This function enables/disables call propagation on a certain element down to its children
        /// </summary>
        public bool CallPropagationEnabled
        {
            get
            {
                return MtaShared.IsElementCallPropagationEnabled(element);
            }
            set
            {
                MtaShared.SetElementCallPropagationEnabled(element, value);
            }
        }

        #endregion

        #region Constructors

        public Element()
        {

        }

        /// <summary>
        /// Create an element from a MTA element instance
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Element(MtaElement mtaElement)
        {
            element = mtaElement;
            ElementManager.Instance.RegisterElement(this);
        }

        /// <summary>
        /// Create a dummy element in the element tree
        /// </summary>
        public Element(string elementType, string elementID = null)
            :this(MtaShared.CreateElement(elementType, elementID)) { }

        #endregion

        #region Methods

        /// <summary>
        /// Sets element data
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="synchronised"></param>
        public void SetData(string key, dynamic value, bool synchronize = false)
        {
            MtaShared.SetElementData(this.MTAElement, key, value, synchronize);
        }

        /// <summary>
        /// Gets element data
        /// </summary>
        /// <param name="key"></param>
        /// <param name="inherit"></param>
        /// <returns></returns>
        public dynamic GetData(string key, bool inherit = false)
        {
            return MtaShared.GetElementData(this.MTAElement, key, inherit);
        }

        /// <summary>
        /// Gets element data
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="inherit"></param>
        /// <returns></returns>
        public dynamic GetData<T>(string key, bool inherit = false)
        {
            return (T)GetData(key, inherit);
        }


        /// <summary>
        /// Desetroys the element
        /// </summary>
        public virtual bool Destroy()
        {
            return MtaShared.DestroyElement(element);
        }

        #endregion

        #region Family Methods

        /// <summary>
        /// This function returns one of the child elements of a given parent element. The child element is selected by its index (0 for the first child, 1 for the second and so on).
        /// </summary>
        public Element GetChild(int index = 0)
        {
            return ElementManager.Instance.GetElement(MtaShared.GetElementChild(element, index));
        }

        /// <summary>
        /// This function is used to retrieve a list of the child elements of a given parent element. Note that it will only return direct children and not elements that are further down the element tree.
        /// </summary>
        public Element[] GetChildren(string ofType = null)
        {
            MtaElement[] mtaElements = MtaShared.GetArrayFromTable(MtaShared.GetElementChildren(element, ofType), "MTAElement");
            return ElementManager.Instance.CastArray<Element>(mtaElements);
        }


        #endregion

        #region Static Methods

        /// <summary>
        /// This function returns an element from the specified ID. If more than one element with the same ID exists, only the first one in the order it appears in the XML tree will be returned by this function.
        /// </summary>
        public static Element GetByID(string id, int index = 0)
        {
            return ElementManager.Instance.GetElement(MtaShared.GetElementByID(id, index));
        }

        /// <summary>
        /// gets Slipe Element from Mta element
        /// </summary>
        /// <param name="mtaElement"></param>
        public static explicit operator Element(MtaElement mtaElement)
        {
            return ElementManager.Instance.GetElement(mtaElement);
        }

        #endregion

        #region Events

        /// <summary>
        /// Adds an eventhandler to this element
        /// </summary>
        public void ListenForEvent(string eventName, bool propagated = true, string priorty = "normal")
        {
            ElementManager.Instance.AddEventHandler(this, eventName, propagated, priorty);
        }

        public virtual void HandleEvent(string eventName, MtaElement source, object p1, object p2, object p3, object p4, object p5, object p6, object p7, object p8)
        {

        }

        #pragma warning disable 67

        public delegate void OnDestroyHandler(Element source, OnDestroyEventArgs eventArgs);
        public event OnDestroyHandler OnDestroy;

#pragma warning restore 67

        #endregion

    }
}
