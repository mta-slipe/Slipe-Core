using Slipe.Shared;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using Slipe.MTADefinitions;

namespace Slipe.Server
{
    public static class ElementExtensions
    {
        public static bool SetVisibleTo(this Element source, Element target, bool visible)
        {
            return MTAServer.SetElementVisibleTo(source.MTAElement, target.MTAElement, visible);
        }

        public static bool ClearVisibleTo(this Element source)
        {
            return MTAServer.ClearElementVisibleTo(source.MTAElement);
        }

        public static bool IsVisibleTo(this Element source, Element target)
        {
            return MTAServer.IsElementVisibleTo(source.MTAElement, target.MTAElement);
        }

        public static Element Clone(this Element source, Vector3 position)
        {
            Slipe.MTADefinitions.MTAElement mtaElement = MTAServer.CloneElement(source.MTAElement, position.X, position.Y, position.Z, false);
            //TODO: Return new element of proper type
            return new Element(mtaElement);
        }

        public static string GetZoneName(this Element source, bool citiesOnly = false)
        {
            return MTAServer.GetElementZoneName(source.MTAElement, citiesOnly);
        }

        public static Element GetSyncer(this Element source)
        {
            return ElementManager.Instance.GetElement(MTAServer.GetElementSyncer(source.MTAElement));
        }

        public static bool SetSyncer(this Element source, Element target)
        {
            return MTAServer.SetElementSyncer(source.MTAElement, target.MTAElement);
        }
    }
}
