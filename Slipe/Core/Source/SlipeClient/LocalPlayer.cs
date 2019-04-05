using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MTADefinitions;
using Slipe.Shared.Enums;
using System.Numerics;

namespace Slipe.Client
{
    public class LocalPlayer : Player
    {
        private static LocalPlayer instance;

        /// <summary>
        /// Creates a local player class from an MTA player element
        /// </summary>
        public LocalPlayer(MTAElement mtaElement) : base(mtaElement)
        {
        }

        /// <summary>
        /// Returns the Local Player element
        /// </summary>
        public static LocalPlayer Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LocalPlayer(MTAClient.GetLocalPlayer());
                }
                return instance;
            }
        }

        /// <summary>
        /// Get and set if the player map forcefuly shows
        /// </summary>
        public bool ForceMap
        {
            get
            {
                return MTAClient.IsPlayerMapForced();
            }
            set
            {
                MTAClient.ForcePlayerMap(value);
            }
        }

        /// <summary>
        /// Get and set the motion blur level of the player
        /// </summary>
        public int BlurLevel
        {
            get
            {
                return MTAClient.GetPlayerBlurLevel();
            }
            set
            {
                MTAClient.SetPlayerBlurLevel(value);
            }
        }

        /// <summary>
        /// Get and set the money of the player
        /// </summary>
        public int Money
        {
            get
            {
                return MTAClient.GetPlayerMoney();
            }
            set
            {
                MTAClient.SetPlayerMoney(value, false);
            }
        }

        /// <summary>
        /// Get the wanted level of the player
        /// </summary>
        public int WantedLevel
        {
            get
            {
                return MTAClient.GetPlayerWantedLevel();
            }
        }

        /// <summary>
        /// Adds money to the player's money
        /// </summary>
        public bool GiveMoney(int amount)
        {
            return MTAClient.GivePlayerMoney(amount);
        }

        /// <summary>
        /// Set the visibility of a Hud component
        /// </summary>
        public bool SetHudComponentVisible(HudComponent component, bool visible)
        {
            return MTAClient.SetPlayerHudComponentVisible(component.ToString(), visible);
        }

        /// <summary>
        /// Check if a certain component is visible
        /// </summary>
        public bool IsHudComponentVisible(HudComponent component)
        {
            return MTAClient.IsPlayerHudComponentVisible(component.ToString());
        }

        /// <summary>
        /// Substract money from the player
        /// </summary>
        public bool TakeMoney(int amount)
        {
            return MTAClient.TakePlayerMoney(amount);
        }

        /// <summary>
        /// Get if the map is currently visible
        /// </summary>
        public bool IsMapVisible
        {
            get
            {
                return MTAClient.IsPlayerMapVisible();
            }
        }

        /// <summary>
        /// This function gets the GUI bounding box of the radar map texture.
        /// </summary>
        public Tuple<Vector2, Vector2> MapBoundingBox
        {
            get
            {
                Tuple<int, int, int, int> r = MTAClient.GetPlayerMapBoundingBox();
                return new Tuple<Vector2, Vector2>(new Vector2(r.Item1, r.Item2), new Vector2(r.Item3, r.Item4));
            }
        }

        /// <summary>
        /// Play an internal GTA sound
        /// </summary>
        public bool PlaySoundFrontEnd(FrontEndSound frontEndSound)
        {
            return MTAClient.PlaySoundFrontEnd((int)frontEndSound);
        }
    }
}
