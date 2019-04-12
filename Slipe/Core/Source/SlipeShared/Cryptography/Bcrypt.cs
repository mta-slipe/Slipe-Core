using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Slipe.MtaDefinitions;

namespace Slipe.Shared.Cryptography
{
    /// <summary>
    /// Represents static wrappers for hasing strings with Bcrypt
    /// </summary>
    public static class Bcrypt
    {
        /// <summary>
        /// Hash a string with the Bcrypt algorithm
        /// </summary>
        public static Task<string> Hash(string input, int cost = 10)
        {
            return MtaPasswords.Hash(input, cost);
        }

        /// <summary>
        /// Verify an input string against a Bcrypt hash
        /// </summary>
        public static Task<bool> Verify(string input, string hash)
        {
            return MtaPasswords.Verify(input, hash);           
        }
    }
}
