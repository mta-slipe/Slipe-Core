using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MtaDefinitions;
using System.Numerics;
using Slipe.Shared.Elements;
using Slipe.Shared.Utilities;
using Slipe.Shared.Radar;
using System.ComponentModel;

namespace Slipe.Client.Radar
{
    /// <summary>
    /// Class representing a minimap blip
    /// </summary>
    public class Blip : SharedBlip
    {

        [EditorBrowsable(EditorBrowsableState.Never)]
        public Blip(MtaElement element) : base(element) { }

        /// <summary>
        /// Creates a blip from all the createBlip parameters
        /// </summary>
        public Blip(Vector3 vector, BlipType icon, Color color, int size = 2, int ordering = 0, float visibleDistance = 16383.0f)
            : this(MtaClient.CreateBlip(vector.X, vector.Y, vector.Z, (int)icon, size, color.R, color.G, color.B, color.A, ordering, visibleDistance)) { }

        /// <summary>
        /// Creates a standard red blip
        /// </summary>
        public Blip(Vector3 vector) 
            : this(vector, 0, Color.Red) { }

        /// <summary>
        /// Creates a blip attached to an MTA element
        /// </summary>
        public Blip(PhysicalElement physicalElement, BlipType icon, Color color, int size = 2, int ordering = 0, float visibleDistance = 16383.0f)
            : this(MtaClient.CreateBlipAttachedTo(physicalElement.MTAElement, (int)icon, size, color.R, color.G, color.B, color.A, ordering, visibleDistance)) { }

        /// <summary>
        /// Creates a standard red blip attached to an  MTA element
        /// </summary>
        public Blip(PhysicalElement physicalElement) 
            : this(physicalElement, 0, Color.Red) { }
    }
}
