using Slipe.MTADefinitions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace Slipe.Shared
{
    public class SharedWorldObject : PhysicalElement
    {
        public Vector3 Scale
        {
            get
            {
                Tuple<float, float, float> scale = MTAShared.GetObjectScale(element);
                return new Vector3(scale.Item1, scale.Item2, scale.Item3);
            }
            set
            {
                MTAShared.SetObjectScale(element, value.X, value.Y, value.Z);
            }
        }

        public SharedWorldObject(MTAElement element): base(element)
        {

        }

        public SharedWorldObject(int model, Vector3 position, Vector3 rotation, bool isLowLOD = false)
        {
            this.element = MTAShared.CreateObject(model, position.X, position.Y, position.Z, rotation.X, rotation.Y, rotation.Z, isLowLOD);
            ElementManager.Instance.RegisterElement(this);
        }

        public SharedWorldObject(int model, Vector3 position): this(model, position, new Vector3(0, 0, 0))
        {
        }

        public bool Move(int milliseconds, Vector3 position, Vector3 rotationOffset, string easingType = null, float easingPeriod = 0, float easingAmplitude = 0, float easingOvershoot = 0)
        {
            return MTAShared.MoveObject(element, milliseconds, position.X, position.Y, position.Z, rotationOffset.X, rotationOffset.Y, rotationOffset.Z, easingType, easingPeriod, easingAmplitude, easingOvershoot);
        }
        public bool Move(int milliseconds, Vector3 position)
        {
            return Move(milliseconds, position, new Vector3(0, 0, 0));
        }

        public bool Stop()
        {
            return MTAShared.StopObject(element);
        }
    }
}
