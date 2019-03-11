using MTASharedWrapper;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using MultiTheftAuto;

namespace MTAServerWrapper
{
    public static class ElementExtensions
    {
        public static bool SetVisibleTo(this Element source, Element target, bool visible)
        {
            return Server.SetElementVisibleTo(source.MTAElement, target.MTAElement, visible);
        }

        public static bool ClearVisibleTo(this Element source)
        {
            return Server.ClearElementVisibleTo(source.MTAElement);
        }

        public static bool IsVisibleTo(this Element source, Element target)
        {
            return Server.IsElementVisibleTo(source.MTAElement, target.MTAElement);
        }

        public static Element Clone(this Element source, Vector3 position)
        {
            MultiTheftAuto.MTAElement mtaElement = Server.CloneElement(source.MTAElement, position.X, position.Y, position.Z, false);
            //TODO: Return new element of proper type
            return new Element(mtaElement);
        }

        public static string GetZoneName(this Element source, bool citiesOnly = false)
        {
            return Server.GetElementZoneName(source.MTAElement, citiesOnly);
        }

        public static Element GetSyncer(this Element source)
        {
            return ElementManager.Instance.GetElement(Server.GetElementSyncer(source.MTAElement));
        }

        public static bool SetSyncer(this Element source, Element target)
        {
            return Server.SetElementSyncer(source.MTAElement, target.MTAElement);
        }
    }
}
