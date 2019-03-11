using MTASharedWrapper;
using System;
using System.Collections.Generic;
using System.Text;
using MultiTheftAuto;

namespace MTAServerWrapper
{
    public class ElementHelper
    {
        private static Dictionary<Type, string> ElementTypeNames = new Dictionary<Type, string>
        {
            [typeof(Element)] = "element",
            [typeof(Vehicle)] = "vehicle",
            [typeof(Player)] = "player",
        };

        public static List<T> GetByType<T>() where T : Element
        {
            List<T> elements = new List<T>();

            if (!ElementTypeNames.ContainsKey(typeof(T)))
            {
                return elements;
            }

            List<dynamic> mtaElements = Shared.GetListFromTable(Server.GetElementsByType(ElementTypeNames[typeof(T)], null));
            foreach (dynamic mtaElement in mtaElements)
            {
                Element element = SharedElementManager.Instance.GetElement((MTAElement)mtaElement);
                if (element != null && element is T)
                {
                    elements.Add((T)element);
                }
            }

            return elements;
        }
    }
}
