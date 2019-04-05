using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MTADefinitions;

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
                (float sampleRate, _, _, _) = MTAClient.GetSoundProperties(sound.MTAElement);
                return sampleRate;
            }
            set
            {
                MTAClient.SetSoundProperties(sound.MTAElement, value, Tempo, Pitch, Reverse);
            }
        }

        public float Tempo
        {
            get
            {
                (_, float tempo, _, _) = MTAClient.GetSoundProperties(sound.MTAElement);
                return tempo;
            }
            set
            {
                MTAClient.SetSoundProperties(sound.MTAElement, SampleRate, value, Pitch, Reverse);
            }
        }

        public float Pitch
        {
            get
            {
                (_, _, float pitch, _) = MTAClient.GetSoundProperties(sound.MTAElement);
                return pitch;
            }
            set
            {
                MTAClient.SetSoundProperties(sound.MTAElement, SampleRate, Tempo, value, Reverse);
            }
        }

        public bool Reverse
        {
            get
            {
                (_, _, _, bool reverse) = MTAClient.GetSoundProperties(sound.MTAElement);
                return reverse;
            }
            set
            {
                MTAClient.SetSoundProperties(sound.MTAElement, SampleRate, Tempo, Pitch, value);
            }
        }

        public SoundProperties(Sound sound)
        {
            this.sound = sound;
        }
    }
}
