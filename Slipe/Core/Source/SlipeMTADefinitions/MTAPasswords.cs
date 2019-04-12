using System;
using System.Threading.Tasks;

namespace Slipe.MtaDefinitions
{
    public static class MtaPasswords
    {
        public static Task<string> Hash(string input, int cost)
        {
            throw new NotImplementedException();
        }

        public static Task<bool> Verify(string input, string hash)
        {
            throw new NotImplementedException();
        }
    }
}
