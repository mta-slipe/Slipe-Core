﻿using SlipeLua.MtaDefinitions;
using System;
using System.Numerics;
using System.Collections.Generic;
using System.Text;
using SlipeLua.Shared.Elements;
using System.ComponentModel;
using SlipeLua.Shared.IO;
using SlipeLua.Client.Browsers.Events;
using SlipeLua.Client.Elements;
using SlipeLua.Client.Dx;

namespace SlipeLua.Client.Browsers
{
    /// <summary>
    /// Class that wraps MTA browsers
    /// </summary>
    [DefaultElementClass(ElementType.Browser)]
    public class Browser : Element
    {
        #region Properties
        /// <summary>
        /// Get browser settings
        /// </summary>
        public static dynamic Settings { get { return MtaClient.GetBrowserSettings(); } }

        /// <summary>
        /// Get if a browser can navigate back
        /// </summary>
        public bool CanNavigateBack { get { return MtaClient.CanBrowserNavigateBack(element); } }

        /// <summary>
        /// Get if a browser can navigate forward
        /// </summary>
        public bool CanNavigateForward { get { return MtaClient.CanBrowserNavigateForward(element); } }

        /// <summary>
        /// Get the title of this browser
        /// </summary>
        public string Title { get { return MtaClient.GetBrowserTitle(element); } }

        /// <summary>
        /// Get the current URL of this browser
        /// </summary>
        public string Url { get { return MtaClient.GetBrowserURL(element); } }

        /// <summary>
        /// Get if this browser is currently loading a page
        /// </summary>
        public bool IsLoading { get { return MtaClient.IsBrowserLoading(element); } }

        /// <summary>
        /// Get if this browser is currently focussed on
        /// </summary>
        public bool IsFocused { get { return MtaClient.IsBrowserFocused(element); } }

        /// <summary>
        /// Get the dx material of the browser, to render it in a Dx function.
        /// </summary>
        public BrowserMaterial Material { get { return material; } }

        /// <summary>
        /// Set the volume of this browser
        /// </summary>
        public float Volume { set { MtaClient.SetBrowserVolume(element, value); } }

        /// <summary>
        /// Set the rendering of this browser enabled or disabled
        /// </summary>
        public bool RenderingPaused { set { MtaClient.SetBrowserRenderingPaused(element, value); } }

        /// <summary>
        /// Set the devtools for this browser
        /// </summary>
        public bool DevTools { set { MtaClient.ToggleBrowserDevTools(element, value); } }

        #endregion

        #region fields
        private readonly BrowserMaterial material;

        #endregion

        #region Constructors

        [EditorBrowsable(EditorBrowsableState.Never)]
        public Browser(MtaElement element) : base(element)
        {
            material = new BrowserMaterial(this);
        }

        /// <summary>
        /// Create a browser from the createBrowser parameters
        /// </summary>
        public Browser(int width, int height, bool isLocal, bool transparent = false)
            : this(MtaClient.CreateBrowser(width, height, isLocal, transparent)) { }

        #endregion

        #region Methods

        /// <summary>
        /// Reload the page of this browser
        /// </summary>
        public bool ReloadPage()
        {
            return MtaClient.ReloadBrowserPage(element);
        }

        /// <summary>
        /// Load a specific browser URL
        /// </summary>
        public bool LoadUrl(string url, string postData = null, bool urlEncoded = true)
        {
            return MtaClient.LoadBrowserURL(element, url, postData, urlEncoded);
        }

        /// <summary>
        /// Focus on this browser
        /// </summary>
        public bool Focus()
        {
            return MtaClient.FocusBrowser(element);
        }

        /// <summary>
        /// Get a specific browser property
        /// </summary>
        public dynamic GetProperty(string key)
        {
            return MtaClient.GetBrowserProperty(element, key);
        }

        /// <summary>
        /// Inject a mousedown event in the browser
        /// </summary>
        public bool InjectMouseDown(MouseButton mouseButton)
        {
            return MtaClient.InjectBrowserMouseDown(element, mouseButton.ToString("f").ToLower());
        }

