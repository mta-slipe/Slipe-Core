using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using Slipe.MTADefinitions;
using Slipe.Shared.Elements;

namespace Slipe.Server
{
    /// <summary>
    /// Extensions for the base shared element class on the server
    /// </summary>
    public static class ElementExtensions
    {
        /// <summary>
        /// Set this element visible for a specific target
        /// </summary>
        public static bool SetVisibleTo(this Element source, Element target, bool visible)
        {
            return MTAServer.SetElementVisibleTo(source.MTAElement, target.MTAElement, visible);
        }

        /// <summary>
        /// Clear all visibility settings of this element
        /// </summary>
        public static bool ClearVisibleTo(this Element source)
        {
            return MTAServer.ClearElementVisibleTo(source.MTAElement);
        }

        /// <summary>
        /// Checks if this element is visible to another
        /// </summary>
        public static bool IsVisibleTo(this Element source, Element target)
        {
            return MTAServer.IsElementVisibleTo(source.MTAElement, target.MTAElement);
        }

        /// <summary>
        /// Clones this element. Returns an element of the proper type
        /// </summary>
        public static Element Clone(this Element source, Vector3 position)
        {
            Slipe.MTADefinitions.MTAElement mtaElement = MTAServer.CloneElement(source.MTAElement, position.X, position.Y, position.Z, false);
            return ElementManager.Instance.GetElement(mtaElement);
        }

        /// <summary>
        /// Gets this element's zone name
        /// </summary>
        public static string GetZoneName(this Element source, bool citiesOnly = false)
        {
            return MTAServer.GetElementZoneName(source.MTAElement, citiesOnly);
        }

        /// <summary>
        /// Gets the syncer of this element
        /// </summary>
        public static Player GetSyncer(this Element source)
        {
            return (Player) ElementManager.Instance.GetElement(MTAServer.GetElementSyncer(source.MTAElement));
        }

        /// <summary>
        /// Sets the syncer of this element
        /// </summary>
        public static bool SetSyncer(this Element source, Player target)
        {
            return MTAServer.SetElementSyncer(source.MTAElement, target.MTAElement);
        }

    }
}
