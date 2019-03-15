using Slipe.Shared;
using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MTADefinitions;

namespace Slipe.Client
{
    public class ElementHelper: IElementHelper
    {
        private static Dictionary<Type, string> ElementTypeNames = new Dictionary<Type, string>
        {
            [typeof(Element)] = "element",
            [typeof(Player)] = "player",
            [typeof(MTAObject)] = "object",
            [typeof(GUIBrowser)] = "gui-browser",
            [typeof(Team)] = "team",
        };

        public static List<T> GetByType<T>() where T : Element
        {
            List<T> elements = new List<T>();

            if (!ElementTypeNames.ContainsKey(typeof(T)))
            {
                return elements;
            }

            List<dynamic> mtaElements = MTAShared.GetListFromTable(MTAServer.GetElementsByType(ElementTypeNames[typeof(T)], null));
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
                case "player":
                    return new Player(element);
                case "object":
                    return new MTAObject(element);
                case "gui-browser":
                    return new GUIBrowser(element);
                case "browser":
                    return new Browser(element);
                case "team":
                    return new Team(element);
            }
            return null;
        }

    }
}
