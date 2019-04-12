using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MtaDefinitions;

namespace Slipe.Shared.Cryptography
{
    /// <summary>
    /// Represents static wrappers for Sha224 methods
    /// </summary>
    public static class Sha224
    {
        /// <summary>
        /// Hash a string with the Sha224 algorithm
        /// </summary>
        public static string Hash(string input)
        {
            return MtaShared.Hash("sha224", input);
        }

        /// <summary>
        /// Verify an input string against a Sha224 hash
        /// </summary>
        public static bool Verify(string input, string hash)
        {
            return (Hash(input) == hash);
        }
    }
}
