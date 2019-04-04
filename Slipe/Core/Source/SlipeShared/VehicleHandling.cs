using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MTADefinitions;
using System.Numerics;
using Slipe.Shared.Enums;

namespace Slipe.Shared
{
    /// <summary>
    /// Represents vehicle handling properties
    /// </summary>
    public class VehicleHandling
    {
        private MTAElement vehicleElement;

        protected float mass;
        protected float turnMass;
        protected float dragCoeff;
        protected Vector3 centerOfMass;
        protected int percentSubmerged;
        protected float tractionMultiplier;
        protected float tractionLoss;
        protected float tractionBias;
        protected int numberOfGears;
        protected float maxVelocity;
        protected float engineAcceleration;
        protected float engineInertia;
        protected DriveType driveType;
        protected EngineType engineType;
        protected float brakeDeceleration;
        protected float brakeBias;
        protected float steeringLock;
        protected float suspensionForceLevel;
        protected float suspensionDamping;
        protected float suspensionHighSpeedDamping;
        protected float suspensionUpperLimit;
        protected float suspensionLowerLimit;
        protected float suspensionFrontRearBias;
        protected float suspensionAntiDiveMultiplier;
        protected float seatOffsetDistance;
        protected float collisionDamageMultiplier;
        protected int monetary;
        protected uint modelFlags;
        protected uint handlingFlags;
        protected VehicleLightType headLight;
        protected VehicleLightType tailLight;
        protected int animGroup;

        /// <summary>
        /// Mass of the vehicle in kilograms.
        /// </summary>
        public float Mass
        {
            get
            {
                UpdateFromGame();
                return mass;
            }
            set
            {
                UpdateToGame("mass", value);
            }
        }

        /// <summary>
        /// Used to calculate motion effects.
        /// </summary>
        public float TurnMass
        {
            get
            {
                UpdateFromGame();
                return turnMass;
            }
            set
            {
                UpdateToGame("turnMass", value);
            }
        }

        /// <summary>
        /// Changes resistance to movement.
        /// </summary>
        public float DragCoefficient
        {
            get
            {
                UpdateFromGame();
                return dragCoeff;
            }
            set
            {
                UpdateToGame("dragCoeff", value);
            }
        }

        /// <summary>
        /// Distance from the centre of the car in metres for the centre of mass.
        /// </summary>
        public Vector3 CenterOfMass
        {
            get
            {
                UpdateFromGame();
                return centerOfMass;
            }
            set
            {
                float[] ar = new float[3];
                ar[1] = value.X;
                ar[2] = value.Y;
                ar[3] = value.Z;
                UpdateToGame("centerOfMass", ar);
            }
        }

        /// <summary>
        /// Percentage of the vehicle height required to be submerged for the car to float.
        /// </summary>
        public int PercentSubmerged
        {
            get
            {
                UpdateFromGame();
                return percentSubmerged;
            }
            set
            {
                UpdateToGame("percentSubmerged", value);
            }
        }

        /// <summary>
        /// Cornering grip of the vehicle as a multiplier of the tyre surface friction.
        /// </summary>
        public float TractionMultiplier
        {
            get
            {
                UpdateFromGame();
                return tractionMultiplier;
            }
            set
            {
                UpdateToGame("tractionMultiplier", value);
            }
        }

        /// <summary>
        /// Accelerating/braking grip of the vehicle as a multiplier of the tyre surface friction.
        /// </summary>
        public float TractionLoss
        {
            get
            {
                UpdateFromGame();
                return tractionLoss;
            }
            set
            {
                UpdateToGame("tractionLoss", value);
            }
        }

        /// <summary>
        /// Ratio of front axle grip to rear axle grip; higher value shifts grip forwards.
        /// </summary>
        public float TractionBias
        {
            get
            {
                UpdateFromGame();
                return tractionBias;
            }
            set
            {
                UpdateToGame("tractionBias", value);
            }
        }

        /// <summary>
        /// Number of gearchange animations and sound effects to use.
        /// </summary>
        public int NumberOfGears
        {
            get
            {
                UpdateFromGame();
                return numberOfGears;
            }
            set
            {
                UpdateToGame("numberOfGears", value);
            }
        }

        /// <summary>
        /// Limits the top speed.
        /// </summary>
        public float MaxVelocity
        {
            get
            {
                UpdateFromGame();
                return maxVelocity;
            }
            set
            {
                UpdateToGame("maxVelocity", value);
            }
        }

        /// <summary>
        /// Basic rate of acceleration.
        /// </summary>
        public float EngineAcceleration
        {
            get
            {
                UpdateFromGame();
                return engineAcceleration;
            }
            set
            {
                UpdateToGame("engineAcceleration", value);
            }
        }

