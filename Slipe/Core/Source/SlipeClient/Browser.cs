using Slipe.Client.Enums;
using Slipe.Client.Javascript;
using Slipe.MTADefinitions;
using System;
using System.Numerics;
using System.Collections.Generic;
using System.Text;
using Slipe.Shared.Elements;

namespace Slipe.Client
{
    /// <summary>
    /// Class that wraps MTA browsers
    /// </summary>
    public class Browser: Element
    {
        /// <summary>
        /// Get browser settings
        /// </summary>
        public static dynamic Settings { get { return MTAClient.GetBrowserSettings(); } }

        /// <summary>
        /// Check if a specific domain is blocked
        /// </summary>
        public static bool IsDomainBlocked(string domain, bool isURL = false)
        {
            return MTAClient.IsBrowserDomainBlocked(domain, isURL);
        }

        /// <summary>
        /// Opens a request window in order to accept the requested remote URLs
        /// </summary>
        public static bool RequestDomains(string[] domains, bool isURL = false)
        {
            return MTAClient.RequestBrowserDomains(domains, isURL, HandleDomainRequest);
        }

        /// <summary>
        /// Opens a request window in order to accept a remote URL
        /// </summary>
        public static bool RequestDomain(string domain, bool isURL = false)
        {
            return RequestDomains(new string[] { domain }, isURL);
        }

        /// <summary>
        /// Handler that is triggered after a domain request was done
        /// </summary>
        public static void HandleDomainRequest(bool wasAccepted, string[] domains)
        {
            for (int i = 0; i < domains.Length; i++)
            {
                string domain = domains[i];
                if (wasAccepted)
                {
                    OnDomainRequestAccepted?.Invoke(domain);
                }
                else
                {
                    OnDomainRequestDenied?.Invoke(domain);
                }
            }
        }

        public static event Action<string> OnDomainRequestAccepted;
        public static event Action<string> OnDomainRequestDenied;

        /// <summary>
        /// Get if a browser can navigate back
        /// </summary>
        public bool CanNavigateBack { get { return MTAClient.CanBrowserNavigateBack(element); } }

        /// <summary>
        /// Get if a browser can navigate forward
        /// </summary>
        public bool CanNavigateForward { get { return MTAClient.CanBrowserNavigateForward(element); } }

        /// <summary>
        /// Get the title of this browser
        /// </summary>
        public string Title { get { return MTAClient.GetBrowserTitle(element); } }

        /// <summary>
        /// Get the current URL of this browser
        /// </summary>
        public string Url { get { return MTAClient.GetBrowserURL(element); } }

        /// <summary>
        /// Get if this browser is currently loading a page
        /// </summary>
        public bool IsLoading { get { return MTAClient.IsBrowserLoading(element); } }

        /// <summary>
        /// Get if this browser is currently focussed on
        /// </summary>
        public bool IsFocused { get { return MTAClient.IsBrowserFocused(element); } }

        /// <summary>
        /// Set the volume of this browser
        /// </summary>
        public float Volume { set { MTAClient.SetBrowserVolume(element, value); } }

        /// <summary>
        /// Set the rendering of this browser enabled or disabled
        /// </summary>
        public bool RenderingPaused { set { MTAClient.SetBrowserRenderingPaused(element, value); } }

        /// <summary>
        /// Set the devtools for this browser
        /// </summary>
        public bool DevTools { set { MTAClient.ToggleBrowserDevTools(element, value); } }

        /// <summary>
        /// Create a browser from the createBrowser parameters
        /// </summary>
        public Browser(int width, int height, bool isLocal, bool transparent = false)
        {
            this.element = MTAClient.CreateBrowser(width, height, isLocal, transparent);
            ElementManager.Instance.RegisterElement(this);
        }

        /// <summary>
        /// Create a browser from a MTA browser element
        /// </summary>
        internal Browser(MTAElement element)
        {
            this.element = element;
            ElementManager.Instance.RegisterElement(this);
        }

        /// <summary>
        /// Reload the page of this browser
        /// </summary>
        public bool ReloadPage()
        {
            return MTAClient.ReloadBrowserPage(element);
        }

        /// <summary>
        /// Load a specific browser URL
        /// </summary>
        public bool LoadUrl(string url, string postData = null, bool urlEncoded = true)
        {
            return MTAClient.LoadBrowserURL(element, url, postData, urlEncoded);
        }

        /// <summary>
        /// Focus on this browser
        /// </summary>
        public bool Focus()
        {
            return MTAClient.FocusBrowser(element);
        }

        /// <summary>
        /// Get a specific browser property
        /// </summary>
        public dynamic GetProperty(string key)
        {
            return MTAClient.GetBrowserProperty(element, key);
        }

