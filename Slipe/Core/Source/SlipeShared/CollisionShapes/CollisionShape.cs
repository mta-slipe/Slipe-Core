using Slipe.MtaDefinitions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using Slipe.Shared.Elements;
using System.ComponentModel;

namespace Slipe.Shared.CollisionShapes
{
    /// <summary>
    /// Base class for collision shapes
    /// </summary>
    public class CollisionShape: PhysicalElement
    {
        /// <summary>
        /// Gets the type of the collision shape
        /// </summary>
        public string ShapeType { get { return MtaShared.GetColShapeType(element); } }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public CollisionShape(MtaElement element) : base(element)
        {
            ListenForEvent("onColShapeHit");
            ListenForEvent("onClientColShapeHit");
            ListenForEvent("onColShapeLeave");
            ListenForEvent("onClientColShapeLeave");
        }

        /// <summary>
        /// Checks whether a certain position is inside a collision shape
        /// </summary>
        public bool IsInside(Vector3 position)
        {
            return MtaShared.IsInsideColShape(element, position.X, position.Y, position.Z);
        }

        /// <summary>
        /// Checks whether a certain element is inside a collision shape
        /// </summary>
        public bool IsElementWithin(PhysicalElement element)
        {
            return MtaShared.IsElementWithinColShape(this.element, element.MTAElement);
        }

        /// <summary>
        /// Gets an array of all elements inside the collision shape
        /// </summary>
        public PhysicalElement[] GetElementsWithin()
        {
            MtaElement[] array = MtaShared.GetArrayFromTable(MtaShared.GetElementsWithinColShape(element, null), "MTAElement");
            return ElementManager.Instance.CastArray<PhysicalElement>(array);
        }

        /// <summary>
        /// Handles certain hit and leave events for collision shapes
        /// </summary>
        public override void HandleEvent(string eventName, MtaElement source, object p1, object p2, object p3, object p4, object p5, object p6, object p7, object p8)
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
                default:
                    base.HandleEvent(eventName, source, p1, p2, p3, p4, p5, p6, p7, p8);
                    break;
            }
        }

        public delegate void OnHitHandler(Element element, bool matchingDimension);
        public event OnHitHandler OnHit;
        public delegate void OnLeaveHandler(Element element, bool matchingDimension);
        public event OnLeaveHandler OnLeave;

    }
}
