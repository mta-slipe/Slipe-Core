﻿using Slipe.Shared;
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
        private static Player localPlayer;

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
                if(localPlayer == null)
                {
                    localPlayer = new Player(MTAClient.GetLocalPlayer());
                }
                return localPlayer;
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
