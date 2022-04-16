using System;
using System.Collections.Generic;
using System.Text;
using SlipeLua.MtaDefinitions;
using System.Numerics;
using System.ComponentModel;
using SlipeLua.Shared.Elements;

namespace SlipeLua.Client.Sounds
{
    /// <summary>
    /// Represents a sound played at a certain location in the world
    /// </summary>
    public class WorldSound : Sound
    {
        #region Properties

        /// <summary>
        /// Gets and sets the position of the element
        /// </summary>
        public Vector3 Position
        {
            get
            {
                Tuple<float, float, float> position = MtaShared.GetElementPosition(element);
                return new Vector3(position.Item1, position.Item2, position.Item3);
            }
            set
            {
                MtaShared.SetElementPosition(element, value.X, value.Y, value.Z, false);
            }
        }

        /// <summary>
        /// Gets and sets the dimension of this element
        /// </summary>
        public int Dimension
        {
            get
            {
                return MtaShared.GetElementDimension(element);
            }
            set
            {
                MtaShared.SetElementDimension(element, value);
            }
        }

        /// <summary>
        /// Get and set the max distance at which this sound stops
        /// </summary>
        public int MaxDistance
        {
            get
            {
                return MtaClient.GetSoundMaxDistance(element);
            }
            set
            {
                MtaClient.SetSoundMaxDistance(element, value);
            }
        }

        /// <summary>
        /// Get and set the minimal distance at which the sound stops getting louder
        /// </summary>
        public int MinDistance
        {
            get
            {
                return MtaClient.GetSoundMinDistance(element);
            }
            set
            {
                MtaClient.SetSoundMinDistance(element, value);
            }
        }

        /// <summary>
        /// Get and set if this sound pans (hearing it closer to the left or right side of the speakers due to the camera position).
        /// </summary>
        public bool PanningEnabled
        {
            get
            {
                return MtaClient.IsSoundPanningEnabled(element);
            }
            set
            {
                MtaClient.SetSoundPanningEnabled(element, value);
            }
        }

        #endregion

        #region Constructors

        [EditorBrowsable(EditorBrowsableState.Never)]
        public WorldSound(MtaElement element) : base(element) { }

        /// <summary>
        /// Create a sound in the world at a certain position
        /// </summary>
        public WorldSound(string pathOrUrl, Vector3 position, bool looped = false, bool throttled = true)
            : this(MtaClient.PlaySound3D(pathOrUrl, position.X, position.Y, position.Z, looped, throttled)) { }

        /// <summary>
        /// Create a GTA Sfx at a 3D position in the world
        /// </summary>
        public WorldSound(SoundContainer container, int bankId, int soundId, Vector3 position, bool looped = false)
            : this(MtaClient.PlaySFX3D(container.ToString().ToLower(), bankId, soundId, position.X, position.Y, position.Z, looped)) { }

        /// <summary>
        /// Create a GTA radio station sound at a 3D position in the world
        /// </summary>
        public WorldSound(RadioStation station, int trackId, Vector3 position, bool looped = false)
            : this(MtaClient.PlaySFX3D("radio", MtaClient.GetRadioChannelName((int)station), trackId, position.X, position.Y, position.Z, looped)) { }

        /// <summary>
        /// Create an extra GTA radio station sound at a 3D position in the world
        /// </summary>
        public WorldSound(ExtraStations station, int trackId, Vector3 position, bool looped = false)
            : this(MtaClient.PlaySFX3D("radio", station.ToString(), trackId, position.X, position.Y, position.Z, looped)) { }

        #endregion

        #region Attach Methods

        /// <summary>
        /// Attach this attachable to a Physical Element with an offset
        /// </summary>
        public void AttachTo(PhysicalElement toElement, Vector3 offset)
        {
            MtaShared.AttachElements(element, toElement.MTAElement, offset.X, offset.Y, offset.Z, 0, 0, 0);
        }

        /// <summary>
        /// Attach this attachable to a Physical Element without any offset
        /// </summary>
        public void AttachTo(PhysicalElement toElement)
        {
            AttachTo(toElement, Vector3.Zero);
        }

        /// <summary>
        /// Detach this attachable
        /// </summary>
        public void Detach()
        {
            MtaShared.DetachElements(element, null);
        }

        /// <summary>
        /// Get the toAttached to which this attachable is attached
        /// </summary>
        public PhysicalElement ToAttached
        {
            get
            {
                return ElementManager.Instance.GetElement<PhysicalElement>(MtaShared.GetElementAttachedTo(element));
            }
        }

        /// <summary>
        /// Get if this attachable is attached to a ToAttachable
        /// </summary>
        public bool IsAttached
        {
            get
            {
                return MtaShared.IsElementAttached(element);
            }
        }

        #endregion
    }
}
