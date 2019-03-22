using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MTADefinitions;
using Slipe.Shared;
using System.Numerics;

namespace Slipe.Client
{
    /// <summary>
    /// This function creates a searchlight. A searchlight is a spotlight which looks like the one available in the Police Maverick.
    /// </summary>
    public class SearchLight : PhysicalElement
    {
        /// <summary>
        /// Create a searchlight from an existing MTA searchlight element
        /// </summary>
        public SearchLight(MTAElement element) : base(element) { }

        /// <summary>
        /// Create a searchlight from all parameters
        /// </summary>
        public SearchLight(Vector3 start, Vector3 end, float startRadius, float endRadius, bool renderSpot = true)
        {
            element = MTAClient.CreateSearchLight(start.X, start.Y, start.Z, end.X, end.Y, end.Z, startRadius, endRadius, renderSpot);
            ElementManager.Instance.RegisterElement(this);
        }

        /// <summary>
        /// Get and set the start position of this searchlight
        /// </summary>
        public Vector3 StartPosition
        {
            get
            {
                Tuple<float, float, float> result = MTAClient.GetSearchLightStartPosition(element);
                return new Vector3(result.Item1, result.Item2, result.Item3);
            }
            set
            {
                MTAClient.SetSearchLightStartPosition(element, value.X, value.Y, value.Z);
            }
        }

        /// <summary>
        /// Get and set the end position of this searchlight
        /// </summary>
        public Vector3 EndPosition
        {
            get
            {
                Tuple<float, float, float> result = MTAClient.GetSearchLightEndPosition(element);
                return new Vector3(result.Item1, result.Item2, result.Item3);
            }
            set
            {
                MTAClient.SetSearchLightEndPosition(element, value.X, value.Y, value.Z);
            }
        }

        /// <summary>
        /// Gets and sets the start radius of a searchlight element.
        /// </summary>
        public float StartRadius
        {
            get
            {
                return MTAClient.GetSearchLightStartRadius(element);
            }
            set
            {
                MTAClient.SetSearchLightStartRadius(element, value);
            }
        }

        /// <summary>
        /// Gets and sets the end radius of a searchlight element.
        /// </summary>
        public float EndRadius
        {
            get
            {
                return MTAClient.GetSearchLightEndRadius(element);
            }
            set
            {
                MTAClient.SetSearchLightEndRadius(element, value);
            }
        }
    }
}
