using Slipe.MtaDefinitions;
using System;
using System.Collections.Generic;
using System.Text;
using Slipe.Shared.Exceptions;
using Slipe.Client.Sounds;
using Slipe.Shared.Elements;
using Slipe.Shared.Utilities;
using System.ComponentModel;
using Slipe.Shared.CollisionShapes;
using Slipe.Client.Pickups;
using Slipe.Shared.Peds;
using Slipe.Client.Vehicles;
using Slipe.Shared.Vehicles;
using Slipe.Shared.Weapons;
using Slipe.Client.Game;
using Slipe.Client.Peds.Events;
using Slipe.Shared.Elements.Events;
using Slipe.Client.IO.Events;

namespace Slipe.Client.Peds
{
    /// <summary>
    /// Class of MTA player elements
    /// </summary>
    [DefaultElementClass(ElementType.Player)]
    public class Player : Ped
    {
        #region Properties

        /// <summary>
        /// Get the team of a player
        /// </summary>
        public Team Team
        {
            get
            {
                return ElementManager.Instance.GetElement<Team>(MtaShared.GetPlayerTeam(element));
            }
        }

        /// <summary>
        /// Gets the name of the player
        /// </summary>
        public string Name
        {
            get
            {
                return MtaShared.GetPlayerName(element);
            }
        }

        /// <summary>
        /// Get and set the color of the player's nametag
        /// </summary>
        public Color NametagColor
        {
            get
            {
                Tuple<int, int, int> r = MtaShared.GetPlayerNametagColor(element);
                return new Color((byte)r.Item1, (byte)r.Item2, (byte)r.Item3);
            }
            set
            {
                MtaShared.SetPlayerNametagColor(element, value.R, value.G, value.B);
            }
        }

        /// <summary>
        /// This will change the text of a player's nickname in the world to something besides the nickname he chose. This will not change the player's actual nickname, it only changes the visible aspect inside the world
        /// </summary>
        public string NametagText
        {
            get
            {
                return MtaShared.GetPlayerNametagText(element);
            }
            set
            {
                MtaShared.SetPlayerNametagText(element, value);
            }
        }

        /// <summary>
        /// Get and set wether the nametag is visible
        /// </summary>
        public bool NametagShowing
        {
            get
            {
                return MtaShared.IsPlayerNametagShowing(element);
            }
            set
            {
                MtaShared.SetPlayerNametagShowing(element, value);
            }
        }

        /// <summary>
        /// Get the ping in milliseconds
        /// </summary>
        public int Ping
        {
            get
            {
                return MtaShared.GetPlayerPing(element);
            }
        }

        private Sound voice;
        /// <summary>
        /// Get the sound element that represents the player's voice
        /// </summary>
        public Sound Voice
        {
            get
            {
                if (voice == null)
                    voice = new Sound(this);
                return voice;
            }
        }

        #endregion

        /// <summary>
        /// Returns the Local Player element
        /// </summary>
        public static LocalPlayer Local
        {
            get
            {
                return LocalPlayer.Instance;
            }
        }

        #region Constructor
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Player(MtaElement mtaElement) : base(mtaElement) { }

        #endregion

        #region Static Methods

        /// <summary>
        /// Retrieves a player class instance from a specified player name 
        /// </summary>
        public static Player GetFromName(string name)
        {
            try
            {
                return ElementManager.Instance.GetElement<Player>(MtaShared.GetPlayerFromName(name));
            }
            catch (MtaException)
            {
                throw new NullElementException("No player with the name " + name + " could be found.");
            }
        }

        #endregion

        #region Events

#pragma warning disable 67

        public delegate void OnJoinHandler(Player source, OnJoinEventArgs eventArgs);
        public static event OnJoinHandler OnJoin;

        public delegate void OnCollisionShapeHitHandler(Player source, OnCollisionShapeHitEventArgs eventArgs);
        public event OnCollisionShapeHitHandler OnCollisionShapeHit;

        public delegate void OnCollisionShapeLeaveHandler(Player source, OnCollisionShapeLeaveEventArgs eventArgs);
        public event OnCollisionShapeLeaveHandler OnCollisionShapeLeave;

        public delegate void OnNicknameChangedHandler(Player source, OnNicknameChangedEventArgs eventArgs);
        public event OnNicknameChangedHandler OnNicknameChanged;

        public delegate void OnPickupHitHandler(Player source, OnPickupHitEventArgs eventArgs);
        public event OnPickupHitHandler OnPickupHit;

        public delegate void OnPickupLeaveHandler(Player source, OnPickupLeaveEventArgs eventArgs);
        public event OnPickupLeaveHandler OnPickupLeave;

        public delegate void OnQuitHandler(Player source, OnQuitEventArgs eventArgs);
        public event OnQuitHandler OnQuit;

        public delegate void OnSpawnHandler(Player source, OnSpawnEventArgs eventArgs);
        public event OnSpawnHandler OnSpawn;

        public delegate void OnVehicleEnterHandler(Player source, OnVehicleEnterEventArgs eventArgs);
        public event OnVehicleEnterHandler OnVehicleEnter;

        public delegate void OnVehicleExitHandler(Player source, OnVehicleExitEventArgs eventArgs);
        public event OnVehicleExitHandler OnVehicleExit;

        public delegate void OnVoicePausedHandler(Player source, OnVoicePausedEventArgs eventArgs);
        public event OnVoicePausedHandler OnVoicePaused;

        public delegate void OnVoiceResumedHandler(Player source, OnVoiceResumedEventArgs eventArgs);
        public event OnVoiceResumedHandler OnVoiceResumed;

        public delegate void OnVoiceStartHandler(Player source, OnVoiceStartEventArgs eventArgs);
        public event OnVoiceStartHandler OnVoiceStart;

        public delegate void OnVoiceStopHandler(Player source, OnVoiceStopEventArgs eventArgs);
        public event OnVoiceStopHandler OnVoiceStop;

        public delegate void OnWeaponSwitchHandler(Player source, OnWeaponSwitchEventArgs eventArgs);
        public event OnWeaponSwitchHandler OnWeaponSwitch;

        public delegate void OnChatMessageHandler(Player source, OnChatMessageEventArgs eventArgs);
        public event OnChatMessageHandler OnChatMessage;

        #pragma warning restore 67

        #endregion

    }
}
