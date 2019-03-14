using MultiTheftAuto;
using System;
using System.Collections.Generic;
using System.Text;
using MTASharedWrapper.Enums;

namespace MTASharedWrapper
{
    public class SharedBlip : PhysicalElement
    {
        protected SharedBlip() { }

        public SharedBlip(MTAElement element) : base(element) { }

        public Color Color
        {
            get
            {
                Tuple<int, int, int, int> tuple = Shared.GetBlipColor(element);
                return new Color((byte)tuple.Item1, (byte)tuple.Item2, (byte)tuple.Item3, (byte)tuple.Item4);
            }
            set
            {
                Shared.SetBlipColor(element, value.R, value.G, value.B, value.A);
            }
        }

        public BlipEnum Icon
        {
            get
            {
                return (BlipEnum) Shared.GetBlipIcon(element);
            }
            set
            {
                Shared.SetBlipIcon(element, (int) value);
            }
        }

        public int Ordering
        {
            get
            {
                return Shared.GetBlipOrdering(element);
            }
            set
            {
                Shared.SetBlipOrdering(element, value);
            }
        }

        public int Size
        {
            get
            {
                return Shared.GetBlipSize(element);
            }
            set
            {
                Shared.SetBlipSize(element, value);
            }
        }

        public float VisibleDistance
        {
            get
            {
                return Shared.GetBlipVisibleDistance(element);
            }
            set
            {
                Shared.SetBlipVisibleDistance(element, value);
            }
        }


    }
}
