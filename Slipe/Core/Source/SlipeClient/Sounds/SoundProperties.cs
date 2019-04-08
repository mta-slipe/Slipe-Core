using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MtaDefinitions;

namespace Slipe.Client.Sounds
{
    /// <summary>
    /// Represents different sound properties
    /// </summary>
    public class SoundProperties
    {
        private Sound sound;

        public float SampleRate
        {
            get
            {
                (float sampleRate, _, _, _) = MtaClient.GetSoundProperties(sound.MTAElement);
                return sampleRate;
            }
            set
            {
                MtaClient.SetSoundProperties(sound.MTAElement, value, Tempo, Pitch, Reverse);
            }
        }

        public float Tempo
        {
            get
            {
                (_, float tempo, _, _) = MtaClient.GetSoundProperties(sound.MTAElement);
                return tempo;
            }
            set
            {
                MtaClient.SetSoundProperties(sound.MTAElement, SampleRate, value, Pitch, Reverse);
            }
        }

        public float Pitch
        {
            get
            {
                (_, _, float pitch, _) = MtaClient.GetSoundProperties(sound.MTAElement);
                return pitch;
            }
            set
            {
                MtaClient.SetSoundProperties(sound.MTAElement, SampleRate, Tempo, value, Reverse);
            }
        }

        public bool Reverse
        {
            get
            {
                (_, _, _, bool reverse) = MtaClient.GetSoundProperties(sound.MTAElement);
                return reverse;
            }
            set
            {
                MtaClient.SetSoundProperties(sound.MTAElement, SampleRate, Tempo, Pitch, value);
            }
        }

        public SoundProperties(Sound sound)
        {
            this.sound = sound;
        }
    }
}
