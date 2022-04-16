using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Shared.Weapons
{
    /// <summary>
    /// Represents the slot of a weapon
    /// </summary>
    public enum WeaponSlot
    {
        Unarmed,
        Melee,
        Handgun,
        Shotgun,
        SMG,
        Rifle,
        Sniper,
        Heavy,
        Thrown,
        Special,
        Gift,
        Parachute,
        Detonator
    }

    /// <summary>
    /// Represents different skills one can have in a weapon
    /// </summary>
    public enum WeaponSkill
    {
        Pro,
        Std,
        Poor
    }

    /// <summary>
    /// Represents different properties weapons can have
    /// </summary>
    public enum WeaponProperty
    {
        Weapon_Range,
        Target_Range,
        Accuracy,
        Damage,
        Maximum_Clip_Ammo,
        MoveSpeed,
        Flag_Aim_No_Auto,
        Flag_Aim_Arm,
        Flag_Aim_1st_Person,
        Flag_Aim_Free,
        Flag_Move_And_Aim,
        Flag_Move_And_Shoot,
        Flag_Type_Throw,
        Flag_Type_Heavy,
        Flag_Type_Constant,
        Flag_Type_Dual,
        Flag_Anim_Reload,
        Flag_Anim_Crouch,
        Flag_Anim_Reload_Loop,
        Flag_Anim_Reload_Long,
        Flag_Shot_Slows,
        Flag_Shot_Rand_Speed,
        Flag_Shot_Anim_Abrupt,
        Flag_Shot_Expands,
        Anim_Loop_Start,
        Anim_Loop_Stop,
        Anim_Loop_Bullet_Fire,
        Anim2_Loop_Start,
        Anim2_Loop_Stop,
        Anim2_Loop_Bullet_Fire,
        Anim_Breakout_Time
    }

    /// <summary>
    /// Represents different states a weapon can be in
    /// </summary>
    public enum WeaponState
    {
        Reloading,
        Firing,
        Ready
    }

}
