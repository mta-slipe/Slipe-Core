using Slipe.Client.Elements;
using Slipe.Shared.Elements;
using Slipe.Client.SightLines;
using Slipe.Client.Peds;
using Slipe.Client.Resources;
using System;
using Slipe.Client.GameWorld;

namespace ClientSide
{
    class Program
    {
        private Follower follower;

        static void Main(string[] args)
        {
            new ElementManager(new ElementHelper());
            new Program();

            // BROKEN UNTIL FIXED BY YANG :D
            //try
            //{
            //    Player p = Player.GetFromName("SAES>DezZolation");
            //    WorldObject ob = new WorldObject(1337, new System.Numerics.Vector3(2488, -1662, 18));
            //    RootElement.OnRender += () =>
            //    {
            //        ob.FaceElement(p);
            //    };
            //}catch(Exception e) { }

        }

        public Program()
        {
            Player.Local.OnConsole += (string cmd) =>
            {
                if (cmd == "npc")
                {
                    follower = new Follower(Player.Local);
                }

            };
        }
    }
}
