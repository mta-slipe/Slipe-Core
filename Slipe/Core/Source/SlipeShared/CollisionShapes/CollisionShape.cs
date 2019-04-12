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

        public delegate void OnHitHandler(PhysicalElement element, bool matchingDimension);
        public event OnHitHandler OnHit;

        public delegate void OnLeaveHandler(PhysicalElement element, bool matchingDimension);
        public event OnLeaveHandler OnLeave;

    }
}
