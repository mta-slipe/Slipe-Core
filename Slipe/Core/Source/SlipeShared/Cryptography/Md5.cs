using System;
using System.Collections.Generic;
using System.Text;
using SlipeLua.MtaDefinitions;

namespace SlipeLua.Shared.Cryptography
{
    /// <summary>
    /// Represents static wrappers for Md5 methods
    /// </summary>
    public static class Md5
    {
        /// <summary>
        /// Hash a string with the Md5 algorithm
        /// </summary>
        public static string Hash(string input)
        {
            return MtaShared.Hash("md5", input);
        }

        /// <summary>
        /// Verify an input string against a Md5 hash
        /// </summary>
        public static bool Verify(string input, string hash)
        {
            return (Hash(input) == hash);
        }
    }
}
