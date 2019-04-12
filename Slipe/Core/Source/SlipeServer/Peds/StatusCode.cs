using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.Peds
{
    /// <summary>
    /// Represents a status code for the player screenshot event
    /// </summary>
    public enum StatusCode
    {
        Ok,
        Disabled,
        Minimized
    }

    /// <summary>
    /// Represents a status code for the player network status event
    /// </summary>
    public enum NetworkInteruptionStatus
    {
        Begin,
        End
    }
}
