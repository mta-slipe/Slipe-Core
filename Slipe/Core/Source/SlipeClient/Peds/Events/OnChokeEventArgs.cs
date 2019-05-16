using Slipe.MtaDefinitions;
using Slipe.Shared.Elements;
using Slipe.Shared.Weapons;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client.Peds.Events
{
    public class OnChokeEventArgs
    {
        /// <summary>
        /// The weapon that caused the choking
        /// </summary>
        SharedWeaponModel WeaponModel { get; }

        /// <summary>
        /// The ped responsible for the choking
        /// </summary>
        Ped ResponsiblePed { get; }

        internal OnChokeEventArgs(dynamic model, MtaElement ped)
        {
            WeaponModel = new SharedWeaponModel((int)model);
            ResponsiblePed = ElementManager.Instance.GetElement<Ped>(ped);
        }
    }
}
