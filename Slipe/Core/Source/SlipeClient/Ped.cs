using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using Slipe.MTADefinitions;
using Slipe.Shared;
using Slipe.Shared.Enums;

namespace Slipe.Client
{
    /// <summary>
    /// Represents a pedestrian 
    /// </summary>
    public class Ped : SharedPed
    {
        public Ped() : base() { }

        /// <summary>
        /// Create a ped from an empty element
        /// </summary>
        public Ped(MTAElement element) : base(element) { }

        /// <summary>
        /// Create a new ped
        /// </summary>
        public Ped(PedModel model, Vector3 position, float rotation = 0.0f)
        {
            element = MTAClient.CreatePed((int)model, position.X, position.Y, position.Z, rotation);
        }

        /// <summary>
        /// Get and set if the ped can fall off bikes
        /// </summary>
        public bool CanBeKnockedOffBike
        {
            get
            {
                return MTAClient.CanPedBeKnockedOffBike(element);
            }
            set
            {
                MTAClient.SetPedCanBeKnockedOffBike(element, value);
            }
        }

        /// <summary>
        /// Retrieve the analog control state of a certain control
        /// </summary>
        public float GetAnalogControlState(AnalogControl control)
        {
            return MTAClient.GetPedAnalogControlState(element, control.ToString());
        }

        /// <summary>
        /// Checks wheter a ped has a certain control pressed
        /// </summary>
        public bool GetControlState(AnalogControl control)
        {
            return MTAClient.GetPedControlState(element, control.ToString());
        }

        /// <summary>
        /// Set the analog control state of this ped
        /// </summary>
        public bool SetAnalogControlState(AnalogControl control, float state)
        {
            return MTAClient.SetPedAnalogControlState(element, control.ToString(), state);
        }

        /// <summary>
        /// Returns the 3D world coordinates of a specific bone of this ped
        /// </summary>
        public Vector3 GetBonePosition(Bone bone)
        {
            Tuple<float, float, float> result = MTAClient.GetPedBonePosition(element, (int)bone);
            return new Vector3(result.Item1, result.Item2, result.Item3);
        }

        /// <summary>
        /// Get and set the camera rotation of the ped
        /// </summary>
        public float CameraRotation
        {
            get
            {
                return MTAClient.GetPedCameraRotation(element);
            }
            set
            {
                MTAClient.SetPedCameraRotation(element, value);
            }
        }

        /// <summary>
        /// Get the movestate of this ped
        /// </summary>
        public MoveState MoveState
        {
            get
            {
                return (MoveState) Enum.Parse(typeof(MoveState), MTAClient.GetPedMoveState(element));
            }
        }

        /// <summary>
        /// Get and set the oxygen level a ped has when under water
        /// </summary>
        public float OxygenLevel
        {
            get
            {
                return MTAClient.GetPedOxygenLevel(element);
            }
            set
            {
                MTAClient.SetPedOxygenLevel(element, value);
            }
        }

        /// <summary>
        /// This function is used to get the name of this ped's current simplest task.
        /// </summary>
        public PedTask SimplestTask
        {
            get
            {
                return (PedTask) Enum.Parse(typeof(PedTask), MTAClient.GetPedSimplestTask(element));
            }
        }

        /// <summary>
        /// This function allows retrieval of the position a ped's target range begins, when he is aiming with a weapon.
        /// </summary>
        public Vector3 TargetStart
        {
            get
            {
                Tuple<float, float, float> result = MTAClient.GetPedTargetStart(element);
                return new Vector3(result.Item1, result.Item2, result.Item3);
            }
        }

        /// <summary>
        /// This function allows retrieval of the position where a ped's target range ends, when he is aiming with a weapon.
        /// </summary>
        public Vector3 TargetEnd
        {
            get
            {
                Tuple<float, float, float> result = MTAClient.GetPedTargetEnd(element);
                return new Vector3(result.Item1, result.Item2, result.Item3);
            }
        }

        /// <summary>
        /// This function allows retrieval of where a ped's target is blocked. It will only be blocked if there is an obstacle within a ped's target range.
        /// </summary>
        public Vector3 TargetCollision
        {
            get
            {
                Tuple<float, float, float> result = MTAClient.GetPedTargetCollision(element);
                return new Vector3(result.Item1, result.Item2, result.Item3);
            }
        }

        /// <summary>
        /// Returns the world position of the muzzle of the weapon that a ped is currently carrying. The weapon muzzle is the end of the gun barrel where the bullets/rockets/... come out.
        /// </summary>
        public Vector3 WeaponMuzzlePosition
        {
            get
            {
                Tuple<float, float, float> result = MTAClient.GetPedWeaponMuzzlePosition(element);
                return new Vector3(result.Item1, result.Item2, result.Item3);
            }
        }

    }
}
