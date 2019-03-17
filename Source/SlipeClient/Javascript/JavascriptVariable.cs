using Slipe.MTADefinitions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client.Javascript
{
    /// <summary>
    /// Class to wrap different types of javascript variables
    /// </summary>
    public class JavascriptVariable
    {
        private string stringRepresentation;


        /// <summary>
        /// An empty js variable
        /// </summary>
        public JavascriptVariable()
        {
            this.stringRepresentation = "null";
        }

        /// <summary>
        /// A js string variable
        /// </summary>
        public JavascriptVariable(string value)
        {
            this.stringRepresentation = "\"" + value + "\"";
        }

        /// <summary>
        /// A js bool variable
        /// </summary>
        public JavascriptVariable(bool value)
        {
            this.stringRepresentation = value.ToString().ToLower();
        }

        /// <summary>
        /// A js integer variable
        /// </summary>
        public JavascriptVariable(int value)
        {
            this.stringRepresentation = value.ToString();
        }

        /// <summary>
        /// A js float variable
        /// </summary>
        public JavascriptVariable(float value)
        {
            this.stringRepresentation = value.ToString();
        }

        /// <summary>
        /// Any MTA variable cast to a json
        /// </summary>
        public JavascriptVariable(dynamic value)
        {
            this.stringRepresentation = MTAShared.ToJSON(value, false, "none");
            // remove MTA's stupid wrapping of JSONs
            this.stringRepresentation = this.stringRepresentation.Substring(1, this.stringRepresentation.Length - 2);
        }

        public override string ToString()
        {
            return this.stringRepresentation;
        }
    }
}
