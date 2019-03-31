using Slipe.MTADefinitions;
using System;
using Slipe.Shared.Exceptions;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Shared
{
    /// <summary>
    /// Class representing a player on the server and the player ped
    /// </summary>
    public class SharedPlayer: SharedPed
    {
        /// <summary>
        /// Creates or retrieves a player from an MTA player element
        /// </summary>
        public SharedPlayer(MTAElement mtaElement) : base(mtaElement)
        {
        }

        /// <summary>
        /// Gets the name of the player
        /// </summary>
        public virtual string Name
        {
            get
            {
                return MTAShared.GetPlayerName(element);
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Retrieves a player class instance from a specified player name 
        /// </summary>
        public static SharedPlayer GetFromName(string name)
        {
            try
            {
                MTAElement mtaElement = MTAShared.GetPlayerFromName(name);
                return (SharedPlayer)ElementManager.Instance.GetElement(mtaElement);
            } catch (MTAException)
            {
                throw new NullElementException("No player with the name " + name + " could be found.");
            }
        }
    }
}
