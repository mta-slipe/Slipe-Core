using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MtaDefinitions;

namespace Slipe.Shared.Cryptography
{
    /// <summary>
    /// Represents static wrappers for Sha512 methods
    /// </summary>
    public static class Sha512
    {
        /// <summary>
        /// Hash a string with the Sha512 algorithm
        /// </summary>
        public static string Hash(string input)
        {
            return MtaShared.Hash("sha512", input);
        }

        /// <summary>
        /// Verify an input string against a Sha512 hash
        /// </summary>
        public static bool Verify(string input, string hash)
        {
            return (Hash(input) == hash);
        }
    }
}
