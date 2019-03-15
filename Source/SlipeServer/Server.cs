using System;
using System.Collections.Generic;
using System.Text;
using Slipe.Server.Enums;
using Slipe.MTADefinitions;

namespace Slipe.Server
{
    class Server
    {
        private static Server instance;
        public static Server Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Server();
                }
                return instance;
            }
        }

        public string Password
        {
            get
            {
                return MTAServer.GetServerPassword();
            }
            set
            {
                MTAServer.SetServerPassword(value);
            }
        }

        public int MaxPlayers
        {
            get
            {
                return MTAServer.GetMaxPlayers();
            }
            set
            {
                MTAServer.SetMaxPlayers(value);
            }
        }

        public int FPSLimit
        {
            get
            {
                return MTAShared.GetFPSLimit();
            }
            set
            {
                MTAShared.SetFPSLimit(value);
            }
        }

        public string Version { get { return MTAShared.GetVersion(); } }
        public int Port { get { return MTAServer.GetServerPort(); } }
        public int HTTPPort { get { return MTAServer.GetServerHttpPort(); } }
        public string Name { get { return MTAServer.GetServerName(); } }

        public bool SetGlitchEnabled(Glitch glitch, bool enabled)
        {
            return MTAServer.SetGlitchEnabled(glitch.ToString("f").ToLower(), enabled);
        }

        public bool IsGlitchEnabled(Glitch glitch)
        {
            return MTAServer.IsGlitchEnabled(glitch.ToString("f").ToLower());
        }

        public void Shutdown(string reason)
        {
            MTAServer.Shutdown(reason);
        }
    }
}
