using MTASharedWrapper;
using MultiTheftAuto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTAServerWrapper
{
    public class Element: SharedElement
    {
        private static Dictionary<Type, string> ElementTypeNames = new Dictionary<Type, string>
        {
            [typeof(Element)] = "element",
            [typeof(Vehicle)] = "vehicle",
            [typeof(Player)] = "player",
        };

        public static List<T> GetByType<T>() where T : SharedElement
        {
            List<T> elements = new List<T>();

            if (!ElementTypeNames.ContainsKey(typeof(T))) {
                return elements;
            }

            dynamic mtaElements = Server.GetElementsByType(ElementTypeNames[typeof(T)], null);

            return elements;
        }
    }
}
