using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using Slipe.MtaDefinitions;
using Slipe.Shared.CollisionShapes;
using Slipe.Shared.Helpers;
using Slipe.Shared.Markers;
using System.ComponentModel;
using Slipe.Shared.IO;
using Slipe.Shared.Peds;
using Slipe.Shared.Elements.Events;

namespace Slipe.Shared.Elements
{
    /// <summary>
    /// Represents a physical element in the GTA world
    /// </summary>
    public abstract class PhysicalElement : Element
    {
        #region Properties

        /// <summary>
        /// Gets and sets the dimension of this element
        /// </summary>
        public int Dimension
        {
            get
            {
                return MtaShared.GetElementDimension(element);
            }
            set
            {
                MtaShared.SetElementDimension(element, value);
            }
        }

        /// <summary>
        /// Gets and sets the interior of this element
        /// </summary>
        public int Interior
        {
            get
            {
                return MtaShared.GetElementInterior(element);
            }
            set
            {
                Vector3 position = Position;
                MtaShared.SetElementInterior(element, value, position.X, position.Y, position.Z);
            }
        }
                
        /// <summary>
        /// Gets and sets if this element is frozen in place
        /// </summary>
        public bool Frozen
        {
            get
            {
                return MtaShared.IsElementFrozen(element);
            }
            set
            {
                MtaShared.SetElementFrozen(element, value);
            }
        }

        /// <summary>
        /// Gets and sets the alpha value of this element
        /// </summary>
        public int Alpha
        {
            get
            {
                return MtaShared.GetElementAlpha(element);
            }
            set
            {
                MtaShared.SetElementAlpha(element, value);
            }
        }

        /// <summary>
        /// Gets and sets the health of this element
        /// </summary>
        public float Health
        {
            get
            {
                return MtaShared.GetElementHealth(element);
            }
            set
            {
                MtaShared.SetElementHealth(element, value);
            }
        }

        /// <summary>
        /// Gets and sets the model of this element
        /// </summary>
        public virtual int Model
        {
            get
            {
                return MtaShared.GetElementModel(element);
            }
            set
            {
                MtaShared.SetElementModel(element, value);
            }
        }

        /// <summary>
        /// Gets the collision shape of this element. (Only applicable to some)
        /// </summary>
        public CollisionShape CollisionShape
        {
            get
            {
                return ElementManager.Instance.GetElement<CollisionShape>(MtaShared.GetElementColShape(element));
            }
        }

        /// <summary>
        /// Get and set if this element is set to have collisions disabled. An element without collisions does not interact with the physical environment and remains static.
        /// </summary>
        public bool CollisionsEnabled
        {
            get
            {
                return MtaShared.GetElementCollisionsEnabled(element);
            }
            set
            {
                MtaShared.SetElementCollisionsEnabled(element, value);
            }
        }

        /// <summary>
        /// Get and set the associated LOW LOD element
        /// </summary>
        public PhysicalElement LowLODElement
        {
            get
            {
                return ElementManager.Instance.GetElement<PhysicalElement>(MtaShared.GetLowLODElement(element));
            }
            set
            {
                MtaShared.SetLowLODElement(element, value.MTAElement);
            }
        }

        /// <summary>
        /// Get or set if this element is double sided
        /// </summary>
        public bool DoubleSided
        {
            get
            {
                return MtaShared.IsElementDoubleSided(element);
            }
            set
            {
                MtaShared.SetElementDoubleSided(element, value);
            }
        }

        /// <summary>
        /// Get if an element is submerged in water
        /// </summary>
        public bool IsInWater
        {
            get
            {
                return MtaShared.IsElementInWater(element);
            }
        }

        /// <summary>
        /// Get if this is a Low LOD element
        /// </summary>
        public bool IsLowLOD
        {
            get
            {
                return MtaShared.IsElementLowLOD(element);
            }
        }

        #endregion

        #region Numeric Properties

        /// <summary>
        /// Gets and sets the position of the element
        /// </summary>
        public Vector3 Position
        {
            get
            {
                Tuple<float, float, float> position = MtaShared.GetElementPosition(element);
                return new Vector3(position.Item1, position.Item2, position.Item3);
            }
            set
            {
                MtaShared.SetElementPosition(element, value.X, value.Y, value.Z, false);
            }
        }

