using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MtaDefinitions;
using System.Numerics;
using Slipe.Shared.Elements;
using Slipe.Shared.Helpers;
using System.ComponentModel;
using Slipe.Client.GameClient;

namespace Slipe.Client.Lights
{
    /// <summary>
    /// This function creates a searchlight. A searchlight is a spotlight which looks like the one available in the Police Maverick.
    /// </summary>
    public class SearchLight : Element
    {
        protected PhysicalElement toAttached;
        protected Vector3 relativeEndPosition;

        #region Properties

        /// <summary>
        /// A matrix describing the offset with which this attachable is attached
        /// </summary>
        public Matrix4x4 Offset { get; set; }

        /// <summary>
        /// Get the physical element to which this attachable is attached
        /// </summary>
        public PhysicalElement ToAttached
        {
            get
            {
                return toAttached;
            }
        }

        /// <summary>
        /// Get if this attachable is attached to a ToAttachable
        /// </summary>
        public bool IsAttached
        {
            get
            {
                return toAttached != null;
            }
        }

        /// <summary>
        /// Get and set the start position of this searchlight
        /// </summary>
        public Vector3 StartPosition
        {
            get
            {
                Tuple<float, float, float> result = MtaClient.GetSearchLightStartPosition(element);
                return new Vector3(result.Item1, result.Item2, result.Item3);
            }
            set
            {
                MtaClient.SetSearchLightStartPosition(element, value.X, value.Y, value.Z);
            }
        }

        /// <summary>
        /// Get and set the end position of this searchlight
        /// </summary>
        public Vector3 EndPosition
        {
            get
            {
                Tuple<float, float, float> result = MtaClient.GetSearchLightEndPosition(element);
                return new Vector3(result.Item1, result.Item2, result.Item3);
            }
            set
            {
                MtaClient.SetSearchLightEndPosition(element, value.X, value.Y, value.Z);
            }
        }

        /// <summary>
        /// Gets and sets the start radius of a searchlight element.
        /// </summary>
        public float StartRadius
        {
            get
            {
                return MtaClient.GetSearchLightStartRadius(element);
            }
            set
            {
                MtaClient.SetSearchLightStartRadius(element, value);
            }
        }

        /// <summary>
        /// Gets and sets the end radius of a searchlight element.
        /// </summary>
        public float EndRadius
        {
            get
            {
                return MtaClient.GetSearchLightEndRadius(element);
            }
            set
            {
                MtaClient.SetSearchLightEndRadius(element, value);
            }
        }

        #endregion

        #region Constructors

        [EditorBrowsable(EditorBrowsableState.Never)]
        public SearchLight(MtaElement element) : base(element) { }

        /// <summary>
        /// Create a searchlight from all parameters
        /// </summary>
        public SearchLight(Vector3 start, Vector3 end, float startRadius, float endRadius, bool renderSpot = true)
            : this(MtaClient.CreateSearchLight(start.X, start.Y, start.Z, end.X, end.Y, end.Z, startRadius, endRadius, renderSpot))
        {
            relativeEndPosition = end - start;
        }

        /// <summary>
        /// Create a searchlight attached to an element
        /// </summary>
        public SearchLight(PhysicalElement attachTo, Vector3 relativeEnd, Matrix4x4 offset, float startRadius, float endRadius, bool renderSpot = true) : this(Vector3.Zero, relativeEnd, startRadius, endRadius, renderSpot)
        {
            AttachTo(attachTo, offset);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Attach this attachable to a toAttachable using a matrix to describe the positional and rotational offset
        /// </summary>
        public void AttachTo(PhysicalElement toElement, Matrix4x4 offsetMatrix)
        {
            toAttached = toElement;
            Offset = offsetMatrix;
            Process.OnUpdate += Update;
        }

        /// <summary>
        /// Attach this attachable to a toAttachable with 2 vectors describing a position offset and a rotation offset
        /// </summary>
        public void AttachTo(PhysicalElement toElement, Vector3 positionOffset, Vector3 rotationOffset)
        {
            AttachTo(toElement, positionOffset, NumericHelper.EulerToQuaternion(rotationOffset));
        }

        /// <summary>
        /// Attach this attachable to a toAttachable with a vector describing the position offset and a quaternion describing the rotation offset
        /// </summary>
        public void AttachTo(PhysicalElement toElement, Vector3 positionOffset, Quaternion rotationOffset)
        {
            AttachTo(toElement, Matrix4x4.Transform(Matrix4x4.CreateTranslation(positionOffset), rotationOffset));
        }

        /// <summary>
        /// Attach this attachable to a toAttachable without any offset
        /// </summary>
        public void AttachTo(PhysicalElement toElement)
        {
            AttachTo(toElement, Matrix4x4.Identity);
        }

        /// <summary>
        /// Detach this attachable
        /// </summary>
        public void Detach()
        {
            Process.OnUpdate -= Update;
        }

        /// <summary>
        /// Updates this element to the correct position and rotation
        /// </summary>
        protected void Update(float timeSlice)
        {
            StartPosition = ToAttached.Position + Offset.Translation;
            EndPosition = Vector3.Transform(relativeEndPosition, ToAttached.Matrix * Offset);
        }

        #endregion
    }
}
