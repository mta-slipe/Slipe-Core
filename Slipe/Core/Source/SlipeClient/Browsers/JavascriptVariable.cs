using Slipe.MtaDefinitions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client.Browsers
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
            stringRepresentation = "null";
        }

        /// <summary>
        /// A js string variable
        /// </summary>
        public JavascriptVariable(string value)
        {
            stringRepresentation = "\"" + value + "\"";
        }

        /// <summary>
        /// A js bool variable
        /// </summary>
        public JavascriptVariable(bool value)
        {
            stringRepresentation = value.ToString().ToLower();
        }

        /// <summary>
        /// A js integer variable
        /// </summary>
        public JavascriptVariable(int value)
        {
            stringRepresentation = value.ToString();
        }

        /// <summary>
        /// A js float variable
        /// </summary>
        public JavascriptVariable(float value)
        {
            stringRepresentation = value.ToString();
        }

        /// <summary>
        /// Any MTA variable cast to a json
        /// </summary>
        public JavascriptVariable(dynamic value)
        {
            stringRepresentation = MtaShared.ToJSON(value, false, "none");
            // remove MTA's stupid wrapping of JSONs
            stringRepresentation = stringRepresentation.Substring(1, stringRepresentation.Length - 2);
        }

        public override string ToString()
        {
            return stringRepresentation;
        }

        public static implicit operator JavascriptVariable(string value)
        {
            return new JavascriptVariable(value);
        }

        public static implicit operator JavascriptVariable(bool value)
        {
            return new JavascriptVariable(value);
        }

        public static implicit operator JavascriptVariable(int value)
        {
            return new JavascriptVariable(value);
        }

        public static implicit operator JavascriptVariable(float value)
        {
            return new JavascriptVariable(value);
        }
    }
}
