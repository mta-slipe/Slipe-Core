using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MTADefinitions;
using Slipe.Shared.Structs;
using Slipe.Shared.Enums;
using System.Numerics;

namespace Slipe.Shared
{
    /// <summary>
    /// Shared singleton of the GTA world
    /// </summary>
    public class SharedWorld
    {
        protected static SharedWorld instance;

        /// <summary>
        /// Retrieve the instance of the current world
        /// </summary>
        public static SharedWorld Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new SharedWorld();
                }
                return instance;
            }
        }

        /// <summary>
        /// Instantiate a new world
        /// </summary>
        public SharedWorld()
        {

        }

        /// <summary>
        /// Gets and sets whether the traffic lights are currently locked or not. 
        /// If the lights are locked, it means they won't change unless you alter the TrafficLightState
        /// </summary>
        public bool LockedTrafficLights
        {
            get
            {
                return MTAShared.AreTrafficLightsLocked();
            }
            set
            {
                MTAShared.SetTrafficLightsLocked(value);
            }
        }

        /// <summary>
        /// Gets and sets the maximum velocity at which aircrafts could fly. 
        /// Using this server-side will return the server-side value, not necessarily the same that is set client-side.
        /// </summary>
        public float AircraftMaxVelocity
        {
            get
            {
                return MTAShared.GetAircraftMaxVelocity();
            }
            set
            {
                MTAShared.SetAircraftMaxVelocity(value);
            }
        }

        /// <summary>
        /// Gets and sets the maximum height at which aircraft can fly without their engines turning off.
        /// </summary>
        public float AircraftMaxHeight
        {
            get
            {
                return MTAShared.GetAircraftMaxHeight();
            }
            set
            {
                MTAShared.SetAircraftMaxHeight(value);
            }
        }

        /// <summary>
        /// Get and sets if clouds are enabled or disabled.
        /// </summary>
        public bool CloudsEnabled
        {
            get
            {
                return MTAShared.GetCloudsEnabled();
            }
            set
            {
                MTAShared.SetCloudsEnabled(value);
            }
        }

        /// <summary>
        /// Get and set the render distance
        /// </summary>
        public float FarClipDistance
        {
            get
            {
                return MTAShared.GetFarClipDistance();
            }
            set
            {
                MTAShared.SetFarClipDistance(value);
            }
        }

        /// <summary>
        /// This function resets the far clip distance to its default state.
        /// </summary>
        public bool ResetFarClipDistance()
        {
            return MTAShared.ResetFarClipDistance();
        }

        /// <summary>
        /// Get and set the current fog render distance.
        /// </summary>
        public float FogDistance
        {
            get
            {
                return MTAShared.GetFogDistance();
            }
            set
            {
                MTAShared.SetFogDistance(value);
            }
        }

        /// <summary>
        /// This function resets the fog render distance to its default state.
        /// </summary>
        public bool ResetFogDistance()
        {
            return MTAShared.ResetFogDistance();
        }

        /// <summary>
        /// Get and set the current game speed value.
        /// </summary>
        public float GameSpeed
        {
            get
            {
                return MTAShared.GetGameSpeed();
            }
            set
            {
                MTAShared.SetGameSpeed(value);
            }
        }

        /// <summary>
        /// Get and set the gravity in the world. Default is 0.008
        /// </summary>
        public float Gravity
        {
            get
            {
                return MTAShared.GetGravity();
            }
            set
            {
                MTAShared.SetGravity(value);
            }
        }

        /// <summary>
        /// Gets and sets the heat haze properties of the world
        /// </summary>
        public HeatHaze HeatHaze
        {
            get
            {
                return HeatHaze.FromRaw(MTAShared.GetHeatHaze());
            }
            set
            {
                MTAShared.SetHeatHaze(value.Intensity, value.RandomShift, value.SpeedMin, value.SpeedMax, (int) value.ScanSize.X, (int)value.ScanSize.Y, (int)value.RenderSize.X, (int)value.RenderSize.Y, value.ShowInside);
            }
        }

        /// <summary>
        /// Reset the heat haze
        /// </summary>
        public bool ResetHeatHaze()
        {
            return MTAShared.ResetHeatHaze();
        }

        /// <summary>
        /// Gets and sets the maximum height at which your jetpack can fly without failing to go higher.
        /// </summary>
        public float JetpackMaxHeight
        {
            get
            {
                return MTAShared.GetJetpackMaxHeight();
            }
            set
            {
                MTAShared.SetJetpackMaxHeight(value);
            }
        }

        /// <summary>
        /// Get a specific garage class instance from a garage ID
        /// </summary>
        public SharedGarage GetGarage(GarageEnum garage)
        {
            return new SharedGarage(garage);
        }

        /// <summary>
        /// Tells you how long an ingame minute takes in real-world milliseconds. The default GTA value is 1000.
        /// </summary>
        public int MinuteDuration
        {
            get
            {
                return MTAShared.GetMinuteDuration();
            }
            set
            {
                MTAShared.SetMinuteDuration(value);
            }
        }

        /// <summary>
        /// Gets and sets the size of the moon. Default is 3
        /// </summary>
        public int Moonsize
        {
            get
            {
                return MTAShared.GetMoonSize();
            }
            set
            {
                MTAShared.SetMoonSize(value);
            }
        }

        /// <summary>
        /// This function is used to reset the size of the moon to its normal size.
        /// </summary>
        public bool ResetMoonSize()
        {
            return MTAShared.ResetMoonSize();
        }

        /// <summary>
        /// Occlusions are used by GTA to enhance performance by hiding objects that are (normally) obscured by certain large buildings. 
        /// However when removeWorldModel is used they may also have the undesired effect of making parts of the map disappear. 
        /// Disabling occlusions will fix that.
        /// </summary>
        public bool OcclusionsEnabled
        {
            get
            {
                return MTAShared.GetOcclusionsEnabled();
            }
            set
            {
                MTAShared.SetOcclusionsEnabled(value);
            }
        }

        /// <summary>
        /// Gets and sets the rain level to any weather available in GTA
        /// The level value is clamped between 0.0 and 10.0 to avoid gameplay issues.
        /// </summary>
        public float RainLevel
        {
            get
            {
                return MTAShared.GetRainLevel();
            }
            set
            {
                MTAShared.SetRainLevel(value);
            }
        }

        /// <summary>
        /// This function resets the rain level of the current weather to its default.
        /// </summary>
        public bool ResetRainLevel()
        {
            return MTAShared.ResetRainLevel();
        }

        /// <summary>
        /// Get and set the gradient of the sky from top to bottom
        /// </summary>
        public Tuple<Color, Color> SkyGradient
        {
            get
            {
                Tuple<int, int, int, int, int, int> raw = MTAShared.GetSkyGradient();
                return new Tuple<Color, Color>(new Color((byte) raw.Item1, (byte) raw.Item2, (byte) raw.Item3), new Color((byte) raw.Item4, (byte) raw.Item5, (byte) raw.Item6));
            }
            set
            {
                MTAShared.SetSkyGradient(value.Item1.R, value.Item1.G, value.Item1.B, value.Item2.R, value.Item2.G, value.Item2.B);
            }
        }

        /// <summary>
        /// Reset the sky gradient to the normal value
        /// </summary>
        public bool ResetSkyGradient()
        {
            return MTAShared.ResetSkyGradient();
        }

        /// <summary>
        /// Get and set the color of the sun
        /// </summary>
        public Tuple<Color, Color> SunColor
        {
            get
            {
                Tuple<int, int, int, int, int, int> raw = MTAShared.GetSunColor();
                return new Tuple<Color, Color>(new Color((byte)raw.Item1, (byte)raw.Item2, (byte)raw.Item3), new Color((byte)raw.Item4, (byte)raw.Item5, (byte)raw.Item6));
            }
            set
            {
                MTAShared.SetSunColor(value.Item1.R, value.Item1.G, value.Item1.B, value.Item2.R, value.Item2.G, value.Item2.B);
            }
        }

        /// <summary>
        /// Reset the color of the sun to normal
        /// </summary>
        public bool ResetSunColor()
        {
            return MTAShared.ResetSunColor();
        }

        /// <summary>
        /// Get and set the size of the sun
        /// </summary>
        public int SunSize
        {
            get
            {
                return (int) MTAShared.GetSunSize();
            }
            set
            {
                MTAShared.SetSunSize(value);
            }
        }

        /// <summary>
        /// Reset the size of the sun to normal
        /// </summary>
        public bool ResetSunSize()
        {
            return MTAShared.ResetSunSize();
        }

        /// <summary>
        /// Get and set the time in the world
        /// </summary>
        public GameTime Time
        {
            get
            {
                Tuple<int, int> time = MTAShared.GetTime();
                return new GameTime(time.Item1, time.Item2);
            }
            set
            {
                MTAShared.SetTime(value.Hour, value.Minute);
            }
        }

        /// <summary>
        /// Get and set the different states of traffic lights in the world
        /// </summary>
        public TrafficLightStateEnum TrafficLightState
        {
            get
            {
                return (TrafficLightStateEnum) MTAShared.GetTrafficLightState();
            }
            set
            {
                if (value == TrafficLightStateEnum.AUTO)
                    MTAShared.SetTrafficLightState("auto");
                else
                    MTAShared.SetTrafficLightState((int) value);
            }
        }

        /// <summary>
        /// Get and set the current weather
        /// The weather is set blended if the weather struct passed is also blended
        /// </summary>
        public Weather Weather
        {
            get
            {
                Tuple<int, int> result = MTAShared.GetWeather();
                return new Weather((WeatherEnum)result.Item1, (WeatherEnum)result.Item2);
            }
            set
            {
                if (value.TransitionTo > 0)
                    MTAShared.SetWeatherBlended((int)value.TransitionTo);
                else
                    MTAShared.SetWeather((int)value.Current);
            }
        }

        /// <summary>
        /// Get and set the wind velocity.
        /// The wind shakes the vegetation and makes particles fly in a direction. The intensity and direction of the effect deppends of the wind velocity in each axis.
        /// </summary>
        public Vector3 WindVelocity
        {
            get
            {
                Tuple<int, int, int> result = MTAShared.GetWindVelocity();
                return new Vector3(result.Item1, result.Item2, result.Item3);
            }
            set
            {
                MTAShared.SetWindVelocity(value.X, value.Y, value.Z);
            }
        }

        /// <summary>
        /// Resets the wind velocity to default
        /// </summary>
        public bool ResetWindVelocity()
        {
            return MTAShared.ResetWindVelocity();
        }

        /// <summary>
        /// Get the name of the zone of a position
        /// </summary>
        public string GetZoneName(Vector3 position, bool citiesOnly = false)
        {
            return MTAShared.GetZoneName(position.X, position.Y, position.Z, citiesOnly);
        }

        /// <summary>
        /// Remove all world models in a certain sphere
        /// </summary>
        public bool RemoveWorldModel(int modelID, float radius, Vector3 position, int interior = 0)
        {
            return MTAShared.RemoveWorldModel(modelID, radius, position.X, position.Y, position.Z, interior);
        }

        /// <summary>
        /// Restore all world models in a certain sphere
        /// </summary>
        public bool RestoreWorldModel(int modelID, float radius, Vector3 position, int interior = -1)
        {
            return MTAShared.RestoreWorldModel(modelID, radius, position.X, position.Y, position.Z, interior);
        }

        /// <summary>
        /// Restore the removal of all world models
        /// </summary>
        public bool RestoreAllWorldModels()
        {
            return MTAShared.RestoreAllWorldModels();
        }

        /// <summary>
        /// This proeprty disables or enables the ambient sounds played by GTA in most interiors, like restaurants, casinos, clubs, houses, etc.
        /// </summary>
        public bool InteriorSounds
        {
            set
            {
                MTAShared.SetInteriorSoundsEnabled(value);
            }
        }

        /// <summary>
        /// Changes the water color of the GTA world.
        /// </summary>
        public Color WaterColor
        {
            get
            {
                Tuple<int, int, int, int> result = MTAShared.GetWaterColor();
                return new Color((byte) result.Item1, (byte) result.Item2, (byte) result.Item3, (byte) result.Item4);
            }
            set
            {
                MTAShared.SetWaterColor(value.R, value.G, value.B, value.A);
            }
        }

        /// <summary>
        /// This function reset the water color of the GTA world to default.
        /// </summary>
        public bool ResetWaterColor()
        {
            return MTAShared.ResetWaterColor();
        }

        /// <summary>
        /// Get or sets the wave height to the desired value, the default is 0.
        /// </summary>
        public float WaveHeight
        {
            get
            {
                return MTAShared.GetWaveHeight();
            }
            set
            {
                MTAShared.SetWaveHeight(value);
            }
        }

        /// <summary>
        /// Sets the height of all the water in the game world.
        /// </summary>
        public bool SetWaterLevel(float level, bool includeWaterFeatures = true, bool includeWaterElements = true)
        {
            return MTAShared.SetWaterLevel(level, includeWaterFeatures, includeWaterElements);
        }

        /// <summary>
        /// This function resets the water of the GTA world back to its default level. Water elements are not affected.
        /// </summary>
        public bool ResetWaterLevel()
        {
            return MTAShared.ResetWaterLevel();
        }



    }
}
