using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client.Sounds
{
    /// <summary>
    /// Represents different sound containers
    /// </summary>
    public enum SoundContainer
    {
        feet,
        genrl,
        pain_a,
        script,
        spc_ea,
        spc_fa,
        spc_na,
        spc_pa
    }

    /// <summary>
    /// Represents different radio stations
    /// </summary>
    public enum RadioStation
    {
        RadioOff,
        PlaybackFM,
        KRose,
        KDST,
        BounceFM,
        SFUR,
        RadioLosSantos,
        RadioX,
        CSR1039,
        KJahWest,
        MasterSounds983,
        WCTR,
        UserTrackPlayer
    }

    /// <summary>
    /// Represents interal GTA radio stations that are not the common ones
    /// </summary>
    public enum ExtraStations
    {
        Adverts,
        Ambience,
        Police,
        Custscene,
        Beats
    }
}
