using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Client.Rendering
{
    /// <summary>
    /// Represents Dx draw blendmodes
    /// </summary>
    public enum BlendMode
    {
        blend,
        add,
        modulate_add,
        overwrite
    }

    /// <summary>
    /// Represents dx testmodes to simulate different memory states
    /// </summary>
    public enum TestMode
    {
        none,
        no_mem,
        low_mem,
        no_shader
    }
}
