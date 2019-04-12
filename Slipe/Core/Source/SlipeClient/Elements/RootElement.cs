using Slipe.MtaDefinitions;
using Slipe.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;
using Slipe.Shared.IO;
using System.Numerics;
using Slipe.Shared.Peds;

namespace Slipe.Client.Elements
{
    public class RootElement: Element
    {
        public RootElement(MtaElement element) : base(element)
        {

        }

        public override void HandleEvent(string eventName, MtaElement element, object p1, object p2, object p3, object p4, object p5, object p6, object p7, object p8)
        {
            OnMiscelaniousEvent?.Invoke(eventName, element, p1, p2, p3, p4, p5, p6, p7, p8);
        }

        public delegate void OnMiscelaniousEventHandler(string eventName, MtaElement element, object p1, object p2, object p3, object p4, object p5, object p6, object p7, object p8);
        public static event OnMiscelaniousEventHandler OnMiscelaniousEvent;

        public delegate void OnKeyHandler(string key, bool isPressed);
        public static event OnKeyHandler OnKey;

        public delegate void OnRenderHandler();
        public static event OnRenderHandler OnRender;

        public delegate void OnPreRenderHandler(float timeSlice);
        public static event OnPreRenderHandler OnPreRender;

        public delegate void OnHUDRenderHandler();
        public static event OnRenderHandler OnHUDRender;

        public delegate void OnBrowserWhiteListChangeHandler(string[] changedDomains);
        public static event OnBrowserWhiteListChangeHandler OnBrowserWhiteListChange;

        public delegate void OnCharacterHandler(string character);
        public static event OnCharacterHandler OnCharacter;

        public delegate void OnClickHandler(MouseButton mouseButton, MouseButtonState buttonState, Vector2 screenPosition, Vector3 worldPosition, PhysicalElement clickedElement);
        public static event OnClickHandler OnClick;

        public delegate void OnDoubleClickHandler(MouseButton mouseButton, Vector2 screenPosition, Vector3 worldPosition, PhysicalElement clickedElement);
        public static event OnDoubleClickHandler OnDoubleClick;

        public delegate void OnCursorMoveHandler(Vector2 relativePosition, Vector2 absolutePosition, Vector3 worldPosition);
        public static event OnCursorMoveHandler OnCursorMove;

        /// This method is just here so that these enums get parsed and are usable in events
        private void initEnums()
        {
            MouseButton m = (MouseButton)Enum.Parse(typeof(MouseButton), "Left", true);
            MouseButtonState s = (MouseButtonState)Enum.Parse(typeof(MouseButtonState), "Down", true);
            QuitType q = (QuitType)Enum.Parse(typeof(QuitType), "Disconnected", true);
        }

    }
}
