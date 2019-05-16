using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client.Browsers
{
    /// <summary>
    /// The reason why the resource was blocked
    /// </summary>
    public enum BlockReason
    {
        NotAllowedYet,
        Blacklisted,
        BlockedProtocolScheme
    }
}
