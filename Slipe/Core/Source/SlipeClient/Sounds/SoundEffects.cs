using System;
using System.Collections.Generic;
using System.Text;
using SlipeLua.MtaDefinitions;

namespace SlipeLua.Client.Sounds
{
    /// <summary>
    /// Represents effects that can be set on a Sound
    /// </summary>
    public class SoundEffects
    {
        private Sound sound;

        #region Properties

        private bool gargle;
        public bool Gargle
        {
            get
            {
                updateSoundEffects();
                return gargle;
            }
            set
            {
                MtaClient.SetSoundEffectEnabled(sound.MTAElement, "gargle", value);
            }
        }

        private bool compressor;
        public bool Compressor
        {
            get
            {
                updateSoundEffects();
                return compressor;
            }
            set
            {
                MtaClient.SetSoundEffectEnabled(sound.MTAElement, "compressor", value);
            }
        }

        private bool echo;
        public bool Echo
        {
            get
            {
                updateSoundEffects();
                return echo;
            }
            set
            {
                MtaClient.SetSoundEffectEnabled(sound.MTAElement, "echo", value);
            }
        }

        private bool i3dl2reverb;
        public bool I3Dl2Reverb
        {
            get
            {
                updateSoundEffects();
                return i3dl2reverb;
            }
            set
            {
                MtaClient.SetSoundEffectEnabled(sound.MTAElement, "i3dl2reverb", value);
            }
        }

        private bool distortion;
        public bool Distorion
        {
            get
            {
                updateSoundEffects();
                return distortion;
            }
            set
            {
                MtaClient.SetSoundEffectEnabled(sound.MTAElement, "distortion", value);
            }
        }

        private bool chorus;
        public bool Chorus
        {
            get
            {
                updateSoundEffects();
                return chorus;
            }
            set
            {
                MtaClient.SetSoundEffectEnabled(sound.MTAElement, "chorus", value);
            }
        }

        private bool parameq;
        public bool Parameq
        {
            get
            {
                updateSoundEffects();
                return parameq;
            }
            set
            {
                MtaClient.SetSoundEffectEnabled(sound.MTAElement, "parameq", value);
            }
        }

        private bool reverb;
        public bool Reverb
        {
            get
            {
                updateSoundEffects();
                return reverb;
            }
            set
            {
                MtaClient.SetSoundEffectEnabled(sound.MTAElement, "reverb", value);
            }
        }

        private bool flanger;
        public bool Flanger
        {
            get
            {
                updateSoundEffects();
                return flanger;
            }
            set
            {
                MtaClient.SetSoundEffectEnabled(sound.MTAElement, "flanger", value);
            }
        }

        #endregion

        public SoundEffects(Sound sound)
        {
            this.sound = sound;
        }

        private void updateSoundEffects()
        {
            Dictionary<string, bool> soundEffects = MtaShared.GetDictionaryFromTable(MtaClient.GetSoundEffects(sound.MTAElement), "System.String", "System.Boolean");
            gargle = soundEffects["gargle"];
            compressor = soundEffects["compressor"];
            echo = soundEffects["echo"];
            i3dl2reverb = soundEffects["i3dl2reverb"];
            distortion = soundEffects["distortion"];
            chorus = soundEffects["chorus"];
            parameq = soundEffects["parameq"];
            reverb = soundEffects["reverb"];
            flanger = soundEffects["flanger"];
        }
    }
}
