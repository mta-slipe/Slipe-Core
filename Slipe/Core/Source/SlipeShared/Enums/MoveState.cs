using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Shared.Enums
{
    /// <summary>
    /// Represents a move state of a ped
    /// </summary>
    public enum MoveState
    {
        stand,
        walk,
        powerwalk,
        jog,
        sprint,
        crouch,
        crawl,
        jump,
        fall,
        climb
    }
}
