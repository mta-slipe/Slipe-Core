using MultiTheftAuto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTASharedWrapper
{
    public class SharedVehicle: SharedElement
    {
        public SharedVehicle(VehicleModel model, Vector3 position, Vector3 rotation, string numberplate = "", int variant1 = 1, int variant2 = 1)
        {
            element = Shared.CreateVehicle((int)model, position.x, position.y, position.z, rotation.x, rotation.y, rotation.z, numberplate, false, variant1, variant2);
        }
        public SharedVehicle(VehicleModel model, Vector3 position): this(model, position, new Vector3(0, 0, 0))
        {
        }
    }
}
