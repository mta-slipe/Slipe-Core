using MultiTheftAuto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTASharedWrapper
{
    public class SharedElementManager
    {
        private static SharedElementManager instance;
        public static SharedElementManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SharedElementManager();
                }
                return instance;
            }
        }

        //private Dictionary<Element, SharedElement> elements;
        private Dictionary<System.Object, SharedElement> elements;

        public SharedElementManager()
        {
            elements = new Dictionary<System.Object, SharedElement>();
        }

        public void RegisterElement(SharedElement element)
        {
            elements.Add(element.MTAElement, element);
        }

        public SharedElement GetElement(Element element)
        {
            return this.elements[element];
        }

        protected internal void AddEventHandler(SharedElement element, string eventName, bool propagated = true, string priorty = "normal")
        {
            Shared.AddEventHandler(eventName, element.MTAElement, "MTASharedWrapper.SharedElementManager.HandleEvent", propagated, priorty);
        }

        public static void HandleEvent(string eventString, Element source, dynamic p1, dynamic p2, dynamic p3, dynamic p4, dynamic p5, dynamic p6, dynamic p7, dynamic p8)
        {
            Instance.GetElement(source).HandleEvent(eventString, p1, p2, p3, p4, p5, p6, p7, p8);
        }

    }
}
