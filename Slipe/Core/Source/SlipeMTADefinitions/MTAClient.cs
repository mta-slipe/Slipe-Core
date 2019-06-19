using System;

namespace Slipe.MtaDefinitions {
	public class MtaClient {
		public static bool PlaySoundFrontEnd (int sound){ throw new NotImplementedException(); }
		public static MtaElement CreateBlip (float x, float y, float z, int icon, int size, int r, int g, int b, int a, int ordering, float visibleDistance){ throw new NotImplementedException(); }
		public static MtaElement CreateBlipAttachedTo (MtaElement elementToAttachTo, int icon, int size, int r, int g, int b, int a, int ordering, float visibleDistance){ throw new NotImplementedException(); }
		public static bool FadeCamera (bool fadeIn, float timeToFade, int red, int green, int blue){ throw new NotImplementedException(); }
		public static int GetCameraInterior (){ throw new NotImplementedException(); }
		public static MtaElement GetCameraTarget (){ throw new NotImplementedException(); }
		public static bool SetCameraTarget (MtaElement target){ throw new NotImplementedException(); }
		public static Tuple<float, float, float, float, float, float, float, float> GetCameraMatrix (){ throw new NotImplementedException(); }
		public static bool SetCameraInterior (int interior){ throw new NotImplementedException(); }
		public static bool SetCameraMatrix (float positionX, float positionY, float positionZ, float lookAtX, float lookAtY, float lookAtZ, float roll, float fov){ throw new NotImplementedException(); }
		public static bool IsCursorShowing (){ throw new NotImplementedException(); }
		public static bool ShowCursor (bool show, bool toggleControls){ throw new NotImplementedException(); }
		public static dynamic GetElementsByType (string theType, MtaElement startat, bool streamedIn){ throw new NotImplementedException(); }
		public static bool CancelEvent (){ throw new NotImplementedException(); }
		public static bool CancelLatentEvent (int handle){ throw new NotImplementedException(); }
		public static dynamic GetLatentEventStatus (int handle){ throw new NotImplementedException(); }
		public static dynamic GetLatentEventHandles (){ throw new NotImplementedException(); }
		public static bool CreateExplosion (float x, float y, float z, int theType, bool makeSound, float camShake){ throw new NotImplementedException(); }
        public static bool BindKey(string key, string keyState, string command) { throw new NotImplementedException(); }
        public static bool BindKey(string key, string keyState, Action<string, string> handlerFunction) { throw new NotImplementedException(); }
        public static bool AddCommandHandler (string commandName, Action<string, string[]> handlerFunction, bool caseSensitive){ throw new NotImplementedException(); }
		public static bool ExecuteCommandHandler (string commandName, string args){ throw new NotImplementedException(); }
		public static dynamic GetFunctionsBoundToKey (string key, string keyState){ throw new NotImplementedException(); }
		public static string GetKeyBoundToFunction (dynamic theFunction){ throw new NotImplementedException(); }
		public static bool IsControlEnabled (string control){ throw new NotImplementedException(); }
		public static bool ToggleAllControls (bool enabled, bool gtaControls, bool mtaControls){ throw new NotImplementedException(); }
		public static bool ToggleControl (string control, bool enabled){ throw new NotImplementedException(); }
        public static bool UnbindKey(string key, string keyState, string command) { throw new NotImplementedException(); }
        public static bool UnbindKey(string key, string keyState, Action<string, string> handlerFunction) { throw new NotImplementedException(); }
        public static MtaElement CreateMarker (float x, float y, float z, string theType, float size, int r, int g, int b, int a){ throw new NotImplementedException(); }
		public static bool OutputChatBox (string text, int r, int g, int b, bool colorCoded){ throw new NotImplementedException(); }
		public static bool ClearChatBox (){ throw new NotImplementedException(); }
		public static bool OutputConsole (string text){ throw new NotImplementedException(); }
		public static bool ShowChat (bool show){ throw new NotImplementedException(); }
		public static MtaElement CreatePed (int modelid, float x, float y, float z, float rot){ throw new NotImplementedException(); }
		public static bool ForcePlayerMap (bool forceOn){ throw new NotImplementedException(); }
		public static int GetPlayerBlurLevel (){ throw new NotImplementedException(); }
		public static int GetPlayerMoney (){ throw new NotImplementedException(); }
		public static int GetPlayerWantedLevel (){ throw new NotImplementedException(); }
		public static bool GivePlayerMoney (int amount){ throw new NotImplementedException(); }
		public static bool IsPlayerMapForced (){ throw new NotImplementedException(); }
		public static bool SetPlayerBlurLevel (int level){ throw new NotImplementedException(); }
		public static bool SetPlayerHudComponentVisible (string component, bool show){ throw new NotImplementedException(); }
		public static bool SetPlayerMoney (int amount, bool instant){ throw new NotImplementedException(); }
		public static bool TakePlayerMoney (int amount){ throw new NotImplementedException(); }
		public static bool DetonateSatchels (){ throw new NotImplementedException(); }
		public static dynamic GetNetworkStats (){ throw new NotImplementedException(); }
        public static MtaElement CreateVehicle(int model, float x, float y, float z, float rx, float ry, float rz, string numberplate, int variant1, int variant2) { throw new NotImplementedException(); }
        public static bool BlowVehicle (MtaElement vehicleToBlow){ throw new NotImplementedException(); }
		public static bool DgsProgressBarSetProgress (MtaElement theProgressbar, float progress){ throw new NotImplementedException(); }
		public static string GetRadioChannelName (int id){ throw new NotImplementedException(); }
		public static bool GetSFXStatus (string audioContainer){ throw new NotImplementedException(); }
		public static int GetSoundBPM (MtaElement sound){ throw new NotImplementedException(); }
		public static int GetRadioChannel (){ throw new NotImplementedException(); }
		public static dynamic GetSoundEffects (MtaElement sound){ throw new NotImplementedException(); }
		public static dynamic GetSoundFFTData (MtaElement sound, int iSamples, int iBands){ throw new NotImplementedException(); }
		public static float GetSoundLength (MtaElement theSound){ throw new NotImplementedException(); }
		public static dynamic GetSoundMetaTags (MtaElement sound, string format){ throw new NotImplementedException(); }
		public static int GetSoundMaxDistance (MtaElement sound){ throw new NotImplementedException(); }
		public static float GetSoundBufferLength (MtaElement theSound){ throw new NotImplementedException(); }
		public static Tuple<int, int> GetSoundLevelData (MtaElement theSound){ throw new NotImplementedException(); }
		public static int GetSoundMinDistance (MtaElement sound){ throw new NotImplementedException(); }
		public static float GetSoundPan (MtaElement theSound){ throw new NotImplementedException(); }
		public static float GetSoundSpeed (MtaElement theSound){ throw new NotImplementedException(); }
		public static float GetSoundPosition (MtaElement theSound){ throw new NotImplementedException(); }
		public static Tuple<float, float, float, bool> GetSoundProperties (MtaElement sound){ throw new NotImplementedException(); }
		public static float GetSoundVolume (MtaElement theSound){ throw new NotImplementedException(); }
		public static bool IsSoundPanningEnabled (MtaElement theSound){ throw new NotImplementedException(); }
		public static dynamic GetSoundWaveData (MtaElement sound, int iSamples){ throw new NotImplementedException(); }
		public static bool IsSoundPaused (MtaElement theSound){ throw new NotImplementedException(); }
		public static MtaElement PlaySFX3D (string containerName, int bankId, int soundId, float x, float y, float z, bool looped){ throw new NotImplementedException(); }
        public static MtaElement PlaySFX3D(string containerName, string radioStation, int trackId, float x, float y, float z, bool looped) { throw new NotImplementedException(); }
        public static bool SetRadioChannel (int ID){ throw new NotImplementedException(); }
		public static MtaElement PlaySound (string soundPath, bool looped, bool throttled){ throw new NotImplementedException(); }
		public static MtaElement PlaySFX (string containerName, int bankId, int soundId, bool looped){ throw new NotImplementedException(); }
        public static MtaElement PlaySFX(string containerName, string radioStation, int trackId, bool looped) { throw new NotImplementedException(); }
        public static MtaElement PlaySound3D (string soundPath, float x, float y, float z, bool looped, bool throttled){ throw new NotImplementedException(); }
		public static bool SetSoundMaxDistance (MtaElement sound, int distance){ throw new NotImplementedException(); }
		public static bool SetSoundEffectEnabled (MtaElement sound, string effectName, bool bEnable){ throw new NotImplementedException(); }
		public static bool SetSoundMinDistance (MtaElement sound, int distance){ throw new NotImplementedException(); }
		public static bool SetSoundPanningEnabled (MtaElement sound, bool enable){ throw new NotImplementedException(); }
		public static bool SetSoundPaused (MtaElement theSound, bool paused){ throw new NotImplementedException(); }
		public static bool SetSoundPan (MtaElement theSound, float pan){ throw new NotImplementedException(); }
		public static bool SetSoundPosition (MtaElement theSound, float pos){ throw new NotImplementedException(); }
		public static bool SetSoundProperties (MtaElement sound, float fSampleRate, float fTempo, float fPitch, bool bReverse){ throw new NotImplementedException(); }
		public static bool SetSoundSpeed (MtaElement theSound, float speed){ throw new NotImplementedException(); }
		public static bool StopSound (MtaElement theSound){ throw new NotImplementedException(); }
		public static bool SetSoundVolume (MtaElement theSound, float volume){ throw new NotImplementedException(); }
		public static bool CanBrowserNavigateBack (MtaElement webBrowser){ throw new NotImplementedException(); }
		public static bool ExecuteBrowserJavascript (MtaElement webBrowser, string jsCode){ throw new NotImplementedException(); }
		public static bool FocusBrowser (MtaElement webBrowser){ throw new NotImplementedException(); }
		public static bool GetBrowserProperty (MtaElement theBrowser, string key){ throw new NotImplementedException(); }
		public static dynamic GetBrowserSettings (){ throw new NotImplementedException(); }
		public static MtaElement CreateBrowser (int width, int height, bool isLocal, bool transparent){ throw new NotImplementedException(); }
		public static string GetBrowserTitle (MtaElement webBrowser){ throw new NotImplementedException(); }
		public static bool GetBrowserSource (MtaElement webBrowser, dynamic callback){ throw new NotImplementedException(); }
		public static string GetBrowserURL (MtaElement webBrowser){ throw new NotImplementedException(); }
		public static bool CanBrowserNavigateForward (MtaElement webBrowser){ throw new NotImplementedException(); }
		public static bool InjectBrowserMouseMove (MtaElement webBrowser, int posX, int posY){ throw new NotImplementedException(); }
		public static bool IsBrowserDomainBlocked (string address, bool isURL){ throw new NotImplementedException(); }
		public static bool InjectBrowserMouseDown (MtaElement webBrowser, string mouseButton){ throw new NotImplementedException(); }
		public static bool IsBrowserLoading (MtaElement webBrowser){ throw new NotImplementedException(); }
		public static bool IsBrowserFocused (MtaElement webBrowser){ throw new NotImplementedException(); }
		public static bool InjectBrowserMouseUp (MtaElement webBrowser, string mouseButton){ throw new NotImplementedException(); }
		public static bool NavigateBrowserBack (MtaElement webBrowser){ throw new NotImplementedException(); }
		public static bool InjectBrowserMouseWheel (MtaElement webBrowser, int verticalScroll, int horizontalScroll){ throw new NotImplementedException(); }
		public static bool LoadBrowserURL (MtaElement webBrowser, string url, string postData, bool urlEncoded){ throw new NotImplementedException(); }
		public static bool ResizeBrowser (MtaElement webBrowser, float width, float height){ throw new NotImplementedException(); }
		public static bool SetBrowserAjaxHandler (MtaElement webBrowser, string url, dynamic handler){ throw new NotImplementedException(); }
		public static bool NavigateBrowserForward (MtaElement webBrowser){ throw new NotImplementedException(); }
		public static bool ReloadBrowserPage (MtaElement webBrowser){ throw new NotImplementedException(); }
		public static bool ToggleBrowserDevTools (MtaElement webBrowser, bool visible){ throw new NotImplementedException(); }
		public static bool RequestBrowserDomains (dynamic pages, bool parseAsURL, Action<bool, string[]> callback){ throw new NotImplementedException(); }
		public static bool SetBrowserRenderingPaused (MtaElement webBrowser, bool paused){ throw new NotImplementedException(); }
		public static Tuple<bool, bool> GetCameraClip (){ throw new NotImplementedException(); }
		public static MtaElement GetCamera (){ throw new NotImplementedException(); }
		public static MtaElement GuiCreateBrowser (float x, float y, float width, float height, bool isLocal, bool isTransparent, bool isRelative, MtaElement parent){ throw new NotImplementedException(); }
		public static bool SetBrowserProperty (MtaElement theBrowser, string key, string value){ throw new NotImplementedException(); }
		public static MtaElement GuiGetBrowser (MtaElement theBrowser){ throw new NotImplementedException(); }
		public static bool SetBrowserVolume (MtaElement webBrowser, float volume){ throw new NotImplementedException(); }
		public static float GetCameraFieldOfView (string cameraMode){ throw new NotImplementedException(); }
		public static bool SetCameraClip (bool objects, bool vehicles){ throw new NotImplementedException(); }
		public static string GetCameraGoggleEffect (){ throw new NotImplementedException(); }
		public static int GetCameraShakeLevel (){ throw new NotImplementedException(); }
		public static int GetCameraViewMode (){ throw new NotImplementedException(); }
		public static bool SetCameraFieldOfView (string cameraMode, float fieldOfView){ throw new NotImplementedException(); }
		public static bool SetCameraGoggleEffect (string goggleEffect, bool noiseEnabled){ throw new NotImplementedException(); }
		public static bool SetCameraShakeLevel (int shakeLevel){ throw new NotImplementedException(); }
		public static bool SetCameraViewMode (int viewMode){ throw new NotImplementedException(); }
		public static int GetCursorAlpha (){ throw new NotImplementedException(); }
		public static Tuple<float, float, float, float, float> GetCursorPosition (){ throw new NotImplementedException(); }
		public static bool SetCursorPosition (int cursorX, int cursorY){ throw new NotImplementedException(); }
		public static string DxConvertPixels (string pixels, string newFormat, int quality){ throw new NotImplementedException(); }
		public static MtaElement DxCreateRenderTarget (int width, int height, bool withAlpha){ throw new NotImplementedException(); }
		public static MtaElement DxCreateScreenSource (int width, int height){ throw new NotImplementedException(); }
		public static MtaElement DxCreateFont (string filepath, int size, bool bold, string quality){ throw new NotImplementedException(); }
		public static bool SetCursorAlpha (int alpha){ throw new NotImplementedException(); }
		public static Tuple<MtaElement, string> DxCreateShader (string filepath, float priority, float maxDistance, bool layered, string elementTypes){ throw new NotImplementedException(); }
		public static MtaElement DxCreateTexture (string pixels, string textureFormat, bool mipmaps, string textureEdge){ throw new NotImplementedException(); }
		public static bool DxDrawCircle (float posX, float posY, float radius, float startAngle, float stopAngle, int theColor, int theCenterColor, int segments, int ratio, bool postGUI){ throw new NotImplementedException(); }
		public static bool DxDrawMaterialSectionLine3D (float startX, float startY, float startZ, float endX, float endY, float endZ, float u, float v, float usize, float vsize, MtaElement material, float width, int color, bool postGUI, float faceTowardX, float faceTowardY, float faceTowardZ){ throw new NotImplementedException(); }
		public static bool DxDrawImage (float posX, float posY, float width, float height, dynamic image, float rotation, float rotationCenterOffsetX, float rotationCenterOffsetY, int color){ throw new NotImplementedException(); }
		public static bool DxDrawMaterialLine3D (float startX, float startY, float startZ, float endX, float endY, float endZ, MtaElement material, float width, int color, bool postGUI, float faceTowardX, float faceTowardY, float faceTowardZ){ throw new NotImplementedException(); }
		public static bool DxDrawMaterialPrimitive (MtaElement pType, dynamic material, bool postGUI, dynamic vertice1, dynamic vertice2){ throw new NotImplementedException(); }
		public static bool DxDrawRectangle (float startX, float startY, float width, float height, int color, bool postGUI, bool subPixelPositioning){ throw new NotImplementedException(); }
		public static bool DxDrawPrimitive (string pType, bool postGUI, dynamic vertice1, dynamic vertice2){ throw new NotImplementedException(); }
		public static bool DxDrawText (string text, float left, float top, float right, float bottom, int color, float scaleXY, float scaleY, dynamic font, string alignX, string alignY, bool clip, bool wordBreak, bool postGUI, bool colorCoded, bool subPixelPositioning, float fRotation, float fRotationCenterX, float fRotationCenterY){ throw new NotImplementedException(); }
		public static string DxGetBlendMode (){ throw new NotImplementedException(); }
		public static int DxGetFontHeight (float scale, dynamic font){ throw new NotImplementedException(); }
		public static Tuple<int, int> DxGetPixelsSize (string pixels){ throw new NotImplementedException(); }
		public static Tuple<int, int, int, int> DxGetPixelColor (string pixels, int x, int y){ throw new NotImplementedException(); }
		public static string DxGetPixelsFormat (string pixels){ throw new NotImplementedException(); }
		public static dynamic DxGetStatus (){ throw new NotImplementedException(); }
		public static bool DxSetAspectRatioAdjustmentEnabled (bool bEnabled, float sourceRatio){ throw new NotImplementedException(); }
		public static float DxGetTextWidth (string text, float scale, dynamic font, bool bColorCoded){ throw new NotImplementedException(); }
		public static bool DxSetBlendMode (string blendMode){ throw new NotImplementedException(); }
		public static Tuple<int, int, dynamic, dynamic> DxGetMaterialSize (MtaElement material){ throw new NotImplementedException(); }
		public static bool DxSetRenderTarget (MtaElement renderTarget, bool clear){ throw new NotImplementedException(); }
		public static bool DxSetPixelColor (string pixels, int x, int y, int r, int g, int b, int a){ throw new NotImplementedException(); }
		public static string DxGetTexturePixels (int surfaceIndex, MtaElement texture, int x, int y, int width, int height){ throw new NotImplementedException(); }
		public static bool DxSetShaderValue (MtaElement theShader, string parameterName, dynamic value){ throw new NotImplementedException(); }
		public static bool DxSetTestMode (string testMode){ throw new NotImplementedException(); }
		public static bool DxSetShaderTransform (MtaElement theShader, float rotationX, float rotationY, float rotationZ, float rotationCenterOffsetX, float rotationCenterOffsetY, float rotationCenterOffsetZ, bool bRotationCenterOffsetOriginIsScreen, float perspectiveCenterOffsetX, float perspectiveCenterOffsetY, bool bPerspectiveCenterOffsetOriginIsScreen){ throw new NotImplementedException(); }
		public static bool DxSetShaderTessellation (MtaElement theShader, int tessellationX, int tessellationY){ throw new NotImplementedException(); }
		public static bool DxDrawLine3D (float startX, float startY, float startZ, float endX, float endY, float endZ, int color, float width, bool postGUI){ throw new NotImplementedException(); }
		public static bool DxSetTextureEdge (MtaElement theTexture, string textureEdge, int border){ throw new NotImplementedException(); }
		public static bool DxDrawLine (int startX, int startY, int endX, int endY, int color, float width, bool postGUI){ throw new NotImplementedException(); }
		public static bool DxDrawImageSection (float posX, float posY, float width, float height, float u, float v, float usize, float vsize, dynamic image, float rotation, float rotationCenterOffsetX, float rotationCenterOffsetY, int color, bool postGUI){ throw new NotImplementedException(); }
		public static bool FxAddBlood (float posX, float posY, float posZ, float dirX, float dirY, float dirZ, int count, float brightness){ throw new NotImplementedException(); }
		public static bool DxUpdateScreenSource (MtaElement screenSource, bool resampleNow){ throw new NotImplementedException(); }
		public static MtaElement CreateEffect (string name, float x, float y, float z, float rX, float rY, float rZ, float drawDistance, bool soundEnable){ throw new NotImplementedException(); }
		public static bool DxSetTexturePixels (int surfaceIndex, MtaElement texture, string pixels, int x, int y, int width, int height){ throw new NotImplementedException(); }
		public static bool FxAddBulletImpact (float posX, float posY, float posZ, float dirX, float dirY, float dirZ, int smokeSize, int sparkCount, float smokeIntensity){ throw new NotImplementedException(); }
		public static bool FxAddBulletSplash (float posX, float posY, float posZ){ throw new NotImplementedException(); }
		public static bool FxAddDebris (float posX, float posY, float posZ, int colorR, int colorG, int colorB, int colorA, float scale, int count){ throw new NotImplementedException(); }
		public static bool FxAddFootSplash (float posX, float posY, float posZ){ throw new NotImplementedException(); }
		public static bool FxAddGunshot (float posX, float posY, float posZ, float dirX, float dirY, float dirZ, bool includeSparks){ throw new NotImplementedException(); }
		public static bool FxAddGlass (float posX, float posY, float posZ, int colorR, int colorG, int colorB, int colorA, float scale, int count){ throw new NotImplementedException(); }
		public static bool FxAddPunchImpact (float posX, float posY, float posZ, float dirX, float dirY, float dirZ){ throw new NotImplementedException(); }
		public static bool FxAddTyreBurst (float posX, float posY, float posZ, float dirX, float dirY, float dirZ){ throw new NotImplementedException(); }
		public static bool FxAddTankFire (float posX, float posY, float posZ, float dirX, float dirY, float dirZ){ throw new NotImplementedException(); }
		public static bool FxAddSparks (float posX, float posY, float posZ, float dirX, float dirY, float dirZ, float force, int count, float acrossLineX, float acrossLineY, float acrossLineZ, bool blur, float spread, float life){ throw new NotImplementedException(); }
		public static float GetEffectDensity (MtaElement theEffect){ throw new NotImplementedException(); }
		public static bool FxAddWaterSplash (float posX, float posY, float posZ){ throw new NotImplementedException(); }
		public static float GetEffectSpeed (MtaElement theEffect){ throw new NotImplementedException(); }
		public static bool SetEffectSpeed (MtaElement theEffect, float speed){ throw new NotImplementedException(); }
		public static bool SetEffectDensity (MtaElement theEffect, float density){ throw new NotImplementedException(); }
		public static bool FxAddWood (float posX, float posY, float posZ, float dirX, float dirY, float dirZ, int count, float brightness){ throw new NotImplementedException(); }
		public static bool FxAddWaterHydrant (float posX, float posY, float posZ){ throw new NotImplementedException(); }
		public static Tuple<float, float, float, float, float, float> GetElementBoundingBox (MtaElement theElement){ throw new NotImplementedException(); }
		public static float GetElementDistanceFromCentreOfMassToBaseOfModel (MtaElement theElement){ throw new NotImplementedException(); }
		public static float GetElementRadius (MtaElement theElement){ throw new NotImplementedException(); }
		public static bool IsElementCollidableWith (MtaElement theElement, MtaElement withElement){ throw new NotImplementedException(); }
		public static bool IsElementLocal (MtaElement theElement){ throw new NotImplementedException(); }
		public static bool IsElementOnScreen (MtaElement theElement){ throw new NotImplementedException(); }
		public static bool IsElementStreamable (MtaElement theElement){ throw new NotImplementedException(); }
		public static bool IsElementSyncer (MtaElement theElement){ throw new NotImplementedException(); }
		public static bool IsElementStreamedIn (MtaElement theElement){ throw new NotImplementedException(); }
		public static bool IsElementWaitingForGroundToLoad (MtaElement theElement){ throw new NotImplementedException(); }
		public static bool SetElementCollidableWith (MtaElement theElement, MtaElement withElement, bool enabled){ throw new NotImplementedException(); }
		public static bool SetElementMatrix (MtaElement theElement, dynamic theMatrix){ throw new NotImplementedException(); }
		public static bool SetElementStreamable (MtaElement theElement, bool streamable){ throw new NotImplementedException(); }
		public static int EngineGetModelIDFromName (string modelName){ throw new NotImplementedException(); }
		public static string EngineGetModelNameFromID (int modelID){ throw new NotImplementedException(); }
		public static float EngineGetModelLODDistance (int model){ throw new NotImplementedException(); }
		public static dynamic EngineGetModelTextureNames (string modelId){ throw new NotImplementedException(); }
		public static bool EngineImportTXD (MtaElement texture, int model_id){ throw new NotImplementedException(); }
		public static MtaElement EngineLoadCOL (string col_file){ throw new NotImplementedException(); }
		public static MtaElement EngineLoadDFF (string dff_file){ throw new NotImplementedException(); }
		public static MtaElement EngineLoadTXD (string txd_file, bool filteringEnabled){ throw new NotImplementedException(); }
		public static dynamic EngineGetVisibleTextureNames (string nameFilter, string modelId){ throw new NotImplementedException(); }
		public static bool EngineApplyShaderToWorldTexture (MtaElement shader, string textureName, MtaElement targetElement, bool appendLayers){ throw new NotImplementedException(); }
		public static MtaElement EngineLoadIFP (string ifp_file, string CustomBlockName){ throw new NotImplementedException(); }
		public static bool EngineReplaceAnimation (MtaElement thePed, string InternalBlockName, string InternalAnimName, string CustomBlockName, string CustomAnimName){ throw new NotImplementedException(); }
		public static bool EngineRemoveShaderFromWorldTexture (MtaElement shader, string textureName, MtaElement targetElement){ throw new NotImplementedException(); }
		public static bool EngineReplaceModel (MtaElement theModel, int modelID, bool alphaTransparency){ throw new NotImplementedException(); }
		public static bool EngineRestoreCOL (int modelID){ throw new NotImplementedException(); }
		public static bool EngineSetModelLODDistance (int model, float distance){ throw new NotImplementedException(); }
		public static bool EngineReplaceCOL (MtaElement theCol, int modelID){ throw new NotImplementedException(); }
		public static bool EngineRestoreModel (int modelID){ throw new NotImplementedException(); }
		public static bool EngineRestoreAnimation (MtaElement thePed, string InternalBlockName, string InternalAnimName){ throw new NotImplementedException(); }
		public static bool EngineSetAsynchronousLoading (bool enable, bool force){ throw new NotImplementedException(); }
		public static dynamic EngineResetSurfaceProperties (int surfaceID){ throw new NotImplementedException(); }
		public static bool EngineSetSurfaceProperties (int surfaceID, string property, dynamic value){ throw new NotImplementedException(); }
		public static dynamic EngineGetSurfaceProperties (int surfaceID, string property){ throw new NotImplementedException(); }
		public static bool TriggerLatentServerEvent (string argument_event, int bandwidth, bool persist, MtaElement theElement, dynamic arguments) { throw new NotImplementedException(); }
		public static bool TriggerServerEvent (string eventName, MtaElement sourceElement, dynamic arguments){ throw new NotImplementedException(); }
		public static bool ExtinguishFire (float x, float y, float z, float radius){ throw new NotImplementedException(); }
		public static bool CreateFire (float x, float y, float z, float size){ throw new NotImplementedException(); }
		public static dynamic GetChatboxLayout (string CVar){ throw new NotImplementedException(); }
		public static bool GuiBringToFront (MtaElement guiElement){ throw new NotImplementedException(); }
		public static MtaElement GuiCreateFont (string filepath, int size){ throw new NotImplementedException(); }
		public static bool GuiBlur (MtaElement guiElement){ throw new NotImplementedException(); }
		public static float GuiGetAlpha (MtaElement guiElement){ throw new NotImplementedException(); }
		public static bool GuiFocus (MtaElement guiElement){ throw new NotImplementedException(); }
		public static Tuple<string, MtaElement> GuiGetFont (MtaElement guiElement){ throw new NotImplementedException(); }
		public static bool GuiGetInputEnabled (){ throw new NotImplementedException(); }
		public static string GuiGetCursorType (){ throw new NotImplementedException(); }
		public static Tuple<float, float> GuiGetPosition (MtaElement guiElement, bool relative){ throw new NotImplementedException(); }
		public static bool GuiGetEnabled (MtaElement guiElement){ throw new NotImplementedException(); }
		public static string GuiGetInputMode (){ throw new NotImplementedException(); }
		public static string GuiGetProperty (MtaElement guiElement, string property){ throw new NotImplementedException(); }
		public static dynamic GuiGetProperties (MtaElement guiElement){ throw new NotImplementedException(); }
		public static Tuple<float, float> GuiGetScreenSize (){ throw new NotImplementedException(); }
		public static Tuple<float, float> GuiGetSize (MtaElement theElement, bool relative){ throw new NotImplementedException(); }
		public static bool GuiGetVisible (MtaElement guiElement){ throw new NotImplementedException(); }
		public static bool GuiSetFont (MtaElement guiElement, dynamic font){ throw new NotImplementedException(); }
		public static bool GuiSetEnabled (MtaElement guiElement, bool enabled){ throw new NotImplementedException(); }
		public static bool GuiSetAlpha (MtaElement guielement, float alpha){ throw new NotImplementedException(); }
		public static string GuiGetText (MtaElement guiElement){ throw new NotImplementedException(); }
		public static bool GuiSetInputEnabled (bool enabled){ throw new NotImplementedException(); }
		public static bool GuiMoveToBack (MtaElement guiElement){ throw new NotImplementedException(); }
		public static bool GuiSetInputMode (string mode){ throw new NotImplementedException(); }
		public static bool GuiSetPosition (MtaElement theElement, float x, float y, bool relative){ throw new NotImplementedException(); }
		public static bool GuiSetProperty (MtaElement guiElement, string property, string value){ throw new NotImplementedException(); }
		public static bool IsChatBoxInputActive (){ throw new NotImplementedException(); }
		public static bool GuiSetVisible (MtaElement guiElement, bool state){ throw new NotImplementedException(); }
		public static bool GuiSetSize (MtaElement guiElement, float width, float height, bool relative){ throw new NotImplementedException(); }
		public static bool GuiSetText (MtaElement guiElement, string text){ throw new NotImplementedException(); }
		public static bool IsConsoleActive (){ throw new NotImplementedException(); }
		public static bool IsMainMenuActive (){ throw new NotImplementedException(); }
		public static bool IsDebugViewActive (){ throw new NotImplementedException(); }
		public static bool IsMTAWindowActive (){ throw new NotImplementedException(); }
		public static bool SetDebugViewActive (bool enabled){ throw new NotImplementedException(); }
		public static bool IsTransferBoxActive (){ throw new NotImplementedException(); }
		public static MtaElement GuiCreateButton (float x, float y, float width, float height, string text, bool relative, MtaElement parent){ throw new NotImplementedException(); }
		public static bool GuiCheckBoxGetSelected (MtaElement theCheckbox){ throw new NotImplementedException(); }
		public static bool GuiCheckBoxSetSelected (MtaElement theCheckbox, bool state){ throw new NotImplementedException(); }
		public static MtaElement GuiCreateCheckBox (float x, float y, float width, float height, string text, bool selected, bool relative, MtaElement parent){ throw new NotImplementedException(); }
		public static string GuiComboBoxGetItemText (MtaElement comboBox, int itemId){ throw new NotImplementedException(); }
		public static int GuiComboBoxGetItemCount (MtaElement comboBox){ throw new NotImplementedException(); }
		public static int GuiComboBoxAddItem (MtaElement comboBox, string value){ throw new NotImplementedException(); }
		public static MtaElement GuiCreateComboBox (float x, float y, float width, float height, string caption, bool relative, MtaElement parent){ throw new NotImplementedException(); }
		public static bool GuiComboBoxClear (MtaElement comboBox){ throw new NotImplementedException(); }
		public static int GuiComboBoxGetSelected (MtaElement comboBox){ throw new NotImplementedException(); }
		public static bool GuiComboBoxIsOpen (MtaElement comboBox){ throw new NotImplementedException(); }
		public static bool GuiComboBoxSetItemText (MtaElement comboBox, int itemId, string text){ throw new NotImplementedException(); }
		public static bool GuiEditIsMasked (MtaElement guiEdit){ throw new NotImplementedException(); }
		public static bool GuiEditIsReadOnly (MtaElement guiEdit){ throw new NotImplementedException(); }
		public static int GuiEditGetCaretIndex (MtaElement theElement){ throw new NotImplementedException(); }
		public static bool GuiEditSetMasked (MtaElement theElement, bool status){ throw new NotImplementedException(); }
		public static int GuiEditGetMaxLength (MtaElement guiEdit){ throw new NotImplementedException(); }
		public static bool GuiEditSetCaretIndex (MtaElement theElement, int index){ throw new NotImplementedException(); }
		public static bool GuiComboBoxRemoveItem (MtaElement comboBox, int itemId){ throw new NotImplementedException(); }
		public static int GuiGridListAddRow (MtaElement gridList, dynamic itemText1, dynamic itemText2){ throw new NotImplementedException(); }
		public static MtaElement GuiCreateGridList (float x, float y, float width, float height, bool relative, MtaElement parent){ throw new NotImplementedException(); }
		public static int GuiGridListAddColumn (MtaElement gridList, string title, float width){ throw new NotImplementedException(); }
		public static bool GuiEditSetReadOnly (MtaElement editField, bool status){ throw new NotImplementedException(); }
		public static bool GuiGridListClear (MtaElement gridList){ throw new NotImplementedException(); }
		public static bool GuiEditSetMaxLength (MtaElement guiEdit, int length){ throw new NotImplementedException(); }
		public static bool GuiGridListAutoSizeColumn (MtaElement gridList, int columnIndex){ throw new NotImplementedException(); }
		public static int GuiGridListGetColumnCount (MtaElement gridList){ throw new NotImplementedException(); }
		public static string GuiGridListGetColumnTitle (MtaElement guiGridlist, int columnIndex){ throw new NotImplementedException(); }
		public static float GuiGridListGetColumnWidth (MtaElement gridList, int columnIndex, bool relative){ throw new NotImplementedException(); }
		public static Tuple<int, int, int, int> GuiGridListGetItemColor (MtaElement gridList, int rowIndex, int columnIndex){ throw new NotImplementedException(); }
		public static string GuiGridListGetItemText (MtaElement gridList, int rowIndex, int columnIndex){ throw new NotImplementedException(); }
		public static int GuiGridListGetRowCount (MtaElement gridList){ throw new NotImplementedException(); }
		public static float GuiGridListGetHorizontalScrollPosition (MtaElement guiGridlist){ throw new NotImplementedException(); }
		public static dynamic GuiGridListGetItemData (MtaElement gridList, int rowIndex, int columnIndex){ throw new NotImplementedException(); }
		public static Tuple<int, int> GuiGridListGetSelectedItem (MtaElement gridList){ throw new NotImplementedException(); }
		public static int GuiGridListGetSelectedCount (MtaElement gridList){ throw new NotImplementedException(); }
		public static float GuiGridListGetVerticalScrollPosition (MtaElement guiGridlist){ throw new NotImplementedException(); }
		public static bool GuiGridListRemoveRow (MtaElement gridList, int rowIndex){ throw new NotImplementedException(); }
		public static int GuiGridListInsertRowAfter (MtaElement gridList, int rowIndex){ throw new NotImplementedException(); }
		public static dynamic GuiGridListGetSelectedItems (MtaElement gridList){ throw new NotImplementedException(); }
		public static bool GuiGridListSetColumnWidth (MtaElement gridList, int columnIndex, float width, bool relative){ throw new NotImplementedException(); }
		public static bool GuiGridListSetColumnTitle (MtaElement guiGridlist, int columnIndex, string title){ throw new NotImplementedException(); }
		public static bool GuiGridListRemoveColumn (MtaElement gridList, int columnIndex){ throw new NotImplementedException(); }
		public static bool GuiGridListSetItemColor (MtaElement gridList, int rowIndex, int columnIndex, int red, int green, int blue, int alpha){ throw new NotImplementedException(); }
		public static bool GuiGridListSetItemData (MtaElement gridList, int rowIndex, int columnIndex, dynamic data){ throw new NotImplementedException(); }
		public static bool GuiGridListSetHorizontalScrollPosition (MtaElement guiGridlist, float fPosition){ throw new NotImplementedException(); }
		public static bool GuiGridListSetScrollBars (MtaElement guiGridlist, bool horizontalBar, bool verticalBar){ throw new NotImplementedException(); }
		public static int GuiMemoGetCaretIndex (MtaElement theElement){ throw new NotImplementedException(); }
		public static bool GuiGridListSetVerticalScrollPosition (MtaElement guiGridlist, float fPosition){ throw new NotImplementedException(); }
		public static float GuiMemoGetVerticalScrollPosition (MtaElement theMemo){ throw new NotImplementedException(); }
		public static bool GuiGridListSetItemText (MtaElement gridList, int rowIndex, int columnIndex, string text, bool section, bool number){ throw new NotImplementedException(); }
		public static bool GuiGridListSetSortingEnabled (MtaElement guiGridlist, bool enabled){ throw new NotImplementedException(); }
		public static bool GuiMemoSetVerticalScrollPosition (MtaElement theMemo, float position){ throw new NotImplementedException(); }
		public static bool GuiGridListSetSelectedItem (MtaElement gridList, int rowIndex, int columnIndex, bool bReset){ throw new NotImplementedException(); }
		public static MtaElement GuiCreateMemo (float x, float y, float width, float height, string text, bool relative, MtaElement parent){ throw new NotImplementedException(); }
		public static bool GuiGridListSetSelectionMode (MtaElement gridlist, int mode){ throw new NotImplementedException(); }
		public static bool GuiMemoIsReadOnly (MtaElement theMemo){ throw new NotImplementedException(); }
		public static float GuiProgressBarGetProgress (MtaElement theProgressbar){ throw new NotImplementedException(); }
		public static MtaElement GuiCreateProgressBar (float x, float y, float width, float height, bool relative, MtaElement parent){ throw new NotImplementedException(); }
		public static MtaElement GuiCreateScrollBar (float x, float y, float width, float height, bool horizontal, bool relative, MtaElement parent){ throw new NotImplementedException(); }
		public static bool GuiMemoSetReadOnly (MtaElement theMemo, bool status){ throw new NotImplementedException(); }
		public static bool GuiRadioButtonSetSelected (MtaElement guiRadioButton, bool state){ throw new NotImplementedException(); }
		public static MtaElement GuiCreateScrollPane (float x, float y, float width, float height, bool relative, MtaElement parent){ throw new NotImplementedException(); }
		public static MtaElement GuiCreateRadioButton (float x, float y, float width, float height, string text, bool relative, MtaElement parent){ throw new NotImplementedException(); }
		public static bool GuiScrollBarSetScrollPosition (MtaElement theScrollBar, float amount){ throw new NotImplementedException(); }
		public static float GuiScrollPaneGetHorizontalScrollPosition (MtaElement horizontalScrollPane){ throw new NotImplementedException(); }
		public static bool GuiMemoSetCaretIndex (MtaElement theMemo, int index){ throw new NotImplementedException(); }
		public static bool GuiProgressBarSetProgress (MtaElement theProgressbar, float progress){ throw new NotImplementedException(); }
		public static float GuiScrollPaneGetVerticalScrollPosition (MtaElement verticalScrollPane){ throw new NotImplementedException(); }
		public static bool GuiScrollPaneSetVerticalScrollPosition (MtaElement verticalScrollPane, float position){ throw new NotImplementedException(); }
		public static bool GuiScrollPaneSetHorizontalScrollPosition (MtaElement horizontalScrollPane, float position){ throw new NotImplementedException(); }
		public static Tuple<int, int> GuiStaticImageGetNativeSize (MtaElement theImage){ throw new NotImplementedException(); }
		public static bool GuiScrollPaneSetScrollBars (MtaElement scrollPane, bool horizontal, bool vertical){ throw new NotImplementedException(); }
		public static float GuiScrollBarGetScrollPosition (MtaElement theScrollBar){ throw new NotImplementedException(); }
		public static bool GuiRadioButtonGetSelected (MtaElement guiRadioButton){ throw new NotImplementedException(); }
		public static MtaElement GuiCreateStaticImage (float x, float y, float width, float height, string path, bool relative, MtaElement parent){ throw new NotImplementedException(); }
		public static float GuiLabelGetFontHeight (MtaElement theLabel){ throw new NotImplementedException(); }
		public static bool GuiLabelSetHorizontalAlign (MtaElement theLabel, string align, bool wordwrap){ throw new NotImplementedException(); }
		public static MtaElement GuiCreateTabPanel (float x, float y, float width, float height, bool relative, MtaElement parent){ throw new NotImplementedException(); }
		public static Tuple<int, int, int> GuiLabelGetColor (MtaElement theLabel){ throw new NotImplementedException(); }
		public static MtaElement GuiGetSelectedTab (MtaElement tabPanel){ throw new NotImplementedException(); }
		public static bool GuiLabelSetVerticalAlign (MtaElement theLabel, string align){ throw new NotImplementedException(); }
		public static bool GuiLabelSetColor (MtaElement theElement, int red, int green, int blue){ throw new NotImplementedException(); }
		public static bool GuiStaticImageLoadImage (MtaElement theElement, string filename){ throw new NotImplementedException(); }
		public static MtaElement GuiCreateWindow (float x, float y, float width, float height, string titleBarText, bool relative){ throw new NotImplementedException(); }
		public static bool GuiSetSelectedTab (MtaElement tabPanel, MtaElement theTab){ throw new NotImplementedException(); }
		public static float GuiLabelGetTextExtent (MtaElement theLabel){ throw new NotImplementedException(); }
		public static MtaElement GuiCreateTab (string text, MtaElement parent){ throw new NotImplementedException(); }
		public static bool GuiDeleteTab (MtaElement tabToDelete, MtaElement tabPanel){ throw new NotImplementedException(); }
		public static dynamic GetBoundKeys (string command){ throw new NotImplementedException(); }
		public static MtaElement GuiCreateLabel (float x, float y, float width, float height, string text, bool relative, MtaElement parent){ throw new NotImplementedException(); }
		public static bool GuiComboBoxSetOpen (MtaElement comboBox, bool state){ throw new NotImplementedException(); }
		public static float GetAnalogControlState (string control){ throw new NotImplementedException(); }
		public static bool GuiWindowIsSizable (MtaElement guiWindow){ throw new NotImplementedException(); }
		public static bool GuiWindowSetSizable (MtaElement theElement, bool status){ throw new NotImplementedException(); }
		public static bool GuiWindowIsMovable (MtaElement guiWindow){ throw new NotImplementedException(); }
		public static dynamic GetCommandsBoundToKey (string theKey, string keyState){ throw new NotImplementedException(); }
		public static bool GetKeyState (string keyName){ throw new NotImplementedException(); }
		public static string GetKeyBoundToCommand (string command){ throw new NotImplementedException(); }
		public static bool GuiWindowSetMovable (MtaElement theElement, bool status){ throw new NotImplementedException(); }
		public static MtaElement GuiCreateEdit (float x, float y, float width, float height, string text, bool relative, MtaElement parent){ throw new NotImplementedException(); }
		public static bool GuiComboBoxSetSelected (MtaElement comboBox, int itemIndex){ throw new NotImplementedException(); }
		public static int GetLightType (MtaElement theLight){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetLightDirection (MtaElement theLight){ throw new NotImplementedException(); }
		public static MtaElement CreateLight (int lightType, float posX, float posY, float posZ, float radius, int r, int g, int b, float dirX, float dirY, float dirZ, bool createsShadow){ throw new NotImplementedException(); }
		public static float GetLightRadius (MtaElement theLight){ throw new NotImplementedException(); }
		public static bool SetLightRadius (MtaElement theLight, float radius){ throw new NotImplementedException(); }
		public static bool SetLightColor (MtaElement theLight, float r, float g, float b){ throw new NotImplementedException(); }
		public static Tuple<int, int, int> GetLightColor (MtaElement theLight){ throw new NotImplementedException(); }
		public static bool SetLightDirection (MtaElement theLight, float x, float y, float z){ throw new NotImplementedException(); }
		public static bool RespawnObject (MtaElement theObject){ throw new NotImplementedException(); }
		public static bool IsObjectBreakable (MtaElement theObject){ throw new NotImplementedException(); }
		public static float GetObjectMass (MtaElement theObject){ throw new NotImplementedException(); }
		public static bool ToggleObjectRespawn (MtaElement theObject, bool respawn){ throw new NotImplementedException(); }
		public static dynamic GetObjectProperty (MtaElement theObject, string property){ throw new NotImplementedException(); }
		public static bool SetObjectMass (MtaElement theObject, float mass){ throw new NotImplementedException(); }
		public static bool SetObjectProperty (MtaElement theObject, string property, dynamic value){ throw new NotImplementedException(); }
		public static bool IsChatVisible (){ throw new NotImplementedException(); }
		public static bool BreakObject (MtaElement theObject){ throw new NotImplementedException(); }
		public static bool SetObjectBreakable (MtaElement theObject, bool breakable){ throw new NotImplementedException(); }
		public static bool CanPedBeKnockedOffBike (MtaElement thePed){ throw new NotImplementedException(); }
		public static string GetPedSimplestTask (MtaElement thePed){ throw new NotImplementedException(); }
		public static float GetPedCameraRotation (MtaElement thePed){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetPedTargetEnd (MtaElement targetingPed){ throw new NotImplementedException(); }
		public static bool GetPedControlState (MtaElement thePed, string control){ throw new NotImplementedException(); }
		public static float GetPedAnalogControlState (MtaElement thePed, string controlName){ throw new NotImplementedException(); }
		public static float GetPedOxygenLevel (MtaElement thePed){ throw new NotImplementedException(); }
		public static string GetPedMoveState (MtaElement thePed){ throw new NotImplementedException(); }
		public static Tuple<string, string> GetPedAnimation (MtaElement thePed){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetPedWeaponMuzzlePosition (MtaElement thePed){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetPedTargetCollision (MtaElement targetingPed){ throw new NotImplementedException(); }
		public static bool IsPedDoingTask (MtaElement thePed, string taskName){ throw new NotImplementedException(); }
		public static Tuple<string, string> GetPedVoice (MtaElement thePed){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetPedTargetStart (MtaElement targetingPed){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetPedBonePosition (MtaElement thePed, int bone){ throw new NotImplementedException(); }
		public static bool GivePedWeapon (MtaElement thePed, int weapon, int ammo, bool setAsCurrent){ throw new NotImplementedException(); }
		public static bool SetAnalogControlState (string control, float state){ throw new NotImplementedException(); }
		public static bool IsPedReloadingWeapon (MtaElement thePed){ throw new NotImplementedException(); }
		public static bool IsPedTargetingMarkerEnabled (){ throw new NotImplementedException(); }
		public static Tuple<string, string, string, string> GetPedTask (MtaElement thePed, string priority, int taskType){ throw new NotImplementedException(); }
		public static bool SetPedAimTarget (MtaElement thePed, float x, float y, float z){ throw new NotImplementedException(); }
		public static bool SetPedControlState (MtaElement thePed, string control, bool state){ throw new NotImplementedException(); }
		public static bool SetPedFootBloodEnabled (MtaElement thePlayer, bool enabled){ throw new NotImplementedException(); }
		public static bool SetPedCanBeKnockedOffBike (MtaElement thePed, bool canBeKnockedOffBike){ throw new NotImplementedException(); }
		public static bool SetPedCameraRotation (MtaElement thePed, float cameraRotation){ throw new NotImplementedException(); }
		public static bool SetPedAnalogControlState (MtaElement thePed, string control, float state){ throw new NotImplementedException(); }
		public static bool SetPedOxygenLevel (MtaElement thePed, float oxygen){ throw new NotImplementedException(); }
		public static bool SetPedLookAt (MtaElement thePed, float x, float y, float z, int time, int blend, MtaElement target){ throw new NotImplementedException(); }
		public static bool SetPedVoice (MtaElement thePed, string voiceType, string voiceName){ throw new NotImplementedException(); }
		public static bool SetPedTargetingMarkerEnabled (bool enabled){ throw new NotImplementedException(); }
		public static MtaElement GetLocalPlayer (){ throw new NotImplementedException(); }
		public static Tuple<int, int, int, int> GetPlayerMapBoundingBox (){ throw new NotImplementedException(); }
		public static bool IsPlayerHudComponentVisible (string component){ throw new NotImplementedException(); }
		public static bool IsPlayerMapVisible (){ throw new NotImplementedException(); }
		public static MtaElement CreateProjectile (MtaElement creator, int weaponType, float posX, float posY, float posZ, float force, MtaElement target, float rotX, float rotY, float rotZ, float velX, float velY, float velZ, int model){ throw new NotImplementedException(); }
		public static MtaElement GetProjectileTarget (MtaElement theProjectile){ throw new NotImplementedException(); }
		public static MtaElement GetProjectileCreator (MtaElement theProjectile){ throw new NotImplementedException(); }
		public static float GetProjectileForce (MtaElement theProjectile){ throw new NotImplementedException(); }
		public static int GetProjectileCounter (MtaElement projectile){ throw new NotImplementedException(); }
		public static int GetProjectileType (MtaElement theProjectile){ throw new NotImplementedException(); }
		public static bool SetProjectileCounter (MtaElement projectile, int timeToDetonate){ throw new NotImplementedException(); }
		public static MtaElement GetResourceGUIElement (MtaResource theResource){ throw new NotImplementedException(); }
		public static MtaElement CreateSearchLight (float startX, float startY, float startZ, float endX, float endY, float endZ, float startRadius, float endRadius, bool renderSpot){ throw new NotImplementedException(); }
		public static float GetSearchLightEndRadius (MtaElement theSearchLight){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetSearchLightEndPosition (MtaElement theSearchLight){ throw new NotImplementedException(); }
		public static bool SetSearchLightEndPosition (MtaElement theSearchLight, float endX, float endY, float endZ){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetSearchLightStartPosition (MtaElement theSearchLight){ throw new NotImplementedException(); }
		public static float GetSearchLightStartRadius (MtaElement theSearchLight){ throw new NotImplementedException(); }
		public static bool SetSearchLightEndRadius (MtaElement theSearchlight, float endRadius){ throw new NotImplementedException(); }
		public static bool SetSearchLightStartRadius (MtaElement theSearchlight, float startRadius){ throw new NotImplementedException(); }
		public static bool SetSearchLightStartPosition (MtaElement theSearchLight, float startX, float startY, float startZ){ throw new NotImplementedException(); }
		public static bool CreateTrayNotification (string notificationText, string iconType, bool useSound){ throw new NotImplementedException(); }
		public static bool DownloadFile (string fileName){ throw new NotImplementedException(); }
		public static dynamic GetLocalization (){ throw new NotImplementedException(); }
		public static bool IsTrayNotificationEnabled (){ throw new NotImplementedException(); }
		public static bool SetClipboard (string theText){ throw new NotImplementedException(); }
		public static bool SetWindowFlashing (bool shouldFlash, int count){ throw new NotImplementedException(); }
		public static bool GetHeliBladeCollisionsEnabled (MtaElement theVehicle){ throw new NotImplementedException(); }
		public static int GetVehicleAdjustableProperty (MtaElement theVehicle){ throw new NotImplementedException(); }
		public static float GetHelicopterRotorSpeed (MtaElement heli){ throw new NotImplementedException(); }
		public static int GetVehicleCurrentGear (MtaElement theVehicle){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetVehicleGravity (MtaElement theVehicle){ throw new NotImplementedException(); }
		public static dynamic GetVehicleComponents (MtaElement theVehicle){ throw new NotImplementedException(); }
		public static bool GetVehicleComponentVisible (MtaElement theVehicle, string theComponent){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetVehicleComponentPosition (MtaElement theVehicle, string theComponent, string argument_base){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetVehicleComponentRotation (MtaElement theVehicle, string theComponent, string argument_base){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetVehicleModelExhaustFumesPosition (int modelID){ throw new NotImplementedException(); }
		public static int GetVehicleNitroCount (MtaElement theVehicle){ throw new NotImplementedException(); }
		public static float GetVehicleNitroLevel (MtaElement theVehicle){ throw new NotImplementedException(); }
		public static bool IsVehicleWindowOpen (MtaElement theVehicle, int window){ throw new NotImplementedException(); }
		public static bool IsTrainChainEngine (MtaElement theTrain){ throw new NotImplementedException(); }
		public static bool SetHeliBladeCollisionsEnabled (MtaElement theVehicle, bool collisions){ throw new NotImplementedException(); }
		public static bool IsVehicleWheelOnGround (MtaElement theVehicle, dynamic wheel){ throw new NotImplementedException(); }
		public static bool SetHelicopterRotorSpeed (MtaElement heli, float speed){ throw new NotImplementedException(); }
		public static bool IsVehicleNitroRecharging (MtaElement theVehicle){ throw new NotImplementedException(); }
		public static bool IsVehicleNitroActivated (MtaElement theVehicle){ throw new NotImplementedException(); }
		public static bool ResetVehicleComponentRotation (MtaElement theVehicle, string theComponent){ throw new NotImplementedException(); }
		public static bool SetVehicleComponentVisible (MtaElement theVehicle, string theComponent, bool visible){ throw new NotImplementedException(); }
		public static bool SetVehicleComponentPosition (MtaElement theVehicle, string theComponent, float posX, float posY, float posZ, string argument_base){ throw new NotImplementedException(); }
		public static bool ResetVehicleComponentPosition (MtaElement theVehicle, string theComponent){ throw new NotImplementedException(); }
		public static bool SetVehicleGravity (MtaElement theVehicle, float x, float y, float z){ throw new NotImplementedException(); }
		public static bool SetVehicleAdjustableProperty (MtaElement theVehicle, int value){ throw new NotImplementedException(); }
		public static bool SetVehicleComponentRotation (MtaElement theVehicle, string theComponent, float rotX, float rotY, float rotZ, string argument_base){ throw new NotImplementedException(); }
		public static bool SetVehicleNitroLevel (MtaElement theVehicle, float level){ throw new NotImplementedException(); }
		public static bool SetVehicleModelExhaustFumesPosition (int modelID, float posX, float posY, float posZ){ throw new NotImplementedException(); }
		public static bool SetWaterDrawnLast (bool bEnabled){ throw new NotImplementedException(); }
		public static bool IsWaterDrawnLast (){ throw new NotImplementedException(); }
		public static float GetWaterLevel (float posX, float posY, float posZ, bool bCheckWaves){ throw new NotImplementedException(); }
		public static bool SetVehicleNitroCount (MtaElement theVehicle, int count){ throw new NotImplementedException(); }
		public static bool SetVehicleWindowOpen (MtaElement theVehicle, int window, bool open){ throw new NotImplementedException(); }
		public static bool SetVehicleNitroActivated (MtaElement theVehicle, bool state){ throw new NotImplementedException(); }
		public static MtaElement CreateWeapon (string theType, float x, float y, float z){ throw new NotImplementedException(); }
		public static bool GetWeaponOwner (MtaElement theWeapon){ throw new NotImplementedException(); }
		public static int GetWeaponClipAmmo (MtaElement theWeapon){ throw new NotImplementedException(); }
		public static int GetWeaponFiringRate (MtaElement theWeapon){ throw new NotImplementedException(); }
		public static int GetWeaponAmmo (MtaElement theWeapon){ throw new NotImplementedException(); }
		public static string GetWeaponState (MtaElement theWeapon){ throw new NotImplementedException(); }
		public static bool GetWeaponFlags (MtaElement theWeapon, string theFlag){ throw new NotImplementedException(); }
		public static bool FireWeapon (MtaElement theWeapon){ throw new NotImplementedException(); }
		public static bool ResetWeaponFiringRate (MtaElement theWeapon){ throw new NotImplementedException(); }
		public static bool GetBirdsEnabled (){ throw new NotImplementedException(); }
		public static dynamic GetWeaponTarget (MtaElement theWeapon){ throw new NotImplementedException(); }
		public static bool SetWeaponState (MtaElement theWeapon, string theState){ throw new NotImplementedException(); }
		public static bool SetWeaponClipAmmo (MtaElement theWeapon, int clipAmmo){ throw new NotImplementedException(); }
		public static bool CreateSWATRope (float fx, float fy, float fZ, int duration){ throw new NotImplementedException(); }
		public static bool SetWeaponFlags (MtaElement theWeapon, string theFlag, bool enable){ throw new NotImplementedException(); }
		public static bool GetInteriorFurnitureEnabled (int roomID){ throw new NotImplementedException(); }
		public static bool SetWeaponFiringRate (MtaElement theWeapon, int firingRate){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetGarageSize (int garageID){ throw new NotImplementedException(); }
		public static float GetGroundPosition (float x, float y, float z){ throw new NotImplementedException(); }
		public static bool GetInteriorSoundsEnabled (){ throw new NotImplementedException(); }
		public static Tuple<float, float, float, float> GetGarageBoundingBox (int garageID){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetGaragePosition (int garageID){ throw new NotImplementedException(); }
		public static float GetNearClipDistance (){ throw new NotImplementedException(); }
		public static float GetPedsLODDistance (){ throw new NotImplementedException(); }
		public static bool ResetPedsLODDistance (){ throw new NotImplementedException(); }
		public static bool SetPedsLODDistance (float distance){ throw new NotImplementedException(); }
		public static Tuple<float, float> GetScreenFromWorldPosition (float x, float y, float z, float edgeTolerance, bool relative){ throw new NotImplementedException(); }
		public static Tuple<float, float> GetVehiclesLODDistance (){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetWorldFromScreenPosition (float x, float y, float depth){ throw new NotImplementedException(); }
		public static bool IsAmbientSoundEnabled (string theType){ throw new NotImplementedException(); }
		public static bool IsLineOfSightClear (float startX, float startY, float startZ, float endX, float endY, float endZ, bool checkBuildings, bool checkVehicles, bool checkPeds, bool checkObjects, bool checkDummies, bool seeThroughStuff, bool ignoreSomeObjectsForCamera, MtaElement ignoredElement){ throw new NotImplementedException(); }
		public static bool IsWorldSoundEnabled (int group, int index){ throw new NotImplementedException(); }
		public static bool IsWorldSpecialPropertyEnabled (string propname){ throw new NotImplementedException(); }
		public static bool ResetAmbientSounds (){ throw new NotImplementedException(); }
		public static Tuple<bool, float, float, float, MtaElement, float, float, Tuple<float, int, float, int, int, float, float, Tuple<float, float, float, float, int>>> ProcessLineOfSight (float startX, float startY, float startZ, float endX, float endY, float endZ, bool checkBuildings, bool checkVehicles, bool checkPlayers, bool checkObjects, bool checkDummies, bool seeThroughStuff, bool ignoreSomeObjectsForCamera, bool shootThroughStuff, MtaElement ignoredElement, bool includeWorldModelInformation, bool bIncludeCarTyres){ throw new NotImplementedException(); }
		public static bool ResetVehiclesLODDistance (){ throw new NotImplementedException(); }
		public static bool ResetWorldSounds (){ throw new NotImplementedException(); }
		public static bool SetAmbientSoundEnabled (string theType, bool enable){ throw new NotImplementedException(); }
		public static bool SetBirdsEnabled (bool enable){ throw new NotImplementedException(); }
		public static bool SetInteriorFurnitureEnabled (int roomID, bool enabled){ throw new NotImplementedException(); }
		public static bool SetNearClipDistance (float distance){ throw new NotImplementedException(); }
		public static bool SetVehiclesLODDistance (float vehiclesDistance, float trainsAndPlanesDistance){ throw new NotImplementedException(); }
		public static Tuple<bool, float, float, float> TestLineAgainstWater (float startX, float startY, float startZ, float endX, float endY, float endZ){ throw new NotImplementedException(); }
		public static bool SetWorldSpecialPropertyEnabled (string propname, bool enable){ throw new NotImplementedException(); }
		public static bool SetWorldSoundEnabled (int group, int index){ throw new NotImplementedException(); }
		public static float GetWaterLevel (MtaElement theWater){ throw new NotImplementedException(); }
		public static bool SetWorldSoundEnabled (int group, int index, bool enable, bool immediate){ throw new NotImplementedException(); }
		public static MtaElement DxCreateTexture (int width, int height, string textureFormat, string textureEdge, string textureType, int depth){ throw new NotImplementedException(); }
		public static bool DxDrawMaterialLine3D (float startX, float startY, float startZ, float endX, float endY, float endZ, MtaElement material, float width, int color, bool postGUI){ throw new NotImplementedException(); }
		public static bool DxDrawMaterialSectionLine3D (float startX, float startY, float startZ, float endX, float endY, float endZ, float u, float v, float usize, float vsize, MtaElement material, float width, int color, bool postGUI){ throw new NotImplementedException(); }
		public static bool DxSetRenderTarget (){ throw new NotImplementedException(); }
        public static bool SetWeaponTarget(MtaElement theWeapon, MtaElement target, int component) { throw new NotImplementedException(); }
        public static bool SetWeaponTarget(MtaElement theWeapon, float x, float y, float z) { throw new NotImplementedException(); }
        public static bool SetWeaponTarget(MtaElement theWeapon) { throw new NotImplementedException(); }
    }
}