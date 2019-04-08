using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MTADefinitions;

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
                    return MTAClient.GetSoundMetaTags(sound.MTAElement, "title");
                }
                catch (MTAException)
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
                    return MTAClient.GetSoundMetaTags(sound.MTAElement, "artist");
                }
                catch (MTAException)
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
                    return MTAClient.GetSoundMetaTags(sound.MTAElement, "album");
                }
                catch (MTAException)
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
                    return MTAClient.GetSoundMetaTags(sound.MTAElement, "genre");
                }
                catch (MTAException)
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
                    return MTAClient.GetSoundMetaTags(sound.MTAElement, "year");
                }
                catch (MTAException)
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
                    return MTAClient.GetSoundMetaTags(sound.MTAElement, "comment");
                }
                catch (MTAException)
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
                    return MTAClient.GetSoundMetaTags(sound.MTAElement, "track");
                }
                catch (MTAException)
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
                    return MTAClient.GetSoundMetaTags(sound.MTAElement, "composer");
                }
                catch (MTAException)
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
                    return MTAClient.GetSoundMetaTags(sound.MTAElement, "copyright");
                }
                catch (MTAException)
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
                    return MTAClient.GetSoundMetaTags(sound.MTAElement, "subtitle");
                }
                catch (MTAException)
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
                    return MTAClient.GetSoundMetaTags(sound.MTAElement, "album_artist");
                }
                catch (MTAException)
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
                    return MTAClient.GetSoundMetaTags(sound.MTAElement, "stream_name");
                }
                catch (MTAException)
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
                    return MTAClient.GetSoundMetaTags(sound.MTAElement, "stream_title");
                }
                catch (MTAException)
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
