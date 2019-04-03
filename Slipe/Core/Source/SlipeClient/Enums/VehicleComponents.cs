using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client.Enums
{
    /// <summary>
    /// Represents different vehicle components
    /// </summary>
    public enum ComponentType
    {
        boot_dummy,
        ug_nitro,
        wheel_rf_dummy,
        wheel_lf_dummy,
        wheel_rb_dummy,
        wheel_lb_dummy,
        chassis,
        chassis_vlo,
        ug_roof,
        door_rf_dummy,
        door_lf_dummy,
        door_rr_dummy,
        door_lr_dummy,
        bonnet_dummy,
        ug_wing_right,
        bump_front_dummy,
        bump_rear_dummy,
        windscreen_dummy,
        ug_wing_left,
        exhaust_ok
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
