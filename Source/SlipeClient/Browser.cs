using Slipe.Client.Enums;
using Slipe.Client.Javascript;
using Slipe.Shared;
using Slipe.MTADefinitions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Client
{
    public class Browser: Element
    {
        public static dynamic Settings { get { return MTAClient.GetBrowserSettings(); } }

        public static bool IsDomainBlocked(string domain, bool isURL = false)
        {
            return MTAClient.IsBrowserDomainBlocked(domain, isURL);
        }

        public static bool RequestDomains(string[] domains, bool isURL = false)
        {
            return MTAClient.RequestBrowserDomains(domains, isURL, HandleDomainRequest);
        }

        public static bool RequestDomain(string domain, bool isURL = false)
        {
            return RequestDomains(new string[] { domain }, isURL);
        }

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

        public bool CanNavigateBack { get { return MTAClient.CanBrowserNavigateBack(element); } }
        public bool CanNavigateForward { get { return MTAClient.CanBrowserNavigateForward(element); } }
        public string Title { get { return MTAClient.GetBrowserTitle(element); } }
        public string Url { get { return MTAClient.GetBrowserURL(element); } }
        public bool IsLoading { get { return MTAClient.IsBrowserLoading(element); } }
        public bool IsFocused { get { return MTAClient.IsBrowserFocused(element); } }

        public float Volume { set { MTAClient.SetBrowserVolume(element, value); } }
        public bool RenderingPaused { set { MTAClient.SetBrowserRenderingPaused(element, value); } }
        public bool DevTools { set { MTAClient.ToggleBrowserDevTools(element, value); } }


        public Browser(int width, int height, bool isLocal, bool transparent = false)
        {
            this.element = MTAClient.CreateBrowser(width, height, isLocal, transparent);
            ElementManager.Instance.RegisterElement(this);
        }

        internal Browser(Slipe.MTADefinitions.MTAElement element)
        {
            this.element = element;
            ElementManager.Instance.RegisterElement(this);
        }

        public bool ReloadPage()
        {
            return MTAClient.ReloadBrowserPage(element);
        }

        public bool LoadUrl(string url, string postData = null, bool urlEncoded = true)
        {
            return MTAClient.LoadBrowserURL(element, url, postData, urlEncoded);
        }

        public bool Focus()
        {
            return MTAClient.FocusBrowser(element);
        }

        public dynamic GetProperty(string key)
        {
            return MTAClient.GetBrowserProperty(element, key);
        }

        public bool InjectMouseDown(MouseButton mouseButton)
        {
            return MTAClient.InjectBrowserMouseDown(element, mouseButton.ToString("f"));
        }

        public bool InjectMouseUp(MouseButton mouseButton)
        {
            return MTAClient.InjectBrowserMouseUp(element, mouseButton.ToString("f"));
        }

        public bool InjectMouseMove(int x, int y)
        {
            return MTAClient.InjectBrowserMouseMove(element, x, y);
        }

        public bool InjectMouseWheel(int vertical, int horizontal)
        {
            return MTAClient.InjectBrowserMouseWheel(element, vertical, horizontal);
        }

        public bool Resize(float x, float y)
        {
            return MTAClient.ResizeBrowser(element, x, y);
        }

        public bool ExecuteJavascript(string javascript)
        {
            Console.WriteLine("Executing " + javascript);
            return MTAClient.ExecuteBrowserJavascript(element, javascript);
        }

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
