using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MtaDefinitions;

namespace Slipe.Shared.Cryptography
{
    /// <summary>
    /// Represents static wrappers for Sha256 methods
    /// </summary>
    public static class Sha256
    {
        /// <summary>
        /// Hash a string with the Sha256 algorithm
        /// </summary>
        public static string Hash(string input)
        {
            return MtaShared.Hash("sha256", input);
        }

        /// <summary>
        /// Verify an input string against a Sha256 hash
        /// </summary>
        public static bool Verify(string input, string hash)
        {
            return (Hash(input) == hash);
        }
    }
}
