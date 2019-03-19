using Slipe.MTADefinitions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace Slipe.Shared.CollisionShapes
{
    /// <summary>
    /// Base class for collision shapes
    /// </summary>
    public class CollisionShape: Element
    {
        /// <summary>
        /// Gets the type of the collision shape
        /// </summary>
        public string ShapeType { get { return MTAShared.GetColShapeType(element); } }
        
        /// <summary>
        /// Checks whether a certain position is inside a collision shape
        /// </summary>
        public bool IsInside(Vector3 position)
        {
            return MTAShared.IsInsideColShape(element, position.X, position.Y, position.Z);
        }

        /// <summary>
        /// Checks whether a certain element is inside a collision shape
        /// </summary>
        public bool IsElementWithin(PhysicalElement element)
        {
            return MTAShared.IsElementWithinColShape(this.element, element.MTAElement);
        }

        /// <summary>
        /// Gets a list of all elements inside the collision shape
        /// </summary>
        public List<PhysicalElement> GetElementsWithin()
        {
            return MTAShared.GetListFromTable(MTAShared.GetElementsWithinColShape(element, null));
        }

        /// <summary>
        /// Handles certain hit and leave events for collision shapes
        /// </summary>
        public override void HandleEvent(string eventName, Slipe.MTADefinitions.MTAElement element, dynamic p1, dynamic p2, dynamic p3, dynamic p4, dynamic p5, dynamic p6, dynamic p7, dynamic p8)
        {
            switch (eventName)
            {
                case "onColShapeHit":
                    OnHit?.Invoke((Element)p1, (bool) p2);
                    break;
                case "onClientColShapeHit":
                    OnHit?.Invoke((Element)p1, (bool) p2);
                    break;
                case "onColShapeLeave":
                    OnLeave?.Invoke((Element)p1, (bool) p2);
                    break;
                case "onClientColShapeLeave":
                    OnLeave?.Invoke((Element)p1, (bool) p2);
                    break;
            }
        }

        public delegate void OnHitHandler(Element element, bool matchingDimension);
        public event OnHitHandler OnHit;
        public delegate void OnLeaveHandler(Element element, bool matchingDimension);
        public event OnLeaveHandler OnLeave;

    }
}
