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

        public override void HandleEvent(string eventName, dynamic p1, dynamic p2, dynamic p3, dynamic p4, dynamic p5, dynamic p6, dynamic p7, dynamic p8)
        {
            switch (eventName)
            {
                case "onVehicleDamage":
                    OnDamage?.Invoke((float) p1);
                    break;
            }
        }

        public delegate void OnVehicleDamageHandler(float loss);
        public event OnVehicleDamageHandler OnDamage;
    }
}
