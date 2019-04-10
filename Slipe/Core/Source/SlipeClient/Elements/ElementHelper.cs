using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MtaDefinitions;
using Slipe.Client.Vehicles;
using Slipe.Client.Effects;
using Slipe.Client.Sounds;
using Slipe.Shared.Elements;
using Slipe.Client.Radar;
using Slipe.Client.GameServer;
using Slipe.Client.Browsers;
using Slipe.Client.Gui;
using Slipe.Client.Lights;
using Slipe.Client.Pickups;
using Slipe.Client.Markers;
using Slipe.Client.GameWorld;
using Slipe.Client.Peds;
using Slipe.Client.Weapons;

namespace Slipe.Client.Elements
{
    /// <summary>
    /// Class that helps the element manager to cast MTA elements to their slip representation
    /// </summary>
    public class ElementHelper : IElementHelper
    {
        private static Dictionary<Type, string> ElementTypeNames = new Dictionary<Type, string>
        {
            [typeof(Element)] = "element",
            [typeof(Player)] = "player",
            [typeof(Vehicle)] = "vehicle",
            [typeof(WorldObject)] = "object",
            [typeof(GuiBrowser)] = "gui-browser",
            [typeof(Team)] = "team",
            [typeof(Pickup)] = "pickup",
            [typeof(Blip)] = "blip",
            [typeof(RadarArea)] = "radararea",
            [typeof(Team)] = "team",
            [typeof(Marker)] = "marker",
            [typeof(Water)] = "water",
            [typeof(Light)] = "light",
            [typeof(SearchLight)] = "searchlight",
            [typeof(Ped)] = "ped",
            [typeof(Effect)] = "effect",
            [typeof(Sound)] = "sound",
            [typeof(CustomWeapon)] = "weapon",
            [typeof(Projectile)] = "projectile",
            [typeof(RootElement)] = "root",
            [typeof(ResourceRootElement)] = "resource"
        };

        /// <summary>
        /// Get a list of all classes of a specific element
        /// </summary>
        public static List<T> GetByType<T>(Element startAt, bool streamedIn = false) where T : Element
        {
            List<T> elements = new List<T>();

            if (!ElementTypeNames.ContainsKey(typeof(T)))
            {
                return elements;
            }

            List<dynamic> mtaElements = MtaShared.GetListFromTable(MtaClient.GetElementsByType(ElementTypeNames[typeof(T)], startAt.MTAElement, streamedIn), "element");
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
        /// Get a list of all classes of a specific element
        /// </summary>
        public static List<T> GetByType<T>() where T : Element
        {
            return GetByType<T>(Element.Root);
        }

        /// <summary>
        /// Instantiate an MTA element as a slipe class of the specific type
        /// </summary>
        public virtual Element InstantiateElement(string type, MtaElement element)
        {
            switch (type)
            {
                case "element":
                    return new Element(element);
                case "player":
                    return new Player(element);
                case "vehicle":
                    return new Vehicle(element);
                case "object":
                    return new WorldObject(element);
                case "gui-browser":
                    return new GuiBrowser(element);
                case "browser":
                    return new Browser(element);
                case "team":
                    return new Team(element);
                case "pickup":
                    return new Pickup(element);
                case "blip":
                    return new Blip(element);
                case "radararea":
                    return new RadarArea(element);
                case "marker":
                    return new Marker(element);
                case "water":
                    return new Water(element);
                case "light":
                    return new Light(element);
                case "searchlight":
                    return new SearchLight(element);
                case "ped":
                    return new Ped(element);
                case "effect":
                    return new Effect(element);
                case "sound":
                    return new Sound(element);
                case "weapon":
                    return new CustomWeapon(element);
                case "projectile":
                    return new Projectile(element);
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