        /// <summary>
        /// Gets and sets the rotation of the element in Euler angles
        /// </summary>
        public Vector3 Rotation
        {
            get
            {
                Tuple<float, float, float> rotation = MtaShared.GetElementRotation(element, "default");
                return new Vector3(rotation.Item1, rotation.Item2, rotation.Item3);
            }
            set
            {
                MtaShared.SetElementRotation(element, value.X, value.Y, value.Z, "default", true);
            }
        }

        /// <summary>
        /// Gets and sets the rotation of the element in quaternions
        /// </summary>
        public Quaternion QuaternionRotation
        {
            get
            {
                return NumericHelper.EulerToQuaternion(Rotation);
            }
            set
            {
                Rotation = NumericHelper.QuaternionToEuler(value);
            }
        }

        /// <summary>
        /// Gets and sets the position,rotation,scale matrix of the element
        /// </summary>
        public Matrix4x4 Matrix
        {
            get
            {
                Tuple<Tuple<float, float, float, float>, Tuple<float, float, float, float>, Tuple<float, float, float, float>, Tuple<float, float, float, float>> matrix = MtaShared.GetElementMatrix(element, false);
                return new Matrix4x4(matrix.Item1.Item1, matrix.Item1.Item2, matrix.Item1.Item3, matrix.Item1.Item4,
                                     matrix.Item2.Item1, matrix.Item2.Item2, matrix.Item2.Item3, matrix.Item2.Item4,
                                     matrix.Item3.Item1, matrix.Item3.Item2, matrix.Item3.Item3, matrix.Item3.Item4,
                                     matrix.Item4.Item1, matrix.Item4.Item2, matrix.Item4.Item3, matrix.Item4.Item4);
            }
            set
            {
                Position = new Vector3(value.M41, value.M42, value.M43);
                QuaternionRotation = Quaternion.CreateFromRotationMatrix(value);
            }
        }

        /// <summary>
        /// Gets the vector that represents forward for the element
        /// </summary>
        public Vector3 ForwardVector
        {
            get
            {
                Matrix4x4 m = Matrix;
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
                Matrix4x4 m = Matrix;
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
                Matrix4x4 m = Matrix;
                return new Vector3(m.M31, m.M32, m.M33);
            }
        }

        /// <summary>
        /// Gets and sets the velocity of this element
        /// </summary>
        public Vector3 Velocity
        {
            get
            {
                Tuple<float, float, float> velocity = MtaShared.GetElementVelocity(element);
                return new Vector3(velocity.Item1, velocity.Item2, velocity.Item3);
            }
            set
            {
                MtaShared.SetElementVelocity(element, value.X, value.Y, value.Z);
            }
        }

        /// <summary>
        /// Gets and sets the current angular velocity of a specified, supported element.
        /// </summary>
        public Vector3 AngularVelocity
        {
            get
            {
                Tuple<float, float, float> velocity = MtaShared.GetElementAngularVelocity(element);
                return new Vector3(velocity.Item1, velocity.Item2, velocity.Item3);
            }
            set
            {
                MtaShared.SetElementAngularVelocity(element, value.X, value.Y, value.Z);
            }
        }

        /// <summary>
        /// Gets and sets the angular velocity of the element in quaternions
        /// </summary>
        public Quaternion AngularQuaternionVelocity
        {
            get
            {
                return NumericHelper.EulerToQuaternion(AngularVelocity);
            }
            set
            {
                AngularVelocity = NumericHelper.QuaternionToEuler(value);
            }
        }

        #endregion

        #region Attach Properties

        /// <summary>
        /// Get the element to which this attachable is attached
        /// </summary>
        public PhysicalElement ToAttached
        {
            get
            {
                return ElementManager.Instance.GetElement<PhysicalElement>(MtaShared.GetElementAttachedTo(element));
            }
        }

        /// <summary>
        /// Get if this attachable is attached to a physical element
        /// </summary>
        public bool IsAttached
        {
            get
            {
                return MtaShared.IsElementAttached(element);
            }
        }

        #endregion

        #region Constructors

        [EditorBrowsable(EditorBrowsableState.Never)]
        public PhysicalElement(MtaElement mtaElement) : base(mtaElement)
        {
        }

        #endregion

        #region Methods

        /// <summary>
        /// This function is used to determine if an element is within a collision shape
        /// Please note that this function doesn't verify whether element is in the same dimension and interior, additional checks could be implemented manually if they are needed.
        /// </summary>
        public bool IsWithinCollisionShape(CollisionShape collisionShape)
        {
            return MtaShared.IsElementWithinColShape(element, collisionShape.MTAElement);
        }

