using Slipe.MtaDefinitions;
using Slipe.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;
using Slipe.Shared.IO;
using System.Numerics;
using Slipe.Shared.Peds;
using Slipe.Shared.Utilities;
using Slipe.Shared.Helpers;
using Slipe.Client.IO;
using Slipe.Client.Browsers;
using Slipe.Client.Game;

namespace Slipe.Client.Elements
{
    [DefaultElementClass(ElementType.Root)]
    public class RootElement: Element
    {
        public RootElement(MtaElement element) : base(element)
        {
            OnPreRender += (float timeSlice) => { Game.GameClient.HandleUpdate(timeSlice); };
            OnChatMessage += (string message, Color color) => { ChatBox.HandleMessage(message, color); };
            OnDebugMessage += (string message, DebugMessageLevel level, string file, int line, Color color) => { Game.GameClient.Debug.HandleMessage(message, level, file, line, color); };
            OnBrowserWhiteListChange += (string[] changed) => { Browser.HandleWhiteListChange(changed); };
            OnMinimize += () => { Game.GameClient.HandleMinimize(); };
            OnNetworkInteruption += (NetworkInteruptionStatus status, int ticksSinceInteruptionStarted) => { Game.GameClient.HandleNetworkInteruption(status, ticksSinceInteruptionStarted); };
            OnRestore += (bool didClearRenderTargets) => { Game.GameClient.HandleRestore(didClearRenderTargets); };
        }

        public override void HandleEvent(string eventName, MtaElement element, object p1, object p2, object p3, object p4, object p5, object p6, object p7, object p8)
        {
            OnMiscelaniousEvent?.Invoke(eventName, element, p1, p2, p3, p4, p5, p6, p7, p8);
        }

        #pragma warning disable 67

        public delegate void OnMiscelaniousEventHandler(string eventName, MtaElement element, object p1, object p2, object p3, object p4, object p5, object p6, object p7, object p8);
        public static event OnMiscelaniousEventHandler OnMiscelaniousEvent;

        internal delegate void OnRenderHandler();
        internal static event OnRenderHandler OnRender;

        internal delegate void OnPreRenderHandler(float timeSlice);
        internal static event OnPreRenderHandler OnPreRender;

        internal delegate void OnHUDRenderHandler();
        internal static event OnRenderHandler OnHUDRender;

        internal delegate void OnKeyHandler(string key, bool isPressed);
        internal static event OnKeyHandler OnKey;

        internal delegate void OnCharacterHandler(string character);
        internal static event OnCharacterHandler OnCharacter;

        internal delegate void OnClickHandler(MouseButton mouseButton, MouseButtonState buttonState, Vector2 screenPosition, Vector3 worldPosition, PhysicalElement clickedElement);
        internal static event OnClickHandler OnClick;

        internal delegate void OnDoubleClickHandler(MouseButton mouseButton, Vector2 screenPosition, Vector3 worldPosition, PhysicalElement clickedElement);
        internal static event OnDoubleClickHandler OnDoubleClick;

        internal delegate void OnCursorMoveHandler(Vector2 relativePosition, Vector2 absolutePosition, Vector3 worldPosition);
        internal static event OnCursorMoveHandler OnCursorMove;

        internal delegate void OnChatMessageHandler(string text, Color color);
        internal static event OnChatMessageHandler OnChatMessage;

        internal delegate void OnDebugMessageHandler(string message, DebugMessageLevel level, string file, int line, Color color);
        internal static event OnDebugMessageHandler OnDebugMessage;

        internal delegate void OnBrowserWhiteListChangeHandler(string[] changedDomains);
        internal static event OnBrowserWhiteListChangeHandler OnBrowserWhiteListChange;

        internal delegate void OnMinimizeHandler();
        internal static event OnMinimizeHandler OnMinimize;

        internal delegate void OnNetworkInteruptionBeginHandler(NetworkInteruptionStatus status, int ticksSinceInteruptionStarted);
        internal event OnNetworkInteruptionBeginHandler OnNetworkInteruption;

        internal delegate void OnRestoreHandler(bool didClearRenderTargets);
        internal event OnRestoreHandler OnRestore;

        /// This method is just here so that these enums get parsed and are usable in events
        private void initEnums()
        {
            MouseButton m = (MouseButton)Enum.Parse(typeof(MouseButton), "Left", true);
            MouseButtonState s = (MouseButtonState)Enum.Parse(typeof(MouseButtonState), "Down", true);
            QuitType q = (QuitType)Enum.Parse(typeof(QuitType), "Disconnected", true);
        }

        #pragma warning restore 67

    }
}
