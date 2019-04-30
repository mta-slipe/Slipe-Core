using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Slipe.MtaDefinitions;

namespace Slipe.Shared.Elements
{
    /// <summary>
    /// Class that manages MTAElement functionality and 
    /// </summary>
    public class ElementManager
    {
        private static ElementManager instance;

        /// <summary>
        /// Get the singleton instance of this class
        /// </summary>
        public static ElementManager Instance
        {
            get
            {
                instance = instance ?? new ElementManager();
                return instance;
            }
        }

        private Element root;

        /// <summary>
        /// Returns the root MTA element
        /// </summary>
        public Element Root {
            get
            {
                if(root == null)
                    root = GetElement(MtaShared.GetRootElement());
                return root;
            }
        }

        private Dictionary<object, Element> elements;
        private Dictionary<string, Type> defaultElementTypes;
        private Dictionary<Type, string> defaultElementTypeNames;

        /// <summary>
        /// Creates the ElementManager given an IElementHelper class that maps MTA elements to classes
        /// </summary>
        public ElementManager()
        {
            elements = new Dictionary<object, Element>();
            defaultElementTypes = new Dictionary<string, Type>();
            defaultElementTypeNames = new Dictionary<Type, string>();

            Type[] defaultClasses = Assembly.GetAssembly(typeof(ElementManager)).GetExportedTypes();
            foreach(Type type in defaultClasses)
            {
                object[] customAttributes = type.GetCustomAttributes(typeof(DefaultElementClassAttribute), false);
                foreach (object a in customAttributes)
                {
                    DefaultElementClassAttribute attribute = (DefaultElementClassAttribute)a;
                    defaultElementTypes[attribute.ElementType] = type;
                    defaultElementTypeNames[type] = attribute.ElementType;
                }
            }
        }

        /// <summary>
        /// Registers an element class
        /// </summary>
        public void RegisterElement(Element element)
        {
            elements.Add(element.MTAElement, element);
        }

        /// <summary>
        /// Gets an element class instance given a certain MTA element
        /// </summary>
        public Element GetElement(MtaElement element)
        {
            if (element == null)
            {
                return null;
            }
            if(!MtaShared.IsElement(element))
            {
                return null;
            }
            if (!elements.ContainsKey(element))
            {
                string mtaElementType = MtaShared.GetElementType(element);
                Type elementType;
                object builtElement = null;

                try
                {
                    elementType = defaultElementTypes[mtaElementType];
                } catch(KeyNotFoundException)
                {
                    elementType = typeof(Element);
                }

                foreach (MethodInfo info in elementType.GetMethods())
                {
                    object[] customAttributes = info.GetCustomAttributes(typeof(DefaultElementConstructorAttribute), false);
                    foreach (DefaultElementConstructorAttribute a in customAttributes)
                    {
                        /*
                        [[
                            builtElement = setmetatable({}, elementType[1])
                            local ctor = info.metadata[3]
                            if ctor == nil then
                                ctor = elementType[1].__ctor__
                            end
                            ctor(builtElement, element)
                        ]]
                        */
                        return (Element)builtElement;
                    }
                }
                return null;
            }
            return elements[element];
        }

        /// <summary>
        /// Cast an array of MTAElements to a desired type
        /// </summary>
        public T[] CastArray<T>(MtaElement[] elements) where T : Element
        {
            T[] result = new T[elements.Length];
            for (int i = 0; i < elements.Length; i++)
            {
                result[i] = (T)Instance.GetElement(elements[i]);
            }
            return result;
        }

        /// <summary>
        /// Get the string representation of an element type
        /// </summary>
        /// <param name="type">The Slipe class of the element</param>
        /// <returns>A string describing the MTA element type</returns>
        public string GetTypeName(Type type)
        {
            return defaultElementTypeNames[type];
        }

        /// <summary>
        /// Get a list of all classes of a specific element
        /// </summary>
        public List<T> GetByType<T>(Element startAt, bool streamedIn = false) where T : Element
        {
            List<T> elements = new List<T>();

            if (!defaultElementTypeNames.ContainsKey(typeof(T)))
            {
                return elements;
            }

            List<dynamic> mtaElements = MtaShared.GetListFromTable(MtaClient.GetElementsByType(defaultElementTypeNames[typeof(T)], startAt.MTAElement, streamedIn), "element");
            foreach (dynamic mtaElement in mtaElements)
            {
                Element element = GetElement((MtaElement)mtaElement);
                if (element != null && element is T)
                {
                    elements.Add((T)element);
                }
            }

            return elements;
        }

        /// <summary>
        /// Get a list of all classes of a specific element
        /// </summary>
        public List<T> GetByType<T>() where T : Element
        {
            return GetByType<T>(root);
        }

        protected internal void AddEventHandler(Element element, string eventName, bool propagated = true, string priorty = "normal")
        {
            MtaShared.AddEventHandler(eventName, element.MTAElement, "Slipe.Shared.Elements.ElementManager.HandleEvent", propagated, priorty);
        }

        /// <summary>
        /// Handles an event when it's triggered on a specific MTA element
        /// </summary>
        public static void HandleEvent(string eventString, MtaElement source, object p1, object p2, object p3, object p4, object p5, object p6, object p7, object p8)
        {
            Element.Root.HandleEvent(eventString, source, p1, p2, p3, p4, p5, p6, p7, p8);
        }

    }
}
