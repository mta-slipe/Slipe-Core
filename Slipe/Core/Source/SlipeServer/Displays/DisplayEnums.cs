using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.Displays
{
    /// <summary>
    /// Represents the priority at which a display should be updates
    /// </summary>
    public enum Priority
    {
        Low,
        Medium,
        High
    }

    /// <summary>
    /// Represents the horizontal alignment
    /// </summary>
    public enum HorizontalAlignment
    {
        Left,
        Center,
        Right
    }

    /// <summary>
    /// Represents the vertical alignment
    /// </summary>
    public enum VerticalAlignment
    {
        Top,
        Center,
        Bottom
    }
}
