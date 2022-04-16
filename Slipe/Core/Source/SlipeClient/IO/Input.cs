using SlipeLua.Client.Elements;
using SlipeLua.Client.IO.Events;
using SlipeLua.MtaDefinitions;
using SlipeLua.Shared.IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeLua.Client.IO
{
    /// <summary>
    /// Class that handles various types of user input
    /// </summary>
    public static class Input
    {
        #region binds

        private static Dictionary<Action<string, KeyState>, Action<string, string>> closures
            = new Dictionary<Action<string, KeyState>, Action<string, string>>();

        /// <summary>
        /// Binds a key to a command
        /// </summary>
        /// <param name="player"></param>
        /// <param name="key"></param>
        /// <param name="state"></param>
        /// <param name="command"></param>
        /// <returns></returns>
        public static bool BindKey(string key, KeyState state, string command)
        {
            return MtaClient.BindKey(key, state.ToString().ToLower(), command);
        }

        /// <summary>
        /// Unbinds a key from a command
        /// </summary>
        /// <param name="player"></param>
        /// <param name="key"></param>
        /// <param name="state"></param>
        /// <param name="command"></param>
        /// <returns></returns>
        public static bool UnbindKey(string key, KeyState state, string command = null)
        {
            return MtaClient.UnbindKey(key, state.ToString().ToLower(), command);
        }

        /// <summary>
        /// Binds a key to a method
        /// </summary>
        /// <param name="player"></param>
        /// <param name="key"></param>
        /// <param name="state"></param>
        /// <param name="handler"></param>
        /// <returns></returns>
        public static bool BindKey(string key, KeyState state, Action<string, KeyState> handler)
        {
            Action<string, string> rawClosure = (string command, string closureState) =>
            {
                handler(command, (KeyState)Enum.Parse(typeof(KeyState), closureState, true));
            };
            closures[handler] = rawClosure;
            return MtaClient.BindKey(key, state.ToString().ToLower(), rawClosure);
        }

        /// <summary>
        /// Unbinds a key from a method
        /// </summary>
        /// <param name="player"></param>
        /// <param name="key"></param>
        /// <param name="state"></param>
        /// <param name="handler"></param>
        /// <returns></returns>
        public static bool UnbindKey(string key, KeyState state, Action<string, KeyState> handler)
        {
            if (closures.ContainsKey(handler))
            {
                bool result = MtaClient.UnbindKey(key, state.ToString().ToLower(), closures[handler]);
                closures.Remove(handler);
                return result;
            }
            return false;
        }
        #endregion

        /// <summary>
        /// Returns current state of a key
        /// </summary>
        /// <param name="keyName"></param>
        /// <returns></returns>
        public static bool IsKeyPressed(string keyName)
        {
            return MtaClient.GetKeyState(keyName);
        }

        /// <summary>
        /// Gets analog control state
        /// </summary>
        /// <param name="control"></param>
        /// <returns></returns>
        public static float GetAnalogControlState(string control)
        {
            return MtaClient.GetAnalogControlState(control);
        }

        /// <summary>
        /// Sets analog control state
        /// </summary>
        /// <param name="control"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool SetAnalogControlState(string control, float value)
        {
            return MtaClient.SetAnalogControlState(control, value);
        }

        /// <summary>
        /// Enables / disabled a control
        /// </summary>
        /// <param name="control"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool SetControlEnabled(string control, bool value)
        {
            return MtaClient.ToggleControl(control, value);
        }

        /// <summary>
        /// Gets whether a control is currently enabled
        /// </summary>
        /// <param name="control"></param>
        /// <returns></returns>
        public static bool IsControlEnabled(string control)
        {
            return MtaClient.IsControlEnabled(control);
        }

        /// <summary>
        /// Enables / disables all controls
        /// </summary>
        /// <param name="value"></param>
        /// <param name="mtaControls"></param>
        /// <param name="gtaControls"></param>
        /// <returns></returns>
        public static bool SetAllControlsEnabled(bool value, bool mtaControls = true, bool gtaControls = false)
        {
            return MtaClient.ToggleAllControls(value, gtaControls, mtaControls);
        }

        /// <summary>
        /// This method gets the player's keyboard layout settings, which they are currently (keyboard layout can be changed at any moment) using at the time of invocation.
        /// </summary>
        /// <returns>A string "ltr", "rtl", "ttb-rtl-ltr" or "ttb-ltr"</returns>
        public static string KeyboardReadingLayout()
        {
            return MtaClient.GetKeyboardReadingLayout();
        }

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
