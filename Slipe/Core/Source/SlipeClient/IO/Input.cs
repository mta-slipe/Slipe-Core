using Slipe.Client.Elements;
using Slipe.Client.IO.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client.IO
{
    /// <summary>
    /// Class that handles various types of user input
    /// </summary>
    public static class Input
    {
        #region Events

#pragma warning disable 67

        public delegate void OnKeyHandler(RootElement source, OnKeyEventArgs eventArgs);
        public static event OnKeyHandler OnKey;

        public delegate void OnCharacterHandler(RootElement source, OnCharacterEventArgs eventArgs);
        public static event OnCharacterHandler OnCharacter;

#pragma warning enable 67

        #endregion
    }
}
