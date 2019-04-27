
using Slipe.Server.Elements;
using Slipe.Shared.Elements;

namespace ServerSide
{
    class Program
    {
        static void Main(string[] args)
        {
            new ElementManager(new ElementHelper());
            new Program();
        }

        public Program()
        {

        }
    }
}
