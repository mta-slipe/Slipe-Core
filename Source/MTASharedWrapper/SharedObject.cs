using MultiTheftAuto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace MTASharedWrapper
{
    public class SharedObject : Element
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
                Shared.SetObjectScale(element, value.X, value.Y, value.Z);
            }
        }

        public SharedObject(int model, Vector3 position, Vector3 rotation, bool isLowLOD = false)
        {
            this.element = Shared.CreateObject(model, position.X, position.Y, position.Z, rotation.X, rotation.Y, rotation.Z, isLowLOD);
            ElementManager.Instance.RegisterElement(this);
        }

        public SharedObject(int model, Vector3 position): this(model, position, new Vector3(0, 0, 0))
        {
        }

        public bool Move(int milliseconds, Vector3 position, Vector3 rotationOffset, string easingType = null, float easingPeriod = 0, float easingAmplitude = 0, float easingOvershoot = 0)
        {
            return Shared.MoveObject(element, milliseconds, position.X, position.Y, position.Z, rotationOffset.X, rotationOffset.Y, rotationOffset.Z, easingType, easingPeriod, easingAmplitude, easingOvershoot);
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
