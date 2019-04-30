using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using Slipe.MtaDefinitions;
using Slipe.Client.Enums;
using Slipe.Shared.Elements;
using Slipe.Shared.Weapons;
using Slipe.Shared.Peds;
using System.ComponentModel;
using Slipe.Client.Vehicles;
using Slipe.Shared.Explosions;

namespace Slipe.Client.Peds
{
    /// <summary>
    /// Represents a pedestrian 
    /// </summary>
    [DefaultElementClass("ped")]
    public class Ped : SharedPed
    {
        #region Properties

        /// <summary>
        /// Get and set if the ped can fall off bikes
        /// </summary>
        public bool CanBeKnockedOffBike
        {
            get
            {
                return MtaClient.CanPedBeKnockedOffBike(element);
            }
            set
            {
                MtaClient.SetPedCanBeKnockedOffBike(element, value);
            }
        }

        /// <summary>
        /// Get and set the camera rotation of the ped
        /// </summary>
        public float CameraRotation
        {
            get
            {
                return MtaClient.GetPedCameraRotation(element);
            }
            set
            {
                MtaClient.SetPedCameraRotation(element, value);
            }
        }

        /// <summary>
        /// Get the movestate of this ped
        /// </summary>
        public MoveState MoveState
        {
            get
            {
                return (MoveState)Enum.Parse(typeof(MoveState), MtaClient.GetPedMoveState(element), true);
            }
        }

        /// <summary>
        /// Get and set the oxygen level a ped has when under water
        /// </summary>
        public float OxygenLevel
        {
            get
            {
                return MtaClient.GetPedOxygenLevel(element);
            }
            set
            {
                MtaClient.SetPedOxygenLevel(element, value);
            }
        }

        /// <summary>
        /// This function is used to get the name of this ped's current simplest task.
        /// </summary>
        public PedTask SimplestTask
        {
            get
            {
                return (PedTask)Enum.Parse(typeof(PedTask), MtaClient.GetPedSimplestTask(element), true);
            }
        }

        /// <summary>
        /// Get and set the voice of this ped
        /// </summary>
        public PedVoice PedVoice
        {
            get
            {
                Tuple<string, string> result = MtaClient.GetPedVoice(element);
                return new PedVoice(result.Item1, result.Item2);
            }
            set
            {
                MtaClient.SetPedVoice(element, value.Group, value.Name);
            }
        }

        /// <summary>
        /// This function allows retrieval of the position a ped's target range begins, when he is aiming with a weapon.
        /// </summary>
        public Vector3 TargetStart
        {
            get
            {
                Tuple<float, float, float> result = MtaClient.GetPedTargetStart(element);
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
                Tuple<float, float, float> result = MtaClient.GetPedTargetEnd(element);
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
                Tuple<float, float, float> result = MtaClient.GetPedTargetCollision(element);
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
                Tuple<float, float, float> result = MtaClient.GetPedWeaponMuzzlePosition(element);
                return new Vector3(result.Item1, result.Item2, result.Item3);
            }
        }

        /// <summary>
        /// Get if the ped is reload their weapon
        /// </summary>
        public bool IsReloadingWeapon
        {
            get
            {
                return MtaClient.IsPedReloadingWeapon(element);
            }
        }

        /// <summary>
        /// Set the footblood state of this ped
        /// </summary>
        public bool FootBloodEnabled
        {
            set
            {
                MtaClient.SetPedFootBloodEnabled(element, value);
            }
        }

        /// <summary>
        /// Get and set the current ped animation
        /// </summary>
        public Animation Animation
        {
            get
            {
                Tuple<string, string> result = MtaClient.GetPedAnimation(element);
                return new Animation(result.Item1, result.Item2);
            }
            set
            {
                SetAnimation(value);
            }
        }

        #endregion

        #region Constructors

        [EditorBrowsable(EditorBrowsableState.Never)]
        [DefaultElementConstructor]
        public Ped(MtaElement element) : base(element) { }