        /// <summary>
        /// Inject a mousedown event in the browser
        /// </summary>
        public bool InjectMouseDown(MouseButton mouseButton)
        {
            return MTAClient.InjectBrowserMouseDown(element, mouseButton.ToString("f"));
        }

        /// <summary>
        /// Inject a mouseup event in the browser
        /// </summary>
        public bool InjectMouseUp(MouseButton mouseButton)
        {
            return MTAClient.InjectBrowserMouseUp(element, mouseButton.ToString("f"));
        }

        /// <summary>
        /// Inject a mousemove event to a specific position
        /// </summary>
        public bool InjectMouseMove(Vector2 position)
        {
            return MTAClient.InjectBrowserMouseMove(element, (int) position.X, (int) position.Y);
        }

        /// <summary>
        /// Inject a mouse scroll event
        /// </summary>
        public bool InjectMouseWheel(int vertical, int horizontal)
        {
            return MTAClient.InjectBrowserMouseWheel(element, vertical, horizontal);
        }

        /// <summary>
        /// Resize the browser to specific dimensions
        /// </summary>
        public bool Resize(Vector2 dimensions)
        {
            return MTAClient.ResizeBrowser(element, dimensions.X, dimensions.Y);
        }

        /// <summary>
        /// Execute some javascript code
        /// </summary>
        public bool ExecuteJavascript(string javascript)
        {
            Console.WriteLine("Executing " + javascript);
            return MTAClient.ExecuteBrowserJavascript(element, javascript);
        }

        /// <summary>
        /// Execute a javascript function using formatted js arguments
        /// </summary>
        public bool ExecuteJavascript(string function, JavascriptVariable[] arguments)
        {
            string javascriptString = function + "(";

            foreach(JavascriptVariable argument in arguments)
            {
                javascriptString += argument.ToString() + ", ";
            }
            javascriptString = javascriptString.Substring(0, javascriptString.Length - 2);

            javascriptString += ")";
            return ExecuteJavascript(javascriptString);
        }
        
        /// <summary>
        /// Handle an event on the browser
        /// </summary>
        public override void HandleEvent(string eventName, MTAElement element, dynamic p1, dynamic p2, dynamic p3, dynamic p4, dynamic p5, dynamic p6, dynamic p7, dynamic p8)
        {
            switch (eventName)
            {
                case "onClientBrowserCreated":
                    OnCreated?.Invoke();
                    break;
                case "onClientBrowserCursorChange":
                    OnCursorChange?.Invoke((int) p1);
                    break;
                case "onClientBrowserDocumentReady":
                    OnDocumentReady?.Invoke((string) p1);
                    break;
                case "onClientBrowserInputFocusChanged":
                    OnInputFocusChange?.Invoke((bool) p1);
                    break;
                case "onClientBrowserLoadingFailed":
                    OnLoadFail?.Invoke((string) p1, (int) p2, (string) p3);
                    break;
                case "onClientBrowserLoadingStart":
                    OnLoadStart?.Invoke((string) p1);
                    break;
                case "onClientBrowserNavigate":
                    OnNavigate?.Invoke((string) p1, (bool) p2);
                    break;
                case "onClientBrowserPopup":
                    OnPopup?.Invoke((string) p1, (string) p2, (bool) p3);
                    break;
                case "onClientBrowserResourceBlocked":
                    OnResourceBlocked?.Invoke((string) p1, (string) p2, (int) p3);
                    break;
                case "onClientBrowserTooltip":
                    OnTooltip?.Invoke((string) p1);
                    break;
            }
        }

        public delegate void OnCreatedHandler();
        public event OnCreatedHandler OnCreated;

        public delegate void OnCursorChangeHandler(int cursorId);
        public event OnCursorChangeHandler OnCursorChange;

        public delegate void OnDocumentReadyHandler(string url);
        public event OnDocumentReadyHandler OnDocumentReady;

        public delegate void OnInputFocusChangeHandler(bool gainedFocus);
        public event OnInputFocusChangeHandler OnInputFocusChange;

        public delegate void OnLoadFailHandler(string url, int errorCode, string errorDescription);
        public event OnLoadFailHandler OnLoadFail;

        public delegate void OnLoadStartHandler(string url);
        public event OnLoadStartHandler OnLoadStart;

        public delegate void OnNavigateHandler(string target, bool isBlocked);
        public event OnNavigateHandler OnNavigate;

        public delegate void OnPopupHandler(string target, string opener, bool isPopup);
        public event OnPopupHandler OnPopup;

        public delegate void OnResourceBlockedHandler(string url, string domain, int reason);
        public event OnResourceBlockedHandler OnResourceBlocked;

        public delegate void OnTooltipHandler(string tooltip);
        public event OnTooltipHandler OnTooltip;
    }
}
