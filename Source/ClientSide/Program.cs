using Slipe.Client.Elements;
using Slipe.Shared.Elements;

namespace ClientSide
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
