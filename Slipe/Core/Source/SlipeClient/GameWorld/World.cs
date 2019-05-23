using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MtaDefinitions;
using System.Numerics;
using Slipe.Client.Enums;
using Slipe.Shared.GameWorld;

namespace Slipe.Client.GameWorld
{
    public class World : SharedWorld
    {
        public static new World Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new World();
                }
                return (World)instance;
            }
        }

        #region Properties

        /// <summary>
        /// This property checks to see if the music played by default in clubs is disabled or not.
        /// </summary>
        public new bool InteriorSounds
        {
            get
            {
                return MtaClient.GetInteriorSoundsEnabled();
            }
            set
            {
                MtaShared.SetInteriorSoundsEnabled(value);
            }
        }

        /// <summary>
        /// Get and set the max value peds are rendered at
        /// </summary>
        public float PedsLodDistance
        {
            get
            {
                return MtaClient.GetPedsLODDistance();
            }
            set
            {
                MtaClient.SetPedsLODDistance(Math.Clamp(value, 0, 500));
            }
        }

        /// <summary>
        /// Get and set the Lod distances for regular vehicles
        /// </summary>
        public float VehiclesLodDistance
        {
            get
            {
                return MtaClient.GetVehiclesLODDistance().Item1;
            }
            set
            {
                MtaClient.SetVehiclesLODDistance(value, TrainsAndPlanesLodDistance);
            }
        }

        /// <summary>
        /// Get and set the Lod distances for trains and planes
        /// </summary>
        public float TrainsAndPlanesLodDistance
        {
            get
            {
                return MtaClient.GetVehiclesLODDistance().Item2;
            }
            set
            {
                MtaClient.SetVehiclesLODDistance(VehiclesLodDistance, value);
            }
        }

        /// <summary>
        /// Flyable birds in the world
        /// </summary>
        public bool BirdsEnabled
        {
            get
            {
                return MtaClient.GetBirdsEnabled();
            }
            set
            {
                MtaClient.SetBirdsEnabled(value);
            }
        }

        /// <summary>
        /// This property changes the water rendering order.
        /// </summary>
        public bool WaterDrawnLast
        {
            get
            {
                return MtaClient.IsWaterDrawnLast();
            }
            set
            {
                MtaClient.SetWaterDrawnLast(value);
            }
        }

        /// <summary>
        /// Get and set if the targeting markers on all peds are enabled
        /// </summary>
        public bool PedTargetingMarkersEnabled
        {
            get
            {
                return MtaClient.IsPedTargetingMarkerEnabled();
            }
            set
            {
                MtaClient.SetPedTargetingMarkerEnabled(value);
            }
        }

        #endregion

        #region Constructors
        /// <summary>
        /// Instantiate a new world
        /// </summary>
        public World()
        {

        }

        #endregion

        #region Methods

        /// <summary>
        /// Get a specific garage class instance from a garage ID
        /// </summary>
        public new Garage GetGarage(GarageLocation garage)
        {
            return new Garage(garage);
        }

        /// <summary>
        /// This function gets the position of the highest ground below a point.
        /// </summary>
        public float GetGroundPosition(Vector3 position)
        {
            return MtaClient.GetGroundPosition(position.X, position.Y, position.Z);
        }

        /// <summary>
        /// Reset the Lod distance of vehicles
        /// </summary>
        public bool ResetVehiclesLodDistance()
        {
            return MtaClient.ResetVehiclesLODDistance();
        }


        /// <summary>
        /// Reset the peds Lod distance
        /// </summary>
        public bool ResetPedsLodDistance()
        {
            return MtaClient.ResetPedsLODDistance();
        }

        /// <summary>
        /// Enables ambient sounds
        /// </summary>
        public bool SetAmbientSoundEnabled(AmbientSound soundType, bool enable = true)
        {
            return MtaClient.SetAmbientSoundEnabled(soundType.ToString().ToLower(), enable);
        }

        /// <summary>
        /// Check if a certain ambient sound is enabled
        /// </summary>
        public bool IsAmbientSoundEnabled(AmbientSound soundType)
        {
            return MtaClient.IsAmbientSoundEnabled(soundType.ToString().ToLower());
        }

        /// <summary>
        /// Resets all ambient sounds
        /// </summary>
        public bool ResetAmbientSounds()
        {
            return MtaClient.ResetAmbientSounds();
        }

        /// <summary>
        /// This function allows you to check if certain world sound effects have not been disabled by setWorldSoundEnabled
        /// </summary>
        public bool IsSoundEnabled(WorldSoundGroup group, int index = -1)
        {
            return MtaClient.IsWorldSoundEnabled((int)group, index);
        }

        /// <summary>
        /// Reset all world sound changes
        /// </summary>
        public bool ResetWorldSounds()
        {
            return MtaClient.ResetWorldSounds();
        }

        /// <summary>
        /// Set a world sound group or specified element enabled or disabled
        /// </summary>
        public bool SetSoundEnabled(WorldSoundGroup group, bool enable, int index = -1, bool immediate = false)
        {
            return MtaClient.SetWorldSoundEnabled((int)group, index, enable, immediate);
        }

        /// <summary>
        /// Enables or disables a special world property.
        /// </summary>
        public bool SetSpecialPropertyEnabled(WorldSpecialProperty property, bool enable)
        {
            return MtaClient.SetWorldSpecialPropertyEnabled(property.ToString().ToLower(), enable);
        }

        /// <summary>
        /// Check if a certain special property is enabled
        /// </summary>
        public bool IsSpecialPropertyEnabled(WorldSpecialProperty property)
        {
            return MtaClient.IsWorldSpecialPropertyEnabled(property.ToString().ToLower());
        }

        /// <summary>
        /// This function toggles furniture generation in interiors with the specified room ID.
        /// </summary>
        public bool SetRoomFurnitureEnabled(RoomFurniture room, bool enabled)
        {
            return MtaClient.SetInteriorFurnitureEnabled((int)room, enabled);
        }

        /// <summary>
        /// Check whether furniture is enabled in a room
        /// </summary>
        public bool IsRoomFurnitureEnabled(RoomFurniture room)
        {
            return MtaClient.GetInteriorFurnitureEnabled((int)room);
        }

        /// <summary>
        /// This function allows you to retrieve the water level from a certain location. 
        /// </summary>
        public float GetWaterLevelAtPosition(Vector3 position, bool checkWaves = false)
        {
            return MtaClient.GetWaterLevel(position.X, position.Y, position.Z, checkWaves);
        }

        #endregion

    }
}
