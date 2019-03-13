using MTASharedWrapper.Enums;
using MultiTheftAuto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace MTASharedWrapper
{
    public class SharedVehicle: PhysicalElement
    {
    
        public SharedVehicle(MTAElement element): base(element)
        {

        }

        public SharedVehicle(VehicleModel model, Vector3 position, Vector3 rotation, string numberplate = "", int variant1 = 1, int variant2 = 1)
        {
            element = Shared.CreateVehicle((int)model, position.X, position.Y, position.Z, rotation.X, rotation.Y, rotation.Z, numberplate, false, variant1, variant2);
            ElementManager.Instance.RegisterElement(this);
        }
        public SharedVehicle(VehicleModel model, Vector3 position): this(model, position, new Vector3(0, 0, 0))
        {
        }
    }
}
