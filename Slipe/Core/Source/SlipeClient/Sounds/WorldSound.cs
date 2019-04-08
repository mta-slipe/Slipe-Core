using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MTADefinitions;
using System.Numerics;
using System.ComponentModel;
using Slipe.Shared.Elements;

namespace Slipe.Client.Sounds
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
                Tuple<float, float, float> position = MTAShared.GetElementPosition(element);
                return new Vector3(position.Item1, position.Item2, position.Item3);
            }
            set
            {
                MTAShared.SetElementPosition(element, value.X, value.Y, value.Z, false);
            }
        }

        /// <summary>
        /// Gets and sets the dimension of this element
        /// </summary>
        public int Dimension
        {
            get
            {
                return MTAShared.GetElementDimension(element);
            }
            set
            {
                MTAShared.SetElementDimension(element, value);
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

        /// <summary>
        /// Get and set the minimal distance at which the sound stops getting louder
        /// </summary>
        public int MinDistance
        {
            get
            {
                return MTAClient.GetSoundMinDistance(element);
            }
            set
            {
                MTAClient.SetSoundMinDistance(element, value);
            }
        }

        /// <summary>
        /// Get and set if this sound pans (hearing it closer to the left or right side of the speakers due to the camera position).
        /// </summary>
        public bool PanningEnabled
        {
            get
            {
                return MTAClient.IsSoundPanningEnabled(element);
            }
            set
            {
                MTAClient.SetSoundPanningEnabled(element, value);
            }
        }

        #endregion

        #region Constructors

        [EditorBrowsable(EditorBrowsableState.Never)]
        public WorldSound(MTAElement element) : base(element) { }

        /// <summary>
        /// Create a sound in the world at a certain position
        /// </summary>
        public WorldSound(string pathOrUrl, Vector3 position, bool looped = false, bool throttled = true)
        {
            element = MTAClient.PlaySound3D(pathOrUrl, position.X, position.Y, position.Z, looped, throttled);
            ElementManager.Instance.RegisterElement(this);
        }

        /// <summary>
        /// Create a GTA Sfx at a 3D position in the world
        /// </summary>
        public WorldSound(SoundContainer container, int bankId, int soundId, Vector3 position, bool looped = false)
        {
            element = MTAClient.PlaySFX3D(container.ToString().ToLower(), bankId, soundId, position.X, position.Y, position.Z, looped);
            ElementManager.Instance.RegisterElement(this);
        }

        /// <summary>
        /// Create a GTA radio station sound at a 3D position in the world
        /// </summary>
        public WorldSound(RadioStation station, int trackId, Vector3 position, bool looped = false)
        {
            string stationName = MTAClient.GetRadioChannelName((int)station);
            element = MTAClient.PlaySFX3D("radio", stationName, trackId, position.X, position.Y, position.Z, looped);
            ElementManager.Instance.RegisterElement(this);
        }

        /// <summary>
        /// Create an extra GTA radio station sound at a 3D position in the world
        /// </summary>
        public WorldSound(ExtraStations station, int trackId, Vector3 position, bool looped = false)
        {
            element = MTAClient.PlaySFX3D("radio", station.ToString(), trackId, position.X, position.Y, position.Z, looped);
            ElementManager.Instance.RegisterElement(this);
        }

        #endregion

        #region Attach Methods

        /// <summary>
        /// Attach this attachable to a Physical Element with an offset
        /// </summary>
        public void AttachTo(PhysicalElement toElement, Vector3 offset)
        {
            MTAShared.AttachElements(element, toElement.MTAElement, offset.X, offset.Y, offset.Z, 0, 0, 0);
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
            MTAShared.DetachElements(element, null);
        }

        /// <summary>
        /// Get the toAttached to which this attachable is attached
        /// </summary>
        public PhysicalElement ToAttached
        {
            get
            {
                return (PhysicalElement)ElementManager.Instance.GetElement(MTAShared.GetElementAttachedTo(element));
            }
        }

        /// <summary>
        /// Get if this attachable is attached to a ToAttachable
        /// </summary>
        public bool IsAttached
        {
            get
            {
                return MTAShared.IsElementAttached(element);
            }
        }

        #endregion
    }
}
