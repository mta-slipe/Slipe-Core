using Slipe.MTADefinitions;
using System;
using System.Collections.Generic;
using System.Text;
using Slipe.Shared.Exceptions;
using Slipe.Client.Sounds;
using Slipe.Shared.Elements;
using Slipe.Shared.Utilities;

namespace Slipe.Client
{
    /// <summary>
    /// Class of MTA player elements
    /// </summary>
    public class Player : Ped
    {
        private static LocalPlayer localPlayer;

        /// <summary>
        /// Get the team of a player
        /// </summary>
        public Team Team
        {
            get
            {
                return (Team) ElementManager.Instance.GetElement(MTAShared.GetPlayerTeam(element));
            }
        }

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

        /// <summary>
        /// Creates a player class from an MTA player element
        /// </summary>
        public Player(MTAElement mtaElement) : base(mtaElement)
        {
        }

        /// <summary>
        /// Gets the name of the player
        /// </summary>
        public string Name
        {
            get
            {
                return MTAShared.GetPlayerName(element);
            }
        }

        /// <summary>
        /// Retrieves a player class instance from a specified player name 
        /// </summary>
        public static Player GetFromName(string name)
        {
            try
            {
                return (Player)ElementManager.Instance.GetElement(MTAShared.GetPlayerFromName(name));
            }
            catch (MTAException)
            {
                throw new NullElementException("No player with the name " + name + " could be found.");
            }
        }

        /// <summary>
        /// Get and set the color of the player's nametag
        /// </summary>
        public Color NametagColor
        {
            get
            {
                Tuple<int, int, int> r = MTAShared.GetPlayerNametagColor(element);
                return new Color((byte)r.Item1, (byte)r.Item2, (byte)r.Item3);
            }
            set
            {
                MTAShared.SetPlayerNametagColor(element, value.R, value.G, value.B);
            }
        }

        /// <summary>
        /// This will change the text of a player's nickname in the world to something besides the nickname he chose. This will not change the player's actual nickname, it only changes the visible aspect inside the world
        /// </summary>
        public string NametagText
        {
            get
            {
                return MTAShared.GetPlayerNametagText(element);
            }
            set
            {
                MTAShared.SetPlayerNametagText(element, value);
            }
        }

        /// <summary>
        /// Get and set wether the nametag is visible
        /// </summary>
        public bool NametagShowing
        {
            get
            {
                return MTAShared.IsPlayerNametagShowing(element);
            }
            set
            {
                MTAShared.SetPlayerNametagShowing(element, value);
            }
        }

        /// <summary>
        /// Get the ping in milliseconds
        /// </summary>
        public int Ping
        {
            get
            {
                return MTAShared.GetPlayerPing(element);
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

    }
}