        /// <summary>
        /// Create a new ped
        /// </summary>
        public Ped(PedModel model, Vector3 position, float rotation = 0.0f)
            : this (MtaClient.CreatePed((int)model, position.X, position.Y, position.Z, rotation)) { }
        #endregion

        #region Methods

        /// <summary>
        /// Retrieve the analog control state of a certain control
        /// </summary>
        public float GetAnalogControlState(AnalogControl control)
        {
            return MtaClient.GetPedAnalogControlState(element, control.ToString());
        }

        /// <summary>
        /// Checks wheter a ped has a certain control pressed
        /// </summary>
        public bool GetControlState(AnalogControl control)
        {
            return MtaClient.GetPedControlState(element, control.ToString());
        }

        /// <summary>
        /// Set the analog control state of this ped
        /// </summary>
        public bool SetAnalogControlState(AnalogControl control, float state)
        {
            return MtaClient.SetPedAnalogControlState(element, control.ToString(), state);
        }

        /// <summary>
        /// Set the control state of a ped
        /// </summary>
        public bool SetControlState(AnalogControl control, bool state)
        {
            return MtaClient.SetPedControlState(element, control.ToString(), state);
        }

        /// <summary>
        /// Returns the 3D world coordinates of a specific bone of this ped
        /// </summary>
        public Vector3 GetBonePosition(Bone bone)
        {
            Tuple<float, float, float> result = MtaClient.GetPedBonePosition(element, (int)bone);
            return new Vector3(result.Item1, result.Item2, result.Item3);
        }

        /// <summary>
        /// Gives a weapon to this ped
        /// </summary>
        public bool GiveWeapon(SharedWeaponModel weapon, int ammo = 30, bool setAsCurrent = false)
        {
            return MtaClient.GivePedWeapon(element, weapon.ID, ammo, setAsCurrent);
        }

        /// <summary>
        /// Check if this ped is doing a certain task
        /// </summary>
        public bool IsDoingTask(PedTask task)
        {
            return MtaClient.IsPedDoingTask(element, task.ToString().ToUpper());
        }

        /// <summary>
        /// Set the ped aiming at a certain position
        /// </summary>
        public bool AimAt(Vector3 position)
        {
            return MtaClient.SetPedAimTarget(element, position.X, position.Y, position.Z);
        }

        /// <summary>
        /// Set the ped to target a specific physical element
        /// </summary>
        public bool AimAt(PhysicalElement targetElement)
        {
            return AimAt(targetElement.Position);
        }

        /// <summary>
        /// Have the ped look at a specific position
        /// </summary>
        public bool LookAt(Vector3 position, int time = 3000, int blend = 1000)
        {
            return MtaClient.SetPedLookAt(element, position.X, position.Y, position.Z, time, blend, null);
        }

        /// <summary>
        /// Have the ped look at a specific physical element
        /// </summary>
        public bool LookAt(PhysicalElement lookAt, int time = 3000, int blend = 1000)
        {
            return MtaClient.SetPedLookAt(element, 0, 0, 0, time, blend, lookAt.MTAElement);
        }

        #endregion

        #region Events

        #pragma warning disable 67

        public delegate void OnDamageHandler(PhysicalElement attacker, DamageType damageType, BodyPart bodyPart, float loss);
        public event OnDamageHandler OnDamage;

        public delegate void OnHeliKilledHandler(Vehicle responsibleHelicopter);
        public event OnHeliKilledHandler OnHeliKilled;

        public delegate void OnWastedHandler(Player killer, DamageType damageType, BodyPart bodyPart, bool stealth);
        public event OnWastedHandler OnWasted;

        public delegate void OnWeaponFireHandler(SharedWeaponModel weaponModel, int ammoLeft, int ammoLeftInClip, Vector3 hitPosition, PhysicalElement hitElement);
        public event OnWeaponFireHandler OnWeaponFire;

        public delegate void OnStepHandler(bool leftFoot);
        public event OnStepHandler OnStep;

        public delegate void OnExplosionHandler(Vector3 position, ExplosionType type);
        public event OnExplosionHandler OnExplosion;

        #pragma warning restore 67

        #endregion

    }
}
