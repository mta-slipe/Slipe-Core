using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MtaDefinitions;
using System.Numerics;
using Slipe.Shared.Peds;
using System.ComponentModel;
using Slipe.Shared.Weapons;
using Slipe.Client.Sounds;
using Slipe.Shared.Elements;

namespace Slipe.Client.Peds
{
    public class LocalPlayer : Player
    {
        private static LocalPlayer instance;

        /// <summary>
        /// Returns the Local Player element
        /// </summary>
        public static LocalPlayer Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LocalPlayer(MtaClient.GetLocalPlayer());
                }
                return instance;
            }
        }

        #region Properties

        /// <summary>
        /// Get and set if the player map forcefuly shows
        /// </summary>
        public bool ForceMap
        {
            get
            {
                return MtaClient.IsPlayerMapForced();
            }
            set
            {
                MtaClient.ForcePlayerMap(value);
            }
        }

        /// <summary>
        /// Get and set the motion blur level of the player
        /// </summary>
        public int BlurLevel
        {
            get
            {
                return MtaClient.GetPlayerBlurLevel();
            }
            set
            {
                MtaClient.SetPlayerBlurLevel(value);
            }
        }

        /// <summary>
        /// Get and set the money of the player
        /// </summary>
        public int Money
        {
            get
            {
                return MtaClient.GetPlayerMoney();
            }
            set
            {
                MtaClient.SetPlayerMoney(value, false);
            }
        }

        /// <summary>
        /// Get the wanted level of the player
        /// </summary>
        public int WantedLevel
        {
            get
            {
                return MtaClient.GetPlayerWantedLevel();
            }
        }

        /// <summary>
        /// Get if the map is currently visible
        /// </summary>
        public bool IsMapVisible
        {
            get
            {
                return MtaClient.IsPlayerMapVisible();
            }
        }

        /// <summary>
        /// This function gets the GUI bounding box of the radar map texture.
        /// </summary>
        public Tuple<Vector2, Vector2> MapBoundingBox
        {
            get
            {
                Tuple<int, int, int, int> r = MtaClient.GetPlayerMapBoundingBox();
                return new Tuple<Vector2, Vector2>(new Vector2(r.Item1, r.Item2), new Vector2(r.Item3, r.Item4));
            }
        }

        /// <summary>
        /// Get and set the radio channel that's playing on the client (even when not in a vehicle)
        /// </summary>
        public RadioStation ActiveRadioStation
        {
            get
            {
                return (RadioStation)MtaClient.GetRadioChannel();
            }
            set
            {
                MtaClient.SetRadioChannel((int)value);
            }
        }

        #endregion

        #region Constructor
        [EditorBrowsable(EditorBrowsableState.Never)]
        public LocalPlayer(MtaElement mtaElement) : base(mtaElement)
        {
        }
        #endregion

        #region Methods

        /// <summary>
        /// Detonate the satchels this player has laid
        /// </summary>
        public bool DetonateSatchels()
        {
            return MtaClient.DetonateSatchels();
        }

        /// <summary>
        /// Adds money to the player's money
        /// </summary>
        public bool GiveMoney(int amount)
        {
            return MtaClient.GivePlayerMoney(amount);
        }

        /// <summary>
        /// Set the visibility of a Hud component
        /// </summary>
        public bool SetHudComponentVisible(HudComponent component, bool visible)
        {
            return MtaClient.SetPlayerHudComponentVisible(component.ToString().ToLower(), visible);
        }

        /// <summary>
        /// Check if a certain component is visible
        /// </summary>
        public bool IsHudComponentVisible(HudComponent component)
        {
            return MtaClient.IsPlayerHudComponentVisible(component.ToString().ToLower());
        }

        /// <summary>
        /// Substract money from the player
        /// </summary>
        public bool TakeMoney(int amount)
        {
            return MtaClient.TakePlayerMoney(amount);
        }

        /// <summary>
        /// Play an internal GTA sound
        /// </summary>
        public bool PlaySoundFrontEnd(FrontEndSound frontEndSound)
        {
            return MtaClient.PlaySoundFrontEnd((int)frontEndSound);
        }

        #endregion

        #region Events

        #pragma warning disable 67

        public delegate void OnChokeHandler(SharedWeaponModel weaponModel, Ped responsiblePed);
        public event OnChokeHandler OnChoke;

        public delegate void OnRadioSwitchHandler(RadioStation newRadioStation);
        public event OnRadioSwitchHandler OnRadioSwitch;

        public delegate void OnStealthKillHandler(Ped victim);
        public event OnStealthKillHandler OnStealthKill;

        public delegate void OnStuntStartHandler(string stuntType);
        public event OnStuntStartHandler OnStuntStart;

        public delegate void OnStuntFinishHandler(string stuntType, int stuntTime, float stuntDistance);
        public event OnStuntFinishHandler OnStuntFinish;

        public delegate void OnTargetHandler(PhysicalElement target);
        public event OnTargetHandler OnTarget;

        public delegate void OnConsoleHandler(string text);
        public event OnConsoleHandler OnConsole;

        #pragma warning restore 67

        #endregion
    }
}
