using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using Slipe.Shared.Elements;
using Slipe.Shared.Helpers;
using Slipe.Client.Elements;
using Slipe.Client.Game.Events;

namespace Slipe.Client.Helpers
{
    /// <summary>
    /// Abstract class that implements attaching functionality in a lazy way (updates only when update is called)
    /// </summary>
    public abstract class LazyAttachableObject
    {
        protected PhysicalElement toAttached;

        /// <summary>
        /// A matrix describing the offset with which this attachable is attached
        /// </summary>
        public Matrix4x4 Offset { get; set; }

        /// <summary>
        /// Get the Physical Element to which this attachable is attached
        /// </summary>
        public PhysicalElement ToAttached
        {
            get
            {
                return toAttached;
            }
        }

        /// <summary>
        /// Get if this attachable is attached to a ToAttachable
        /// </summary>
        public bool IsAttached
        {
            get
            {
                return toAttached != null;
            }
        }

        /// <summary>
        /// Attach this attachable to a toAttachable using a matrix to describe the positional and rotational offset
        /// </summary>
        public void AttachTo(PhysicalElement toElement, Matrix4x4 offsetMatrix)
        {
            toAttached = toElement;
            Offset = offsetMatrix;
            OnAttach();
        }

        /// <summary>
        /// Attach this attachable to a toAttachable with 2 vectors describing a position offset and a rotation offset
        /// </summary>
        public void AttachTo(PhysicalElement toElement, Vector3 positionOffset, Vector3 rotationOffset)
        {
            AttachTo(toElement, positionOffset, NumericHelper.EulerToQuaternion(rotationOffset));
        }

        /// <summary>
        /// Attach this attachable to a toAttachable with a vector describing the position offset and a quaternion describing the rotation offset
        /// </summary>
        public void AttachTo(PhysicalElement toElement, Vector3 positionOffset, Quaternion rotationOffset)
        {
            AttachTo(toElement, Matrix4x4.Transform(Matrix4x4.CreateTranslation(positionOffset), rotationOffset));
        }

        /// <summary>
        /// Attach this attachable to a toAttachable without any offset
        /// </summary>
        public void AttachTo(PhysicalElement toElement)
        {
            AttachTo(toElement, Matrix4x4.Identity);
        }

        /// <summary>
        /// Detach this attachable
        /// </summary>
        public void Detach()
        {
            OnDetach();
        }

        protected virtual void OnAttach()
        {

        }

        protected virtual void OnDetach()
        {
            toAttached = null;
        }

        /// <summary>
        /// Updates this element to the correct position and rotation
        /// </summary>
        protected abstract void Update(RootElement source, OnUpdateEventArgs eventArgs);
    }
}
