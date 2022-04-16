using System;
using System.Collections.Generic;
using System.Text;
using SlipeLua.MtaDefinitions;

namespace SlipeLua.Shared.Cryptography
{
    /// <summary>
    /// Represents static wrappers for Sha384 methods
    /// </summary>
    public static class Sha384
    {
        /// <summary>
        /// Hash a string with the Sha384 algorithm
        /// </summary>
        public static string Hash(string input)
        {
            return MtaShared.Hash("sha384", input);
        }

        /// <summary>
        /// Verify an input string against a Sha384 hash
        /// </summary>
        public static bool Verify(string input, string hash)
        {
            return (Hash(input) == hash);
        }
    }
}
