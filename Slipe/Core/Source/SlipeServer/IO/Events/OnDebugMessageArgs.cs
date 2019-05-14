using Slipe.Shared.IO;
using Slipe.Shared.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Server.IO.Events
{
    public class OnDebugMessageArgs
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

        internal OnDebugMessageArgs(string message, DebugMessageLevel level, string file, int line, Color color)
        {
            Message = message;
            Level = level;
            File = file;
            Line = line;
            Color = color;
        }
    }
}
