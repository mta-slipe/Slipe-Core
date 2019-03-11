using MTASharedWrapper;
using MTASharedWrapper.Enums;
using MultiTheftAuto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTAServerWrapper
{
    public class Camera
    {
        private Player player;

        public Camera(Player player)
        {
            this.player = player;
        }

        public bool Fade(CameraFade fade, Color color, int time = 1000)
        {
            return Server.FadeCamera(player.MTAElement, fade == CameraFade.IN ? true : false, time / 1000, color.R, color.G, color.B);
        }

        public bool Fade(CameraFade fade)
        {
            return Fade(fade, new Color(0x000000));
        }
    }
}
