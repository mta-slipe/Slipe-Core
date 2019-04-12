using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Sql
{
    public class SqlOptions
    {
        /// <summary>
        /// Whether the connection should be shared with other scripts
        /// </summary>
        public bool Share 
        {
            get {
                throw new NotImplementedException();
            }
            set{

            }
        }

        /// <summary>
        /// Whether the connection should batch multiple queries into one call
        /// </summary>
        public bool Batch 
        {
            get {
                throw new NotImplementedException();
            }
            set{

            }
        }

        /// <summary>
        /// Whether the connection should automatically attempt to reconnect if connection is lost
        /// </summary>
        public bool AutoReconnect 
        {
            get {
                throw new NotImplementedException();
            }
            set{

            }
        }

        /// <summary>
        /// Whether the queries executed on the connection should be logged
        /// </summary>
        public bool Log 
        {
            get {
                throw new NotImplementedException();
            }
            set{

            }
        }

        /// <summary>
        /// Tag for this connection to easily identify it in MySql server logs
        /// </summary>
        public string Tag 
        {
            get {
                throw new NotImplementedException();
            }
            set{

            }
        }

        /// <summary>
        /// List of errors / warnings to surpress
        /// </summary>
        public string[] Surpress 
        {
            get {
                throw new NotImplementedException();
            }
            set{

            }
        }

        /// <summary>
        /// Whether the connection should support running multiple statements at once
        /// </summary>
        public bool Multi_statements 
        {
            get {
                throw new NotImplementedException();
            }
            set{

            }
        }

    }
}
