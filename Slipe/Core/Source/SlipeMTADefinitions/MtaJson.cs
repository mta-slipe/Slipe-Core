using SlipeLua.MtaDefinitions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Json
{
    public static class Json
    {
        public static string Serialize(object value, bool compact = false, JsonPrettyType prettyType  = JsonPrettyType.None)
        {
            throw new NotImplementedException();
        }

        public static T Deserialize<T>(string json)
        {
            throw new NotImplementedException();
        }
    }

    public enum JsonPrettyType
    {
        None,
        Spaces,
        Tabs
    }
}
