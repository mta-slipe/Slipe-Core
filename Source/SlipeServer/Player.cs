using Slipe.Shared;
using Slipe.MTADefinitions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace Slipe.Server
{
    /// <summary>
    /// Class for a player in the MTA server
    /// </summary>
    public class Player : SharedPlayer
    {
        /// <summary>
        /// Creates a player from an MTA player element
        /// </summary>
        public Player(MTAElement mtaElement) : base(mtaElement)
        {
            Camera = new Camera(this);
        }

        /// <summary>
        /// Get the camera of the player
        /// </summary>
        public Camera Camera { get; }

        /// <summary>
        /// Get and set the wanted level of the player
        /// </summary>
        public int WantedLevel
        {
            get
            {
                return MTAServer.GetPlayerWantedLevel(element);
            }
            set
            {
                MTAServer.SetPlayerWantedLevel(element, value);
            }
        }

        /// <summary>
        /// Get and set the name of the player
        /// </summary>
        public override string Name
        {
            get
            {
                return MTAShared.GetPlayerName(element);
            }
            set
            {
                MTAServer.SetPlayerName(element, value);
            }
        }

        /// <summary>
        /// Get and set the team of the player
        /// </summary>
        public Team Team
        {
            get
            {
                MTAElement mtaTeam = MTAShared.GetPlayerTeam(element);
                return (Team)ElementManager.Instance.GetElement(mtaTeam);
            }
            set
            {
                MTAServer.SetPlayerTeam(MTAElement, value.MTAElement);
            }
        }

        /// <summary>
        /// Spawn the player at a certain position
        /// </summary>
        public void Spawn(Vector3 position, int rotation = 0, int skin = 0, int interior = 0, int dimension = 0, Team team = null)
        {
            MTAServer.SpawnPlayer(element, position.X, position.Y, position.Z, rotation, skin, interior, dimension, team == null ? null : team.MTAElement);
        }
    }
}
