using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client.Vehicles
{
    /// <summary>
    /// Represents different vehicle components
    /// </summary>
    public enum ComponentType
    {
        chassis,
        chassis_vlo,
        misc_a,
        misc_b,
        misc_c,
        misc_d,
        boot_dummy,
        bonnet_dummy,
        ug_nitro,
        ug_spoiler,
        ug_wing_left,
        ug_wing_right,
        exhaust_ok,
        bump_front_dummy,
        bump_rear_dummy,
        wheel_lb_dummy,
        wheel_rb_dummy,
        wheel_lf_dummy,
        wheel_rf_dummy,
        door_lb_dummy,
        door_rb_dummy,
        door_lf_dumm,
        door_rf_dummy,
        windscreen_dummy,
        plate_rear,
        plate_front,
        handlebars,
        mudguard,
        forks_front,
        forks_rear,
        wheel_front,
        wheel_rear,
    }

    /// <summary>
    /// Representing what the position is relative to 
    /// </summary>
    public enum ComponentBase
    {
        parent,
        root,
        world
    }
}
