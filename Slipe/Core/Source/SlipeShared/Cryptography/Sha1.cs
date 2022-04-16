using System;
using System.Collections.Generic;
using System.Text;
using SlipeLua.MtaDefinitions;

namespace SlipeLua.Shared.Cryptography
{
    /// <summary>
    /// Represents static wrappers for Sha1 methods
    /// </summary>
    public static class Sha1
    {
        /// <summary>
        /// Hash a string with the Sha1 algorithm
        /// </summary>
        public static string Hash(string input)
        {
            return MtaShared.Hash("sha1", input);
        }

        /// <summary>
        /// Verify an input string against a Sha1 hash
        /// </summary>
        public static bool Verify(string input, string hash)
        {
            return (Hash(input) == hash);
        }
    }
}
