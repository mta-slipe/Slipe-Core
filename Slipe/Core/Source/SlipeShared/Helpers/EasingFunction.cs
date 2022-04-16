using System;
using System.Collections.Generic;
using System.Text;
using SlipeLua.MtaDefinitions;
using System.Numerics;

namespace SlipeLua.Shared.Helpers
{
    /// <summary>
    /// Represents an easing function
    /// </summary>
    public class EasingFunction
    {
        #region Properties
        /// <summary>
        /// The period of the easing function
        /// </summary>
        public float Period { get; set; }

        /// <summary>
        /// The amplitude of the easing function
        /// </summary>
        public float Amplitude { get; set; }

        /// <summary>
        /// The overshoot of the easing function
        /// </summary>
        public float Overshoot { get; set; }

        /// <summary>
        /// The name of this easing function
        /// </summary>
        public string Name { get; }

        #endregion

        #region Constructors

        private EasingFunction(string name)
        {
            Name = name;
            Period = 0;
            Amplitude = 0;
            Overshoot = 0;
        }

        /// <summary>
        /// Create a new easing function with different easing parameters
        /// </summary>
        /// <param name="function">The base easing function</param>
        /// <param name="period">The period of the function</param>
        /// <param name="amplitude">The amplitude of the function</param>
        /// <param name="overshoot">The overshoot of the function</param>
        public EasingFunction(EasingFunction function, float period = 0, float amplitude = 0, float overshoot = 0)
        {
            Name = function.Name;
            Period = period;
            Amplitude = amplitude;
            Overshoot = overshoot;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Get the easing value of a function at a specific moment
        /// </summary>
        /// <param name="progress">The progress between 0 and 1</param>
        /// <returns>The easing value at this moment in the function</returns>
        public float Interpolate(float progress)
        {
            return MtaShared.GetEasingValue(progress, Name, Period, Amplitude, Overshoot);
        }

        /// <summary>
        /// Get the easing value between two vectors
        /// </summary>
        /// <param name="start">The start vector</param>
        /// <param name="end">The end vector</param>
        /// <param name="progress">The progress between the two vectors</param>
        /// <returns>The interpolated vector between the given two</returns>
        public Vector3 InterpolateVector(Vector3 start, Vector3 end, float progress)
        {
            Tuple<float, float, float> r = MtaShared.InterpolateBetween(start.X, start.Y, start.Z, end.X, end.Y, end.Z, progress, Name, Period, Amplitude, Overshoot);
            return new Vector3(r.Item1, r.Item2, r.Item3);
        }

        /// <summary>
        /// Get the easing value between two vectors
        /// </summary>
        /// <param name="start">The start vector</param>
        /// <param name="end">The end vector</param>
        /// <param name="progress">The progress between the two vectors</param>
        /// <returns>The interpolated vector between the given two</returns>
        public Vector2 InterpolateVector(Vector2 start, Vector2 end, float progress)
        {
            Vector3 r = InterpolateVector(new Vector3(start, 0), new Vector3(end, 0), progress);
            return new Vector2(r.X, r.Y);
        }

        #endregion

        #region Statics

        public static EasingFunction Linear { get { return new EasingFunction("Linear"); } }
        public static EasingFunction InQuad { get { return new EasingFunction("InQuad"); } }
        public static EasingFunction OutQuad { get { return new EasingFunction("OutQuad"); } }
        public static EasingFunction InOutQuad { get { return new EasingFunction("InOutQuad"); } }
        public static EasingFunction OutInQuad { get { return new EasingFunction("OutInQuad"); } }
        public static EasingFunction InElastic { get { return new EasingFunction("InElastic"); } }
        public static EasingFunction OutElastic { get { return new EasingFunction("OutElastic"); } }
        public static EasingFunction InOutElastic { get { return new EasingFunction("InOutElastic"); } }
        public static EasingFunction OutInElastic { get { return new EasingFunction("OutInElastic"); } }
        public static EasingFunction InBack { get { return new EasingFunction("InBack"); } }
        public static EasingFunction OutBack { get { return new EasingFunction("OutBack"); } }
        public static EasingFunction InOutBack { get { return new EasingFunction("InOutBack"); } }
        public static EasingFunction OutInBack { get { return new EasingFunction("OutInBack"); } }
        public static EasingFunction InBounce { get { return new EasingFunction("InBounce"); } }
        public static EasingFunction OutBounce { get { return new EasingFunction("OutBounce"); } }
        public static EasingFunction InOutBounce { get { return new EasingFunction("InOutBounce"); } }
        public static EasingFunction OutInBounce { get { return new EasingFunction("OutInBounce"); } }
        public static EasingFunction SineCurve { get { return new EasingFunction("SineCurve"); } }
        public static EasingFunction CosineCurve { get { return new EasingFunction("CosineCurve"); } }

        #endregion
    }
}
