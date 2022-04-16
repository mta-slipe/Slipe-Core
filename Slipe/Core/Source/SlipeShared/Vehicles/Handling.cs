using System;
using System.Collections.Generic;
using System.Text;
using SlipeLua.MtaDefinitions;
using System.Numerics;

namespace SlipeLua.Shared.Vehicles
{
    /// <summary>
    /// Represents vehicle handling properties
    /// </summary>
    public class Handling
    {
        private MtaElement vehicleElement;

        #region Properties

        protected float mass;
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

        protected float turnMass;
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

        protected float dragCoeff;
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

        protected Vector3 centerOfMass;
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

        protected int percentSubmerged;
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

        protected float tractionMultiplier;
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

        protected float tractionLoss;
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

        protected float tractionBias;
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

        protected int numberOfGears;
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

        protected float maxVelocity;
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

        protected float engineAcceleration;
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

        protected float engineInertia;
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

        protected DriveType driveType;
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
                UpdateToGame("driveType", value.ToString().ToLower());
            }
        }

        protected EngineType engineType;
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
                UpdateToGame("engineType", value.ToString().ToLower());
            }
        }


        protected float brakeDeceleration;
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

        protected float brakeBias;
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

        protected float steeringLock;
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

        protected float suspensionForceLevel;
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

        protected float suspensionDamping;
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

        protected float suspensionHighSpeedDamping;
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

        protected float suspensionUpperLimit;
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

        protected float suspensionLowerLimit;
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

        protected float suspensionFrontRearBias;
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

        protected float suspensionAntiDiveMultiplier;
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

        protected float seatOffsetDistance;
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

        protected float collisionDamageMultiplier;
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

        protected int monetary;
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

        protected uint modelFlags;
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

        protected uint handlingFlags;
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

        protected VehicleLightType headLight;
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

        protected VehicleLightType tailLight;
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

        protected int animGroup;
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
        #endregion

        protected Handling() { }

        /// <summary>
        /// Builds vehicle handling from a vehicle
        /// </summary>
        public Handling(SharedVehicle vehicle)
        {
            vehicleElement = vehicle.MTAElement;
        }

        /// <summary>
        /// Build a vehicle handling instance from a raw handling table
        /// </summary>
        public Handling(Dictionary<string, dynamic> raw)
        {
            BuildFromTable(raw);
        }

        protected void BuildFromTable(Dictionary<string, dynamic> t)
        {
            mass = (float) t["mass"];
            turnMass = (float)t["turnMass"];
            dragCoeff = (float)t["dragCoeff"];
            float[] c = MtaShared.GetArrayFromTable(t["centerOfMass"], "System.Single");
            centerOfMass = new Vector3(c[0], c[1], c[2]);
            percentSubmerged = (int)t["percentSubmerged"];
            tractionMultiplier = (float)t["tractionMultiplier"];
            tractionLoss = (float)t["tractionLoss"];
            tractionBias = (float)t["tractionBias"];
            numberOfGears = (int)t["numberOfGears"];
            maxVelocity = (float)t["maxVelocity"];
            engineAcceleration = (float)t["engineAcceleration"];
            engineInertia = (float)t["engineInertia"];
            driveType = (DriveType) Enum.Parse(typeof(DriveType), t["driveType"], true);
            engineType = (EngineType)Enum.Parse(typeof(EngineType), t["engineType"], true);
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
                BuildFromTable(MtaShared.GetDictionaryFromTable(MtaShared.GetVehicleHandling(vehicleElement), "System.String", "System.Dynamic"));
        }

        protected virtual void UpdateToGame(string key, dynamic value)
        {
            if (vehicleElement != null)
                MtaShared.SetVehicleHandling(vehicleElement, key, value);
        }


    }
}
