using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SlipeLua.Sql
{
    public class Database
    {
        /// <summary>
        /// Creatse a connection with a sqlite daTabase
        /// </summary>
        public Database(string filepath, SqlOptions options = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a connection with a MySql server
        /// </summary>
        public Database(string connectionString, string username = "", string password = "", SqlOptions options = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a connection with a MySql server
        /// </summary>
        public Database(MySqlConnectionString connectionString, string username = "", string password = "", SqlOptions options = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Runs an SQL query discarding the results
        /// </summary>
        /// <param name="query">sql query</param>
        /// <param name="parameters">parameters for the SQL query</param>
        public void Exec(string query, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Runs an SQL query and resturns the results asynchronously
        /// </summary>
        /// <param name="query">sql query</param>
        /// <param name="parameters">parameters for the SQL query</param>
        /// <returns>An array of dictionaries representing the resulting rows of the query</returns>
        public Task<Dictionary<string, SqlValue>[]> Query(string query, params object[] parameters)
        {
            throw new NotImplementedException();
        }
    }
}
