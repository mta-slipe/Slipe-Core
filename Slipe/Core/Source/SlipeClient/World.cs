using System;
using System.Collections.Generic;
using System.Text;
using Slipe.Shared;
using Slipe.MTADefinitions;
using System.Numerics;
using Slipe.Client.Enums;
using Slipe.Shared.World;

namespace Slipe.Client
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
                return (World) instance;
            }
        }

        /// <summary>
        /// Instantiate a new world
        /// </summary>
        public World()
        {

        }

        /// <summary>
        /// Get a specific garage class instance from a garage ID
        /// </summary>
        public new Garage GetGarage(GarageLocation garage)
        {
            return new Garage(garage);
        }

        /// <summary>
        /// This function gets the Z level of the highest ground below a point.
        /// </summary>
        public float GetGroundPosition(Vector3 position)
        {
            return MTAClient.GetGroundPosition(position.X, position.Y, position.Z);
        }

        /// <summary>
        /// This property checks to see if the music played by default in clubs is disabled or not.
        /// </summary>
        public new bool InteriorSounds
        {
            get
            {
                return MTAClient.GetInteriorSoundsEnabled();
            }
            set
            {
                MTAShared.SetInteriorSoundsEnabled(value);
            }
        }

        /// <summary>
        /// Get and set the max value peds are rendered at
        /// </summary>
        public float PedsLODDistance
        {
            get
            {
                return MTAClient.GetPedsLODDistance();
            }
            set
            {
                MTAClient.SetPedsLODDistance(Math.Clamp(value, 0, 500));
            }
        }

        /// <summary>
        /// Get and set the LOD distances for regular vehicles
        /// </summary>
        public float VehiclesLODDistance
        {
            get
            {
                return MTAClient.GetVehiclesLODDistance().Item1;
            }
            set
            {
                MTAClient.SetVehiclesLODDistance(value, TrainsAndPlanesLODDistance);
            }
        }

        /// <summary>
        /// Get and set the LOD distances for trains and planes
        /// </summary>
        public float TrainsAndPlanesLODDistance
        {
            get
            {
                return MTAClient.GetVehiclesLODDistance().Item2;
            }
            set
            {
                MTAClient.SetVehiclesLODDistance(VehiclesLODDistance, value);
            }
        }

        /// <summary>
        /// Reset the LOD distance of vehicles
        /// </summary>
        public bool ResetVehiclesLODDistance()
        {
            return MTAClient.ResetVehiclesLODDistance();
        }


        /// <summary>
        /// Reset the peds LOD distance
        /// </summary>
        public bool ResetPedsLODDistance()
        {
            return MTAClient.ResetPedsLODDistance();
        }

        /// <summary>
        /// Enables ambient sounds
        /// </summary>
        public bool SetAmbientSoundEnabled(AmbientSoundEnum soundType, bool enable = true)
        {
            return MTAClient.SetAmbientSoundEnabled(soundType.ToString().ToLower(), enable);
        }

        /// <summary>
        /// Check if a certain ambient sound is enabled
        /// </summary>
        public bool IsAmbientSoundEnabled(AmbientSoundEnum soundType)
        {
            return MTAClient.IsAmbientSoundEnabled(soundType.ToString().ToLower());
        }

        /// <summary>
        /// Resets all ambient sounds
        /// </summary>
        public bool ResetAmbientSounds()
        {
            return MTAClient.ResetAmbientSounds();
        }

        /// <summary>
        /// This function allows you to check if certain world sound effects have not been disabled by setWorldSoundEnabled
        /// </summary>
        public bool IsSoundEnabled(WorldSoundGroupEnum group, int index = -1)
        {
            return MTAClient.IsWorldSoundEnabled((int)group, index);
        }

        /// <summary>
        /// Reset all world sound changes
        /// </summary>
        public bool ResetWorldSounds()
        {
            return MTAClient.ResetWorldSounds();
        }

        /// <summary>
        /// Set a world sound group or specified element enabled or disabled
        /// </summary>
        public bool SetSoundEnabled(WorldSoundGroupEnum group, bool enable, int index = -1, bool immediate = false)
        {
            return MTAClient.SetWorldSoundEnabled((int)group, index, enable, immediate);
        }

        /// <summary>
        /// Enables or disables a special world property.
        /// </summary>
        public bool SetSpecialPropertyEnabled(WorldSpecialPropertyEnum property, bool enable)
        {
            return MTAClient.SetWorldSpecialPropertyEnabled(property.ToString().ToLower(), enable);
        }

        /// <summary>
        /// Check if a certain special property is enabled
        /// </summary>
        public bool IsSpecialPropertyEnabled(WorldSoundGroupEnum property)
        {
            return MTAClient.IsWorldSpecialPropertyEnabled(property.ToString().ToLower());
        }

        /// <summary>
        /// This function toggles furniture generation in interiors with the specified room ID.
        /// </summary>
        public bool SetRoomFurnitureEnabled(RoomFurnitureEnum room, bool enabled)
        {
            return MTAClient.SetInteriorFurnitureEnabled((int)room, enabled);
        }

        /// <summary>
        /// Check whether furniture is enabled in a room
        /// </summary>
        public bool IsRoomFurnitureEnabled(RoomFurnitureEnum room)
        {
            return MTAClient.GetInteriorFurnitureEnabled((int)room);
        }

        /// <summary>
        /// Flyable birds in the world
        /// </summary>
        public bool BirdsEnabled
        {
            get
            {
                return MTAClient.GetBirdsEnabled();
            }
            set
            {
                MTAClient.SetBirdsEnabled(value);
            }
        }

        /// <summary>
        /// This function allows you to retrieve the water level from a certain location. 
        /// </summary>
        public float GetWaterLevelAtPosition(Vector3 position, bool checkWaves = false)
        {
            return MTAClient.GetWaterLevel(position.X, position.Y, position.Z, checkWaves);
        }

        /// <summary>
        /// This property changes the water rendering order.
        /// </summary>
        public bool WaterDrawnLast
        {
            get
            {
                return MTAClient.IsWaterDrawnLast();
            }
            set
            {
                MTAClient.SetWaterDrawnLast(value);
            }
        }

        /// <summary>
        /// Get and set if the targeting markers on all peds are enabled
        /// </summary>
        public bool PedTargetingMarkersEnabled
        {
            get
            {
                return MTAClient.IsPedTargetingMarkerEnabled();
            }
            set
            {
                MTAClient.SetPedTargetingMarkerEnabled(value);
            }
        }
    }
}
