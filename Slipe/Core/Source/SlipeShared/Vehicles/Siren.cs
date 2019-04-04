using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using Slipe.MTADefinitions;

namespace Slipe.Shared.Vehicles
{
    /// <summary>
    /// Represents a single siren point
    /// </summary>
    public class Siren
    {
        private SharedVehicle vehicle;
        private int point;

        #region Properties
        private Vector3 position;
        /// <summary>
        /// Set the relative position of this siren from the center of the vehicle
        /// </summary>
        public Vector3 Position
        {
            get
            {
                return position;
            }
            set
            {
                position = value;
                UpdateThisSiren();
            }
        }

        private Color color;
        /// <summary>
        /// Set the color of this siren, including alpha
        /// </summary>
        public Color Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
                UpdateThisSiren();
            }
        }

        private float minAlpha;
        /// <summary>
        /// The minimum alpha of the light during day time
        /// </summary>
        public float MinimalAlpha
        {
            get
            {
                return minAlpha;
            }
            set
            {
                minAlpha = value;
                UpdateThisSiren();
            }
        }
        #endregion

        /// <summary>
        /// Build a vehicle siren
        /// </summary>
        public Siren(SharedVehicle vehicle, int point, Vector3 position, Color color, float minAlpha = 0.0f, bool updateOnConstruct = true)
        {
            this.vehicle = vehicle;
            this.point = point;
            this.position = position;
            this.color = color;
            this.minAlpha = minAlpha;

            if(updateOnConstruct)
                UpdateThisSiren();
        }

        protected void UpdateThisSiren()
        {
            MTAShared.SetVehicleSirens(vehicle.MTAElement, point, position.X, position.Y, position.Z, color.R, color.G, color.B, color.A, minAlpha);
        }  
    }
}
