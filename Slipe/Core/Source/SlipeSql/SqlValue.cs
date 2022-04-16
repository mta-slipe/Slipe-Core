using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Sql
{
    public class SqlValue
    {
        /// <summary>
        /// Represents a value used by  
        /// </summary>
        public SqlValue(object value)
        {

        }

        public static implicit operator string(SqlValue value)
        {
            return string.Empty;
        }

        public static implicit operator int(SqlValue value)
        {
            return 0;
        }

        public static implicit operator float(SqlValue value)
        {
            return 0f;
        }
    }
}
