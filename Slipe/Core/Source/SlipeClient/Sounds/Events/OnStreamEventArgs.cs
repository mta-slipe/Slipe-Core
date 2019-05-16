using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client.Sounds.Events
{
    public class OnStreamEventArgs
    {
        public bool Success { get; }
        public int Length { get; }
        public string Name { get; }
        public string ErrorMessage { get; }

        internal OnStreamEventArgs(dynamic s, dynamic l, dynamic n, dynamic e)
        {
            Success = (bool)s;
            Length = (int)l;
            Name = (string)n;
            ErrorMessage = (string)e;
        }

    }
}