        /// <summary>
        /// Inject a mouseup event in the browser
        /// </summary>
        public bool InjectMouseUp(MouseButton mouseButton)
        {
            return MtaClient.InjectBrowserMouseUp(element, mouseButton.ToString("f").ToLower());
        }

        /// <summary>
        /// Inject a mousemove event to a specific position
        /// </summary>
        public bool InjectMouseMove(Vector2 position)
        {
            return MtaClient.InjectBrowserMouseMove(element, (int)position.X, (int)position.Y);
        }

        /// <summary>
        /// Inject a mouse scroll event
        /// </summary>
        public bool InjectMouseWheel(int vertical, int horizontal)
        {
            return MtaClient.InjectBrowserMouseWheel(element, vertical, horizontal);
        }

        /// <summary>
        /// Resize the browser to specific dimensions
        /// </summary>
        public bool Resize(Vector2 dimensions)
        {
            return MtaClient.ResizeBrowser(element, dimensions.X, dimensions.Y);
        }

        /// <summary>
        /// Execute some javascript code
        /// </summary>
        public bool ExecuteJavascript(string javascript)
        {
            return MtaClient.ExecuteBrowserJavascript(element, javascript);
        }

        /// <summary>
        /// Execute a javascript function using formatted js arguments
        /// </summary>
        public bool ExecuteJavascript(string function, IEnumerable<JavascriptVariable> arguments)
        {
            string javascriptString = function + "(";

            foreach (JavascriptVariable argument in arguments)
            {
                javascriptString += argument.ToString() + ", ";
            }
            javascriptString = javascriptString.Substring(0, javascriptString.Length - 2);

            javascriptString += ")";
            return ExecuteJavascript(javascriptString);
        }

        #endregion

        #region Static Methods

        /// <summary>
        /// Check if a specific domain is blocked
        /// </summary>
        public static bool IsDomainBlocked(string domain, bool isURL = false)
        {
            return MtaClient.IsBrowserDomainBlocked(domain, isURL);
        }

        /// <summary>
        /// Opens a request window in order to accept the requested remote URLs
        /// </summary>
        public static bool RequestDomains(string[] domains, bool isURL = false)
        {
            return MtaClient.RequestBrowserDomains(domains, isURL, HandleDomainRequest);
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

        #endregion

        #region Events

        #pragma warning disable 67

        public delegate void OnCreatedHandler(Browser source, OnCreatedEventArgs eventArgs);
        public event OnCreatedHandler OnCreated;

        public delegate void OnCursorChangeHandler(Browser source, OnCursorChangeEventArgs eventArgs);
        public event OnCursorChangeHandler OnCursorChange;

        public delegate void OnDocumentReadyHandler(Browser source, OnDocumentReadEventArgs eventArgs);
        public event OnDocumentReadyHandler OnDocumentReady;

        public delegate void OnInputFocusChangeHandler(Browser source, OnInputFocusChangeEventArgs eventArgs);
        public event OnInputFocusChangeHandler OnInputFocusChange;

        public delegate void OnLoadFailHandler(Browser source, OnLoadFailEventArgs eventArgs);
        public event OnLoadFailHandler OnLoadFail;

        public delegate void OnLoadStartHandler(Browser source, OnLoadStartEventArgs eventArgs);
        public event OnLoadStartHandler OnLoadStart;

        public delegate void OnNavigateHandler(Browser source, OnNavigateEventArgs eventArgs);
        public event OnNavigateHandler OnNavigate;

        public delegate void OnPopupHandler(Browser source, OnPopupEventArgs eventArgs);
        public event OnPopupHandler OnPopup;

        public delegate void OnResourceBlockedHandler(Browser source, OnResourceBlockedEventArgs eventArgs);
        public event OnResourceBlockedHandler OnResourceBlocked;

        public delegate void OnTooltipHandler(Browser source, OnTooltipEventArgs eventArgs);
        public event OnTooltipHandler OnTooltip;

        public delegate void OnWhiteListChangeHandler(RootElement source, OnWhiteListChangeEventArgs eventArgs);
        public static event OnWhiteListChangeHandler OnWhiteListChange;

#pragma warning restore 67

        #endregion
    }
}
