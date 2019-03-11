using MultiTheftAuto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTASharedWrapper
{
    public class ElementManager
    {
        private static ElementManager instance;
        public static ElementManager Instance
        {
            get
            {
                return instance ?? new ElementManager();
            }
        }


        private Element root;
        public Element Root { get { return root; } }

        private Dictionary<System.Object, Element> elements;

        public ElementManager()
        {
            instance = this;
            elements = new Dictionary<System.Object, Element>();
            root = new Element(Shared.GetRootElement());
        }

        public void RegisterElement(Element element)
        {
            elements.Add(element.MTAElement, element);
        }

        public Element GetElement(MultiTheftAuto.MTAElement element)
        {
            if (!this.elements.ContainsKey(element))
            {
                //TODO: Create new element of correct type
                return null;
            }
            return this.elements[element];
        }

        protected internal void AddEventHandler(Element element, string eventName, bool propagated = true, string priorty = "normal")
        {
            Shared.AddEventHandler(eventName, element.MTAElement, "MTASharedWrapper.ElementManager.HandleEvent", propagated, priorty);
        }

        public static void HandleEvent(string eventString, MTAElement source, dynamic p1, dynamic p2, dynamic p3, dynamic p4, dynamic p5, dynamic p6, dynamic p7, dynamic p8)
        {
            Element element = Instance.GetElement(source);
            if (element == null)
            {
                // if the resource is not aware of the referenced element's existance have the root element handle it instead
                // this is particularly useful for playerJoin, since the player element will not exist before that yet
                Element.Root.HandleEvent(eventString, source, p1, p2, p3, p4, p5, p6, p7, p8);
                return;
            }
            element.HandleEvent(eventString, source, p1, p2, p3, p4, p5, p6, p7, p8);
        }

    }
}
