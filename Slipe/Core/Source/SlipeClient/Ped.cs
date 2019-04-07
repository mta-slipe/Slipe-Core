using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using Slipe.MTADefinitions;
using Slipe.Shared.Enums;
using Slipe.Client.Structs;
using Slipe.Client.Enums;
using Slipe.Shared.Elements;
using Slipe.Shared.Weapons;
using Slipe.Shared.Peds;
using System.ComponentModel;

namespace Slipe.Client
{
    /// <summary>
    /// Represents a pedestrian 
    /// </summary>
    public class Ped : SharedPed
    {
        public Ped() : base() { }

        [EditorBrowsable(EditorBrowsableState.Never)]
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
        /// Set the control state of a ped
        /// </summary>
        public bool SetControlState(AnalogControl control, bool state)
        {
            return MTAClient.SetPedControlState(element, control.ToString(), state);
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
        /// Get and set the voice of this ped
        /// </summary>
        public PedVoice PedVoice
        {
            get
            {
                Tuple<string, string> result = MTAClient.GetPedVoice(element);
                return new PedVoice(result.Item1, result.Item2);
            }
            set
            {
                MTAClient.SetPedVoice(element, value.Group, value.Name);
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

        /// <summary>
        /// Gives a weapon to this ped
        /// </summary>
        public bool GiveWeapon(WeaponType weapon, int ammo = 30, bool setAsCurrent = false)
        {
            return MTAClient.GivePedWeapon(element, (int)weapon, ammo, setAsCurrent);
        }

        /// <summary>
        /// Check if this ped is doing a certain task
        /// </summary>
        public bool IsDoingTask(PedTask task)
        {
            return MTAClient.IsPedDoingTask(element, task.ToString());
        }

        /// <summary>
        /// Get if the ped is reload their weapon
        /// </summary>
        public bool IsReloadingWeapon
        {
            get
            {
                return MTAClient.IsPedReloadingWeapon(element);
            }
        }

        /// <summary>
        /// Set the ped aiming at a certain position
        /// </summary>
        public bool AimAt(Vector3 position)
        {
            return MTAClient.SetPedAimTarget(element, position.X, position.Y, position.Z);
        }

        /// <summary>
        /// Set the ped to target a specific physical element
        /// </summary>
        public bool AimAt(PhysicalElement targetElement)
        {
            return AimAt(targetElement.Position);
        }

        /// <summary>
        /// Set the footblood state of this ped
        /// </summary>
        public bool FootBloodEnabled
        {
            set
            {
                MTAClient.SetPedFootBloodEnabled(element, value);
            }
        }

        /// <summary>
        /// Have the ped look at a specific position
        /// </summary>
        public bool LookAt(Vector3 position, int time = 3000, int blend = 1000)
        {
            return MTAClient.SetPedLookAt(element, position.X, position.Y, position.Z, time, blend, null);
        }

        /// <summary>
        /// Have the ped look at a specific physical element
        /// </summary>
        public bool LookAt(PhysicalElement lookAt, int time = 3000, int blend = 1000)
        {
            return MTAClient.SetPedLookAt(element, 0, 0, 0, time, blend, lookAt.MTAElement);
        }

        /// <summary>
        /// Get and set the current ped animation
        /// </summary>
        public Animation Animation
        {
            get
            {
                Tuple<string, string> result = MTAClient.GetPedAnimation(element);
                return new Animation(result.Item1, result.Item2);
            }
            set
            {
                SetAnimation(value);
            }
        }

    }
}
