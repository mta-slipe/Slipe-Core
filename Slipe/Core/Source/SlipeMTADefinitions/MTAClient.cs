using System;

namespace Slipe.MTADefinitions {
	public class MTAClient {
		public static bool PlaySoundFrontEnd (int sound){ throw new NotImplementedException(); }
		public static MTAElement CreateBlip (float x, float y, float z, int icon, int size, int r, int g, int b, int a, int ordering, float visibleDistance){ throw new NotImplementedException(); }
		public static MTAElement CreateBlipAttachedTo (MTAElement elementToAttachTo, int icon, int size, int r, int g, int b, int a, int ordering, float visibleDistance){ throw new NotImplementedException(); }
		public static bool FadeCamera (bool fadeIn, float timeToFade, int red, int green, int blue){ throw new NotImplementedException(); }
		public static Tuple<float, float, float, float, float, float, float, float> GetCameraMatrix (){ throw new NotImplementedException(); }
		public static int GetCameraInterior (){ throw new NotImplementedException(); }
		public static MTAElement GetCameraTarget (){ throw new NotImplementedException(); }
		public static bool SetCameraInterior (int interior){ throw new NotImplementedException(); }
		public static bool SetCameraTarget (MTAElement target){ throw new NotImplementedException(); }
		public static bool SetCameraMatrix (float positionX, float positionY, float positionZ, float lookAtX, float lookAtY, float lookAtZ, float roll, float fov){ throw new NotImplementedException(); }
		public static bool IsCursorShowing (){ throw new NotImplementedException(); }
		public static bool ShowCursor (bool show, bool toggleControls){ throw new NotImplementedException(); }
		public static dynamic GetElementsByType (string theType, MTAElement startat){ throw new NotImplementedException(); }
		public static bool CancelEvent (){ throw new NotImplementedException(); }
		public static bool CancelLatentEvent (int handle){ throw new NotImplementedException(); }
		public static dynamic GetLatentEventHandles (){ throw new NotImplementedException(); }
		public static dynamic GetLatentEventStatus (int handle){ throw new NotImplementedException(); }
		public static bool CreateExplosion (float x, float y, float z, int theType, bool makeSound, float camShake){ throw new NotImplementedException(); }
		public static bool BindKey (string key, string keyState, dynamic handlerFunction, dynamic arguments){ throw new NotImplementedException(); }
		public static bool AddCommandHandler (string commandName, dynamic handlerFunction, bool caseSensitive){ throw new NotImplementedException(); }
		public static bool ExecuteCommandHandler (string commandName, string args){ throw new NotImplementedException(); }
		public static dynamic GetFunctionsBoundToKey (string key, string keyState){ throw new NotImplementedException(); }
		public static string GetKeyBoundToFunction (dynamic theFunction){ throw new NotImplementedException(); }
		public static bool IsControlEnabled (string control){ throw new NotImplementedException(); }
		public static bool ToggleAllControls (bool enabled, bool gtaControls, bool mtaControls){ throw new NotImplementedException(); }
		public static bool ToggleControl (string control, bool enabled){ throw new NotImplementedException(); }
		public static bool UnbindKey (string key, string keyState, string command){ throw new NotImplementedException(); }
		public static MTAElement CreateMarker (float x, float y, float z, string theType, float size, int r, int g, int b, int a){ throw new NotImplementedException(); }
		public static bool ClearChatBox (){ throw new NotImplementedException(); }
		public static bool OutputConsole (string text){ throw new NotImplementedException(); }
		public static bool OutputChatBox (string text, int r, int g, int b, bool colorCoded){ throw new NotImplementedException(); }
		public static bool ShowChat (bool show){ throw new NotImplementedException(); }
		public static MTAElement CreatePed (int modelid, float x, float y, float z, float rot){ throw new NotImplementedException(); }
		public static bool ForcePlayerMap (bool forceOn){ throw new NotImplementedException(); }
		public static int GetPlayerBlurLevel (){ throw new NotImplementedException(); }
		public static int GetPlayerMoney (){ throw new NotImplementedException(); }
		public static bool IsPlayerMapForced (){ throw new NotImplementedException(); }
		public static bool GivePlayerMoney (int amount){ throw new NotImplementedException(); }
		public static int GetPlayerWantedLevel (){ throw new NotImplementedException(); }
		public static bool SetPlayerBlurLevel (int level){ throw new NotImplementedException(); }
		public static bool SetPlayerMoney (int amount, bool instant){ throw new NotImplementedException(); }
		public static bool SetPlayerHudComponentVisible (string component, bool show){ throw new NotImplementedException(); }
		public static bool TakePlayerMoney (int amount){ throw new NotImplementedException(); }
		public static bool DetonateSatchels (){ throw new NotImplementedException(); }
		public static dynamic GetNetworkStats (){ throw new NotImplementedException(); }
		public static bool BlowVehicle (MTAElement vehicleToBlow){ throw new NotImplementedException(); }
		public static string GetRadioChannelName (int id){ throw new NotImplementedException(); }
		public static int GetRadioChannel (){ throw new NotImplementedException(); }
		public static float GetSoundBufferLength (MTAElement theSound){ throw new NotImplementedException(); }
		public static bool GetSFXStatus (string audioContainer){ throw new NotImplementedException(); }
		public static int GetSoundBPM (MTAElement sound){ throw new NotImplementedException(); }
		public static dynamic GetSoundFFTData (MTAElement sound, int iSamples, int iBands){ throw new NotImplementedException(); }
		public static dynamic GetSoundEffects (MTAElement sound){ throw new NotImplementedException(); }
		public static Tuple<int, int> GetSoundLevelData (MTAElement theSound){ throw new NotImplementedException(); }
		public static float GetSoundLength (MTAElement theSound){ throw new NotImplementedException(); }
		public static dynamic GetSoundMetaTags (MTAElement sound, string format){ throw new NotImplementedException(); }
		public static int GetSoundMinDistance (MTAElement sound){ throw new NotImplementedException(); }
		public static int GetSoundMaxDistance (MTAElement sound){ throw new NotImplementedException(); }
		public static float GetSoundPan (MTAElement theSound){ throw new NotImplementedException(); }
		public static Tuple<float, float, float, bool> GetSoundProperties (MTAElement sound){ throw new NotImplementedException(); }
		public static float GetSoundVolume (MTAElement theSound){ throw new NotImplementedException(); }
		public static float GetSoundPosition (MTAElement theSound){ throw new NotImplementedException(); }
		public static float GetSoundSpeed (MTAElement theSound){ throw new NotImplementedException(); }
		public static dynamic GetSoundWaveData (MTAElement sound, int iSamples){ throw new NotImplementedException(); }
		public static MTAElement PlaySFX (string containerName, int bankId, int soundId, bool looped){ throw new NotImplementedException(); }
		public static bool IsSoundPaused (MTAElement theSound){ throw new NotImplementedException(); }
		public static bool IsSoundPanningEnabled (MTAElement theSound){ throw new NotImplementedException(); }
		public static MTAElement PlaySFX3D (string containerName, int bankId, int soundId, float x, float y, float z, bool looped){ throw new NotImplementedException(); }
		public static MTAElement PlaySound (string soundPath, bool looped, bool throttled){ throw new NotImplementedException(); }
		public static MTAElement PlaySound3D (string soundPath, float x, float y, float z, bool looped){ throw new NotImplementedException(); }
		public static bool SetRadioChannel (int ID){ throw new NotImplementedException(); }
		public static bool SetSoundEffectEnabled (MTAElement sound, string effectName, bool bEnable){ throw new NotImplementedException(); }
		public static bool SetSoundMaxDistance (MTAElement sound, int distance){ throw new NotImplementedException(); }
		public static bool SetSoundMinDistance (MTAElement sound, int distance){ throw new NotImplementedException(); }
		public static bool SetSoundPan (MTAElement theSound, float pan){ throw new NotImplementedException(); }
		public static bool SetSoundPosition (MTAElement theSound, float pos){ throw new NotImplementedException(); }
		public static bool SetSoundPaused (MTAElement theSound, bool paused){ throw new NotImplementedException(); }
		public static bool SetSoundProperties (MTAElement sound, float fSampleRate, float fTempo, float fPitch, bool bReverse){ throw new NotImplementedException(); }
		public static bool SetSoundVolume (MTAElement theSound, float volume){ throw new NotImplementedException(); }
		public static bool SetSoundPanningEnabled (MTAElement sound, bool enable){ throw new NotImplementedException(); }
		public static bool StopSound (MTAElement theSound){ throw new NotImplementedException(); }
		public static bool SetSoundSpeed (MTAElement theSound, float speed){ throw new NotImplementedException(); }
		public static bool CanBrowserNavigateBack (MTAElement webBrowser){ throw new NotImplementedException(); }
		public static bool CanBrowserNavigateForward (MTAElement webBrowser){ throw new NotImplementedException(); }
		public static bool ExecuteBrowserJavascript (MTAElement webBrowser, string jsCode){ throw new NotImplementedException(); }
		public static MTAElement CreateBrowser (int width, int height, bool isLocal, bool transparent){ throw new NotImplementedException(); }
		public static bool GetBrowserProperty (MTAElement theBrowser, string key){ throw new NotImplementedException(); }
		public static bool FocusBrowser (MTAElement webBrowser){ throw new NotImplementedException(); }
		public static dynamic GetBrowserSettings (){ throw new NotImplementedException(); }
		public static string GetBrowserTitle (MTAElement webBrowser){ throw new NotImplementedException(); }
		public static bool GetBrowserSource (MTAElement webBrowser, dynamic callback){ throw new NotImplementedException(); }
		public static string GetBrowserURL (MTAElement webBrowser){ throw new NotImplementedException(); }
		public static bool IsBrowserFocused (MTAElement webBrowser){ throw new NotImplementedException(); }
		public static bool InjectBrowserMouseMove (MTAElement webBrowser, int posX, int posY){ throw new NotImplementedException(); }
		public static bool InjectBrowserMouseWheel (MTAElement webBrowser, int verticalScroll, int horizontalScroll){ throw new NotImplementedException(); }
		public static bool InjectBrowserMouseDown (MTAElement webBrowser, string mouseButton){ throw new NotImplementedException(); }
		public static bool InjectBrowserMouseUp (MTAElement webBrowser, string mouseButton){ throw new NotImplementedException(); }
		public static bool NavigateBrowserBack (MTAElement webBrowser){ throw new NotImplementedException(); }
		public static bool LoadBrowserURL (MTAElement webBrowser, string url, string postData, bool urlEncoded){ throw new NotImplementedException(); }
		public static bool IsBrowserLoading (MTAElement webBrowser){ throw new NotImplementedException(); }
		public static bool RequestBrowserDomains (dynamic pages, bool parseAsURL, Action<bool, string[]> callback){ throw new NotImplementedException(); }
		public static bool IsBrowserDomainBlocked (string address, bool isURL){ throw new NotImplementedException(); }
		public static bool ReloadBrowserPage (MTAElement webBrowser){ throw new NotImplementedException(); }
		public static bool NavigateBrowserForward (MTAElement webBrowser){ throw new NotImplementedException(); }
		public static bool ResizeBrowser (MTAElement webBrowser, float width, float height){ throw new NotImplementedException(); }
		public static bool SetBrowserAjaxHandler (MTAElement webBrowser, string url, dynamic handler){ throw new NotImplementedException(); }
		public static bool SetBrowserRenderingPaused (MTAElement webBrowser, bool paused){ throw new NotImplementedException(); }
		public static bool ToggleBrowserDevTools (MTAElement webBrowser, bool visible){ throw new NotImplementedException(); }
		public static bool SetBrowserVolume (MTAElement webBrowser, float volume){ throw new NotImplementedException(); }
		public static MTAElement GuiCreateBrowser (float x, float y, float width, float height, bool isLocal, bool isTransparent, bool isRelative, MTAElement parent){ throw new NotImplementedException(); }
		public static bool SetBrowserProperty (MTAElement theBrowser, string key, string value){ throw new NotImplementedException(); }
		public static MTAElement GuiGetBrowser (MTAElement theBrowser){ throw new NotImplementedException(); }
		public static MTAElement GetCamera (){ throw new NotImplementedException(); }
		public static Tuple<bool, bool> GetCameraClip (){ throw new NotImplementedException(); }
		public static float GetCameraFieldOfView (string cameraMode){ throw new NotImplementedException(); }
		public static string GetCameraGoggleEffect (){ throw new NotImplementedException(); }
		public static int GetCameraShakeLevel (){ throw new NotImplementedException(); }
		public static int GetCameraViewMode (){ throw new NotImplementedException(); }
		public static bool SetCameraClip (bool objects, bool vehicles){ throw new NotImplementedException(); }
		public static bool SetCameraGoggleEffect (string goggleEffect, bool noiseEnabled){ throw new NotImplementedException(); }
		public static bool SetCameraFieldOfView (string cameraMode, float fieldOfView){ throw new NotImplementedException(); }
		public static bool SetCameraShakeLevel (int shakeLevel){ throw new NotImplementedException(); }
		public static bool SetCameraViewMode (int viewMode){ throw new NotImplementedException(); }
		public static int GetCursorAlpha (){ throw new NotImplementedException(); }
		public static bool SetCursorAlpha (int alpha){ throw new NotImplementedException(); }
		public static Tuple<float, float, float, float, float> GetCursorPosition (){ throw new NotImplementedException(); }
		public static MTAElement DxCreateFont (string filepath, int size, bool bold, string quality){ throw new NotImplementedException(); }
		public static MTAElement DxCreateRenderTarget (int width, int height, bool withAlpha){ throw new NotImplementedException(); }
		public static string DxConvertPixels (string pixels, string newFormat, int quality){ throw new NotImplementedException(); }
		public static MTAElement DxCreateScreenSource (int width, int height){ throw new NotImplementedException(); }
		public static Tuple<MTAElement, string> DxCreateShader (string filepath, float priority, float maxDistance, bool layered, string elementTypes){ throw new NotImplementedException(); }
		public static MTAElement DxCreateTexture (string pixels, string textureFormat, bool mipmaps, string textureEdge){ throw new NotImplementedException(); }
		public static bool DxDrawImageSection (float posX, float posY, float width, float height, float u, float v, float usize, float vsize, dynamic image, float rotation, float rotationCenterOffsetX, float rotationCenterOffsetY, int color, bool postGUI){ throw new NotImplementedException(); }
		public static bool DxDrawImage (float posX, float posY, float width, float height, dynamic image, float rotation, float rotationCenterOffsetX, float rotationCenterOffsetY, int color){ throw new NotImplementedException(); }
		public static bool DxDrawCircle (float posX, float posY, float radius, float startAngle, float stopAngle, MTAElement theColor, MTAElement theCenterColor, int segments, int ratio, bool postGUI){ throw new NotImplementedException(); }
		public static bool DxDrawLine (int startX, int startY, int endX, int endY, int color, float width, bool postGUI){ throw new NotImplementedException(); }
		public static bool DxDrawLine3D (float startX, float startY, float startZ, float endX, float endY, float endZ, int color, float width, bool postGUI){ throw new NotImplementedException(); }
		public static bool DxDrawMaterialLine3D (float startX, float startY, float startZ, float endX, float endY, float endZ, MTAElement material, float width, int color, bool postGUI, float faceTowardX, float faceTowardY, float faceTowardZ){ throw new NotImplementedException(); }
		public static bool DxDrawMaterialPrimitive (MTAElement pType, dynamic material, bool postGUI, dynamic vertice1, dynamic vertice2){ throw new NotImplementedException(); }
		public static bool DxDrawPrimitive (string pType, bool postGUI, dynamic vertice1, dynamic vertice2){ throw new NotImplementedException(); }
		public static bool DxDrawMaterialSectionLine3D (float startX, float startY, float startZ, float endX, float endY, float endZ, float u, float v, float usize, float vsize, MTAElement material, int width, int color, bool postGUI, float faceTowardX, float faceTowardY, float faceTowardZ){ throw new NotImplementedException(); }
		public static int DxGetFontHeight (float scale, dynamic font){ throw new NotImplementedException(); }
		public static bool DxDrawRectangle (float startX, float startY, float width, float height, int color, bool postGUI, bool subPixelPositioning){ throw new NotImplementedException(); }
		public static Tuple<int, int> DxGetPixelsSize (string pixels){ throw new NotImplementedException(); }
		public static string DxGetBlendMode (){ throw new NotImplementedException(); }
		public static string DxGetPixelsFormat (string pixels){ throw new NotImplementedException(); }
		public static Tuple<int, int, int, int> DxGetPixelColor (string pixels, int x, int y){ throw new NotImplementedException(); }
		public static float DxGetTextWidth (string text, float scale, dynamic font, bool bColorCoded){ throw new NotImplementedException(); }
		public static Tuple<int, int, dynamic, dynamic> DxGetMaterialSize (MTAElement material){ throw new NotImplementedException(); }
		public static string DxGetTexturePixels (int surfaceIndex, MTAElement texture, int x, int y, int width, int height){ throw new NotImplementedException(); }
		public static dynamic DxGetStatus (){ throw new NotImplementedException(); }
		public static bool DxDrawText (string text, float left, float top, float right, float bottom, int color, float scaleXY, float scaleY, dynamic font, string alignX, string alignY, bool clip, bool wordBreak, bool postGUI, bool colorCoded, bool subPixelPositioning, float fRotation, float fRotationCenterX, float fRotationCenterY){ throw new NotImplementedException(); }
		public static bool DxSetAspectRatioAdjustmentEnabled (bool bEnabled, float sourceRatio){ throw new NotImplementedException(); }
		public static bool DxSetBlendMode (string blendMode){ throw new NotImplementedException(); }
		public static bool DxSetPixelColor (string pixels, int x, int y, int r, int g, int b, int a){ throw new NotImplementedException(); }
		public static bool DxSetShaderValue (MTAElement theShader, string parameterName, dynamic value){ throw new NotImplementedException(); }
		public static bool DxSetRenderTarget (MTAElement renderTarget, bool clear){ throw new NotImplementedException(); }
		public static bool DxUpdateScreenSource (MTAElement screenSource, bool resampleNow){ throw new NotImplementedException(); }
		public static bool DxSetTextureEdge (MTAElement theTexture, string textureEdge, int border){ throw new NotImplementedException(); }
		public static bool DxSetTestMode (string testMode){ throw new NotImplementedException(); }
		public static bool DxSetTexturePixels (int surfaceIndex, MTAElement texture, string pixels, int x, int y, int width, int height){ throw new NotImplementedException(); }
		public static bool FxAddBlood (float posX, float posY, float posZ, float dirX, float dirY, float dirZ, int count, float brightness){ throw new NotImplementedException(); }
		public static MTAElement CreateEffect (string name, float x, float y, float z, float rX, float rY, float rZ, float drawDistance, bool soundEnable){ throw new NotImplementedException(); }
		public static bool FxAddFootSplash (float posX, float posY, float posZ){ throw new NotImplementedException(); }
		public static bool DxSetShaderTessellation (MTAElement theShader, int tessellationX, int tessellationY){ throw new NotImplementedException(); }
		public static bool FxAddDebris (float posX, float posY, float posZ, int colorR, int colorG, int colorB, int colorA, float scale, int count){ throw new NotImplementedException(); }
		public static bool FxAddBulletSplash (float posX, float posY, float posZ){ throw new NotImplementedException(); }
		public static bool FxAddGunshot (float posX, float posY, float posZ, float dirX, float dirY, float dirZ, bool includeSparks){ throw new NotImplementedException(); }
		public static bool DxSetShaderTransform (MTAElement theShader, float rotationX, float rotationY, float rotationZ, float rotationCenterOffsetX, float rotationCenterOffsetY, float rotationCenterOffsetZ, bool bRotationCenterOffsetOriginIsScreen, float perspectiveCenterOffsetX, float perspectiveCenterOffsetY, bool bPerspectiveCenterOffsetOriginIsScreen){ throw new NotImplementedException(); }
		public static bool FxAddGlass (float posX, float posY, float posZ, int colorR, int colorG, int colorB, int colorA, float scale, int count){ throw new NotImplementedException(); }
		public static bool FxAddBulletImpact (float posX, float posY, float posZ, float dirX, float dirY, float dirZ, int smokeSize, int sparkCount, float smokeIntensity){ throw new NotImplementedException(); }
		public static bool FxAddPunchImpact (float posX, float posY, float posZ, float dirX, float dirY, float dirZ){ throw new NotImplementedException(); }
		public static bool FxAddSparks (float posX, float posY, float posZ, float dirX, float dirY, float dirZ, float force, int count, float acrossLineX, float acrossLineY, float acrossLineZ, bool blur, float spread, float life){ throw new NotImplementedException(); }
		public static bool FxAddTankFire (float posX, float posY, float posZ, float dirX, float dirY, float dirZ){ throw new NotImplementedException(); }
		public static bool FxAddWaterHydrant (float posX, float posY, float posZ){ throw new NotImplementedException(); }
		public static bool FxAddWood (float posX, float posY, float posZ, float dirX, float dirY, float dirZ, int count, float brightness){ throw new NotImplementedException(); }
		public static float GetEffectSpeed (MTAElement theEffect){ throw new NotImplementedException(); }
		public static float GetEffectDensity (MTAElement theEffect){ throw new NotImplementedException(); }
		public static bool SetEffectDensity (MTAElement theEffect, float density){ throw new NotImplementedException(); }
		public static bool FxAddWaterSplash (float posX, float posY, float posZ){ throw new NotImplementedException(); }
		public static Tuple<float, float, float, float, float, float> GetElementBoundingBox (MTAElement theElement){ throw new NotImplementedException(); }
		public static float GetElementDistanceFromCentreOfMassToBaseOfModel (MTAElement theElement){ throw new NotImplementedException(); }
		public static bool SetCursorPosition (int cursorX, int cursorY){ throw new NotImplementedException(); }
		public static bool IsElementCollidableWith (MTAElement theElement, MTAElement withElement){ throw new NotImplementedException(); }
		public static float GetElementRadius (MTAElement theElement){ throw new NotImplementedException(); }
		public static bool IsElementLocal (MTAElement theElement){ throw new NotImplementedException(); }
		public static bool IsElementStreamable (MTAElement theElement){ throw new NotImplementedException(); }
		public static bool IsElementStreamedIn (MTAElement theElement){ throw new NotImplementedException(); }
		public static bool IsElementSyncer (MTAElement theElement){ throw new NotImplementedException(); }
		public static bool IsElementWaitingForGroundToLoad (MTAElement theElement){ throw new NotImplementedException(); }
		public static bool SetElementCollidableWith (MTAElement theElement, MTAElement withElement, bool enabled){ throw new NotImplementedException(); }
		public static bool IsElementOnScreen (MTAElement theElement){ throw new NotImplementedException(); }
		public static bool SetElementStreamable (MTAElement theElement, bool streamable){ throw new NotImplementedException(); }
		public static string EngineGetModelNameFromID (int modelID){ throw new NotImplementedException(); }
		public static bool EngineApplyShaderToWorldTexture (MTAElement shader, string textureName, MTAElement targetElement, bool appendLayers){ throw new NotImplementedException(); }
		public static int EngineGetModelIDFromName (string modelName){ throw new NotImplementedException(); }
		public static dynamic EngineGetModelTextureNames (string modelId){ throw new NotImplementedException(); }
		public static float EngineGetModelLODDistance (int model){ throw new NotImplementedException(); }
		public static bool FxAddTyreBurst (float posX, float posY, float posZ, float dirX, float dirY, float dirZ){ throw new NotImplementedException(); }
		public static bool SetElementMatrix (MTAElement theElement, dynamic theMatrix){ throw new NotImplementedException(); }
		public static dynamic EngineGetVisibleTextureNames (string nameFilter, string modelId){ throw new NotImplementedException(); }
		public static bool EngineImportTXD (MTAElement texture, int model_id){ throw new NotImplementedException(); }
		public static MTAElement EngineLoadIFP (string ifp_file, string CustomBlockName){ throw new NotImplementedException(); }
		public static MTAElement EngineLoadCOL (string col_file){ throw new NotImplementedException(); }
		public static MTAElement EngineLoadTXD (string txd_file, bool filteringEnabled){ throw new NotImplementedException(); }
		public static MTAElement EngineLoadDFF (string dff_file){ throw new NotImplementedException(); }
		public static bool EngineRemoveShaderFromWorldTexture (MTAElement shader, string textureName, MTAElement targetElement){ throw new NotImplementedException(); }
		public static bool EngineReplaceCOL (MTAElement theCol, int modelID){ throw new NotImplementedException(); }
		public static bool SetEffectSpeed (MTAElement theEffect, float speed){ throw new NotImplementedException(); }
		public static bool EngineRestoreModel (int modelID){ throw new NotImplementedException(); }
		public static bool EngineSetAsynchronousLoading (bool enable, bool force){ throw new NotImplementedException(); }
		public static bool EngineReplaceModel (MTAElement theModel, int modelID, bool alphaTransparency){ throw new NotImplementedException(); }
		public static dynamic EngineGetSurfaceProperties (int surfaceID, string property){ throw new NotImplementedException(); }
		public static bool EngineSetSurfaceProperties (int surfaceID, string property, dynamic value){ throw new NotImplementedException(); }
		public static dynamic EngineResetSurfaceProperties (int surfaceID){ throw new NotImplementedException(); }
		public static bool EngineRestoreAnimation (MTAElement thePed, string InternalBlockName, string InternalAnimName){ throw new NotImplementedException(); }
		public static bool EngineReplaceAnimation (MTAElement thePed, string InternalBlockName, string InternalAnimName, string CustomBlockName, string CustomAnimName){ throw new NotImplementedException(); }
		public static bool EngineSetModelLODDistance (int model, float distance){ throw new NotImplementedException(); }
		public static bool EngineRestoreCOL (int modelID){ throw new NotImplementedException(); }
		public static bool TriggerServerEvent (string eventName, MTAElement sourceElement, dynamic arguments){ throw new NotImplementedException(); }
		public static bool TriggerLatentServerEvent (string argument_event, int bandwidth, bool persist, MTAElement theElement){ throw new NotImplementedException(); }
		public static bool ExtinguishFire (float x, float y, float z, float radius){ throw new NotImplementedException(); }
		public static bool GuiBlur (MTAElement guiElement){ throw new NotImplementedException(); }
		public static string GuiGetCursorType (){ throw new NotImplementedException(); }
		public static bool GuiFocus (MTAElement guiElement){ throw new NotImplementedException(); }
		public static Tuple<string, MTAElement> GuiGetFont (MTAElement guiElement){ throw new NotImplementedException(); }
		public static bool GuiBringToFront (MTAElement guiElement){ throw new NotImplementedException(); }
		public static Tuple<float, float> GuiGetPosition (MTAElement guiElement, bool relative){ throw new NotImplementedException(); }
		public static float GuiGetAlpha (MTAElement guiElement){ throw new NotImplementedException(); }
		public static bool CreateFire (float x, float y, float z, float size){ throw new NotImplementedException(); }
		public static string GuiGetInputMode (){ throw new NotImplementedException(); }
		public static bool GuiGetEnabled (MTAElement guiElement){ throw new NotImplementedException(); }
		public static MTAElement GuiCreateFont (string filepath, int size){ throw new NotImplementedException(); }
		public static string GuiGetProperty (MTAElement guiElement, string property){ throw new NotImplementedException(); }
		public static dynamic GuiGetProperties (MTAElement guiElement){ throw new NotImplementedException(); }
		public static Tuple<float, float> GuiGetScreenSize (){ throw new NotImplementedException(); }
		public static Tuple<float, float> GuiGetSize (MTAElement theElement, bool relative){ throw new NotImplementedException(); }
		public static bool GuiSetAlpha (MTAElement guielement, float alpha){ throw new NotImplementedException(); }
		public static bool GuiSetEnabled (MTAElement guiElement, bool enabled){ throw new NotImplementedException(); }
		public static bool GuiSetInputEnabled (bool enabled){ throw new NotImplementedException(); }
		public static bool GuiSetFont (MTAElement guiElement, dynamic font){ throw new NotImplementedException(); }
		public static string GuiGetText (MTAElement guiElement){ throw new NotImplementedException(); }
		public static bool GuiGetVisible (MTAElement guiElement){ throw new NotImplementedException(); }
		public static bool GuiMoveToBack (MTAElement guiElement){ throw new NotImplementedException(); }
		public static bool GuiSetPosition (MTAElement theElement, float x, float y, bool relative){ throw new NotImplementedException(); }
		public static bool GuiSetProperty (MTAElement guiElement, string property, string value){ throw new NotImplementedException(); }
		public static bool GuiSetSize (MTAElement guiElement, float width, float height, bool relative){ throw new NotImplementedException(); }
		public static bool GuiSetInputMode (string mode){ throw new NotImplementedException(); }
		public static bool GuiSetVisible (MTAElement guiElement, bool state){ throw new NotImplementedException(); }
		public static bool IsChatBoxInputActive (){ throw new NotImplementedException(); }
		public static bool IsDebugViewActive (){ throw new NotImplementedException(); }
		public static bool GuiSetText (MTAElement guiElement, string text){ throw new NotImplementedException(); }
		public static bool IsMainMenuActive (){ throw new NotImplementedException(); }
		public static bool SetDebugViewActive (bool enabled){ throw new NotImplementedException(); }
		public static bool GuiCheckBoxSetSelected (MTAElement theCheckbox, bool state){ throw new NotImplementedException(); }
		public static MTAElement GuiCreateButton (float x, float y, float width, float height, string text, bool relative, MTAElement parent){ throw new NotImplementedException(); }
		public static MTAElement GuiCreateCheckBox (float x, float y, float width, float height, string text, bool selected, bool relative, MTAElement parent){ throw new NotImplementedException(); }
		public static MTAElement GuiCreateComboBox (float x, float y, float width, float height, string caption, bool relative, MTAElement parent){ throw new NotImplementedException(); }
		public static bool IsMTAWindowActive (){ throw new NotImplementedException(); }
		public static int GuiComboBoxGetItemCount (MTAElement comboBox){ throw new NotImplementedException(); }
		public static int GuiComboBoxAddItem (MTAElement comboBox, string value){ throw new NotImplementedException(); }
		public static bool IsTransferBoxActive (){ throw new NotImplementedException(); }
		public static bool GuiComboBoxClear (MTAElement comboBox){ throw new NotImplementedException(); }
		public static bool GuiCheckBoxGetSelected (MTAElement theCheckbox){ throw new NotImplementedException(); }
		public static bool GuiComboBoxSetItemText (MTAElement comboBox, int itemId, string text){ throw new NotImplementedException(); }
		public static bool GuiComboBoxSetOpen (MTAElement comboBox, bool state){ throw new NotImplementedException(); }
		public static bool GuiComboBoxRemoveItem (MTAElement comboBox, int itemId){ throw new NotImplementedException(); }
		public static int GuiEditGetCaretIndex (MTAElement theElement){ throw new NotImplementedException(); }
		public static MTAElement GuiCreateEdit (float x, float y, float width, float height, string text, bool relative, MTAElement parent){ throw new NotImplementedException(); }
		public static bool GuiComboBoxSetSelected (MTAElement comboBox, int itemIndex){ throw new NotImplementedException(); }
		public static bool GuiComboBoxIsOpen (MTAElement comboBox){ throw new NotImplementedException(); }
		public static bool GuiEditSetCaretIndex (MTAElement theElement, int index){ throw new NotImplementedException(); }
		public static bool GuiEditIsMasked (MTAElement guiEdit){ throw new NotImplementedException(); }
		public static string GuiComboBoxGetItemText (MTAElement comboBox, int itemId){ throw new NotImplementedException(); }
		public static int GuiComboBoxGetSelected (MTAElement comboBox){ throw new NotImplementedException(); }
		public static bool GuiEditSetMasked (MTAElement theElement, bool status){ throw new NotImplementedException(); }
		public static bool GuiEditSetReadOnly (MTAElement editField, bool status){ throw new NotImplementedException(); }
		public static int GuiEditGetMaxLength (MTAElement guiEdit){ throw new NotImplementedException(); }
		public static bool GuiEditIsReadOnly (MTAElement guiEdit){ throw new NotImplementedException(); }
		public static int GuiGridListAddColumn (MTAElement gridList, string title, float width){ throw new NotImplementedException(); }
		public static MTAElement GuiCreateGridList (float x, float y, float width, float height, bool relative, MTAElement parent){ throw new NotImplementedException(); }
		public static bool GuiEditSetMaxLength (MTAElement guiEdit, int length){ throw new NotImplementedException(); }
		public static int GuiGridListAddRow (MTAElement gridList, dynamic itemText1, dynamic itemText2){ throw new NotImplementedException(); }
		public static bool GuiGridListClear (MTAElement gridList){ throw new NotImplementedException(); }
		public static dynamic GetChatboxLayout (string CVar){ throw new NotImplementedException(); }
		public static int GuiGridListGetColumnCount (MTAElement gridList){ throw new NotImplementedException(); }
		public static bool GuiGetInputEnabled (){ throw new NotImplementedException(); }
		public static int GuiGridListGetRowCount (MTAElement gridList){ throw new NotImplementedException(); }
		public static string GuiGridListGetItemText (MTAElement gridList, int rowIndex, int columnIndex){ throw new NotImplementedException(); }
		public static dynamic GuiGridListGetItemData (MTAElement gridList, int rowIndex, int columnIndex){ throw new NotImplementedException(); }
		public static int GuiGridListGetSelectedCount (MTAElement gridList){ throw new NotImplementedException(); }
		public static bool GuiGridListGetColumnWidth (MTAElement gridList, int columnIndex, bool relative){ throw new NotImplementedException(); }
		public static int GuiGridListInsertRowAfter (MTAElement gridList, int rowIndex){ throw new NotImplementedException(); }
		public static float GuiGridListGetHorizontalScrollPosition (MTAElement guiGridlist){ throw new NotImplementedException(); }
		public static string GuiGridListGetColumnTitle (MTAElement guiGridlist, int columnIndex){ throw new NotImplementedException(); }
		public static float GuiGridListGetVerticalScrollPosition (MTAElement guiGridlist){ throw new NotImplementedException(); }
		public static dynamic GuiGridListGetSelectedItems (MTAElement gridList){ throw new NotImplementedException(); }
		public static Tuple<int, int, int, int> GuiGridListGetItemColor (MTAElement gridList, int rowIndex, int columnIndex){ throw new NotImplementedException(); }
		public static Tuple<int, int> GuiGridListGetSelectedItem (MTAElement gridList){ throw new NotImplementedException(); }
		public static bool GuiGridListRemoveColumn (MTAElement gridList, int columnIndex){ throw new NotImplementedException(); }
		public static bool GuiGridListSetColumnWidth (MTAElement gridList, int columnIndex, float width, bool relative){ throw new NotImplementedException(); }
		public static bool GuiGridListSetColumnTitle (MTAElement guiGridlist, int columnIndex, string title){ throw new NotImplementedException(); }
		public static bool GuiGridListRemoveRow (MTAElement gridList, int rowIndex){ throw new NotImplementedException(); }
		public static bool GuiGridListSetHorizontalScrollPosition (MTAElement guiGridlist, float fPosition){ throw new NotImplementedException(); }
		public static bool GuiGridListSetItemText (MTAElement gridList, int rowIndex, int columnIndex, string text, bool section, bool number){ throw new NotImplementedException(); }
		public static bool GuiGridListSetScrollBars (MTAElement guiGridlist, bool horizontalBar, bool verticalBar){ throw new NotImplementedException(); }
		public static bool GuiGridListSetItemColor (MTAElement gridList, int rowIndex, int columnIndex, int red, int green, int blue, int alpha){ throw new NotImplementedException(); }
		public static bool GuiGridListSetSelectionMode (MTAElement gridlist, int mode){ throw new NotImplementedException(); }
		public static bool GuiGridListSetSelectedItem (MTAElement gridList, int rowIndex, int columnIndex, bool bReset){ throw new NotImplementedException(); }
		public static bool GuiGridListSetItemData (MTAElement gridList, int rowIndex, int columnIndex, dynamic data){ throw new NotImplementedException(); }
		public static bool GuiGridListSetSortingEnabled (MTAElement guiGridlist, bool enabled){ throw new NotImplementedException(); }
		public static bool GuiGridListSetVerticalScrollPosition (MTAElement guiGridlist, float fPosition){ throw new NotImplementedException(); }
		public static MTAElement GuiCreateMemo (float x, float y, float width, float height, string text, bool relative, MTAElement parent){ throw new NotImplementedException(); }
		public static int GuiMemoGetCaretIndex (MTAElement theElement){ throw new NotImplementedException(); }
		public static bool GuiMemoSetReadOnly (MTAElement theMemo, bool status){ throw new NotImplementedException(); }
		public static bool GuiProgressBarSetProgress (MTAElement theProgressbar, float progress){ throw new NotImplementedException(); }
		public static bool GuiMemoIsReadOnly (MTAElement theMemo){ throw new NotImplementedException(); }
		public static bool GuiMemoSetCaretIndex (MTAElement theMemo, int index){ throw new NotImplementedException(); }
		public static float GuiMemoGetVerticalScrollPosition (MTAElement theMemo){ throw new NotImplementedException(); }
		public static float GuiProgressBarGetProgress (MTAElement theProgressbar){ throw new NotImplementedException(); }
		public static bool IsConsoleActive (){ throw new NotImplementedException(); }
		public static MTAElement GuiCreateScrollBar (float x, float y, float width, float height, bool horizontal, bool relative, MTAElement parent){ throw new NotImplementedException(); }
		public static bool GuiRadioButtonGetSelected (MTAElement guiRadioButton){ throw new NotImplementedException(); }
		public static bool GuiMemoSetVerticalScrollPosition (MTAElement theMemo, float position){ throw new NotImplementedException(); }
		public static MTAElement GuiCreateRadioButton (float x, float y, float width, float height, string text, bool relative, MTAElement parent){ throw new NotImplementedException(); }
		public static bool GuiRadioButtonSetSelected (MTAElement guiRadioButton, bool state){ throw new NotImplementedException(); }
		public static float GuiScrollBarGetScrollPosition (MTAElement theScrollBar){ throw new NotImplementedException(); }
		public static bool GuiScrollBarSetScrollPosition (MTAElement theScrollBar, float amount){ throw new NotImplementedException(); }
		public static float GuiScrollPaneGetVerticalScrollPosition (MTAElement verticalScrollPane){ throw new NotImplementedException(); }
		public static MTAElement GuiCreateScrollPane (float x, float y, float width, float height, bool relative, MTAElement parent){ throw new NotImplementedException(); }
		public static float GuiScrollPaneGetHorizontalScrollPosition (MTAElement horizontalScrollPane){ throw new NotImplementedException(); }
		public static MTAElement GuiCreateStaticImage (float x, float y, float width, float height, string path, bool relative, MTAElement parent){ throw new NotImplementedException(); }
		public static bool GuiScrollPaneSetVerticalScrollPosition (MTAElement verticalScrollPane, float position){ throw new NotImplementedException(); }
		public static bool GuiScrollPaneSetScrollBars (MTAElement scrollPane, bool horizontal, bool vertical){ throw new NotImplementedException(); }
		public static MTAElement GuiCreateTabPanel (float x, float y, float width, float height, bool relative, MTAElement parent){ throw new NotImplementedException(); }
		public static bool GuiScrollPaneSetHorizontalScrollPosition (MTAElement horizontalScrollPane, float position){ throw new NotImplementedException(); }
		public static bool GuiStaticImageLoadImage (MTAElement theElement, string filename){ throw new NotImplementedException(); }
		public static bool GuiSetSelectedTab (MTAElement tabPanel, MTAElement theTab){ throw new NotImplementedException(); }
		public static bool GuiDeleteTab (MTAElement tabToDelete, MTAElement tabPanel){ throw new NotImplementedException(); }
		public static MTAElement GuiCreateTab (string text, MTAElement parent){ throw new NotImplementedException(); }
		public static MTAElement GuiGetSelectedTab (MTAElement tabPanel){ throw new NotImplementedException(); }
		public static MTAElement GuiCreateLabel (float x, float y, float width, float height, string text, bool relative, MTAElement parent){ throw new NotImplementedException(); }
		public static Tuple<int, int, int> GuiLabelGetColor (MTAElement theLabel){ throw new NotImplementedException(); }
		public static float GuiLabelGetFontHeight (MTAElement theLabel){ throw new NotImplementedException(); }
		public static bool GuiLabelSetColor (MTAElement theElement, int red, int green, int blue){ throw new NotImplementedException(); }
		public static float GuiLabelGetTextExtent (MTAElement theLabel){ throw new NotImplementedException(); }
		public static Tuple<int, int> GuiStaticImageGetNativeSize (MTAElement theImage){ throw new NotImplementedException(); }
		public static MTAElement GuiCreateProgressBar (float x, float y, float width, float height, bool relative, MTAElement parent){ throw new NotImplementedException(); }
		public static bool GuiLabelSetHorizontalAlign (MTAElement theLabel, string align, bool wordwrap){ throw new NotImplementedException(); }
		public static MTAElement GuiCreateWindow (float x, float y, float width, float height, string titleBarText, bool relative){ throw new NotImplementedException(); }
		public static bool GuiLabelSetVerticalAlign (MTAElement theLabel, string align){ throw new NotImplementedException(); }
		public static bool GuiWindowIsSizable (MTAElement guiWindow){ throw new NotImplementedException(); }
		public static bool GuiWindowIsMovable (MTAElement guiWindow){ throw new NotImplementedException(); }
		public static bool GuiWindowSetSizable (MTAElement theElement, bool status){ throw new NotImplementedException(); }
		public static bool GuiWindowSetMovable (MTAElement theElement, bool status){ throw new NotImplementedException(); }
		public static string GetKeyBoundToCommand (string command){ throw new NotImplementedException(); }
		public static dynamic GetBoundKeys (string command){ throw new NotImplementedException(); }
		public static dynamic GetCommandsBoundToKey (string theKey, string keyState){ throw new NotImplementedException(); }
		public static float GetAnalogControlState (string control){ throw new NotImplementedException(); }
		public static bool GetKeyState (string keyName){ throw new NotImplementedException(); }
		public static bool GuiGridListAutoSizeColumn (MTAElement gridList, int columnIndex){ throw new NotImplementedException(); }
		public static Tuple<int, int, int> GetLightColor (MTAElement theLight){ throw new NotImplementedException(); }
		public static MTAElement CreateLight (int lightType, float posX, float posY, float posZ, float radius, int r, int g, int b, float dirX, float dirY, float dirZ, bool createsShadow){ throw new NotImplementedException(); }
		public static int GetLightType (MTAElement theLight){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetLightDirection (MTAElement theLight){ throw new NotImplementedException(); }
		public static float GetLightRadius (MTAElement theLight){ throw new NotImplementedException(); }
		public static bool SetLightColor (MTAElement theLight, float r, float g, float b){ throw new NotImplementedException(); }
		public static bool SetLightRadius (MTAElement theLight, float radius){ throw new NotImplementedException(); }
		public static bool SetLightDirection (MTAElement theLight, float x, float y, float z){ throw new NotImplementedException(); }
		public static bool BreakObject (MTAElement theObject){ throw new NotImplementedException(); }
		public static float GetObjectMass (MTAElement theObject){ throw new NotImplementedException(); }
		public static bool IsObjectBreakable (MTAElement theObject){ throw new NotImplementedException(); }
		public static bool SetObjectBreakable (MTAElement theObject, bool breakable){ throw new NotImplementedException(); }
		public static bool RespawnObject (MTAElement theObject){ throw new NotImplementedException(); }
		public static bool SetObjectMass (MTAElement theObject, float mass){ throw new NotImplementedException(); }
		public static dynamic GetObjectProperty (MTAElement theObject, string property){ throw new NotImplementedException(); }
		public static bool SetObjectProperty (MTAElement theObject, string property, dynamic value){ throw new NotImplementedException(); }
		public static bool IsChatVisible (){ throw new NotImplementedException(); }
		public static bool ToggleObjectRespawn (MTAElement theObject, bool respawn){ throw new NotImplementedException(); }
		public static float GetPedAnalogControlState (MTAElement thePed, string controlName){ throw new NotImplementedException(); }
		public static bool CanPedBeKnockedOffBike (MTAElement thePed){ throw new NotImplementedException(); }
		public static Tuple<string, string> GetPedAnimation (MTAElement thePed){ throw new NotImplementedException(); }
		public static float GetPedCameraRotation (MTAElement thePed){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetPedBonePosition (MTAElement thePed, int bone){ throw new NotImplementedException(); }
		public static bool GetPedControlState (MTAElement thePed, string control){ throw new NotImplementedException(); }
		public static string GetPedMoveState (MTAElement thePed){ throw new NotImplementedException(); }
		public static float GetPedOxygenLevel (MTAElement thePed){ throw new NotImplementedException(); }
		public static string GetPedSimplestTask (MTAElement thePed){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetPedTargetEnd (MTAElement targetingPed){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetPedTargetCollision (MTAElement targetingPed){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetPedTargetStart (MTAElement targetingPed){ throw new NotImplementedException(); }
		public static Tuple<string, string, string, string> GetPedTask (MTAElement thePed, string priority, int taskType){ throw new NotImplementedException(); }
		public static Tuple<string, string> GetPedVoice (MTAElement thePed){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetPedWeaponMuzzlePosition (MTAElement thePed){ throw new NotImplementedException(); }
		public static bool GivePedWeapon (MTAElement thePed, int weapon, int ammo, bool setAsCurrent){ throw new NotImplementedException(); }
		public static bool IsPedDoingTask (MTAElement thePed, string taskName){ throw new NotImplementedException(); }
		public static bool IsPedReloadingWeapon (MTAElement thePed){ throw new NotImplementedException(); }
		public static bool IsPedTargetingMarkerEnabled (){ throw new NotImplementedException(); }
		public static bool SetPedAimTarget (MTAElement thePed, float x, float y, float z){ throw new NotImplementedException(); }
		public static bool SetPedAnalogControlState (MTAElement thePed, string control, float state){ throw new NotImplementedException(); }
		public static bool SetAnalogControlState (string control, float state){ throw new NotImplementedException(); }
		public static bool SetPedCanBeKnockedOffBike (MTAElement thePed, bool canBeKnockedOffBike){ throw new NotImplementedException(); }
		public static bool SetPedControlState (MTAElement thePed, string control, bool state){ throw new NotImplementedException(); }
		public static bool SetPedCameraRotation (MTAElement thePed, float cameraRotation){ throw new NotImplementedException(); }
		public static bool SetPedFootBloodEnabled (MTAElement thePlayer, bool enabled){ throw new NotImplementedException(); }
		public static bool SetPedLookAt (MTAElement thePed, float x, float y, float z, int time, int blend, MTAElement target){ throw new NotImplementedException(); }
		public static bool SetPedOxygenLevel (MTAElement thePed, float oxygen){ throw new NotImplementedException(); }
		public static bool SetPedTargetingMarkerEnabled (bool enabled){ throw new NotImplementedException(); }
		public static bool SetPedVoice (MTAElement thePed, string voiceType, string voiceName){ throw new NotImplementedException(); }
		public static MTAElement GetLocalPlayer (){ throw new NotImplementedException(); }
		public static Tuple<int, int, int, int> GetPlayerMapBoundingBox (){ throw new NotImplementedException(); }
		public static bool IsPlayerHudComponentVisible (string component){ throw new NotImplementedException(); }
		public static int GetProjectileCounter (MTAElement projectile){ throw new NotImplementedException(); }
		public static MTAElement CreateProjectile (MTAElement creator, int weaponType, float posX, float posY, float posZ, float force, MTAElement target, float rotX, float rotY, float rotZ, float velX, float velY, float velZ, int model){ throw new NotImplementedException(); }
		public static bool IsPlayerMapVisible (){ throw new NotImplementedException(); }
		public static MTAElement GetProjectileCreator (MTAElement theProjectile){ throw new NotImplementedException(); }
		public static float GetProjectileForce (MTAElement theProjectile){ throw new NotImplementedException(); }
		public static int GetProjectileType (MTAElement theProjectile){ throw new NotImplementedException(); }
		public static bool SetProjectileCounter (MTAElement projectile, int timeToDetonate){ throw new NotImplementedException(); }
		public static MTAElement GetProjectileTarget (MTAElement theProjectile){ throw new NotImplementedException(); }
		public static MTAElement GetResourceGUIElement (MTAResource theResource){ throw new NotImplementedException(); }
		public static MTAElement CreateSearchLight (float startX, float startY, float startZ, float endX, float endY, float endZ, float startRadius, float endRadius, bool renderSpot){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetSearchLightEndPosition (MTAElement theSearchLight){ throw new NotImplementedException(); }
		public static bool SetSearchLightEndPosition (MTAElement theSearchLight, float endX, float endY, float endZ){ throw new NotImplementedException(); }
		public static float GetSearchLightEndRadius (MTAElement theSearchLight){ throw new NotImplementedException(); }
		public static float GetSearchLightStartRadius (MTAElement theSearchLight){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetSearchLightStartPosition (MTAElement theSearchLight){ throw new NotImplementedException(); }
		public static bool SetSearchLightEndRadius (MTAElement theSearchlight, float endRadius){ throw new NotImplementedException(); }
		public static bool SetSearchLightStartRadius (MTAElement theSearchlight, float startRadius){ throw new NotImplementedException(); }
		public static bool SetSearchLightStartPosition (MTAElement theSearchLight, float startX, float startY, float startZ){ throw new NotImplementedException(); }
		public static bool CreateTrayNotification (string notificationText, string iconType, bool useSound){ throw new NotImplementedException(); }
		public static bool DownloadFile (string fileName){ throw new NotImplementedException(); }
		public static dynamic GetLocalization (){ throw new NotImplementedException(); }
		public static bool IsTrayNotificationEnabled (){ throw new NotImplementedException(); }
		public static bool SetClipboard (string theText){ throw new NotImplementedException(); }
		public static bool SetWindowFlashing (bool shouldFlash, int count){ throw new NotImplementedException(); }
		public static float GetHelicopterRotorSpeed (MTAElement heli){ throw new NotImplementedException(); }
		public static int GetVehicleAdjustableProperty (MTAElement theVehicle){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetVehicleComponentRotation (MTAElement theVehicle, string theComponent, string argument_base){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetVehicleComponentPosition (MTAElement theVehicle, string theComponent, string argument_base){ throw new NotImplementedException(); }
		public static int GetVehicleCurrentGear (MTAElement theVehicle){ throw new NotImplementedException(); }
		public static bool GetVehicleComponentVisible (MTAElement theVehicle, string theComponent){ throw new NotImplementedException(); }
		public static dynamic GetVehicleComponents (MTAElement theVehicle){ throw new NotImplementedException(); }
		public static int GetVehicleNitroCount (MTAElement theVehicle){ throw new NotImplementedException(); }
		public static float GetVehicleNitroLevel (MTAElement theVehicle){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetVehicleModelExhaustFumesPosition (int modelID){ throw new NotImplementedException(); }
		public static bool IsTrainChainEngine (MTAElement theTrain){ throw new NotImplementedException(); }
		public static bool IsVehicleWheelOnGround (MTAElement theVehicle, dynamic wheel){ throw new NotImplementedException(); }
		public static bool ResetVehicleComponentRotation (MTAElement theVehicle, string theComponent){ throw new NotImplementedException(); }
		public static bool SetHelicopterRotorSpeed (MTAElement heli, float speed){ throw new NotImplementedException(); }
		public static bool ResetVehicleComponentPosition (MTAElement theVehicle, string theComponent){ throw new NotImplementedException(); }
		public static bool SetHeliBladeCollisionsEnabled (MTAElement theVehicle, bool collisions){ throw new NotImplementedException(); }
		public static bool IsVehicleNitroRecharging (MTAElement theVehicle){ throw new NotImplementedException(); }
		public static bool IsVehicleWindowOpen (MTAElement theVehicle, int window){ throw new NotImplementedException(); }
		public static bool GetHeliBladeCollisionsEnabled (MTAElement theVehicle){ throw new NotImplementedException(); }
		public static bool SetVehicleComponentRotation (MTAElement theVehicle, string theComponent, float rotX, float rotY, float rotZ, string argument_base){ throw new NotImplementedException(); }
		public static bool SetVehicleComponentVisible (MTAElement theVehicle, string theComponent, bool visible){ throw new NotImplementedException(); }
		public static bool SetVehicleAdjustableProperty (MTAElement theVehicle, int value){ throw new NotImplementedException(); }
		public static bool SetVehicleComponentPosition (MTAElement theVehicle, string theComponent, float posX, float posY, float posZ, string argument_base){ throw new NotImplementedException(); }
		public static bool SetVehicleNitroActivated (MTAElement theVehicle, bool state){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetVehicleGravity (MTAElement theVehicle){ throw new NotImplementedException(); }
		public static bool SetVehicleModelExhaustFumesPosition (int modelID, float posX, float posY, float posZ){ throw new NotImplementedException(); }
		public static bool SetVehicleNitroLevel (MTAElement theVehicle, float level){ throw new NotImplementedException(); }
		public static bool SetVehicleWindowOpen (MTAElement theVehicle, int window, bool open){ throw new NotImplementedException(); }
		public static float GetWaterLevel (float posX, float posY, float posZ, bool bCheckWaves){ throw new NotImplementedException(); }
        public static float GetWaterLevel(MTAElement theWater) { throw new NotImplementedException(); }
        public static bool SetWaterDrawnLast (bool bEnabled){ throw new NotImplementedException(); }
		public static bool IsWaterDrawnLast (){ throw new NotImplementedException(); }
		public static int GetWeaponClipAmmo (MTAElement theWeapon){ throw new NotImplementedException(); }
		public static MTAElement CreateWeapon (string theType, float x, float y, float z){ throw new NotImplementedException(); }
		public static bool GetWeaponFlags (MTAElement theWeapon, string theFlag){ throw new NotImplementedException(); }
		public static int GetWeaponAmmo (MTAElement theWeapon){ throw new NotImplementedException(); }
		public static bool IsVehicleNitroActivated (MTAElement theVehicle){ throw new NotImplementedException(); }
		public static bool GetWeaponOwner (MTAElement theWeapon){ throw new NotImplementedException(); }
		public static bool FireWeapon (MTAElement theWeapon){ throw new NotImplementedException(); }
		public static dynamic GetWeaponTarget (MTAElement theWeapon){ throw new NotImplementedException(); }
		public static string GetWeaponState (MTAElement theWeapon){ throw new NotImplementedException(); }
		public static bool ResetWeaponFiringRate (MTAElement theWeapon){ throw new NotImplementedException(); }
		public static bool SetWeaponState (MTAElement theWeapon, string theState){ throw new NotImplementedException(); }
		public static bool SetWeaponFlags (MTAElement theWeapon, string theFlag, bool enable){ throw new NotImplementedException(); }
		public static bool GetBirdsEnabled (){ throw new NotImplementedException(); }
		public static bool SetWeaponClipAmmo (MTAElement theWeapon, int clipAmmo){ throw new NotImplementedException(); }
		public static bool CreateSWATRope (float fx, float fy, float fZ, int duration){ throw new NotImplementedException(); }
		public static bool SetWeaponFiringRate (MTAElement theWeapon, int firingRate){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetGaragePosition (int garageID){ throw new NotImplementedException(); }
		public static bool GetInteriorSoundsEnabled (){ throw new NotImplementedException(); }
		public static bool GetInteriorFurnitureEnabled (int roomID){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetGarageSize (int garageID){ throw new NotImplementedException(); }
		public static Tuple<float, float, float, float> GetGarageBoundingBox (int garageID){ throw new NotImplementedException(); }
		public static float GetGroundPosition (float x, float y, float z){ throw new NotImplementedException(); }
		public static bool SetVehicleGravity (MTAElement theVehicle, float x, float y, float z){ throw new NotImplementedException(); }
		public static float GetNearClipDistance (){ throw new NotImplementedException(); }
		public static bool SetVehicleNitroCount (MTAElement theVehicle, int count){ throw new NotImplementedException(); }
		public static float GetPedsLODDistance (){ throw new NotImplementedException(); }
		public static bool ResetPedsLODDistance (){ throw new NotImplementedException(); }
		public static bool SetPedsLODDistance (float distance){ throw new NotImplementedException(); }
		public static Tuple<float, float> GetScreenFromWorldPosition (float x, float y, float z, float edgeTolerance, bool relative){ throw new NotImplementedException(); }
		public static Tuple<float, float> GetVehiclesLODDistance (){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetWorldFromScreenPosition (float x, float y, float depth){ throw new NotImplementedException(); }
		public static bool IsWorldSoundEnabled (int group, int index){ throw new NotImplementedException(); }
		public static bool IsWorldSpecialPropertyEnabled (string propname){ throw new NotImplementedException(); }
		public static bool IsAmbientSoundEnabled (string theType){ throw new NotImplementedException(); }
		public static Tuple<bool, float, float, float, MTAElement, float, float, Tuple<float, int, float, int, int, float, float, Tuple<float, float, float, float, int>>> ProcessLineOfSight (float startX, float startY, float startZ, float endX, float endY, float endZ, bool checkBuildings, bool checkVehicles, bool checkPlayers, bool checkObjects, bool checkDummies, bool seeThroughStuff, bool ignoreSomeObjectsForCamera, bool shootThroughStuff, MTAElement ignoredElement, bool includeWorldModelInformation, bool bIncludeCarTyres){ throw new NotImplementedException(); }
		public static bool IsLineOfSightClear (float startX, float startY, float startZ, float endX, float endY, float endZ, bool checkBuildings, bool checkVehicles, bool checkPeds, bool checkObjects, bool checkDummies, bool seeThroughStuff, bool ignoreSomeObjectsForCamera, MTAElement ignoredElement){ throw new NotImplementedException(); }
		public static bool ResetAmbientSounds (){ throw new NotImplementedException(); }
		public static bool ResetVehiclesLODDistance (){ throw new NotImplementedException(); }
		public static int GetWeaponFiringRate (MTAElement theWeapon){ throw new NotImplementedException(); }
		public static bool ResetWorldSounds (){ throw new NotImplementedException(); }
		public static bool SetBirdsEnabled (bool enable){ throw new NotImplementedException(); }
		public static bool SetAmbientSoundEnabled (string theType, bool enable){ throw new NotImplementedException(); }
		public static bool SetInteriorFurnitureEnabled (int roomID, bool enabled){ throw new NotImplementedException(); }
		public static bool SetNearClipDistance (float distance){ throw new NotImplementedException(); }
		public static bool SetVehiclesLODDistance (float vehiclesDistance, float trainsAndPlanesDistance){ throw new NotImplementedException(); }

        public static bool SetWorldSoundEnabled(int group, int index, bool enable, bool immediate) { throw new NotImplementedException(); }
        public static bool SetWorldSpecialPropertyEnabled (string propname, bool enable){ throw new NotImplementedException(); }
		public static Tuple<bool, float, float, float> TestLineAgainstWater (float startX, float startY, float startZ, float endX, float endY, float endZ){ throw new NotImplementedException(); }
	}
}