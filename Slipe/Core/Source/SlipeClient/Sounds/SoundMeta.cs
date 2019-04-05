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
                return MTAClient.GetSoundMetaTags(sound.MTAElement, "title");
            }
        }

        public string Artist
        {
            get
            {
                return MTAClient.GetSoundMetaTags(sound.MTAElement, "artist");
            }
        }

        public string Album
        {
            get
            {
                return MTAClient.GetSoundMetaTags(sound.MTAElement, "album");
            }
        }

        public string Genre
        {
            get
            {
                return MTAClient.GetSoundMetaTags(sound.MTAElement, "genre");
            }
        }

        public string Year
        {
            get
            {
                return MTAClient.GetSoundMetaTags(sound.MTAElement, "year");
            }
        }

        public string Comment
        {
            get
            {
                return MTAClient.GetSoundMetaTags(sound.MTAElement, "comment");
            }
        }

        public string Track
        {
            get
            {
                return MTAClient.GetSoundMetaTags(sound.MTAElement, "track");
            }
        }

        public string Composer
        {
            get
            {
                return MTAClient.GetSoundMetaTags(sound.MTAElement, "composer");
            }
        }

        public string Copyright
        {
            get
            {
                return MTAClient.GetSoundMetaTags(sound.MTAElement, "copyright");
            }
        }

        public string Subtitle
        {
            get
            {
                return MTAClient.GetSoundMetaTags(sound.MTAElement, "subtitle");
            }
        }

        public string AlbumArtist
        {
            get
            {
                return MTAClient.GetSoundMetaTags(sound.MTAElement, "album_artist");
            }
        }

        public string StreamName
        {
            get
            {
                return MTAClient.GetSoundMetaTags(sound.MTAElement, "stream_name");
            }
        }

        public string StreamTitle
        {
            get
            {
                return MTAClient.GetSoundMetaTags(sound.MTAElement, "stream_title");
            }
        }
        #endregion

        public SoundMeta(Sound sound)
        {
            this.sound = sound;
        }
    }
}
