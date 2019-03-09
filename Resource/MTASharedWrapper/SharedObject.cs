using MultiTheftAuto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTASharedWrapper
{
    public class SharedObject : SharedElement
    {
        public Vector3 Scale
        {
            get
            {
                Tuple<float, float, float> scale = Shared.GetObjectScale(element);
                return new Vector3(scale.Item1, scale.Item2, scale.Item3);
            }
            set
            {
                Shared.SetObjectScale(element, value.x, value.y, value.z);
            }
        }

        public SharedObject(int model, Vector3 position, Vector3 rotation, bool isLowLOD = false)
        {
            this.element = Shared.CreateObject(model, position.x, position.y, position.z, rotation.x, rotation.y, rotation.z, isLowLOD);
        }

        public SharedObject(int model, Vector3 position): this(model, position, new Vector3(0, 0, 0))
        {
        }

        public bool Move(int milliseconds, Vector3 position, Vector3 rotationOffset, string easingType = null, float easingPeriod = 0, float easingAmplitude = 0, float easingOvershoot = 0)
        {
            return Shared.MoveObject(element, milliseconds, position.x, position.y, position.z, rotationOffset.x, rotationOffset.y, rotationOffset.z, easingType, easingPeriod, easingAmplitude, easingOvershoot);
        }
        public bool Move(int milliseconds, Vector3 position)
        {
            return Move(milliseconds, position, new Vector3(0, 0, 0));
        }

        public bool Stop()
        {
            return Shared.StopObject(element);
        }
    }
}
