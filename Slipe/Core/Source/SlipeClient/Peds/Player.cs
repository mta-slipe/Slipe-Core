using Slipe.MtaDefinitions;
using System;
using System.Collections.Generic;
using System.Text;
using Slipe.Shared.Exceptions;
using Slipe.Client.Sounds;
using Slipe.Shared.Elements;
using Slipe.Shared.Utilities;
using Slipe.Client.GameServer;
using System.ComponentModel;

namespace Slipe.Client.Peds
{
    /// <summary>
    /// Class of MTA player elements
    /// </summary>
    public class Player : Ped
    {
        private static LocalPlayer localPlayer;

        #region Properties

        /// <summary>
        /// Get the team of a player
        /// </summary>
        public Team Team
        {
            get
            {
                return (Team)ElementManager.Instance.GetElement(MtaShared.GetPlayerTeam(element));
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
        public Player(MtaElement mtaElement) : base(mtaElement)
        {
        }

        #endregion

        #region Static Methods

        /// <summary>
        /// Retrieves a player class instance from a specified player name 
        /// </summary>
        public static Player GetFromName(string name)
        {
            try
            {
                return (Player)ElementManager.Instance.GetElement(MtaShared.GetPlayerFromName(name));
            }
            catch (MtaException)
            {
                throw new NullElementException("No player with the name " + name + " could be found.");
            }
        }

        #endregion

    }
}
