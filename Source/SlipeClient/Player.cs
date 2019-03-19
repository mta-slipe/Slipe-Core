using Slipe.Shared;
using Slipe.MTADefinitions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client
{
    /// <summary>
    /// Class of MTA player elements
    /// </summary>
    public class Player : SharedPlayer
    {
        /// <summary>
        /// Get the team of a player
        /// </summary>
        public Team Team
        {
            get
            {
                MTAElement mtaTeam = MTAShared.GetPlayerTeam(element);
                return (Team) ElementManager.Instance.GetElement(mtaTeam);
            }
        }

        /// <summary>
        /// Returns the Local Player element
        /// </summary>
        public static Player Local
        {
            get
            {
                return new Player(MTAClient.GetLocalPlayer());
            }
        }

        /// <summary>
        /// Creates a player class from an MTA player element
        /// </summary>
        public Player(MTAElement mtaElement) : base(mtaElement)
        {
        }
    }
}
