using Slipe.MtaDefinitions;
using Slipe.Server.Peds;
using Slipe.Server.Vehicles;
using Slipe.Shared.Elements;
using System;
using System.Numerics;

namespace ServerSide
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program();
        }

        public Program()
        {

        }
    }

    [DefaultElementClass("player")]
    public class MyPlayer : Player
    {
        public MyPlayer(MtaElement element) : base(element)
        {
            Console.WriteLine("We instantiated a MyPlayer as a default player yay! :D");
        }
    }
}
