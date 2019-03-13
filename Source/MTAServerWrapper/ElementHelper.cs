using MTASharedWrapper;
using System;
using System.Collections.Generic;
using System.Text;
using MultiTheftAuto;

namespace MTAServerWrapper
{
    public class ElementHelper: IElementHelper
    {
        private static Dictionary<Type, string> ElementTypeNames = new Dictionary<Type, string>
        {
            [typeof(Element)] = "element",
            [typeof(Vehicle)] = "vehicle",
            [typeof(Player)] = "player",
            [typeof(MTAObject)] = "object",
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
                Element element = ElementManager.Instance.GetElement((MTAElement)mtaElement);
                if (element != null && element is T)
                {
                    elements.Add((T)element);
                }
            }

            return elements;
        }
        
        public Element InstantiateElement(string type, MTAElement element)
        {
            switch (type)
            {
                case "element":
                    return new Element(element);
                case "vehicle":
                    return new Vehicle(element);
                case "player":
                    return new Player(element);
                case "object":
                    return new MTAObject(element);
            }
            return null;
        }

    }
}
