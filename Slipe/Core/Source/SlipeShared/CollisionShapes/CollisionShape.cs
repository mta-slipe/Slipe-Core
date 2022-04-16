﻿using SlipeLua.MtaDefinitions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using SlipeLua.Shared.Elements;
using System.ComponentModel;
using SlipeLua.Shared.CollisionShapes.Events;

namespace SlipeLua.Shared.CollisionShapes
{
    /// <summary>
    /// Base class for collision shapes
    /// </summary>
    [DefaultElementClass(ElementType.ColShape)]
    public class CollisionShape: PhysicalElement
    {
        /// <summary>
        /// Gets the type of the collision shape
        /// </summary>
        public string ShapeType { get { return MtaShared.GetColShapeType(element); } }

        /// <summary>
        /// Gets an array of all elements inside the collision shape
        /// </summary>
        public PhysicalElement[] ElementsWithin
        {
            get
            {
                MtaElement[] array = MtaShared.GetArrayFromTable(MtaShared.GetElementsWithinColShape(element, null), "MTAElement");
                return ElementManager.Instance.CastArray<PhysicalElement>(array);
            }
        }

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
        /// Gets an array of all elements of a specific type inside the collision shape
        /// </summary>
        public T[] GetElementsWithin<T>() where T : PhysicalElement
        {
            MtaElement[] array = MtaShared.GetArrayFromTable(MtaShared.GetElementsWithinColShape(element, ElementManager.Instance.GetTypeName(typeof(T))), "MTAElement");
            return ElementManager.Instance.CastArray<T>(array);
        }

#pragma warning disable 67

        public delegate void OnHitHandler(CollisionShape source, OnHitEventArgs eventArgs);
        public event OnHitHandler OnHit;

        public delegate void OnLeaveHandler(CollisionShape source, OnLeaveEventArgs eventArgs);
        public event OnLeaveHandler OnLeave;

        #pragma warning restore 67
    }
}
