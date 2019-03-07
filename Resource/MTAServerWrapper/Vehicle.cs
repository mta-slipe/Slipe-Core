using MTASharedWrapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTAServerWrapper
{
    public class Vehicle : SharedVehicle
    {
        public Vehicle(VehicleModel model, Vector3 position) : base(model, position)
        {
        }

        public Vehicle(VehicleModel model, Vector3 position, Vector3 rotation, string numberplate = "", int variant1 = 1, int variant2 = 1) : base(model, position, rotation, numberplate, variant1, variant2)
        {
        }
    }
}
