using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MTADefinitions;
using Slipe.Server.GameServer;
using Slipe.Server.GameWorld;
using Slipe.Server.Markers;
using Slipe.Server.Peds;
using Slipe.Server.Pickups;
using Slipe.Server.Radar;
using Slipe.Server.Vehicles;
using Slipe.Shared.Elements;

namespace Slipe.Server.Elements
{
    /// <summary>
    /// This class enables the server element manager to properly cast MTA elements to server class instances
    /// </summary>
    public class ElementHelper : IElementHelper
    {

        private static Dictionary<Type, string> ElementTypeNames = new Dictionary<Type, string>
        {
            [typeof(Element)] = "element",
            [typeof(Vehicle)] = "vehicle",
            [typeof(Player)] = "player",
            [typeof(WorldObject)] = "object",
            [typeof(Pickup)] = "pickup",
            [typeof(Blip)] = "blip",
            [typeof(RadarArea)] = "radararea",
            [typeof(Team)] = "team",
            [typeof(Marker)] = "marker",
            [typeof(Water)] = "water",
            [typeof(Ped)] = "ped"
        };

        /// <summary>
        /// Returns a list of all elements of type T
        /// </summary>
        public static List<T> GetByType<T>(Element startAt) where T : Element
        {
            List<T> elements = new List<T>();

            if (!ElementTypeNames.ContainsKey(typeof(T)))
            {
                return elements;
            }
            List<dynamic> mtaElements = MTAShared.GetListFromTable(MTAServer.GetElementsByType(ElementTypeNames[typeof(T)], startAt.MTAElement), "element");
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

        /// <summary>
        /// Returns a list of all elements of type T
        /// </summary>
        public static List<T> GetByType<T>() where T : Element
        {
            return GetByType<T>(Element.Root);
        }

        /// <summary>
        /// Creates an instance of an element given a certain type
        /// </summary>
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
                    return new WorldObject(element);
                case "pickup":
                    return new Pickup(element);
                case "blip":
                    return new Blip(element);
                case "radararea":
                    return new RadarArea(element);
                case "team":
                    return new Team(element);
                case "marker":
                    return new Marker(element);
                case "water":
                    return new Water(element);
                case "ped":
                    return new Ped(element);
                default:
                    return new Element(element);
            }
        }

    }
}