        /// <summary>
        /// Smooths or sharpens the acceleration curve.
        /// </summary>
        public float EngineInertia
        {
            get
            {
                UpdateFromGame();
                return engineInertia;
            }
            set
            {
                UpdateToGame("engineInertia", value);
            }
        }

        /// <summary>
        /// Assigns Front, Rear or 4 wheel drive.
        /// </summary>
        public DriveType DriveType
        {
            get
            {
                UpdateFromGame();
                return driveType;
            }
            set
            {
                UpdateToGame("driveType", value.ToString());
            }
        }

        /// <summary>
        /// Assigns Petrol, Diesel or Electric engine characteristics.
        /// </summary>
        public EngineType EngineType
        {
            get
            {
                UpdateFromGame();
                return engineType;
            }
            set
            {
                UpdateToGame("engineType", value.ToString());
            }
        }

        /// <summary>
        /// Overall decelerative force.
        /// </summary>
        public float BrakeDeceleration
        {
            get
            {
                UpdateFromGame();
                return brakeDeceleration;
            }
            set
            {
                UpdateToGame("brakeDeceleration", value);
            }
        }

        /// <summary>
        /// Ratio of braking force of front compared to rear; higher values move bias forward.
        /// </summary>
        public float BrakeBias
        {
            get
            {
                UpdateFromGame();
                return brakeBias;
            }
            set
            {
                UpdateToGame("brakeBias", value);
            }
        }

        /// <summary>
        /// Maximum angle of steering in degrees.
        /// </summary>
        public float SteeringLock
        {
            get
            {
                UpdateFromGame();
                return steeringLock;
            }
            set
            {
                UpdateToGame("steeringLock", value);
            }
        }

        /// <summary>
        /// Force of suspension dampeners
        /// </summary>
        public float SuspensionForceLevel
        {
            get
            {
                UpdateFromGame();
                return suspensionForceLevel;
            }
            set
            {
                UpdateToGame("suspensionForceLevel", value);
            }
        }

        /// <summary>
        /// The inverse negative force of suspension dampeners
        /// </summary>
        public float SuspensionDamping
        {
            get
            {
                UpdateFromGame();
                return suspensionDamping;
            }
            set
            {
                UpdateToGame("suspensionDamping", value);
            }
        }

        /// <summary>
        /// Stiffens the dampening strength as speed increases.
        /// </summary>
        public float SuspensionHighSpeedDamping
        {
            get
            {
                UpdateFromGame();
                return suspensionHighSpeedDamping;
            }
            set
            {
                UpdateToGame("suspensionHighSpeedDamping", value);
            }
        }

        /// <summary>
        /// Uppermost movement of wheels in metres.
        /// </summary>
        public float SuspensionUpperLimit
        {
            get
            {
                UpdateFromGame();
                return suspensionUpperLimit;
            }
            set
            {
                UpdateToGame("suspensionUpperLimit", value);
            }
        }

        /// <summary>
        /// Ride height of vehicle in metres.
        /// </summary>
        public float SuspensionLowerLimit
        {
            get
            {
                UpdateFromGame();
                return suspensionLowerLimit;
            }
            set
            {
                UpdateToGame("suspensionLowerLimit", value);
            }
        }

        /// <summary>
        /// Ratio of suspension force to apply at the front compared to the rear.
        /// </summary>
        public float SuspensionFrontRearBias
        {
            get
            {
                UpdateFromGame();
                return suspensionFrontRearBias;
            }
            set
            {
                UpdateToGame("suspensionFrontRearBias", value);
            }
        }

        /// <summary>
        /// Changes the amount of body pitching under braking and acceleration.
        /// </summary>
        public float SuspensionAntiDiveMultiplier
        {
            get
            {
                UpdateFromGame();
                return suspensionAntiDiveMultiplier;
            }
            set
            {
                UpdateToGame("suspensionAntiDiveMultiplier", value);
            }
        }

        /// <summary>
        /// Distance from door position to seat postion.
        /// </summary>
        public float SeatOffsetDistance
        {
            get
            {
                UpdateFromGame();
                return seatOffsetDistance;
            }
            set
            {
                UpdateToGame("seatOffsetDistance", value);
            }
        }

        /// <summary>
        /// Amount of engine damage vehicle gets from collisions. Higher value means more damage.
        /// </summary>
        public float CollisionDamageMultiplier
        {
            get
            {
                UpdateFromGame();
                return collisionDamageMultiplier;
            }
            set
            {
                UpdateToGame("collisionDamageMultiplier", value);
            }
        }

        /// <summary>
        /// Used to calculate the Value of property damaged statistic.
        /// </summary>
        public int Monetary
        {
            get
            {
                UpdateFromGame();
                return monetary;
            }
        }

