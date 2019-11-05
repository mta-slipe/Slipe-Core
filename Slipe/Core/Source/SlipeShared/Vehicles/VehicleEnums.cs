using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Shared.Vehicles
{
    /// <summary>
    /// Represents different doors of vehicles
    /// </summary>
    public enum Door
    {
        Hood,
        Trunk,
        FrontLeft,
        FrontRight,
        RearLeft,
        RearRight
    }

    /// <summary>
    /// Represents different damage states a door can be in
    /// </summary>
    public enum DoorState
    {
        ShutIntact,
        AjarIntact,
        ShutDamaged,
        AjarDamaged,
        Missing
    }

    /// <summary>
    /// Represents the positions of vehicle lights
    /// </summary>
    public enum Light
    {
        FrontLeft,
        FrontRight,
        RearRight,
        RearLeft
    }

    /// <summary>
    /// Represents the working state of vehicle lights
    /// </summary>
    public enum LightState
    {
        Working,
        Broken
    }

    /// <summary>
    /// Representing the state of vehicle lights
    /// </summary>
    public enum OverrideLightState
    {
        Default,
        ForcedOff,
        ForcedOn,
    }

    /// <summary>
    /// Represents the paintjob on a vehicle
    /// </summary>
    public enum Paintjob
    {
        First,
        Second,
        Third,
        Default
    }

    /// <summary>
    /// Represents damagable panels on vehicles
    /// </summary>
    public enum Panel
    {
        FrontLeft,
        FrontRight,
        RearLeft,
        RearRight,
        Windscreen,
        FrontBumper,
        RearBumper
    }

    /// <summary>
    /// Represents damagable plane parts
    /// </summary>
    public enum PlanePanel
    {
        EngineSmokeLeft,
        EngineSmokeRight,
        Rudder,
        Elevators,
        Ailerons
    }

    /// <summary>
    /// Represents damage to a vehicle panel
    /// </summary>
    public enum DamageLevel
    {
        Undamaged,
        SlightlyDamaged,
        Damaged,
        VeryDamaged
    }

    /// <summary>
    /// Represents different types of sirens
    /// </summary>
    public enum SirenType
    {
        invisible = 1,
        single = 2,
        dual = 3,
        triple = 4,
        quadruple = 5,
        max = 6
    }

    /// <summary>
    /// Representing the state of vehicle wheels
    /// </summary>
    public enum WheelState
    {
        Inflated,
        Flat,
        FallenOff,
        Collisionless
    }

    /// <summary>
    /// Represents a vehicle wheel
    /// </summary>
    public enum Wheel
    {
        FrontLeft,
        RearLeft,
        FrontRight,
        RearRight
    }

    /// <summary>
    /// Represents a vehicle window
    /// </summary>
    public enum Window
    {
        MotorbikeShield,
        RearWindow,
        RightFrontWindow,
        RightBackWindow,
        LeftFrontWindow,
        LeftBackWindow,
        WindShield
    }

    /// <summary>
    /// Represents different vehicle seats
    /// </summary>
    public enum Seat
    {
        FrontLeft,
        FrontRight,
        RearLeft,
        RearRight,
        None
    }

    /// <summary>
    /// Represents a vehicle part
    /// </summary>
    public enum Part
    {
        Frame,
        Trunk = 2,
        Hood,
        Rear,
        FrontLeftDoor,
        FrontRightDoor,
        RearLeftDoor,
        RearRightDoor,
        FrontLeftTyre = 13,
        FrontRightTyre,
        BackLeftTyre,
        BackRightTyre
    }

    /// <summary>
    /// Represents different upgrades that can be made to vehicles
    /// </summary>
    public enum Upgrade
    {
        spl_b_mar_m = 1000,
        spl_b_bab_m,
        spl_b_bar_m,
        spl_b_mab_m,
        bnt_b_sc_m,
        bnt_b_sc_l,
        rf_b_sc_r,
        wg_l_b_ssk,
        nto_b_l,
        nto_b_s,
        nto_b_tw,
        bnt_b_sc_p_m,
        bnt_b_sc_p_l,
        lgt_b_rspt,
        spl_b_bar_l,
        spl_b_bbr_l,
        spl_b_bbr_m,
        wg_r_b_ssk,
        exh_b_ts,
        exh_b_t,
        exh_b_l,
        exh_b_m,
        exh_b_s,
        spl_b_bbb_m,
        lgt_b_sspt,
        wheel_or1,
        wg_l_a_s,
        wg_r_a_s,
        exh_a_s,
        exh_c_s,
        wg_r_c_s,
        wg_l_c_s,
        rf_a_s,
        rf_c_s,
        exh_a_l,
        rf_c_l,
        wg_l_a_l,
        exh_c_l,
        rf_a_l,
        wg_l_c_l,
        wg_r_a_l,
        wg_r_c_l,
        wg_l_lr_br1,
        exh_lr_br2,
        exh_lr_br1,
        exh_c_f,
        exh_a_f,
        wg_l_a_f,
        wg_l_c_f,
        spl_a_f_r,
        spl_c_f_r,
        wg_r_a_f,
        wg_r_c_f,
        rf_c_f,
        rf_a_f,
        rf_a_st,
        wg_l_a_st,
        wg_l_c_st,
        spl_a_st_r,
        exh_c_st,
        spl_c_st_r,
        rf_c_st,
        wg_r_a_st,
        wg_r_c_st,
        exh_a_st,
        exh_a_j,
        exh_c_j,
        rf_a_j,
        rf_c_j,
        wg_l_a_j,
        wg_l_c_j,
        wg_r_a_j,
        wg_r_c_j,
        wheel_sr6,
        wheel_sr3,
        wheel_sr2,
        wheel_lr4,
        wheel_lr1,
        wheel_lr3,
        wheel_sr1,
        wheel_sr5,
        wheel_sr4,
        wheel_gn1,
        wheel_lr2,
        wheel_lr5,
        wheel_gn2,
        stereo,
        hydralics,
        rf_a_u,
        exh_c_u,
        wg_l_a_u,
        rf_c_u,
        exh_a_u,
        wg_l_c_u,
        wg_r_a_u,
        wg_r_c_u,
        wheel_gn3,
        wheel_gn4,
        wheel_gn5,
        wg_r_lr_br1,
        misc_c_lr_rem1,
        wg_r_lr_rem1,
        wg_r_lr_sv,
        rf_lr_bl2,
        exh_lr_bl1,
        exh_lr_bl2,
        wg_l_lr_rem2,
        wg_r_lr_bl1,
        wg_l_lr_bl1,
        bbb_lr_slv1,
        bbb_lr_slv2,
        bnt_lr_slv1,
        bnt_lr_slv2,
        exh_lr_slv1,
        exh_lr_slv2,
        fbb_lr_slv1,
        fbb_lr_slv2,
        fbmp_lr_slv1,
        wg_l_lr_slv1,
        wg_l_lr_slv2,
        wg_r_lr_slv1,
        wg_r_lr_slv2,
        wg_l_lr_rem1,
        misc_c_lr_rem2,
        wg_r_lr_rem2,
        misc_c_lr_rem3,
        exh_lr_rem1,
        exh_lr_rem2,
        rf_lr_bl1,
        exh_lr_sv1,
        rf_lr_sv1,
        rf_lr_sv2,
        exh_lr_sv2,
        wg_l_lr_sv,
        wg_l_lr_t1,
        exh_lr_t2,
        exh_lr_t1,
        wg_r_lr_t1,
        spl_a_s_b,
        spl_c_s_b,
        rbmp_c_s,
        rbmp_a_s,
        bntr_b_ov,
        bntl_b_ov,
        bntr_b_sq,
        bntl_b_sq,
        spl_c_l_b,
        spl_a_l_b,
        rbmp_c_l,
        rbmp_a_l,
        rbmp_a_f,
        rbmp_c_f,
        fbmp_c_f,
        fbmp_a_f,
        rbmp_a_st,
        fbmp_a_st,
        rbmp_c_st,
        fbmp_c_st,
        spl_c_j_b,
        rbmp_a_j,
        fbmp_a_j,
        rbmp_c_j,
        spl_a_j_b,
        spl_c_u_b,
        spl_a_u_b,
        fbmp_c_u,
        fbmp_a_u,
        rbmp_c_u,
        rbmp_a_u,
        fbmp_a_s,
        fbmp_c_s,
        fbmp_a_l,
        fbmp_c_l,
        fbmp_c_j,
        fbmp_lr_br1,
        fbmp_lr_br2,
        rbmp_lr_br1,
        rbmp_lr_br2,
        rbmp_lr_rem2,
        fbmp_lr_rem1,
        rbmp_lr_rem1,
        fbmp_lr_bl2,
        fbmp_lr_bl1,
        rbmp_lr_bl2,
        rbmp_lr_bl1,
        fbmp_lr_rem2,
        rbmp_lr_sv2,
        rbmp_lr_sv1,
        fbmp_lr_sv2,
        fbmp_lr_sv1,
        fbmp_lr_t2,
        fbmp_lr_t1,
        rbmp_lr_t1,
        rbmp_lr_t2
    }

    /// <summary>
    /// Represents slots for different upgrades
    /// </summary>
    public enum UpgradeSlot
    {
        Hood,
        Vent,
        Spoiler,
        Sideskirt,
        FrontBullbar,
        RearBullbar,
        Headlights,
        Roof,
        Nitrous,
        Hydraulics,
        Stereo,
        Wheels = 12,
        Exhaust,
        FrontBumper,
        RearBumper,
        Misc
    }

    /// <summary>
    /// Represents a vehicle tire
    /// </summary>
    public enum Tire
    {
        FrontLeft,
        FrontRight,
        RearLeft,
        RearRight
    }

    /// <summary>
    /// Represents different types of vehicle weapons
    /// </summary>
    public enum Weapon
    {
        Invalid,
        WaterCannon,
        TankGun,
        Rocket,
        HeatSeekingRocket
    }
}
