﻿using System;
using System.Collections.Generic;
using System.Text;
using SlipeLua.MtaDefinitions;
using System.Numerics;
using SlipeLua.Shared.Elements;
using SlipeLua.Shared.Utilities;
using SlipeLua.Shared.Radar;
using System.ComponentModel;

namespace SlipeLua.Server.Radar
{
    /// <summary>
    /// A class representing a blip on the minimap
    /// </summary>
    [DefaultElementClass(ElementType.Blip)]
    public class Blip : SharedBlip
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Blip(MtaElement element) : base(element) { }

        /// <summary>
        /// Creates a blip from all createBlip parameters
        /// </summary>
        public Blip(Vector3 vector, BlipType icon, Color color, int size = 2, int ordering = 0, float visibleDistance = 16383.0f, Element visibleTo = null)
            : this(MtaServer.CreateBlip(vector.X, vector.Y, vector.Z, (int)icon, size, color.R, color.G, color.B, color.A, ordering, visibleDistance, visibleTo?.MTAElement)) { }

        /// <summary>
        /// Creates a standard red blip
        /// </summary>
        public Blip(Vector3 vector) 
            : this(vector, 0, Color.Red) { }

        /// <summary>
        /// Creates a blip attached to an element in the world
        /// </summary>
        public Blip(PhysicalElement physicalElement, BlipType icon, Color color, int size = 2, int ordering = 0, float visibleDistance = 16383.0f, Element visibleTo = null)
            : this(MtaServer.CreateBlipAttachedTo(physicalElement.MTAElement, (int)icon, size, color.R, color.G, color.B, color.A, ordering, visibleDistance, visibleTo?.MTAElement)) { }

        /// <summary>
        /// Creates a red standard blip attached to an element in the world
        /// </summary>
        public Blip(PhysicalElement physicalElement) 
            : this(physicalElement, 0, Color.Red) { }
    }
}
