using Slipe.Client.Elements;
using Slipe.Shared.Elements;
using Slipe.Client.SightLines;
using Slipe.Client.Peds;

namespace ClientSide
{
    class Program
    {
        private Follower follower;

        static void Main(string[] args)
        {
            new ElementManager(new ElementHelper());
            new Program();
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
