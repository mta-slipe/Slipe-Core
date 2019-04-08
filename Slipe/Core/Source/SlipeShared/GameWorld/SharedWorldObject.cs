using Slipe.MtaDefinitions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using Slipe.Shared.Elements;
using System.ComponentModel;
using Slipe.Shared.Helpers;

namespace Slipe.Shared.GameWorld
{
    /// <summary>
    /// Class representing static, 3D models in the GTA world.
    /// </summary>
    public class SharedWorldObject : PhysicalElement
    {
        /// <summary>
        /// Gets and sets the scale of the WorldObject
        /// </summary>
        public Vector3 Scale
        {
            get
            {
                Tuple<float, float, float> scale = MtaShared.GetObjectScale(element);
                return new Vector3(scale.Item1, scale.Item2, scale.Item3);
            }
            set
            {
                MtaShared.SetObjectScale(element, value.X, value.Y, value.Z);
            }
        }

        #region Constructors

        /// <summary>
        /// Creates or retrieves a SharedWorldObject using an MTAElement representing an object
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public SharedWorldObject(MtaElement element) : base(element) { }

        /// <summary>
        /// Creates a SharedWorldObject from all CreateObject variables
        /// </summary>
        /// <include file='doc.xml' path='docs/members[@name="SharedWorldObject"]/constructor/*'/>
        public SharedWorldObject(int model, Vector3 position, Vector3 rotation, bool isLowLOD = false)
        {
            element = MtaShared.CreateObject(model, position.X, position.Y, position.Z, rotation.X, rotation.Y, rotation.Z, isLowLOD);
            ElementManager.Instance.RegisterElement(this);
        }

        /// <summary>
        /// Creates a SharedWorldObject from a model ID and a position Vector3
        /// </summary>
        public SharedWorldObject(int model, Vector3 position) : this(model, position, Vector3.Zero) { }

        #endregion

        /// <summary>
        /// Moves a WorldObject to a position and rotation during a period, using an easing function
        /// </summary>
        public bool Move(int milliseconds, Vector3 position, Vector3 rotationOffset, EasingFunction easingType = EasingFunction.Linear, float easingPeriod = 0, float easingAmplitude = 0, float easingOvershoot = 0)
        {
            return MtaShared.MoveObject(element, milliseconds, position.X, position.Y, position.Z, rotationOffset.X, rotationOffset.Y, rotationOffset.Z, easingType.ToString(), easingPeriod, easingAmplitude, easingOvershoot);
        }

        /// <summary>
        /// Moves a WorldObject to a position in a certain time
        /// </summary>
        public bool Move(int milliseconds, Vector3 position)
        {
            return Move(milliseconds, position, new Vector3(0, 0, 0));
        }

        /// <summary>
        /// Stops a WorldObject from moving
        /// </summary>
        public bool Stop()
        {
            return MtaShared.StopObject(element);
        }
    }
}