        /// <summary>
        /// This function is used to determine if this element is within a marker.
        /// </summary>
        public bool IsWithinMarker(SharedMarker marker)
        {
            return MtaShared.IsElementWithinMarker(element, marker.MTAElement);
        }

        #endregion

        #region Attach Methods

        /// <summary>
        /// Attach this attachable to a toAttachable using a matrix to describe the positional and rotational offset
        /// </summary>
        public void AttachTo(PhysicalElement toElement, Matrix4x4 offsetMatrix)
        {
            AttachTo(toElement, offsetMatrix.Translation, Quaternion.CreateFromRotationMatrix(offsetMatrix));
        }

        /// <summary>
        /// Attach this attachable to a toAttachable with 2 vectors describing a position offset and a rotation offset
        /// </summary>
        public void AttachTo(PhysicalElement toElement, Vector3 positionOffset, Vector3 rotationOffset)
        {
            MtaShared.AttachElements(element, toElement.MTAElement, positionOffset.X, positionOffset.Y, positionOffset.Z, rotationOffset.X, rotationOffset.Y, rotationOffset.Z);
        }

        /// <summary>
        /// Attach this attachable to a toAttachable with a vector describing the position offset and a quaternion describing the rotation offset
        /// </summary>
        public void AttachTo(PhysicalElement toElement, Vector3 positionOffset, Quaternion rotationOffset)
        {
            AttachTo(toElement, positionOffset, NumericHelper.QuaternionToEuler(rotationOffset));
        }

        /// <summary>
        /// Attach this attachable to a toAttachable without any offset
        /// </summary>
        public void AttachTo(PhysicalElement toElement)
        {
            AttachTo(toElement, Vector3.Zero, Vector3.Zero);
        }

        /// <summary>
        /// Detach this attachable
        /// </summary>
        public void Detach()
        {
            MtaShared.DetachElements(element, null);
        }

        /// <summary>
        /// A matrix describing the offset with which this attachable is attached
        /// </summary>
        public Matrix4x4 Offset
        {
            get
            {
                Tuple<float, float, float, float, float, float> offsets = MtaShared.GetElementAttachedOffsets(element);
                Matrix4x4 m = Matrix4x4.CreateFromQuaternion(NumericHelper.EulerToQuaternion(new Vector3(offsets.Item4, offsets.Item5, offsets.Item6)));
                m.Translation = new Vector3(offsets.Item1, offsets.Item2, offsets.Item3);
                return m;
            }
            set
            {
                Vector3 translationOffset = value.Translation;
                Vector3 rotationOffset = NumericHelper.QuaternionToEuler(Quaternion.CreateFromRotationMatrix(value));
                MtaShared.SetElementAttachedOffsets(element, translationOffset.X, translationOffset.Y, translationOffset.Z, rotationOffset.X, rotationOffset.Y, rotationOffset.Z);
            }
        }

        #endregion

        #region Static Methods

        /// <summary>
        /// This function is used to retrieve an array of all elements of specified type within a range of 3D coordinates.
        /// </summary>
        public static PhysicalElement[] GetWithinRange(Vector3 position, float range, string type = "")
        {
            MtaElement[] mtaElements = MtaShared.GetArrayFromTable(MtaShared.GetElementsWithinRange(position.X, position.Y, position.Z, range, type), "MTAElement");
            return ElementManager.Instance.CastArray<PhysicalElement>(mtaElements);
        }

        /// <summary>
        /// Make this element face another element
        /// </summary>
        /// <param name="target">The element to face</param>
        public virtual void FaceElement(PhysicalElement target)
        {
            Rotation = NumericHelper.RotationBetweenPositions(Position, target.Position);
        }

        #endregion

        #region Events
#pragma warning disable 67

        public delegate void OnClickedHandler(PhysicalElement source, OnClickedArgs eventArgs);
        public event OnClickedHandler OnClicked;

        public delegate void OnModelChangeHandler(PhysicalElement source, OnModelChangeArgs eventArgs);
        public event OnModelChangeHandler OnModelChange;

        public delegate void OnStartSyncHandler(SharedPed newSyncer);
        public event OnStartSyncHandler OnStartSync;

        public delegate void OnStopSyncHandler(SharedPed oldSyncer);
        public event OnStopSyncHandler OnStopSync;

        public delegate void OnStreamInHandler();
        public event OnStreamInHandler OnStreamIn;

        public delegate void OnStreamOutHandler();
        public event OnStreamOutHandler OnStreamOut;

        #pragma warning restore 67
        #endregion

    }
}
