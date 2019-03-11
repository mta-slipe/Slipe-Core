using MTAClientWrapper.Enums;
using MTAClientWrapper.Javascript;
using MTASharedWrapper;
using MultiTheftAuto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTAClientWrapper
{
    public class Browser: Element
    {
        public static dynamic Settings { get { return Client.GetBrowserSettings(); } }

        public static bool IsDomainBlocked(string domain, bool isURL = false)
        {
            return Client.IsBrowserDomainBlocked(domain, isURL);
        }

        public static bool RequestDomains(string[] domains, bool isURL = false)
        {
            return Client.RequestBrowserDomains(domains, isURL, HandleDomainRequest);
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

        public bool CanNavigateBack { get { return Client.CanBrowserNavigateBack(element); } }
        public bool CanNavigateForward { get { return Client.CanBrowserNavigateForward(element); } }
        public string Title { get { return Client.GetBrowserTitle(element); } }
        public string Url { get { return Client.GetBrowserURL(element); } }
        public bool IsLoading { get { return Client.IsBrowserLoading(element); } }
        public bool IsFocused { get { return Client.IsBrowserFocused(element); } }

        public float Volume { set { Client.SetBrowserVolume(element, value); } }
        public bool RenderingPaused { set { Client.SetBrowserRenderingPaused(element, value); } }
        public bool DevTools { set { Client.ToggleBrowserDevTools(element, value); } }


        public Browser(int width, int height, bool isLocal, bool transparent = false)
        {
            this.element = Client.CreateBrowser(width, height, isLocal, transparent);
            ElementManager.Instance.RegisterElement(this);
        }

        internal Browser(MultiTheftAuto.MTAElement element)
        {
            this.element = element;
            ElementManager.Instance.RegisterElement(this);
        }

        public bool ReloadPage()
        {
            return Client.ReloadBrowserPage(element);
        }

        public bool LoadUrl(string url, string postData = null, bool urlEncoded = true)
        {
            return Client.LoadBrowserURL(element, url, postData, urlEncoded);
        }

        public bool Focus()
        {
            return Client.FocusBrowser(element);
        }

        public dynamic GetProperty(string key)
        {
            return Client.GetBrowserProperty(element, key);
        }

        public bool InjectMouseDown(MouseButton mouseButton)
        {
            return Client.InjectBrowserMouseDown(element, mouseButton.ToString("f"));
        }

        public bool InjectMouseUp(MouseButton mouseButton)
        {
            return Client.InjectBrowserMouseUp(element, mouseButton.ToString("f"));
        }

        public bool InjectMouseMove(int x, int y)
        {
            return Client.InjectBrowserMouseMove(element, x, y);
        }

        public bool InjectMouseWheel(int vertical, int horizontal)
        {
            return Client.InjectBrowserMouseWheel(element, vertical, horizontal);
        }

        public bool Resize(float x, float y)
        {
            return Client.ResizeBrowser(element, x, y);
        }

        public bool ExecuteJavascript(string javascript)
        {
            Console.WriteLine("Executing " + javascript);
            return Client.ExecuteBrowserJavascript(element, javascript);
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