        /// <summary>
        /// Special animations features of the which can be enabled or disabled.
        /// </summary>
        public uint ModelFlags
        {
            get
            {
                UpdateFromGame();
                return modelFlags;
            }
            set
            {
                UpdateToGame("modelFlags", value);
            }
        }

        /// <summary>
        /// Special performance features. 
        /// </summary>
        public uint HandlingFlags
        {
            get
            {
                UpdateFromGame();
                return handlingFlags;
            }
            set
            {
                UpdateToGame("handlingFlags", value);
            }
        }

        /// <summary>
        /// Type of head lights of the vehicle.
        /// </summary>
        public VehicleLightType HeadLight
        {
            get
            {
                UpdateFromGame();
                return headLight;
            }
            set
            {
                UpdateToGame("headLight", value.ToString().ToLower());
            }
        }

        /// <summary>
        /// Same as above but for the tail lights.
        /// </summary>
        public VehicleLightType TailLight
        {
            get
            {
                UpdateFromGame();
                return tailLight;
            }
            set
            {
                UpdateToGame("tailLight", value.ToString().ToLower());
            }
        }

        /// <summary>
        /// Refers to an Animation ID number.
        /// </summary>
        public int AnimationGroup
        {
            get
            {
                UpdateFromGame();
                return animGroup;
            }
            set
            {
                UpdateToGame("animGroup", value);
            }
        }

        protected void BuildFromTable(Dictionary<string, dynamic> t)
        {
            mass = (float) t["mass"];
            turnMass = (float)t["turnMass"];
            dragCoeff = (float)t["dragCoeff"];
            float[] c = MTAShared.GetArrayFromTable(t["centerOfMass"], "System.Single");
            centerOfMass = new Vector3(c[0], c[1], c[2]);
            percentSubmerged = (int)t["percentSubmerged"];
            tractionMultiplier = (float)t["tractionMultiplier"];
            tractionLoss = (float)t["tractionLoss"];
            tractionBias = (float)t["tractionBias"];
            numberOfGears = (int)t["numberOfGears"];
            maxVelocity = (float)t["maxVelocity"];
            engineAcceleration = (float)t["engineAcceleration"];
            engineInertia = (float)t["engineInertia"];
            driveType = (DriveType) Enum.Parse(typeof(DriveType), t["driveType"]);
            engineType = (EngineType)Enum.Parse(typeof(EngineType), t["engineType"]);
            brakeDeceleration = (float)t["brakeDeceleration"];
            brakeBias = (float)t["brakeBias"];
            steeringLock = (float)t["steeringLock"];
            suspensionForceLevel = (float)t["suspensionForceLevel"];
            suspensionDamping = (float)t["suspensionDamping"];
            suspensionHighSpeedDamping = (float)t["suspensionHighSpeedDamping"];
            suspensionUpperLimit = (float)t["suspensionUpperLimit"];
            suspensionLowerLimit = (float)t["suspensionLowerLimit"];
            suspensionFrontRearBias = (float)t["suspensionFrontRearBias"];
            suspensionAntiDiveMultiplier = (float)t["suspensionAntiDiveMultiplier"];
            seatOffsetDistance = (float)t["seatOffsetDistance"];
            collisionDamageMultiplier = (float)t["collisionDamageMultiplier"];
            monetary = (int)t["monetary"];
            modelFlags = (uint)t["modelFlags"];
            handlingFlags = (uint)t["handlingFlags"];
            headLight = (VehicleLightType)Enum.Parse(typeof(VehicleLightType), t["headLight"], true);
            tailLight = (VehicleLightType)Enum.Parse(typeof(VehicleLightType), t["tailLight"], true);
            animGroup = (int)t["animGroup"];
        }

        protected virtual void UpdateFromGame()
        {
            if (vehicleElement != null)
                BuildFromTable(MTAShared.GetDictionaryFromTable(MTAShared.GetVehicleHandling(vehicleElement), "System.String", "System.Dynamic"));
        }

        protected virtual void UpdateToGame(string key, dynamic value)
        {
            if (vehicleElement != null)
                MTAShared.SetVehicleHandling(vehicleElement, key, value);
        }

        protected VehicleHandling() { }

        /// <summary>
        /// Builds vehicle handling from a vehicle
        /// </summary>
        public VehicleHandling(SharedVehicle vehicle)
        {
            vehicleElement = vehicle.MTAElement;
        }

        /// <summary>
        /// Build a vehicle handling instance from a raw handling table
        /// </summary>
        public VehicleHandling(Dictionary<string, dynamic> raw)
        {
            BuildFromTable(raw);
        }
    }
}
