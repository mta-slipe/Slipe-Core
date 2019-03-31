using System;
using System.Collections.Generic;
using System.Text;
using Slipe.Shared;
using Slipe.MTADefinitions;
using System.Numerics;

namespace Slipe.Client
{
    /// <summary>
    /// Extensions for clientsided elements
    /// </summary>
    public static class ElementExtensions
    {
        /// <summary>
        /// This function returns the minimum and maximum relative coordinates of an element's bounding box.
        /// </summary>
        public static Tuple<Vector3, Vector3> GetBoundingBox(this PhysicalElement e)
        {
            Tuple<float, float, float, float, float, float> result = MTAClient.GetElementBoundingBox(e.MTAElement);
            Vector3 min = new Vector3(result.Item1, result.Item2, result.Item3);
            Vector3 max = new Vector3(result.Item4, result.Item5, result.Item6);
            return new Tuple<Vector3, Vector3>(min, max);
        }

        /// <summary>
        /// his function is used to retrieve the distance between a element's centre of mass to the base of the model. This can be used to calculate the position the element has to be set to, to have it on ground level.
        /// </summary>
        public static float GetDistanceFromCentreOfMassToBaseOfModel(this PhysicalElement e)
        {
            return MTAClient.GetElementDistanceFromCentreOfMassToBaseOfModel(e.MTAElement);
        }

        /// <summary>
        /// his function gets the radius of an element. Normally, sphere or circle-shaped elements tend to return a more accurate and expected radius than others with another shapes.
        /// </summary>
        public static float GetRadius(this PhysicalElement e)
        {
            return MTAClient.GetElementRadius(e.MTAElement);
        }

        /// <summary>
        /// This function can be used to set an element to collide with another element. An element with collisions disabled does not interact physically with the other element.
        /// </summary>
        public static bool SetCollidableWith(this PhysicalElement e, PhysicalElement collideWith, bool enabled)
        {
            return MTAClient.SetElementCollidableWith(e.MTAElement, collideWith.MTAElement, enabled);
        }

        /// <summary>
        /// This function can be used to check whether specified element is collidable with another element.
        /// </summary>
        public static bool IsCollidableWith(this PhysicalElement e, PhysicalElement collideWith)
        {
            return MTAClient.IsElementCollidableWith(e.MTAElement, collideWith.MTAElement);
        }

        /// <summary>
        /// This function checks whether this element is local to the client (doesn't exist in the server) or not.
        /// </summary>
        public static bool IsLocal(this PhysicalElement e)
        {
            return MTAClient.IsElementLocal(e.MTAElement);
        }

        /// <summary>
        /// This function will check if this element is on the screen. Elements behind objects but still in the camera view count as being on screen.
        /// </summary>
        public static bool IsOnScreen(this PhysicalElement e)
        {
            return MTAClient.IsElementOnScreen(e.MTAElement);
        }

        /// <summary>
        /// This function can be used to disable streaming for this element. This will make sure the element is not virtualized (streamed out from GTA) when the player moves far away from it.
        /// </summary>
        public static bool SetStreamable(this PhysicalElement e, bool enabled)
        {
            return MTAClient.SetElementStreamable(e.MTAElement, enabled);
        }

        /// <summary>
        /// Check if this element is streamable
        /// </summary>
        public static bool IsStreamable(this PhysicalElement e)
        {
            return MTAClient.IsElementStreamable(e.MTAElement);
        }

        /// <summary>
        /// This function checks whether this element is currently streamed in (not virtualized) and are actual GTA objects in the world.
        /// </summary>
        public static bool IsStreamedIn(this PhysicalElement e)
        {
            return MTAClient.IsElementStreamedIn(e.MTAElement);
        }

        /// <summary>
        /// This function checks whether this element is synced by the local player or not. 
        /// </summary>
        public static bool IsSyncer(this PhysicalElement e)
        {
            return MTAClient.IsElementSyncer(e.MTAElement);
        }

        /// <summary>
        /// This function checks whether MTA has frozen an element because it is above map objects which are still loading or not.
        /// </summary>
        public static bool IsWaitingForGroundToLoad(this PhysicalElement e)
        {
            return MTAClient.IsElementWaitingForGroundToLoad(e.MTAElement);
        }
    }
}
