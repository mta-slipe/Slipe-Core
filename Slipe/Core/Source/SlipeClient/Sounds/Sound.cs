using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MTADefinitions;
using Slipe.Shared;
using System.ComponentModel;
using System.Numerics;
using Slipe.Client;

namespace Slipe.Client.Sounds
{
    /// <summary>
    /// Represents a sound played for the player or as a 3D element
    /// </summary>
    public class Sound : PhysicalElement
    {
        #region Properties

        /// <summary>
        /// Gets the beats per minute of this sound element.
        /// </summary>
        public int Bpm
        {
            get
            {
                return MTAClient.GetSoundBPM(element);
            }
        }

        /// <summary>
        /// Gets the buffer playback length of the sound. Works only with streams.
        /// </summary>
        public float BufferLength
        {
            get
            {
                return MTAClient.GetSoundBufferLength(element);
            }
        }

        private SoundEffects effects;
        /// <summary>
        /// Used to enable or disable specific sound effects.
        /// </summary>
        public SoundEffects Effects
        {
            get
            {
                if (effects == null)
                    effects = new SoundEffects(this);
                return effects;
            }
        }

        /// <summary>
        /// Get the playback length
        /// </summary>
        public float Length
        {
            get
            {
                return MTAClient.GetSoundLength(element);
            }
        }

        /// <summary>
        /// Get the left/right level from this sound
        /// </summary>
        public Tuple<int, int> LevelData
        {
            get
            {
                return MTAClient.GetSoundLevelData(element);
            }
        }

        /// <summary>
        /// Get and set the max distance at which this sound stops
        /// </summary>
        public int MaxDistance
        {
            get
            {
                return MTAClient.GetSoundMaxDistance(element);
            }
            set
            {
                MTAClient.SetSoundMaxDistance(element, value);
            }
        }

        private SoundMeta meta;
        /// <summary>
        /// Used to get the meta tags attached to this sound. These provide information about the sound, for instance the title or the artist.
        /// </summary>
        public SoundMeta MetaTags
        {
            get
            {
                if (meta == null)
                    meta = new SoundMeta(this);
                return meta;
            }
        }

        #endregion 

        #region Constructors
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Sound(MTAElement element) : base(element) { }

        /// <summary>
        /// Create a non 3D sound
        /// </summary>
        public Sound(string pathOrUrl, bool looped = false, bool throttled = true)
        {
            element = MTAClient.PlaySound(pathOrUrl, looped, throttled);
            ElementManager.Instance.RegisterElement(this);
        }

        /// <summary>
        /// Create a sound in the world at a certain position
        /// </summary>
        public Sound(string pathOrUrl, Vector3 position, bool looped = false, bool throttled = true)
        {
            element = MTAClient.PlaySound3D(pathOrUrl, position.X, position.Y, position.Z, looped, throttled);
            ElementManager.Instance.RegisterElement(this);
        }

        /// <summary>
        /// Create a GTA Sfx
        /// </summary>
        public Sound(SoundContainer container, int bankId, int soundId, bool looped = false)
        {
            element = MTAClient.PlaySFX(container.ToString().ToLower(), bankId, soundId, looped);
            ElementManager.Instance.RegisterElement(this);
        }

        /// <summary>
        /// Create a GTA radio station sound
        /// </summary>
        public Sound(RadioStation station, int trackId, bool looped = false)
        {
            string stationName = MTAClient.GetRadioChannelName((int)station);
            element = MTAClient.PlaySFX("radio", stationName, trackId, looped);
            ElementManager.Instance.RegisterElement(this);
        }

        /// <summary>
        /// Create an extra GTA radio station sound
        /// </summary>
        public Sound(ExtraStations station, int trackId, bool looped = false)
        {
            element = MTAClient.PlaySFX("radio", station.ToString(), trackId, looped);
            ElementManager.Instance.RegisterElement(this);
        }

        /// <summary>
        /// Create a GTA Sfx at a 3D position in the world
        /// </summary>
        public Sound(SoundContainer container, int bankId, int soundId, Vector3 position, bool looped = false)
        {
            element = MTAClient.PlaySFX3D(container.ToString().ToLower(), bankId, soundId, position.X, position.Y, position.Z, looped);
            ElementManager.Instance.RegisterElement(this);
        }

        /// <summary>
        /// Create a GTA radio station sound at a 3D position in the world
        /// </summary>
        public Sound(RadioStation station, int trackId, Vector3 position, bool looped = false)
        {
            string stationName = MTAClient.GetRadioChannelName((int)station);
            element = MTAClient.PlaySFX3D("radio", stationName, trackId, position.X, position.Y, position.Z, looped);
            ElementManager.Instance.RegisterElement(this);
        }

        /// <summary>
        /// Create an extra GTA radio station sound at a 3D position in the world
        /// </summary>
        public Sound(ExtraStations station, int trackId, Vector3 position, bool looped = false)
        {
            element = MTAClient.PlaySFX3D("radio", station.ToString(), trackId, position.X, position.Y, position.Z, looped);
            ElementManager.Instance.RegisterElement(this);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public Sound(Player player)
        {
            element = player.MTAElement;
        }
        #endregion

        /// <summary>
        /// This function gets the fast fourier transform data for an audio stream which is an array of floats representing the current audio frame. 
        /// </summary>
        public float[] GetFftData(int iSamples = 512, int iBands = 0)
        {
            Dictionary<int, float> raw = MTAShared.GetDictionaryFromTable(MTAClient.GetSoundFFTData(element, iSamples, iBands), "System.Int32", "System.Single");
            float[] fftData = new float[raw.Count];
            foreach(KeyValuePair<int, float> pair in raw)
            {
                fftData[pair.Key] = pair.Value;
            }
            return fftData;
        }

        /// <summary>
        /// Check if a soundcontainer is available on this client
        /// </summary>
        public static bool GetSfxStatus(SoundContainer container)
        {
            return MTAClient.GetSFXStatus(container.ToString().ToLower());
        }

    }
}
