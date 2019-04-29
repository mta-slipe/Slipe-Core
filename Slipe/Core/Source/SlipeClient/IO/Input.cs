using Slipe.Client.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client.IO
{
    /// <summary>
    /// Class that handles various types of user input
    /// </summary>
    public class Input
    {
        protected static Input instance;

        public static Input Instance
        {
            get
            {
                instance = instance ?? new Input();
                return instance;
            }
        }

        /// <summary>
        /// Get the cursor
        /// </summary>
        public Cursor Cursor
        {
            get
            {
                return Cursor.Instance;
            }
        }

        private Input()
        {
            RootElement.OnKey += (string key, bool isPressed) => { OnKey?.Invoke(key, isPressed); };
            RootElement.OnCharacter += (string character) => { OnCharacter?.Invoke(character); };
        }

        #region Events

        public delegate void OnKeyHandler(string key, bool isPressed);
        public static event OnKeyHandler OnKey;

        public delegate void OnCharacterHandler(string character);
        public static event OnCharacterHandler OnCharacter;

        #endregion
    }
}
