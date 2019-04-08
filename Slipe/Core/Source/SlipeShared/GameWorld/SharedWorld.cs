using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MtaDefinitions;
using System.Numerics;
using Slipe.Shared.Utilities;

namespace Slipe.Shared.GameWorld
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
                if (instance == null)
                {
                    instance = new SharedWorld();
                }
                return instance;
            }
        }

        #region Properties

        /// <summary>
        /// Gets and sets whether the traffic lights are currently locked or not. 
        /// If the lights are locked, it means they won't change unless you alter the TrafficLightState
        /// </summary>
        public bool LockedTrafficLights
        {
            get
            {
                return MtaShared.AreTrafficLightsLocked();
            }
            set
            {
                MtaShared.SetTrafficLightsLocked(value);
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
                return MtaShared.GetAircraftMaxVelocity();
            }
            set
            {
                MtaShared.SetAircraftMaxVelocity(value);
            }
        }

        /// <summary>
        /// Gets and sets the maximum height at which aircraft can fly without their engines turning off.
        /// </summary>
        public float AircraftMaxHeight
        {
            get
            {
                return MtaShared.GetAircraftMaxHeight();
            }
            set
            {
                MtaShared.SetAircraftMaxHeight(value);
            }
        }

        /// <summary>
        /// Get and sets if clouds are enabled or disabled.
        /// </summary>
        public bool CloudsEnabled
        {
            get
            {
                return MtaShared.GetCloudsEnabled();
            }
            set
            {
                MtaShared.SetCloudsEnabled(value);
            }
        }

        /// <summary>
        /// Get and set the render distance
        /// </summary>
        public float FarClipDistance
        {
            get
            {
                return MtaShared.GetFarClipDistance();
            }
            set
            {
                MtaShared.SetFarClipDistance(value);
            }
        }

        /// <summary>
        /// Get and set the current fog render distance.
        /// </summary>
        public float FogDistance
        {
            get
            {
                return MtaShared.GetFogDistance();
            }
            set
            {
                MtaShared.SetFogDistance(value);
            }
        }

        /// <summary>
        /// Get and set the current game speed value.
        /// </summary>
        public float GameSpeed
        {
            get
            {
                return MtaShared.GetGameSpeed();
            }
            set
            {
                MtaShared.SetGameSpeed(value);
            }
        }

        /// <summary>
        /// Get and set the gravity in the world. Default is 0.008
        /// </summary>
        public float Gravity
        {
            get
            {
                return MtaShared.GetGravity();
            }
            set
            {
                MtaShared.SetGravity(value);
            }
        }

        /// <summary>
        /// Gets and sets the heat haze properties of the world
        /// </summary>
        public HeatHaze HeatHaze
        {
            get
            {
                return HeatHaze.FromRaw(MtaShared.GetHeatHaze());
            }
            set
            {
                MtaShared.SetHeatHaze(value.Intensity, value.RandomShift, value.SpeedMin, value.SpeedMax, (int)value.ScanSize.X, (int)value.ScanSize.Y, (int)value.RenderSize.X, (int)value.RenderSize.Y, value.ShowInside);
            }
        }

        /// <summary>
        /// Gets and sets the maximum height at which your jetpack can fly without failing to go higher.
        /// </summary>
        public float JetpackMaxHeight
        {
            get
            {
                return MtaShared.GetJetpackMaxHeight();
            }
            set
            {
                MtaShared.SetJetpackMaxHeight(value);
            }
        }

        /// <summary>
        /// Tells you how long an ingame minute takes in real-world milliseconds. The default GTA value is 1000.
        /// </summary>
        public int MinuteDuration
        {
            get
            {
                return MtaShared.GetMinuteDuration();
            }
            set
            {
                MtaShared.SetMinuteDuration(value);
            }
        }

        /// <summary>
        /// Gets and sets the size of the moon. Default is 3
        /// </summary>
        public int Moonsize
        {
            get
            {
                return MtaShared.GetMoonSize();
            }
            set
            {
                MtaShared.SetMoonSize(value);
            }
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
                return MtaShared.GetOcclusionsEnabled();
            }
            set
            {
                MtaShared.SetOcclusionsEnabled(value);
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
                return MtaShared.GetRainLevel();
            }
            set
            {
                MtaShared.SetRainLevel(value);
            }
        }

        /// <summary>
        /// Get and set the gradient of the sky from top to bottom
        /// </summary>
        public Tuple<Color, Color> SkyGradient
        {
            get
            {
                Tuple<int, int, int, int, int, int> raw = MtaShared.GetSkyGradient();
                return new Tuple<Color, Color>(new Color((byte)raw.Item1, (byte)raw.Item2, (byte)raw.Item3), new Color((byte)raw.Item4, (byte)raw.Item5, (byte)raw.Item6));
            }
            set
            {
                MtaShared.SetSkyGradient(value.Item1.R, value.Item1.G, value.Item1.B, value.Item2.R, value.Item2.G, value.Item2.B);
            }
        }

        /// <summary>
        /// Get and set the color of the sun
        /// </summary>
        public Tuple<Color, Color> SunColor
        {
            get
            {
                Tuple<int, int, int, int, int, int> raw = MtaShared.GetSunColor();
                return new Tuple<Color, Color>(new Color((byte)raw.Item1, (byte)raw.Item2, (byte)raw.Item3), new Color((byte)raw.Item4, (byte)raw.Item5, (byte)raw.Item6));
            }
            set
            {
                MtaShared.SetSunColor(value.Item1.R, value.Item1.G, value.Item1.B, value.Item2.R, value.Item2.G, value.Item2.B);
            }
        }

        /// <summary>
        /// Get and set the size of the sun
        /// </summary>
        public int SunSize
        {
            get
            {
                return (int)MtaShared.GetSunSize();
            }
            set
            {
                MtaShared.SetSunSize(value);
            }
        }

        /// <summary>
        /// Get and set the time in the world
        /// </summary>
        public GameTime Time
        {
            get
            {
                Tuple<int, int> time = MtaShared.GetTime();
                return new GameTime(time.Item1, time.Item2);
            }
            set
            {
                MtaShared.SetTime(value.Hour, value.Minute);
            }
        }

        /// <summary>
        /// Get and set the different states of traffic lights in the world
        /// </summary>
        public TrafficLightState TrafficLightState
        {
            get
            {
                return (TrafficLightState)MtaShared.GetTrafficLightState();
            }
            set
            {
                if (value == TrafficLightState.Auto)
                    MtaShared.SetTrafficLightState("auto");
                else
                    MtaShared.SetTrafficLightState((int)value);
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
                Tuple<int, int> result = MtaShared.GetWeather();
                return new Weather((WeatherType)result.Item1, (WeatherType)result.Item2);
            }
            set
            {
                if (value.TransitionTo > 0)
                    MtaShared.SetWeatherBlended((int)value.TransitionTo);
                else
                    MtaShared.SetWeather((int)value.Current);
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
                Tuple<int, int, int> result = MtaShared.GetWindVelocity();
                return new Vector3(result.Item1, result.Item2, result.Item3);
            }
            set
            {
                MtaShared.SetWindVelocity(value.X, value.Y, value.Z);
            }
        }

        /// <summary>
        /// This proeprty disables or enables the ambient sounds played by GTA in most interiors, like restaurants, casinos, clubs, houses, etc.
        /// </summary>
        public bool InteriorSounds
        {
            set
            {
                MtaShared.SetInteriorSoundsEnabled(value);
            }
        }

        /// <summary>
        /// Changes the water color of the GTA world.
        /// </summary>
        public Color WaterColor
        {
            get
            {
                Tuple<int, int, int, int> result = MtaShared.GetWaterColor();
                return new Color((byte)result.Item1, (byte)result.Item2, (byte)result.Item3, (byte)result.Item4);
            }
            set
            {
                MtaShared.SetWaterColor(value.R, value.G, value.B, value.A);
            }
        }

        /// <summary>
        /// Get or sets the wave height to the desired value, the default is 0.
        /// </summary>
        public float WaveHeight
        {
            get
            {
                return MtaShared.GetWaveHeight();
            }
            set
            {
                MtaShared.SetWaveHeight(value);
            }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Instantiate a new world
        /// </summary>
        public SharedWorld() { }

        #endregion

        #region Methods

        /// <summary>
        /// This function resets the far clip distance to its default state.
        /// </summary>
        public bool ResetFarClipDistance()
        {
            return MtaShared.ResetFarClipDistance();
        }

        /// <summary>
        /// This function resets the fog render distance to its default state.
        /// </summary>
        public bool ResetFogDistance()
        {
            return MtaShared.ResetFogDistance();
        }

        /// <summary>
        /// Reset the heat haze
        /// </summary>
        public bool ResetHeatHaze()
        {
            return MtaShared.ResetHeatHaze();
        }

        /// <summary>
        /// Get a specific garage class instance from a garage ID
        /// </summary>
        public SharedGarage GetGarage(GarageLocation garage)
        {
            return new SharedGarage(garage);
        }

        /// <summary>
        /// This function is used to reset the size of the moon to its normal size.
        /// </summary>
        public bool ResetMoonSize()
        {
            return MtaShared.ResetMoonSize();
        }

        /// <summary>
        /// This function resets the rain level of the current weather to its default.
        /// </summary>
        public bool ResetRainLevel()
        {
            return MtaShared.ResetRainLevel();
        }

        /// <summary>
        /// Reset the sky gradient to the normal value
        /// </summary>
        public bool ResetSkyGradient()
        {
            return MtaShared.ResetSkyGradient();
        }

        /// <summary>
        /// Reset the color of the sun to normal
        /// </summary>
        public bool ResetSunColor()
        {
            return MtaShared.ResetSunColor();
        }

        /// <summary>
        /// Reset the size of the sun to normal
        /// </summary>
        public bool ResetSunSize()
        {
            return MtaShared.ResetSunSize();
        }

        /// <summary>
        /// Resets the wind velocity to default
        /// </summary>
        public bool ResetWindVelocity()
        {
            return MtaShared.ResetWindVelocity();
        }

        /// <summary>
        /// Get the name of the zone of a position
        /// </summary>
        public string GetZoneName(Vector3 position, bool citiesOnly = false)
        {
            return MtaShared.GetZoneName(position.X, position.Y, position.Z, citiesOnly);
        }

        /// <summary>
        /// Remove all world models in a certain sphere
        /// </summary>
        public bool RemoveWorldModel(int modelID, float radius, Vector3 position, int interior = 0)
        {
            return MtaShared.RemoveWorldModel(modelID, radius, position.X, position.Y, position.Z, interior);
        }

        /// <summary>
        /// Restore all world models in a certain sphere
        /// </summary>
        public bool RestoreWorldModel(int modelID, float radius, Vector3 position, int interior = -1)
        {
            return MtaShared.RestoreWorldModel(modelID, radius, position.X, position.Y, position.Z, interior);
        }

        /// <summary>
        /// Restore the removal of all world models
        /// </summary>
        public bool RestoreAllWorldModels()
        {
            return MtaShared.RestoreAllWorldModels();
        }

        /// <summary>
        /// This function reset the water color of the GTA world to default.
        /// </summary>
        public bool ResetWaterColor()
        {
            return MtaShared.ResetWaterColor();
        }

        /// <summary>
        /// Sets the height of all the water in the game world.
        /// </summary>
        public bool SetWaterLevel(float level, bool includeWaterFeatures = true, bool includeWaterElements = true)
        {
            return MtaShared.SetWaterLevel(level, includeWaterFeatures, includeWaterElements);
        }

        /// <summary>
        /// This function resets the water of the GTA world back to its default level. Water elements are not affected.
        /// </summary>
        public bool ResetWaterLevel()
        {
            return MtaShared.ResetWaterLevel();
        }

        #endregion

    }
}
