using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MTADefinitions;
using System.ComponentModel;
using Slipe.Client;
using Slipe.Shared.Elements;

namespace Slipe.Client.Sounds
{
    /// <summary>
    /// Represents a sound played for the player
    /// </summary>
    public class Sound : Element
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

        /// <summary>
        /// Get and set the pan level of this sound element. (-1.0 (left) to 1.0 (right))
        /// </summary>
        public float Pan
        {
            get
            {
                return MTAClient.GetSoundPan(element);
            }
            set
            {
                MTAClient.SetSoundPan(element, value);
            }
        }

        /// <summary>
        /// Get and set the position in seconds on the sound track
        /// </summary>
        public float TrackPosition
        {
            get
            {
                return MTAClient.GetSoundPosition(element);
            }
            set
            {
                MTAClient.SetSoundPosition(element, value);
            }
        }

        private SoundProperties properties;
        /// <summary>
        /// Get the properties of this sound
        /// </summary>
        public SoundProperties Properties
        {
            get
            {
                if (properties == null)
                    properties = new SoundProperties(this);
                return properties;
            }
        }

        /// <summary>
        /// Get and set the speed of this sound
        /// </summary>
        public float Speed
        {
            get
            {
                return MTAClient.GetSoundSpeed(element);
            }
            set
            {
                MTAClient.SetSoundSpeed(element, value);
            }
        }

        /// <summary>
        /// Get and set the volume. Range is from 0.0 to 1.0. This can go above 1.0 for amplification.
        /// </summary>
        public float Volume
        {
            get
            {
                return MTAClient.GetSoundVolume(element);
            }
            set
            {
                MTAClient.SetSoundVolume(element, value);
            }
        }

        /// <summary>
        /// Get and set if the sound is paused
        /// </summary>
        public bool Paused
        {
            get
            {
                return MTAClient.IsSoundPaused(element);
            }
            set
            {
                MTAClient.SetSoundPaused(element, value);
            }
        }

        #endregion 

        #region Constructors
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Sound(MTAElement element) : base(element) { }

        protected Sound() { }

        /// <summary>
        /// Create sound
        /// </summary>
        public Sound(string pathOrUrl, bool looped = false, bool throttled = true)
        {
            element = MTAClient.PlaySound(pathOrUrl, looped, throttled);
            ElementManager.Instance.RegisterElement(this);
        }

        /// <summary>
        /// Create a GTA Sfx
        /// </summary>
        public Sound(SoundContainer container, int bankId, int soundId, bool looped = false)
        {
            //string containerBank = ((SoundContainer)container).ToString().ToLower();
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

        [EditorBrowsable(EditorBrowsableState.Never)]
        public Sound(Player player)
        {
            element = player.MTAElement;
        }
        #endregion

        #region Methods

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
        /// Stop and destroy this sound
        /// </summary>
        public override bool Destroy()
        {
            return MTAClient.StopSound(element);
        }
        /// <summary>
        /// Check if a soundcontainer is available on this client
        /// </summary>
        public static bool GetSfxStatus(SoundContainer container)
        {
            return MTAClient.GetSFXStatus(container.ToString().ToLower());
        }

        #endregion

    }
}
