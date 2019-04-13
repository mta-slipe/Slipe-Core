using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MtaDefinitions;

namespace Slipe.Shared.Cryptography
{
    /// <summary>
    /// Represents static wrappers for the Base64 encoding algorithm
    /// </summary>
    public static class Base64
    {
        /// <summary>
        /// Encode a string with Base64
        /// </summary>
        public static string Encode(string input)
        {
            return MtaShared.Base64Encode(input);
        }

        /// <summary>
        /// Decode a string with Base64
        /// </summary>
        public static string Decode(string input)
        {
            return MtaShared.Base64Decode(input);
        }
    }
}
