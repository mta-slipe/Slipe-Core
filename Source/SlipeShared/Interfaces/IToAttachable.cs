using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace Slipe.Shared.Interfaces
{
    /// <summary>
    /// Defines classes that can be attached to by IAttachables
    /// </summary>
    public interface IToAttachable
    {
        /// <summary>
        /// Get only the position vector of this object in world space
        /// </summary>
        Vector3 Position { get; set; }

        /// <summary>
        /// Get the entire matrix of this object in world space
        /// </summary>
        Matrix4x4 Matrix { get; set; }
    }
}
