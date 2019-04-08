using Slipe.MtaDefinitions;
using System;
using System.Collections.Generic;
using System.Text;
using Slipe.Shared.Elements;
using Slipe.Shared.Utilities;
using System.ComponentModel;

namespace Slipe.Shared.Radar
{
    /// <summary>
    /// Class representing a minimap blip
    /// </summary>
    public class SharedBlip : PhysicalElement
    {
        #region Properties

        /// <summary>
        /// Gets and sets the color of the blip
        /// </summary>
        public Color Color
        {
            get
            {
                Tuple<int, int, int, int> tuple = MtaShared.GetBlipColor(element);
                return new Color((byte)tuple.Item1, (byte)tuple.Item2, (byte)tuple.Item3, (byte)tuple.Item4);
            }
            set
            {
                MtaShared.SetBlipColor(element, value.R, value.G, value.B, value.A);
            }
        }

        /// <summary>
        /// Gets and sets the icon of the blip
        /// </summary>
        public BlipType Icon
        {
            get
            {
                return (BlipType)MtaShared.GetBlipIcon(element);
            }
            set
            {
                MtaShared.SetBlipIcon(element, (int)value);
            }
        }

        /// <summary>
        /// Gets and sets the ordering of the blip, higher values are stacked on top of lower values
        /// </summary>
        public int Ordering
        {
            get
            {
                return MtaShared.GetBlipOrdering(element);
            }
            set
            {
                MtaShared.SetBlipOrdering(element, value);
            }
        }

        /// <summary>
        /// Gets or sets the size of the blip. Default is 2. Maximum is 25
        /// </summary>
        public int Size
        {
            get
            {
                return MtaShared.GetBlipSize(element);
            }
            set
            {
                MtaShared.SetBlipSize(element, value);
            }
        }

        /// <summary>
        /// Gets or sets the distance up to which this blip is visible for visible elements
        /// </summary>
        public float VisibleDistance
        {
            get
            {
                return MtaShared.GetBlipVisibleDistance(element);
            }
            set
            {
                MtaShared.SetBlipVisibleDistance(element, value);
            }
        }

        #endregion

        #region Constructors

        protected SharedBlip() { }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public SharedBlip(MtaElement element) : base(element) { }

        #endregion

    }
}
