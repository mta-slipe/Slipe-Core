using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using Slipe.MTADefinitions;
using Slipe.Shared.CollisionShapes;
using Slipe.Shared.Interfaces;

namespace Slipe.Shared
{
    /// <summary>
    /// Represents a physical element in the GTA world
    /// </summary>
    public class PhysicalElement : Element, IToAttachable
    {
        public PhysicalElement()
        {
        }

        public PhysicalElement(MTAElement mtaElement) : base(mtaElement)
        {

        }

        /// <summary>
        /// Gets and sets the position of the element
        /// </summary>
        public Vector3 Position
        {
            get
            {
                Tuple<float, float, float> position = MTAShared.GetElementPosition(element);
                return new Vector3(position.Item1, position.Item2, position.Item3);
            }
            set
            {
                MTAShared.SetElementPosition(element, value.X, value.Y, value.Z, false);
            }
        }

        /// <summary>
        /// Gets and sets the rotation of the element in Euler angles
        /// </summary>
        public Vector3 Rotation
        {
            get
            {
                Tuple<float, float, float> rotation = MTAShared.GetElementRotation(element, "default");
                return new Vector3(rotation.Item1, rotation.Item2, rotation.Item3);
            }
            set
            {
                MTAShared.SetElementRotation(element, value.X, value.Y, value.Z, "default", true);
            }
        }

        /// <summary>
        /// Gets and sets teh rotation of the element in quaternions
        /// </summary>
        public Quaternion QuaternionRotation
        {
            get
            {
                // Default is XYZ
                // Yaw = y-axis, Pitch = x-axis, Roll = z-axis
                Tuple<float, float, float> rotation = MTAShared.GetElementRotation(element, "default");
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

                MTAShared.SetElementRotation(element, (float)(yaw * (180.0 / Math.PI)), (float)(pitch * (180.0 / Math.PI)), (float)(roll * (180.0 / Math.PI)), "default", false);
            }
        }

        /// <summary>
        /// Gets and sets the position,rotation,scale matrix of the element
        /// </summary>
        public Matrix4x4 Matrix
        {
            get
            {
                Tuple<Tuple<float, float, float, float>, Tuple<float, float, float, float>, Tuple<float, float, float, float>, Tuple<float, float, float, float>> matrix = MTAShared.GetElementMatrix(element, false);
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

        /// <summary>
        /// Gets the vector that represents forward for the element
        /// </summary>
        public Vector3 ForwardVector
        {
            get
            {
                Matrix4x4 m = this.Matrix;
                return new Vector3(m.M21, m.M22, m.M23);
            }
        }

        /// <summary>
        /// Gets the vector that represents right for the element
        /// </summary>
        public Vector3 RightVector
        {
            get
            {
                Matrix4x4 m = this.Matrix;
                return new Vector3(m.M11, m.M12, m.M13);
            }
        }

        /// <summary>
        /// Gets the vector that represents up for the element
        /// </summary>
        public Vector3 UpVector
        {
            get
            {
                Matrix4x4 m = this.Matrix;
                return new Vector3(m.M31, m.M32, m.M33);
            }
        }

        /// <summary>
        /// Gets and sets the dimension of this element
        /// </summary>
        public int Dimension
        {
            get
            {
                return MTAShared.GetElementDimension(element);
            }
            set
            {
                MTAShared.SetElementDimension(element, value);
            }
        }

        /// <summary>
        /// Gets and sets the interior of this element
        /// </summary>
        public int Interior
        {
            get
            {
                return MTAShared.GetElementInterior(element);
            }
            set
            {
                Vector3 position = Position;
                MTAShared.SetElementInterior(element, value, position.X, position.Y, position.Z);
            }
        }

        /// <summary>
        /// Gets and sets if this element is frozen in place
        /// </summary>
        public bool Frozen
        {
            get
            {
                return MTAShared.IsElementFrozen(element);
            }
            set
            {
                MTAShared.SetElementFrozen(element, value);
            }
        }

        /// <summary>
        /// Gets and sets the alpha value of this element
        /// </summary>
        public int Alpha
        {
            get
            {
                return MTAShared.GetElementAlpha(element);
            }
            set
            {
                MTAShared.SetElementAlpha(element, value);
            }
        }

        /// <summary>
        /// Gets and sets the health of this element
        /// </summary>
        public float Health
        {
            get
            {
                return MTAShared.GetElementHealth(element);
            }
            set
            {
                MTAShared.SetElementHealth(element, value);
            }
        }

        /// <summary>
        /// Gets and sets the velocity of this element
        /// </summary>
        public Vector3 Velocity
        {
            get
            {
                Tuple<float, float, float> velocity = MTAShared.GetElementVelocity(element);
                return new Vector3(velocity.Item1, velocity.Item2, velocity.Item3);
            }
            set
            {
                MTAShared.SetElementVelocity(element, value.X, value.Y, value.Z);
            }
        }

        /// <summary>
        /// Gets and sets the model of this element
        /// </summary>
        public int Model
        {
            get
            {
                return MTAShared.GetElementModel(element);
            }
            set
            {
                MTAShared.SetElementModel(element, value);
            }
        }

        /// <summary>
        /// Gets the collision shape of this element. (Only applicable to some)
        /// </summary>
        public CollisionShape CollisionShape
        {
            get
            {
                return (CollisionShape)ElementManager.Instance.GetElement(MTAShared.GetElementColShape(element));
            }
        }

        /// <summary>
        /// Attaches this element to another element given a certain offset and rotation
        /// </summary>
        public bool AttachTo(PhysicalElement element, Vector3 offset, Vector3 rotationOffset)
        {
            return MTAShared.AttachElements(this.element, element.element, offset.X, offset.Y, offset.Z, rotationOffset.X, rotationOffset.Y, rotationOffset.Z);
        }

        /// <summary>
        /// Attaches this element to another element given a certain offset
        /// </summary>
        public bool AttachTo(PhysicalElement element, Vector3 offset)
        {
            return AttachTo(element, offset, new Vector3(0, 0, 0));
        }
    }
}
