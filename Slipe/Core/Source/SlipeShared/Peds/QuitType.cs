using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Shared.Peds
{
    /// <summary>
    /// Represents the type with which the player quit
    /// </summary>
    public enum QuitType
    {
        Unknown,
        Quit,
        Kicked,
        Banned,
        Bad_Connection,
        Timed_Out
    }
}
