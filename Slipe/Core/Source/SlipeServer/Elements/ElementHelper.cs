using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MtaDefinitions;
using Slipe.Server.GameServer;
using Slipe.Server.GameWorld;
using Slipe.Server.Markers;
using Slipe.Server.Peds;
using Slipe.Server.Pickups;
using Slipe.Server.Radar;
using Slipe.Server.Vehicles;
using Slipe.Shared.Elements;
using Slipe.Shared.CollisionShapes;

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
            [typeof(CollisionShape)] = "colshape",
            [typeof(Pickup)] = "pickup",
            [typeof(Blip)] = "blip",
            [typeof(RadarArea)] = "radararea",
            [typeof(Team)] = "team",
            [typeof(Marker)] = "marker",
            [typeof(Water)] = "water",
            [typeof(Ped)] = "ped",
            [typeof(RootElement)] = "root",
            [typeof(ResourceRootElement)] = "resource"
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
            List<dynamic> mtaElements = MtaShared.GetListFromTable(MtaServer.GetElementsByType(ElementTypeNames[typeof(T)], startAt.MTAElement), "element");
            foreach (dynamic mtaElement in mtaElements)
            {
                Element element = ElementManager.Instance.GetElement((MtaElement)mtaElement);
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
        public virtual Element InstantiateElement(string type, MtaElement element)
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
                case "colshape":
                    return new CollisionShape(element);
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
                case "root":
                    return new RootElement(element);
                case "resource":
                    return new ResourceRootElement(element);
                default:
                    return new Element(element);
            }
        }

    }
}
