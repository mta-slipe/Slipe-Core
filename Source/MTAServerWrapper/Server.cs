using System;
using System.Collections.Generic;
using System.Text;
using MTAServerWrapper.Enums;
using MultiTheftAuto;

namespace MTAServerWrapper
{
    class MTAServer
    {
        private static MTAServer instance;
        public static MTAServer Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MTAServer();
                }
                return instance;
            }
        }

        public string Password
        {
            get
            {
                return Server.GetServerPassword();
            }
            set
            {
                Server.SetServerPassword(value);
            }
        }

        public int MaxPlayers
        {
            get
            {
                return Server.GetMaxPlayers();
            }
            set
            {
                Server.SetMaxPlayers(value);
            }
        }

        public int FPSLimit
        {
            get
            {
                return Shared.GetFPSLimit();
            }
            set
            {
                Shared.SetFPSLimit(value);
            }
        }

        public string Version { get { return Shared.GetVersion(); } }
        public int Port { get { return Server.GetServerPort(); } }
        public int HTTPPort { get { return Server.GetServerHttpPort(); } }
        public string Name { get { return Server.GetServerName(); } }

        public bool SetGlitchEnabled(Glitch glitch, bool enabled)
        {
            return Server.SetGlitchEnabled(glitch.ToString("f").ToLower(), enabled);
        }

        public bool IsGlitchEnabled(Glitch glitch)
        {
            return Server.IsGlitchEnabled(glitch.ToString("f").ToLower());
        }

        public void Shutdown(string reason)
        {
            Server.Shutdown(reason);
        }
    }
}
