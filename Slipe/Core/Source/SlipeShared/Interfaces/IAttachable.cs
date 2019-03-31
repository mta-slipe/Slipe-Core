using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace Slipe.Shared.Interfaces
{
    /// <summary>
    /// Defines classes that can attach themselves to IToAttachables
    /// </summary>
    public interface IAttachable
    {
        /// <summary>
        /// Attach this attachable to a toAttachable using a matrix to describe the positional and rotational offset
        /// </summary>
        void AttachTo(PhysicalElement toElement, Matrix4x4 offsetMatrix);

        /// <summary>
        /// Attach this attachable to a toAttachable with 2 vectors describing a position offset and a rotation offset
        /// </summary>
        void AttachTo(PhysicalElement toElement, Vector3 positionOffset, Vector3 rotationOffset);

        /// <summary>
        /// Attach this attachable to a toAttachable with a vector describing the position offset and a quaternion describing the rotation offset
        /// </summary>
        void AttachTo(PhysicalElement toElement, Vector3 positionOffset, Quaternion rotationOffset);

        /// <summary>
        /// Attach this attachable to a toAttachable without any offset
        /// </summary>
        void AttachTo(PhysicalElement toElement);

        /// <summary>
        /// Detach this attachable
        /// </summary>
        void Detach();

        /// <summary>
        /// A matrix describing the offset with which this attachable is attached
        /// </summary>
        Matrix4x4 Offset { get; set; }

        /// <summary>
        /// Get the physical element to which this attachable is attached
        /// </summary>
        PhysicalElement ToAttached { get; }

        /// <summary>
        /// Get if this attachable is attached to a ToAttachable
        /// </summary>
        bool IsAttached { get; }

    }
}
