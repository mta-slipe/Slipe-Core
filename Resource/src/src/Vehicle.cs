using MultiTheftAuto;
using src;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTAWrapper
{
    class Vehicle: Element
    {
        public Vehicle(VehicleModel model, Vector3 position, Vector3 rotation, string numberplate = "", int variant1 = 1, int variant2 = 1)
        {
            element = Server.CreateVehicle((int)model, position.x, position.y, position.z, rotation.x, rotation.y, rotation.z, numberplate, false, variant1, variant2);
        }
        public Vehicle(VehicleModel model, Vector3 position): this(model, position, new Vector3(0, 0, 0))
        {
        }
    }
}
