using System;
using System.Collections.Generic;
using System.Text;
using SlipeLua.MtaDefinitions;

namespace SlipeLua.Shared.Helpers
{
    /// <summary>
    /// Represents a handler for the server or client Mta version and Os info
    /// </summary>
    public class SystemVersion
    {
        /// <summary>
        /// The MTA server or client version (depending where the function was called) in pure numerical form, e.g. "256"
        /// </summary>
        public int Number { get; }

        /// <summary>
        /// The MTA server or client version (depending where the function was called) in textual form, e.g. "1.0"
        /// </summary>
        public string Mta { get; }

        /// <summary>
        /// The full MTA product name, either "MTA:SA Server" or "MTA:SA Client".
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// The netcode version number.
        /// </summary>
        public string Netcode { get; }

        /// <summary>
        /// The operating system on which the server or client is running
        /// </summary>
        public string Os { get; }

        /// <summary>
        /// The type of build
        /// </summary>
        public string Type { get; }

        /// <summary>
        /// The build tag (from 1.0.3 onwards). Contains infomation about the underlying version used
        /// </summary>
        public string Tag { get; }

        /// <summary>
        /// A 15 character sortable version string
        /// </summary>
        public string Sortable { get; }

        /// <summary>
        /// Create a new version object
        /// </summary>
        public SystemVersion()
        {
            Dictionary<string, string> dictionary = MtaShared.GetDictionaryFromTable(MtaShared.GetVersion(), "System.String", "System.String");
            Number = Int32.Parse(dictionary["number"]);
            Mta = dictionary["mta"];
            Name = dictionary["name"];
            Netcode = dictionary["netcode"];
            Os = dictionary["os"];
            Type = dictionary["type"];
            Tag = dictionary["tag"];
            Sortable = dictionary["sortable"];
        }
    }
}
