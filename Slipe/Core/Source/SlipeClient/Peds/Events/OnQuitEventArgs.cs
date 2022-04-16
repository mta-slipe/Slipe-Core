using SlipeLua.MtaDefinitions;
using SlipeLua.Shared.Elements;
using SlipeLua.Shared.Peds;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Client.Peds.Events
{
    public class OnQuitEventArgs
    {
        /// <summary>
        /// How the player left.
        /// </summary>
        public QuitType QuitType { get; }

        internal OnQuitEventArgs(dynamic quitType)
        {
            QuitType = (QuitType)Enum.Parse(typeof(QuitType), (string)quitType);
        }
    }
}
