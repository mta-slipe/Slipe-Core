using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using MultiTheftAuto;
using MTASharedWrapper.CollisionShapes;

namespace MTASharedWrapper
{
    public class PhysicalElement : Element
    {
        public PhysicalElement() : base()
        {

        }

        public PhysicalElement(MTAElement mtaElement) : base(mtaElement)
        {

        }

        public Vector3 Position
        {
            get
            {
                Tuple<float, float, float> position = Shared.GetElementPosition(element);
                return new Vector3(position.Item1, position.Item2, position.Item3);
            }
            set
            {
                Shared.SetElementPosition(element, value.X, value.Y, value.Z, false);
            }
        }

        public Vector3 Rotation
        {
            get
            {
                Tuple<float, float, float> rotation = Shared.GetElementRotation(element, "default");
                return new Vector3(rotation.Item1, rotation.Item2, rotation.Item3);
            }
            set
            {
                Shared.SetElementRotation(element, value.X, value.Y, value.Z, "default", true);
            }
        }

        public Quaternion QuaternionRotation
        {
            get
            {
                // Default is XYZ
                // Yaw = y-axis, Pitch = x-axis, Roll = z-axis
                Tuple<float, float, float> rotation = Shared.GetElementRotation(element, "default");
                float v1 = rotation.Item1 * (float)(Math.PI / 180.0);
                float v2 = rotation.Item2 * (float)(Math.PI / 180.0);
                float v3 = rotation.Item3 * (float)(Math.PI / 180.0);
                return Quaternion.CreateFromYawPitchRoll(v1, v2, v3);
            }
            set
            {
                float v1 = value.Z;
                float v2 = value.X;
                float v3 = value.Y;
                float v4 = value.W;


                double sinr_cosp = 2.0 * (v4 * v1 + v2 * v3);
                double cosr_cosp = 1.0 - 2.0 * (v1 * v1 + v2 * v2);
                double roll = Math.Atan2(sinr_cosp, cosr_cosp);


                double sinp = 2.0 * (v4 * v2 - v3 * v1);
                double pitch;
                if (Math.Abs(sinp) >= 1)
                    pitch = Math.Sign(sinp) > 0 ? Math.PI : -Math.PI;
                else
                    pitch = Math.Asin(sinp);


                double siny_cosp = 2.0 * (v4 * v3 + v1 * v2);
                double cosy_cosp = 1.0 - 2.0 * (v2 * v2 + v3 * v3);
                double yaw = Math.Atan2(siny_cosp, cosy_cosp);

                if (yaw < 0)
                    yaw += 2 * Math.PI;

                if (pitch < 0)
                    pitch += 2 * Math.PI;

                if (roll < 0)
                    roll += 2 * Math.PI;

                // Vector3 v = new Vector3((float) roll, (float) pitch, (float) yaw);
                // Console.WriteLine(v.ToString());
                Shared.SetElementRotation(element, (float)(yaw * (180.0 / Math.PI)), (float)(pitch * (180.0 / Math.PI)), (float)(roll * (180.0 / Math.PI)), "default", false);
            }
        }

        public Matrix4x4 Matrix
        {
            get
            {
                Tuple<Tuple<float, float, float, float>, Tuple<float, float, float, float>, Tuple<float, float, float, float>, Tuple<float, float, float, float>> matrix = Shared.GetElementMatrix(element, false);
                return new Matrix4x4(matrix.Item1.Item1, matrix.Item1.Item2, matrix.Item1.Item3, matrix.Item1.Item4,
                                     matrix.Item2.Item1, matrix.Item2.Item2, matrix.Item2.Item3, matrix.Item2.Item4,
                                     matrix.Item3.Item1, matrix.Item3.Item2, matrix.Item3.Item3, matrix.Item3.Item4,
                                     matrix.Item4.Item1, matrix.Item4.Item2, matrix.Item4.Item3, matrix.Item4.Item4);
            }
            set
            {
                this.Position = new Vector3(value.M41, value.M42, value.M43);
                this.QuaternionRotation = Quaternion.CreateFromRotationMatrix(value);
            }
        }

        public Vector3 ForwardVector
        {
            get
            {
                Matrix4x4 m = this.Matrix;
                return new Vector3(m.M21, m.M22, m.M23);
            }
        }

        public Vector3 RightVector
        {
            get
            {
                Matrix4x4 m = this.Matrix;
                return new Vector3(m.M11, m.M12, m.M13);
            }
        }

        public Vector3 UpVector
        {
            get
            {
                Matrix4x4 m = this.Matrix;
                return new Vector3(m.M31, m.M32, m.M33);
            }
        }

        public int Dimension
        {
            get
            {
                return Shared.GetElementDimension(element);
            }
            set
            {
                Shared.SetElementDimension(element, value);
            }
        }

        public int Interior
        {
            get
            {
                return Shared.GetElementInterior(element);
            }
            set
            {
                Vector3 position = Position;
                Shared.SetElementInterior(element, value, position.X, position.Y, position.Z);
            }
        }

        public bool Frozen
        {
            get
            {
                return Shared.IsElementFrozen(element);
            }
            set
            {
                Shared.SetElementFrozen(element, value);
            }
        }

        public int Alpha
        {
            get
            {
                return Shared.GetElementAlpha(element);
            }
            set
            {
                Shared.SetElementAlpha(element, value);
            }
        }

        public float Health
        {
            get
            {
                return Shared.GetElementHealth(element);
            }
            set
            {
                Shared.SetElementHealth(element, value);
            }
        }

        public Vector3 Velocity
        {
            get
            {
                Tuple<float, float, float> velocity = Shared.GetElementVelocity(element);
                return new Vector3(velocity.Item1, velocity.Item2, velocity.Item3);
            }
            set
            {
                Shared.SetElementVelocity(element, value.X, value.Y, value.Z);
            }
        }

        public int Model
        {
            get
            {
                return Shared.GetElementModel(element);
            }
            set
            {
                Shared.SetElementModel(element, value);
            }
        }

        public CollisionShape CollisionShape
        {
            get
            {
                return (CollisionShape)ElementManager.Instance.GetElement(Shared.GetElementColShape(element));
            }
        }
    }
}
