using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MtaDefinitions;

namespace Slipe.Client.Sounds
{
    /// <summary>
    /// Represents sound meta data
    /// </summary>
    public class SoundMeta
    {
        private Sound sound;

        #region Properties
        public string Title
        {
            get
            {
                try
                {
                    return MtaClient.GetSoundMetaTags(sound.MTAElement, "title");
                }
                catch (MtaException)
                {
                    return null;
                }
            }
        }

        public string Artist
        {
            get
            {
                try
                {
                    return MtaClient.GetSoundMetaTags(sound.MTAElement, "artist");
                }
                catch (MtaException)
                {
                    return null;
                }
            }
        }

        public string Album
        {
            get
            {
                try
                {
                    return MtaClient.GetSoundMetaTags(sound.MTAElement, "album");
                }
                catch (MtaException)
                {
                    return null;
                }
            }
        }

        public string Genre
        {
            get
            {
                try
                {
                    return MtaClient.GetSoundMetaTags(sound.MTAElement, "genre");
                }
                catch (MtaException)
                {
                    return null;
                }
            }
        }

        public string Year
        {
            get
            {
                try
                {
                    return MtaClient.GetSoundMetaTags(sound.MTAElement, "year");
                }
                catch (MtaException)
                {
                    return null;
                }
            }
        }

        public string Comment
        {
            get
            {
                try
                {
                    return MtaClient.GetSoundMetaTags(sound.MTAElement, "comment");
                }
                catch (MtaException)
                {
                    return null;
                }
            }
        }

        public string Track
        {
            get
            {
                try
                {
                    return MtaClient.GetSoundMetaTags(sound.MTAElement, "track");
                }
                catch (MtaException)
                {
                    return null;
                }
            }
        }

        public string Composer
        {
            get
            {
                try
                {
                    return MtaClient.GetSoundMetaTags(sound.MTAElement, "composer");
                }
                catch (MtaException)
                {
                    return null;
                }
            }
        }

        public string Copyright
        {
            get
            {
                try
                {
                    return MtaClient.GetSoundMetaTags(sound.MTAElement, "copyright");
                }
                catch (MtaException)
                {
                    return null;
                }
            }
        }

        public string Subtitle
        {
            get
            {
                try
                {
                    return MtaClient.GetSoundMetaTags(sound.MTAElement, "subtitle");
                }
                catch (MtaException)
                {
                    return null;
                }
            }
        }

        public string AlbumArtist
        {
            get
            {
                try
                {
                    return MtaClient.GetSoundMetaTags(sound.MTAElement, "album_artist");
                }
                catch (MtaException)
                {
                    return null;
                }
            }
        }

        public string StreamName
        {
            get
            {
                try
                {
                    return MtaClient.GetSoundMetaTags(sound.MTAElement, "stream_name");
                }
                catch (MtaException)
                {
                    return null;
                }
            }
        }

        public string StreamTitle
        {
            get
            {
                try
                {
                    return MtaClient.GetSoundMetaTags(sound.MTAElement, "stream_title");
                }
                catch (MtaException)
                {
                    return null;
                }
            }
        }
        #endregion

        public SoundMeta(Sound sound)
        {
            this.sound = sound;
        }
    }
}
