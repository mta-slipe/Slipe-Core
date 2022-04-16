using System;
using System.Collections.Generic;
using System.Text;
using SlipeLua.MtaDefinitions;
using System.ComponentModel;
using SlipeLua.Shared.Elements;
using SlipeLua.Client.Peds;
using SlipeLua.Client.Sounds.Events;

namespace SlipeLua.Client.Sounds
{
    /// <summary>
    /// Represents a sound played for the player
    /// </summary>
    [DefaultElementClass(ElementType.Sound)]
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
                return MtaClient.GetSoundBPM(element);
            }
        }

        /// <summary>
        /// Gets the buffer playback length of the sound. Works only with streams.
        /// </summary>
        public float BufferLength
        {
            get
            {
                return MtaClient.GetSoundBufferLength(element);
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
                return MtaClient.GetSoundLength(element);
            }
        }

        /// <summary>
        /// Get the left/right level from this sound
        /// </summary>
        public Tuple<int, int> LevelData
        {
            get
            {
                return MtaClient.GetSoundLevelData(element);
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
                return MtaClient.GetSoundPan(element);
            }
            set
            {
                MtaClient.SetSoundPan(element, value);
            }
        }

        /// <summary>
        /// Get and set the position in seconds on the sound track
        /// </summary>
        public float TrackPosition
        {
            get
            {
                return MtaClient.GetSoundPosition(element);
            }
            set
            {
                MtaClient.SetSoundPosition(element, value);
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
                return MtaClient.GetSoundSpeed(element);
            }
            set
            {
                MtaClient.SetSoundSpeed(element, value);
            }
        }

        /// <summary>
        /// Get and set the volume. Range is from 0.0 to 1.0. This can go above 1.0 for amplification.
        /// </summary>
        public float Volume
        {
            get
            {
                return MtaClient.GetSoundVolume(element);
            }
            set
            {
                MtaClient.SetSoundVolume(element, value);
            }
        }

        /// <summary>
        /// Get and set if the sound is paused
        /// </summary>
        public bool Paused
        {
            get
            {
                return MtaClient.IsSoundPaused(element);
            }
            set
            {
                MtaClient.SetSoundPaused(element, value);
            }
        }

        #endregion 

        #region Constructors

        [EditorBrowsable(EditorBrowsableState.Never)]
        public Sound(MtaElement element) : base(element) { }

        /// <summary>
        /// Create sound
        /// </summary>
        public Sound(string pathOrUrl, bool looped = false, bool throttled = true)
            : this(MtaClient.PlaySound(pathOrUrl, looped, throttled)) { }

        /// <summary>
        /// Create a GTA Sfx
        /// </summary>
        public Sound(SoundContainer container, int bankId, int soundId, bool looped = false)
            : this(MtaClient.PlaySFX(container.ToString().ToLower(), bankId, soundId, looped)) { }

        /// <summary>
        /// Create a GTA radio station sound
        /// </summary>
        public Sound(RadioStation station, int trackId, bool looped = false)
            : this(MtaClient.PlaySFX("radio", MtaClient.GetRadioChannelName((int)station), trackId, looped)) { }

        /// <summary>
        /// Create an extra GTA radio station sound
        /// </summary>
        public Sound(ExtraStations station, int trackId, bool looped = false)
            : this(MtaClient.PlaySFX("radio", station.ToString(), trackId, looped)) { }

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
            Dictionary<int, float> raw = MtaShared.GetDictionaryFromTable(MtaClient.GetSoundFFTData(element, iSamples, iBands), "System.Int32", "System.Single");
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
            return MtaClient.StopSound(element);
        }
        /// <summary>
        /// Check if a soundcontainer is available on this client
        /// </summary>
        public static bool GetSfxStatus(SoundContainer container)
        {
            return MtaClient.GetSFXStatus(container.ToString().ToLower());
        }

        #endregion

        #region Events

        #pragma warning disable 67

        public delegate void OnBeatHandler(Sound source, OnBeatEventArgs eventArgs);
        public event OnBeatHandler OnBeat;

        public delegate void OnMetaChangedHandler(Sound source, OnMetaChangedEventArgs eventArgs);
        public event OnMetaChangedHandler OnMetaChanged;

        public delegate void OnDownloadFinishedHandler(Sound source, OnDownloadFinishedEventArgs eventArgs);
        public event OnDownloadFinishedHandler OnDownloadFinished;

        public delegate void OnStartHandler(Sound source, OnStartEventArgs eventArgs);
        public event OnStartHandler OnStart;

        public delegate void OnStopHandler(Sound source, OnStopEventArgs eventArgs);
        public event OnStopHandler OnStop;

        public delegate void OnStreamHandler(Sound source, OnStreamEventArgs eventArgs);
        public event OnStreamHandler OnStream;

        #pragma warning restore 67

        #endregion

    }
}
