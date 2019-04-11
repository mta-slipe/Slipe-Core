using Slipe.MtaDefinitions;
using Slipe.Shared.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Shared.IO
{
    public class SharedMtaDebug
    {
        protected internal SharedMtaDebug()
        {

        }

        public void WriteLine(string line, DebugMessageLevel level = DebugMessageLevel.Information)
        {
            MtaShared.OutputDebugString(line, (int) level, 255, 255, 255);
        }

        public void WriteLine(string line, Color color)
        {
            MtaShared.OutputDebugString(line, (int)DebugMessageLevel.Custom, color.R, color.G, color.B);
        }

        public void WriteLine(string line, DebugMessageLevel level, Color color)
        {
            MtaShared.OutputDebugString(line, (int)level, color.R, color.G, color.B);
        }
    }
}
