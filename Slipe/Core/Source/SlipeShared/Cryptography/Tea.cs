using System;
using System.Collections.Generic;
using System.Text;
using SlipeLua.MtaDefinitions;

namespace SlipeLua.Shared.Cryptography
{
    /// <summary>
    /// Represents static wrappers for the Tiny Encryption Algorithm 
    /// </summary>
    public static class Tea
    {
        /// <summary>
        /// Encrypt a string with the Tiny Encryption Algorithm
        /// </summary>
        public static string Encrypt(string input, string key)
        {
            Dictionary<string, string> options = new Dictionary<string, string>();
            options["key"] = key;
            return MtaShared.EncodeString("tea", input, options);
        }

        /// <summary>
        /// Decrypt an encrypted string with the Tiny Encryption Algorithm
        /// </summary>
        public static string Decrypt(string input, string key)
        {
            Dictionary<string, string> options = new Dictionary<string, string>();
            options["key"] = key;
            return MtaShared.DecodeString("tea", input, options);
        }
    }
}
