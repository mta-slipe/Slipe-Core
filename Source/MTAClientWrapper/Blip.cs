using MTASharedWrapper;
using System;
using System.Collections.Generic;
using System.Text;
using MTASharedWrapper.Enums;
using MultiTheftAuto;
using System.Numerics;

namespace MTAClientWrapper
{
    public class Blip : SharedBlip
    {
        public Blip(Vector3 vector, BlipEnum icon, Color color, int size = 2, int ordering = 0, float visibleDistance = 16383.0f)
        {
            element = Client.CreateBlip(vector.X, vector.Y, vector.Z, (int)icon, size, color.R, color.G, color.B, color.A, ordering, visibleDistance);
            ElementManager.Instance.RegisterElement(this);
        }

        public Blip(Vector3 vector) : this(vector, 0, Color.Red)
        {

        }

        public Blip(PhysicalElement physicalElement, BlipEnum icon, Color color, int size = 2, int ordering = 0, float visibleDistance = 16383.0f)
        {
            element = Client.CreateBlipAttachedTo(physicalElement.MTAElement, (int)icon, size, color.R, color.G, color.B, color.A, ordering, visibleDistance);
            ElementManager.Instance.RegisterElement(this);
        }

        public Blip(PhysicalElement physicalElement) : this(physicalElement, 0, Color.Red)
        {

        }
    }
}
