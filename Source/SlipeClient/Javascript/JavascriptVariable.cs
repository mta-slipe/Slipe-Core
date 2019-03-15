using Slipe.MTADefinitions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client.Javascript
{
    public class JavascriptVariable
    {
        private string stringRepresentation;


        public JavascriptVariable()
        {
            this.stringRepresentation = "null";
        }

        public JavascriptVariable(string value)
        {
            this.stringRepresentation = "\"" + value + "\"";
        }

        public JavascriptVariable(bool value)
        {
            this.stringRepresentation = value.ToString().ToLower();
        }

        public JavascriptVariable(int value)
        {
            this.stringRepresentation = value.ToString();
        }

        public JavascriptVariable(float value)
        {
            this.stringRepresentation = value.ToString();
        }

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
