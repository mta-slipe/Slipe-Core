using Slipe.Shared.IO;
using Slipe.Shared.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.IO.Events
{
    public class OnDebugMessageEventArgs
    {
        /// <summary>
        /// The content of the debug message
        /// </summary>
        public string Message { get; }

        /// <summary>
        /// The level
        /// </summary>
        public DebugMessageLevel Level { get; }

        /// <summary>
        /// The file this message was thrown in
        /// </summary>
        public string File { get; }

        /// <summary>
        /// The line number of this message
        /// </summary>
        public int Line { get; }

        /// <summary>
        /// The color that this message is cast to
        /// </summary>
        public Color Color { get; }

        internal OnDebugMessageEventArgs(dynamic message, dynamic level, dynamic file, dynamic line, dynamic r, dynamic g, dynamic b)
        {
            Message = (string) message;
            Level = (DebugMessageLevel) level;
            File = (string) file;
            Line = (int) line;
            Color = new Color((byte)r, (byte)g, (byte)b);
        }
    }
}
