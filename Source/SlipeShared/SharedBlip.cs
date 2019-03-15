using Slipe.MTADefinitions;
using System;
using System.Collections.Generic;
using System.Text;
using Slipe.Shared.Enums;

namespace Slipe.Shared
{
    public class SharedBlip : PhysicalElement
    {
        protected SharedBlip() { }

        public SharedBlip(MTAElement element) : base(element) { }

        public Color Color
        {
            get
            {
                Tuple<int, int, int, int> tuple = MTAShared.GetBlipColor(element);
                return new Color((byte)tuple.Item1, (byte)tuple.Item2, (byte)tuple.Item3, (byte)tuple.Item4);
            }
            set
            {
                MTAShared.SetBlipColor(element, value.R, value.G, value.B, value.A);
            }
        }

        public BlipEnum Icon
        {
            get
            {
                return (BlipEnum) MTAShared.GetBlipIcon(element);
            }
            set
            {
                MTAShared.SetBlipIcon(element, (int) value);
            }
        }

        public int Ordering
        {
            get
            {
                return MTAShared.GetBlipOrdering(element);
            }
            set
            {
                MTAShared.SetBlipOrdering(element, value);
            }
        }

        public int Size
        {
            get
            {
                return MTAShared.GetBlipSize(element);
            }
            set
            {
                MTAShared.SetBlipSize(element, value);
            }
        }

        public float VisibleDistance
        {
            get
            {
                return MTAShared.GetBlipVisibleDistance(element);
            }
            set
            {
                MTAShared.SetBlipVisibleDistance(element, value);
            }
        }


    }
}
