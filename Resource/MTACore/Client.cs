using System;

namespace MultiTheftAuto {
	public class Client {
		public static bool PlaySoundFrontEnd (int sound){ throw new NotImplementedException(); }
		public static Element CreateBlipAttachedTo (Element elementToAttachTo, int icon, int size, int r, int g, int b, int a, int ordering, float visibleDistance){ throw new NotImplementedException(); }
		public static Element CreateBlip (float x, float y, float z, int icon, int size, int r, int g, int b, int a, int ordering, float visibleDistance){ throw new NotImplementedException(); }
		public static bool FadeCamera (bool fadeIn, float timeToFade, int red, int green, int blue){ throw new NotImplementedException(); }
		public static Tuple<float, float, float, float, float, float, float, float> GetCameraMatrix (){ throw new NotImplementedException(); }
		public static int GetCameraInterior (){ throw new NotImplementedException(); }
		public static Element GetCameraTarget (){ throw new NotImplementedException(); }
		public static bool SetCameraInterior (int interior){ throw new NotImplementedException(); }
		public static bool SetCameraMatrix (float positionX, float positionY, float positionZ, float lookAtX, float lookAtY, float lookAtZ, float roll, float fov){ throw new NotImplementedException(); }
		public static bool SetCameraTarget (Element target){ throw new NotImplementedException(); }
		public static bool IsCursorShowing (){ throw new NotImplementedException(); }
		public static bool ShowCursor (bool show, bool toggleControls){ throw new NotImplementedException(); }
		public static dynamic GetElementsByType (string theType, Element startat){ throw new NotImplementedException(); }
		public static bool CancelEvent (){ throw new NotImplementedException(); }
		public static bool CancelLatentEvent (int handle){ throw new NotImplementedException(); }
		public static dynamic GetLatentEventHandles (){ throw new NotImplementedException(); }
		public static dynamic GetLatentEventStatus (int handle){ throw new NotImplementedException(); }
		public static bool CreateExplosion (float x, float y, float z, int theType, bool makeSound, float camShake){ throw new NotImplementedException(); }
		public static bool BindKey (string key, string keyState, dynamic handlerFunction, dynamic arguments){ throw new NotImplementedException(); }
		public static bool AddCommandHandler (string commandName, dynamic handlerFunction, bool caseSensitive){ throw new NotImplementedException(); }
		public static string GetKeyBoundToFunction (dynamic theFunction){ throw new NotImplementedException(); }
		public static bool ExecuteCommandHandler (string commandName, string args){ throw new NotImplementedException(); }
		public static dynamic GetFunctionsBoundToKey (string key, string keyState){ throw new NotImplementedException(); }
		public static bool IsControlEnabled (string control){ throw new NotImplementedException(); }
		public static bool ToggleAllControls (bool enabled, bool gtaControls, bool mtaControls){ throw new NotImplementedException(); }
		public static bool ToggleControl (string control, bool enabled){ throw new NotImplementedException(); }
		public static bool UnbindKey (string key, string keyState, string command){ throw new NotImplementedException(); }
		public static Element CreateMarker (float x, float y, float z, string theType, float size, int r, int g, int b, int a){ throw new NotImplementedException(); }
		public static bool ClearChatBox (){ throw new NotImplementedException(); }
		public static bool OutputChatBox (string text, int r, int g, int b, bool colorCoded){ throw new NotImplementedException(); }
		public static bool OutputConsole (string text){ throw new NotImplementedException(); }
		public static bool ShowChat (bool show){ throw new NotImplementedException(); }
		public static Element CreatePed (int modelid, float x, float y, float z, float rot){ throw new NotImplementedException(); }
		public static bool ForcePlayerMap (bool forceOn){ throw new NotImplementedException(); }
		public static int GetPlayerBlurLevel (){ throw new NotImplementedException(); }
		public static int GetPlayerMoney (){ throw new NotImplementedException(); }
		public static int GetPlayerWantedLevel (){ throw new NotImplementedException(); }
		public static bool GivePlayerMoney (int amount){ throw new NotImplementedException(); }
		public static bool IsPlayerMapForced (){ throw new NotImplementedException(); }
		public static bool SetPlayerBlurLevel (int level){ throw new NotImplementedException(); }
		public static bool SetPlayerHudComponentVisible (string component, bool show){ throw new NotImplementedException(); }
		public static bool SetPlayerMoney (int amount, bool instant){ throw new NotImplementedException(); }
		public static bool DetonateSatchels (){ throw new NotImplementedException(); }
		public static bool TakePlayerMoney (int amount){ throw new NotImplementedException(); }
		public static dynamic GetNetworkStats (){ throw new NotImplementedException(); }
		public static bool BlowVehicle (Element vehicleToBlow){ throw new NotImplementedException(); }
		public static int GetRadioChannel (){ throw new NotImplementedException(); }
		public static string GetRadioChannelName (int id){ throw new NotImplementedException(); }
		public static bool GetSFXStatus (string audioContainer){ throw new NotImplementedException(); }
		public static float GetSoundBufferLength (Element theSound){ throw new NotImplementedException(); }
		public static int GetSoundBPM (Element sound){ throw new NotImplementedException(); }
		public static Tuple<int, int> GetSoundLevelData (Element theSound){ throw new NotImplementedException(); }
		public static float GetSoundLength (Element theSound){ throw new NotImplementedException(); }
		public static dynamic GetSoundEffects (Element sound){ throw new NotImplementedException(); }
		public static dynamic GetSoundFFTData (Element sound, int iSamples, int iBands){ throw new NotImplementedException(); }
		public static int GetSoundMaxDistance (Element sound){ throw new NotImplementedException(); }
		public static float GetSoundPosition (Element theSound){ throw new NotImplementedException(); }
		public static float GetSoundPan (Element theSound){ throw new NotImplementedException(); }
		public static int GetSoundMinDistance (Element sound){ throw new NotImplementedException(); }
		public static dynamic GetSoundMetaTags (Element sound, string format){ throw new NotImplementedException(); }
		public static float GetSoundSpeed (Element theSound){ throw new NotImplementedException(); }
		public static Tuple<float, float, float, bool> GetSoundProperties (Element sound){ throw new NotImplementedException(); }
		public static bool IsSoundPanningEnabled (Element theSound){ throw new NotImplementedException(); }
		public static float GetSoundVolume (Element theSound){ throw new NotImplementedException(); }
		public static dynamic GetSoundWaveData (Element sound, int iSamples){ throw new NotImplementedException(); }
		public static Element PlaySound (string soundPath, bool looped, bool throttled){ throw new NotImplementedException(); }
		public static bool IsSoundPaused (Element theSound){ throw new NotImplementedException(); }
		public static bool SetRadioChannel (int ID){ throw new NotImplementedException(); }
		public static bool SetSoundMinDistance (Element sound, int distance){ throw new NotImplementedException(); }
		public static bool SetSoundPanningEnabled (Element sound, bool enable){ throw new NotImplementedException(); }
		public static Element PlaySFX3D (string containerName, int bankId, int soundId, float x, float y, float z, bool looped){ throw new NotImplementedException(); }
		public static bool SetSoundSpeed (Element theSound, float speed){ throw new NotImplementedException(); }
		public static Element PlaySFX (string containerName, int bankId, int soundId, bool looped){ throw new NotImplementedException(); }
		public static bool SetSoundPan (Element theSound, float pan){ throw new NotImplementedException(); }
		public static bool SetSoundPaused (Element theSound, bool paused){ throw new NotImplementedException(); }
		public static bool SetSoundVolume (Element theSound, float volume){ throw new NotImplementedException(); }
		public static Element PlaySound3D (string soundPath, float x, float y, float z, bool looped){ throw new NotImplementedException(); }
		public static bool SetSoundMaxDistance (Element sound, int distance){ throw new NotImplementedException(); }
		public static bool SetSoundPosition (Element theSound, float pos){ throw new NotImplementedException(); }
		public static bool SetSoundEffectEnabled (Element sound, string effectName, bool bEnable){ throw new NotImplementedException(); }
		public static bool SetSoundProperties (Element sound, float fSampleRate, float fTempo, float fPitch, bool bReverse){ throw new NotImplementedException(); }
		public static bool FocusBrowser (Element webBrowser){ throw new NotImplementedException(); }
		public static bool ExecuteBrowserJavascript (Element webBrowser, string jsCode){ throw new NotImplementedException(); }
		public static bool CanBrowserNavigateForward (Element webBrowser){ throw new NotImplementedException(); }
		public static bool StopSound (Element theSound){ throw new NotImplementedException(); }
		public static dynamic GetBrowserSettings (){ throw new NotImplementedException(); }
		public static bool InjectBrowserMouseMove (Element webBrowser, int posX, int posY){ throw new NotImplementedException(); }
		public static bool GetBrowserProperty (Element theBrowser, string key){ throw new NotImplementedException(); }
		public static bool CanBrowserNavigateBack (Element webBrowser){ throw new NotImplementedException(); }
		public static string GetBrowserURL (Element webBrowser){ throw new NotImplementedException(); }
		public static Element CreateBrowser (int width, int height, bool isLocal, bool transparent){ throw new NotImplementedException(); }
		public static string GetBrowserTitle (Element webBrowser){ throw new NotImplementedException(); }
		public static bool GetBrowserSource (Element webBrowser, dynamic callback){ throw new NotImplementedException(); }
		public static bool InjectBrowserMouseUp (Element webBrowser, string mouseButton){ throw new NotImplementedException(); }
		public static bool InjectBrowserMouseDown (Element webBrowser, string mouseButton){ throw new NotImplementedException(); }
		public static bool IsBrowserFocused (Element webBrowser){ throw new NotImplementedException(); }
		public static bool IsBrowserDomainBlocked (string address, bool isURL){ throw new NotImplementedException(); }
		public static bool InjectBrowserMouseWheel (Element webBrowser, int verticalScroll, int horizontalScroll){ throw new NotImplementedException(); }
		public static bool IsBrowserLoading (Element webBrowser){ throw new NotImplementedException(); }
		public static bool NavigateBrowserBack (Element webBrowser){ throw new NotImplementedException(); }
		public static bool LoadBrowserURL (Element webBrowser, string url, string postData, bool urlEncoded){ throw new NotImplementedException(); }
		public static bool RequestBrowserDomains (dynamic pages, bool parseAsURL, Action<bool, string[]> callback){ throw new NotImplementedException(); }
		public static bool ResizeBrowser (Element webBrowser, float width, float height){ throw new NotImplementedException(); }
		public static bool ReloadBrowserPage (Element webBrowser){ throw new NotImplementedException(); }
		public static bool SetBrowserAjaxHandler (Element webBrowser, string url, dynamic handler){ throw new NotImplementedException(); }
		public static bool SetBrowserProperty (Element theBrowser, string key, string value){ throw new NotImplementedException(); }
		public static bool NavigateBrowserForward (Element webBrowser){ throw new NotImplementedException(); }
		public static bool SetBrowserRenderingPaused (Element webBrowser, bool paused){ throw new NotImplementedException(); }
		public static bool SetBrowserVolume (Element webBrowser, float volume){ throw new NotImplementedException(); }
		public static bool ToggleBrowserDevTools (Element webBrowser, bool visible){ throw new NotImplementedException(); }
		public static Element GuiCreateBrowser (float x, float y, float width, float height, bool isLocal, bool isTransparent, bool isRelative, Element parent){ throw new NotImplementedException(); }
		public static Element GuiGetBrowser (Element theBrowser){ throw new NotImplementedException(); }
		public static float GetCameraFieldOfView (string cameraMode){ throw new NotImplementedException(); }
		public static Element GetCamera (){ throw new NotImplementedException(); }
		public static Tuple<bool, bool> GetCameraClip (){ throw new NotImplementedException(); }
		public static string GetCameraGoggleEffect (){ throw new NotImplementedException(); }
		public static int GetCameraShakeLevel (){ throw new NotImplementedException(); }
		public static int GetCameraViewMode (){ throw new NotImplementedException(); }
		public static bool SetCameraClip (bool objects, bool vehicles){ throw new NotImplementedException(); }
		public static bool SetCameraFieldOfView (string cameraMode, float fieldOfView){ throw new NotImplementedException(); }
		public static bool SetCameraGoggleEffect (string goggleEffect, bool noiseEnabled){ throw new NotImplementedException(); }
		public static bool SetCameraShakeLevel (int shakeLevel){ throw new NotImplementedException(); }
		public static bool SetCameraViewMode (int viewMode){ throw new NotImplementedException(); }
		public static Tuple<float, float, float, float, float> GetCursorPosition (){ throw new NotImplementedException(); }
		public static bool SetCursorPosition (int cursorX, int cursorY){ throw new NotImplementedException(); }
		public static bool SetCursorAlpha (int alpha){ throw new NotImplementedException(); }
		public static int GetCursorAlpha (){ throw new NotImplementedException(); }
		public static string DxConvertPixels (string pixels, string newFormat, int quality){ throw new NotImplementedException(); }
		public static Element DxCreateFont (string filepath, int size, bool bold, string quality){ throw new NotImplementedException(); }
		public static Element DxCreateRenderTarget (int width, int height, bool withAlpha){ throw new NotImplementedException(); }
		public static Element DxCreateScreenSource (int width, int height){ throw new NotImplementedException(); }
		public static Tuple<Element, string> DxCreateShader (string filepath, float priority, float maxDistance, bool layered, string elementTypes){ throw new NotImplementedException(); }
		public static Element DxCreateTexture (string pixels, string textureFormat, bool mipmaps, string textureEdge){ throw new NotImplementedException(); }
		public static bool DxDrawCircle (float posX, float posY, float radius, float startAngle, float stopAngle, Element theColor, Element theCenterColor, int segments, int ratio, bool postGUI){ throw new NotImplementedException(); }
		public static bool DxDrawImage (float posX, float posY, float width, float height, dynamic image, float rotation, float rotationCenterOffsetX, float rotationCenterOffsetY, int color){ throw new NotImplementedException(); }
		public static bool DxDrawImageSection (float posX, float posY, float width, float height, float u, float v, float usize, float vsize, dynamic image, float rotation, float rotationCenterOffsetX, float rotationCenterOffsetY, int color, bool postGUI){ throw new NotImplementedException(); }
		public static bool DxDrawLine (int startX, int startY, int endX, int endY, int color, float width, bool postGUI){ throw new NotImplementedException(); }
		public static bool DxDrawLine3D (float startX, float startY, float startZ, float endX, float endY, float endZ, int color, float width, bool postGUI){ throw new NotImplementedException(); }
		public static bool DxDrawMaterialLine3D (float startX, float startY, float startZ, float endX, float endY, float endZ, Element material, float width, int color, bool postGUI, float faceTowardX, float faceTowardY, float faceTowardZ){ throw new NotImplementedException(); }
		public static bool DxDrawMaterialSectionLine3D (float startX, float startY, float startZ, float endX, float endY, float endZ, float u, float v, float usize, float vsize, Element material, int width, int color, bool postGUI, float faceTowardX, float faceTowardY, float faceTowardZ){ throw new NotImplementedException(); }
		public static bool DxDrawMaterialPrimitive (Element pType, dynamic material, bool postGUI, dynamic vertice1, dynamic vertice2){ throw new NotImplementedException(); }
		public static bool DxDrawRectangle (float startX, float startY, float width, float height, int color, bool postGUI, bool subPixelPositioning){ throw new NotImplementedException(); }
		public static bool DxDrawPrimitive (string pType, bool postGUI, dynamic vertice1, dynamic vertice2){ throw new NotImplementedException(); }
		public static bool DxDrawText (string text, float left, float top, float right, float bottom, int color, float scaleXY, float scaleY, dynamic font, string alignX, string alignY, bool clip, bool wordBreak, bool postGUI, bool colorCoded, bool subPixelPositioning, float fRotation, float fRotationCenterX, float fRotationCenterY){ throw new NotImplementedException(); }
		public static string DxGetPixelsFormat (string pixels){ throw new NotImplementedException(); }
		public static dynamic DxGetStatus (){ throw new NotImplementedException(); }
		public static Tuple<int, int, int, int> DxGetPixelColor (string pixels, int x, int y){ throw new NotImplementedException(); }
		public static string DxGetBlendMode (){ throw new NotImplementedException(); }
		public static Tuple<int, int, dynamic, dynamic> DxGetMaterialSize (Element material){ throw new NotImplementedException(); }
		public static int DxGetFontHeight (float scale, dynamic font){ throw new NotImplementedException(); }
		public static Tuple<int, int> DxGetPixelsSize (string pixels){ throw new NotImplementedException(); }
		public static float DxGetTextWidth (string text, float scale, dynamic font, bool bColorCoded){ throw new NotImplementedException(); }
		public static bool DxSetBlendMode (string blendMode){ throw new NotImplementedException(); }
		public static bool DxSetPixelColor (string pixels, int x, int y, int r, int g, int b, int a){ throw new NotImplementedException(); }
		public static string DxGetTexturePixels (int surfaceIndex, Element texture, int x, int y, int width, int height){ throw new NotImplementedException(); }
		public static bool DxSetShaderValue (Element theShader, string parameterName, dynamic value){ throw new NotImplementedException(); }
		public static bool DxSetAspectRatioAdjustmentEnabled (bool bEnabled, float sourceRatio){ throw new NotImplementedException(); }
		public static bool DxSetTestMode (string testMode){ throw new NotImplementedException(); }
		public static bool DxSetRenderTarget (Element renderTarget, bool clear){ throw new NotImplementedException(); }
		public static bool DxSetShaderTessellation (Element theShader, int tessellationX, int tessellationY){ throw new NotImplementedException(); }
		public static bool DxSetTextureEdge (Element theTexture, string textureEdge, int border){ throw new NotImplementedException(); }
		public static bool DxSetShaderTransform (Element theShader, float rotationX, float rotationY, float rotationZ, float rotationCenterOffsetX, float rotationCenterOffsetY, float rotationCenterOffsetZ, bool bRotationCenterOffsetOriginIsScreen, float perspectiveCenterOffsetX, float perspectiveCenterOffsetY, bool bPerspectiveCenterOffsetOriginIsScreen){ throw new NotImplementedException(); }
		public static bool DxUpdateScreenSource (Element screenSource, bool resampleNow){ throw new NotImplementedException(); }
		public static bool FxAddBlood (float posX, float posY, float posZ, float dirX, float dirY, float dirZ, int count, float brightness){ throw new NotImplementedException(); }
		public static bool DxSetTexturePixels (int surfaceIndex, Element texture, string pixels, int x, int y, int width, int height){ throw new NotImplementedException(); }
		public static bool FxAddFootSplash (float posX, float posY, float posZ){ throw new NotImplementedException(); }
		public static bool FxAddDebris (float posX, float posY, float posZ, int colorR, int colorG, int colorB, int colorA, float scale, int count){ throw new NotImplementedException(); }
		public static bool FxAddBulletSplash (float posX, float posY, float posZ){ throw new NotImplementedException(); }
		public static Element CreateEffect (string name, float x, float y, float z, float rX, float rY, float rZ, float drawDistance, bool soundEnable){ throw new NotImplementedException(); }
		public static bool FxAddBulletImpact (float posX, float posY, float posZ, float dirX, float dirY, float dirZ, int smokeSize, int sparkCount, float smokeIntensity){ throw new NotImplementedException(); }
		public static bool FxAddTankFire (float posX, float posY, float posZ, float dirX, float dirY, float dirZ){ throw new NotImplementedException(); }
		public static bool FxAddGlass (float posX, float posY, float posZ, int colorR, int colorG, int colorB, int colorA, float scale, int count){ throw new NotImplementedException(); }
		public static bool FxAddSparks (float posX, float posY, float posZ, float dirX, float dirY, float dirZ, float force, int count, float acrossLineX, float acrossLineY, float acrossLineZ, bool blur, float spread, float life){ throw new NotImplementedException(); }
		public static bool FxAddGunshot (float posX, float posY, float posZ, float dirX, float dirY, float dirZ, bool includeSparks){ throw new NotImplementedException(); }
		public static bool FxAddTyreBurst (float posX, float posY, float posZ, float dirX, float dirY, float dirZ){ throw new NotImplementedException(); }
		public static bool FxAddWaterHydrant (float posX, float posY, float posZ){ throw new NotImplementedException(); }
		public static bool FxAddPunchImpact (float posX, float posY, float posZ, float dirX, float dirY, float dirZ){ throw new NotImplementedException(); }
		public static bool FxAddWaterSplash (float posX, float posY, float posZ){ throw new NotImplementedException(); }
		public static bool FxAddWood (float posX, float posY, float posZ, float dirX, float dirY, float dirZ, int count, float brightness){ throw new NotImplementedException(); }
		public static float GetEffectDensity (Element theEffect){ throw new NotImplementedException(); }
		public static bool SetEffectDensity (Element theEffect, float density){ throw new NotImplementedException(); }
		public static float GetEffectSpeed (Element theEffect){ throw new NotImplementedException(); }
		public static bool SetEffectSpeed (Element theEffect, float speed){ throw new NotImplementedException(); }
		public static Tuple<float, float, float, float, float, float> GetElementBoundingBox (Element theElement){ throw new NotImplementedException(); }
		public static float GetElementDistanceFromCentreOfMassToBaseOfModel (Element theElement){ throw new NotImplementedException(); }
		public static float GetElementRadius (Element theElement){ throw new NotImplementedException(); }
		public static bool IsElementCollidableWith (Element theElement, Element withElement){ throw new NotImplementedException(); }
		public static bool IsElementLocal (Element theElement){ throw new NotImplementedException(); }
		public static bool IsElementStreamable (Element theElement){ throw new NotImplementedException(); }
		public static bool IsElementOnScreen (Element theElement){ throw new NotImplementedException(); }
		public static bool IsElementStreamedIn (Element theElement){ throw new NotImplementedException(); }
		public static bool IsElementSyncer (Element theElement){ throw new NotImplementedException(); }
		public static bool IsElementWaitingForGroundToLoad (Element theElement){ throw new NotImplementedException(); }
		public static bool SetElementCollidableWith (Element theElement, Element withElement, bool enabled){ throw new NotImplementedException(); }
		public static bool SetElementStreamable (Element theElement, bool streamable){ throw new NotImplementedException(); }
		public static bool SetElementMatrix (Element theElement, dynamic theMatrix){ throw new NotImplementedException(); }
		public static int EngineGetModelIDFromName (string modelName){ throw new NotImplementedException(); }
		public static float EngineGetModelLODDistance (int model){ throw new NotImplementedException(); }
		public static bool EngineApplyShaderToWorldTexture (Element shader, string textureName, Element targetElement, bool appendLayers){ throw new NotImplementedException(); }
		public static string EngineGetModelNameFromID (int modelID){ throw new NotImplementedException(); }
		public static dynamic EngineGetVisibleTextureNames (string nameFilter, string modelId){ throw new NotImplementedException(); }
		public static dynamic EngineGetModelTextureNames (string modelId){ throw new NotImplementedException(); }
		public static bool EngineImportTXD (Element texture, int model_id){ throw new NotImplementedException(); }
		public static Element EngineLoadIFP (string ifp_file, string CustomBlockName){ throw new NotImplementedException(); }
		public static Element EngineLoadCOL (string col_file){ throw new NotImplementedException(); }
		public static Element EngineLoadDFF (string dff_file){ throw new NotImplementedException(); }
		public static Element EngineLoadTXD (string txd_file, bool filteringEnabled){ throw new NotImplementedException(); }
		public static bool EngineRemoveShaderFromWorldTexture (Element shader, string textureName, Element targetElement){ throw new NotImplementedException(); }
		public static bool EngineReplaceAnimation (Element thePed, string InternalBlockName, string InternalAnimName, string CustomBlockName, string CustomAnimName){ throw new NotImplementedException(); }
		public static bool EngineReplaceCOL (Element theCol, int modelID){ throw new NotImplementedException(); }
		public static bool EngineRestoreCOL (int modelID){ throw new NotImplementedException(); }
		public static bool EngineRestoreAnimation (Element thePed, string InternalBlockName, string InternalAnimName){ throw new NotImplementedException(); }
		public static bool EngineRestoreModel (int modelID){ throw new NotImplementedException(); }
		public static bool EngineReplaceModel (Element theModel, int modelID, bool alphaTransparency){ throw new NotImplementedException(); }
		public static bool EngineSetAsynchronousLoading (bool enable, bool force){ throw new NotImplementedException(); }
		public static bool EngineSetModelLODDistance (int model, float distance){ throw new NotImplementedException(); }
		public static dynamic EngineGetSurfaceProperties (int surfaceID, string property){ throw new NotImplementedException(); }
		public static bool EngineSetSurfaceProperties (int surfaceID, string property, dynamic value){ throw new NotImplementedException(); }
		public static dynamic EngineResetSurfaceProperties (int surfaceID){ throw new NotImplementedException(); }
		public static bool TriggerLatentServerEvent (string argument_event, int bandwidth, bool persist, Element theElement){ throw new NotImplementedException(); }
		public static bool TriggerServerEvent (string argument_event, Element theElement){ throw new NotImplementedException(); }
		public static bool ExtinguishFire (float x, float y, float z, float radius){ throw new NotImplementedException(); }
		public static bool CreateFire (float x, float y, float z, float size){ throw new NotImplementedException(); }
		public static bool GuiBringToFront (Element guiElement){ throw new NotImplementedException(); }
		public static dynamic GetChatboxLayout (string CVar){ throw new NotImplementedException(); }
		public static bool GuiBlur (Element guiElement){ throw new NotImplementedException(); }
		public static Element GuiCreateFont (string filepath, int size){ throw new NotImplementedException(); }
		public static bool GuiFocus (Element guiElement){ throw new NotImplementedException(); }
		public static float GuiGetAlpha (Element guiElement){ throw new NotImplementedException(); }
		public static string GuiGetCursorType (){ throw new NotImplementedException(); }
		public static Tuple<string, Element> GuiGetFont (Element guiElement){ throw new NotImplementedException(); }
		public static Tuple<float, float> GuiGetPosition (Element guiElement, bool relative){ throw new NotImplementedException(); }
		public static string GuiGetInputMode (){ throw new NotImplementedException(); }
		public static bool GuiGetEnabled (Element guiElement){ throw new NotImplementedException(); }
		public static bool GuiGetInputEnabled (){ throw new NotImplementedException(); }
		public static dynamic GuiGetProperties (Element guiElement){ throw new NotImplementedException(); }
		public static string GuiGetText (Element guiElement){ throw new NotImplementedException(); }
		public static string GuiGetProperty (Element guiElement, string property){ throw new NotImplementedException(); }
		public static bool GuiSetInputEnabled (bool enabled){ throw new NotImplementedException(); }
		public static Tuple<float, float> GuiGetSize (Element theElement, bool relative){ throw new NotImplementedException(); }
		public static bool GuiMoveToBack (Element guiElement){ throw new NotImplementedException(); }
		public static bool GuiSetEnabled (Element guiElement, bool enabled){ throw new NotImplementedException(); }
		public static bool GuiSetAlpha (Element guielement, float alpha){ throw new NotImplementedException(); }
		public static Tuple<float, float> GuiGetScreenSize (){ throw new NotImplementedException(); }
		public static bool IsMTAWindowActive (){ throw new NotImplementedException(); }
		public static bool GuiSetInputMode (string mode){ throw new NotImplementedException(); }
		public static bool IsTransferBoxActive (){ throw new NotImplementedException(); }
		public static bool GuiSetPosition (Element theElement, float x, float y, bool relative){ throw new NotImplementedException(); }
		public static bool GuiGetVisible (Element guiElement){ throw new NotImplementedException(); }
		public static bool GuiSetText (Element guiElement, string text){ throw new NotImplementedException(); }
		public static bool GuiSetProperty (Element guiElement, string property, string value){ throw new NotImplementedException(); }
		public static bool GuiSetSize (Element guiElement, float width, float height, bool relative){ throw new NotImplementedException(); }
		public static bool GuiSetFont (Element guiElement, dynamic font){ throw new NotImplementedException(); }
		public static bool SetDebugViewActive (bool enabled){ throw new NotImplementedException(); }
		public static bool GuiSetVisible (Element guiElement, bool state){ throw new NotImplementedException(); }
		public static bool IsMainMenuActive (){ throw new NotImplementedException(); }
		public static bool IsDebugViewActive (){ throw new NotImplementedException(); }
		public static bool IsChatBoxInputActive (){ throw new NotImplementedException(); }
		public static bool IsConsoleActive (){ throw new NotImplementedException(); }
		public static Element GuiCreateEdit (float x, float y, float width, float height, string text, bool relative, Element parent){ throw new NotImplementedException(); }
		public static string GuiComboBoxGetItemText (Element comboBox, int itemId){ throw new NotImplementedException(); }
		public static bool GuiCheckBoxGetSelected (Element theCheckbox){ throw new NotImplementedException(); }
		public static Element GuiCreateCheckBox (float x, float y, float width, float height, string text, bool selected, bool relative, Element parent){ throw new NotImplementedException(); }
		public static Element GuiCreateComboBox (float x, float y, float width, float height, string caption, bool relative, Element parent){ throw new NotImplementedException(); }
		public static int GuiComboBoxGetItemCount (Element comboBox){ throw new NotImplementedException(); }
		public static int GuiComboBoxAddItem (Element comboBox, string value){ throw new NotImplementedException(); }
		public static bool GuiCheckBoxSetSelected (Element theCheckbox, bool state){ throw new NotImplementedException(); }
		public static bool GuiComboBoxSetItemText (Element comboBox, int itemId, string text){ throw new NotImplementedException(); }
		public static bool GuiComboBoxRemoveItem (Element comboBox, int itemId){ throw new NotImplementedException(); }
		public static bool GuiComboBoxClear (Element comboBox){ throw new NotImplementedException(); }
		public static Element GuiCreateButton (float x, float y, float width, float height, string text, bool relative, Element parent){ throw new NotImplementedException(); }
		public static int GuiEditGetCaretIndex (Element theElement){ throw new NotImplementedException(); }
		public static bool GuiComboBoxIsOpen (Element comboBox){ throw new NotImplementedException(); }
		public static int GuiComboBoxGetSelected (Element comboBox){ throw new NotImplementedException(); }
		public static bool GuiEditSetMasked (Element theElement, bool status){ throw new NotImplementedException(); }
		public static bool GuiComboBoxSetOpen (Element comboBox, bool state){ throw new NotImplementedException(); }
		public static bool GuiComboBoxSetSelected (Element comboBox, int itemIndex){ throw new NotImplementedException(); }
		public static bool GuiEditIsMasked (Element guiEdit){ throw new NotImplementedException(); }
		public static bool GuiEditIsReadOnly (Element guiEdit){ throw new NotImplementedException(); }
		public static bool GuiGridListAutoSizeColumn (Element gridList, int columnIndex){ throw new NotImplementedException(); }
		public static bool GuiEditSetReadOnly (Element editField, bool status){ throw new NotImplementedException(); }
		public static bool GuiEditSetCaretIndex (Element theElement, int index){ throw new NotImplementedException(); }
		public static Element GuiCreateGridList (float x, float y, float width, float height, bool relative, Element parent){ throw new NotImplementedException(); }
		public static int GuiEditGetMaxLength (Element guiEdit){ throw new NotImplementedException(); }
		public static bool GuiGridListClear (Element gridList){ throw new NotImplementedException(); }
		public static bool GuiEditSetMaxLength (Element guiEdit, int length){ throw new NotImplementedException(); }
		public static float GuiGridListGetHorizontalScrollPosition (Element guiGridlist){ throw new NotImplementedException(); }
		public static int GuiGridListGetRowCount (Element gridList){ throw new NotImplementedException(); }
		public static Tuple<int, int, int, int> GuiGridListGetItemColor (Element gridList, int rowIndex, int columnIndex){ throw new NotImplementedException(); }
		public static int GuiGridListAddColumn (Element gridList, string title, float width){ throw new NotImplementedException(); }
		public static int GuiGridListInsertRowAfter (Element gridList, int rowIndex){ throw new NotImplementedException(); }
		public static string GuiGridListGetColumnTitle (Element guiGridlist, int columnIndex){ throw new NotImplementedException(); }
		public static int GuiGridListGetColumnCount (Element gridList){ throw new NotImplementedException(); }
		public static bool GuiGridListGetColumnWidth (Element gridList, int columnIndex, bool relative){ throw new NotImplementedException(); }
		public static dynamic GuiGridListGetSelectedItems (Element gridList){ throw new NotImplementedException(); }
		public static dynamic GuiGridListGetItemData (Element gridList, int rowIndex, int columnIndex){ throw new NotImplementedException(); }
		public static string GuiGridListGetItemText (Element gridList, int rowIndex, int columnIndex){ throw new NotImplementedException(); }
		public static float GuiGridListGetVerticalScrollPosition (Element guiGridlist){ throw new NotImplementedException(); }
		public static bool GuiGridListSetItemData (Element gridList, int rowIndex, int columnIndex, dynamic data){ throw new NotImplementedException(); }
		public static int GuiGridListAddRow (Element gridList, dynamic itemText1, dynamic itemText2){ throw new NotImplementedException(); }
		public static int GuiGridListGetSelectedCount (Element gridList){ throw new NotImplementedException(); }
		public static bool GuiGridListSetSortingEnabled (Element guiGridlist, bool enabled){ throw new NotImplementedException(); }
		public static bool GuiGridListSetColumnTitle (Element guiGridlist, int columnIndex, string title){ throw new NotImplementedException(); }
		public static bool GuiGridListSetItemColor (Element gridList, int rowIndex, int columnIndex, int red, int green, int blue, int alpha){ throw new NotImplementedException(); }
		public static Tuple<int, int> GuiGridListGetSelectedItem (Element gridList){ throw new NotImplementedException(); }
		public static bool GuiGridListSetSelectionMode (Element gridlist, int mode){ throw new NotImplementedException(); }
		public static bool GuiGridListSetColumnWidth (Element gridList, int columnIndex, float width, bool relative){ throw new NotImplementedException(); }
		public static bool GuiGridListSetScrollBars (Element guiGridlist, bool horizontalBar, bool verticalBar){ throw new NotImplementedException(); }
		public static bool GuiGridListSetHorizontalScrollPosition (Element guiGridlist, float fPosition){ throw new NotImplementedException(); }
		public static bool GuiGridListSetItemText (Element gridList, int rowIndex, int columnIndex, string text, bool section, bool number){ throw new NotImplementedException(); }
		public static bool GuiGridListSetSelectedItem (Element gridList, int rowIndex, int columnIndex, bool bReset){ throw new NotImplementedException(); }
		public static float GuiProgressBarGetProgress (Element theProgressbar){ throw new NotImplementedException(); }
		public static int GuiMemoGetCaretIndex (Element theElement){ throw new NotImplementedException(); }
		public static bool GuiGridListSetVerticalScrollPosition (Element guiGridlist, float fPosition){ throw new NotImplementedException(); }
		public static bool GuiMemoSetReadOnly (Element theMemo, bool status){ throw new NotImplementedException(); }
		public static Element GuiCreateMemo (float x, float y, float width, float height, string text, bool relative, Element parent){ throw new NotImplementedException(); }
		public static Element GuiCreateRadioButton (float x, float y, float width, float height, string text, bool relative, Element parent){ throw new NotImplementedException(); }
		public static Element GuiCreateScrollBar (float x, float y, float width, float height, bool horizontal, bool relative, Element parent){ throw new NotImplementedException(); }
		public static bool GuiMemoSetVerticalScrollPosition (Element theMemo, float position){ throw new NotImplementedException(); }
		public static float GuiScrollBarGetScrollPosition (Element theScrollBar){ throw new NotImplementedException(); }
		public static float GuiScrollPaneGetHorizontalScrollPosition (Element horizontalScrollPane){ throw new NotImplementedException(); }
		public static bool GuiRadioButtonGetSelected (Element guiRadioButton){ throw new NotImplementedException(); }
		public static bool GuiScrollPaneSetVerticalScrollPosition (Element verticalScrollPane, float position){ throw new NotImplementedException(); }
		public static bool GuiScrollBarSetScrollPosition (Element theScrollBar, float amount){ throw new NotImplementedException(); }
		public static Element GuiCreateScrollPane (float x, float y, float width, float height, bool relative, Element parent){ throw new NotImplementedException(); }
		public static float GuiScrollPaneGetVerticalScrollPosition (Element verticalScrollPane){ throw new NotImplementedException(); }
		public static bool GuiStaticImageLoadImage (Element theElement, string filename){ throw new NotImplementedException(); }
		public static bool GuiScrollPaneSetScrollBars (Element scrollPane, bool horizontal, bool vertical){ throw new NotImplementedException(); }
		public static bool GuiMemoSetCaretIndex (Element theMemo, int index){ throw new NotImplementedException(); }
		public static bool GuiMemoIsReadOnly (Element theMemo){ throw new NotImplementedException(); }
		public static dynamic GetBoundKeys (string command){ throw new NotImplementedException(); }
		public static Element GuiCreateTab (string text, Element parent){ throw new NotImplementedException(); }
		public static bool GuiProgressBarSetProgress (Element theProgressbar, float progress){ throw new NotImplementedException(); }
		public static bool GuiScrollPaneSetHorizontalScrollPosition (Element horizontalScrollPane, float position){ throw new NotImplementedException(); }
		public static bool GuiLabelSetVerticalAlign (Element theLabel, string align){ throw new NotImplementedException(); }
		public static Tuple<int, int> GuiStaticImageGetNativeSize (Element theImage){ throw new NotImplementedException(); }
		public static Element GuiCreateStaticImage (float x, float y, float width, float height, string path, bool relative, Element parent){ throw new NotImplementedException(); }
		public static float GuiMemoGetVerticalScrollPosition (Element theMemo){ throw new NotImplementedException(); }
		public static bool GuiRadioButtonSetSelected (Element guiRadioButton, bool state){ throw new NotImplementedException(); }
		public static Element GuiCreateProgressBar (float x, float y, float width, float height, bool relative, Element parent){ throw new NotImplementedException(); }
		public static bool GuiWindowSetMovable (Element theElement, bool status){ throw new NotImplementedException(); }
		public static float GuiLabelGetFontHeight (Element theLabel){ throw new NotImplementedException(); }
		public static bool GuiDeleteTab (Element tabToDelete, Element tabPanel){ throw new NotImplementedException(); }
		public static float GetAnalogControlState (string control){ throw new NotImplementedException(); }
		public static Element GuiCreateTabPanel (float x, float y, float width, float height, bool relative, Element parent){ throw new NotImplementedException(); }
		public static dynamic GetCommandsBoundToKey (string theKey, string keyState){ throw new NotImplementedException(); }
		public static bool GuiGridListRemoveColumn (Element gridList, int columnIndex){ throw new NotImplementedException(); }
		public static Element GuiCreateWindow (float x, float y, float width, float height, string titleBarText, bool relative){ throw new NotImplementedException(); }
		public static float GetLightRadius (Element theLight){ throw new NotImplementedException(); }
		public static bool GuiLabelSetHorizontalAlign (Element theLabel, string align, bool wordwrap){ throw new NotImplementedException(); }
		public static bool GetKeyState (string keyName){ throw new NotImplementedException(); }
		public static Element CreateLight (int lightType, float posX, float posY, float posZ, float radius, int r, int g, int b, float dirX, float dirY, float dirZ, bool createsShadow){ throw new NotImplementedException(); }
		public static bool GuiLabelSetColor (Element theElement, int red, int green, int blue){ throw new NotImplementedException(); }
		public static bool GuiWindowIsSizable (Element guiWindow){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetLightDirection (Element theLight){ throw new NotImplementedException(); }
		public static string GetKeyBoundToCommand (string command){ throw new NotImplementedException(); }
		public static bool SetLightDirection (Element theLight, float x, float y, float z){ throw new NotImplementedException(); }
		public static bool SetLightColor (Element theLight, float r, float g, float b){ throw new NotImplementedException(); }
		public static bool GuiGridListRemoveRow (Element gridList, int rowIndex){ throw new NotImplementedException(); }
		public static int GetLightType (Element theLight){ throw new NotImplementedException(); }
		public static Tuple<int, int, int> GetLightColor (Element theLight){ throw new NotImplementedException(); }
		public static bool SetLightRadius (Element theLight, float radius){ throw new NotImplementedException(); }
		public static bool GuiWindowIsMovable (Element guiWindow){ throw new NotImplementedException(); }
		public static float GuiLabelGetTextExtent (Element theLabel){ throw new NotImplementedException(); }
		public static bool GuiWindowSetSizable (Element theElement, bool status){ throw new NotImplementedException(); }
		public static bool GuiSetSelectedTab (Element tabPanel, Element theTab){ throw new NotImplementedException(); }
		public static Element GuiGetSelectedTab (Element tabPanel){ throw new NotImplementedException(); }
		public static Tuple<int, int, int> GuiLabelGetColor (Element theLabel){ throw new NotImplementedException(); }
		public static Element GuiCreateLabel (float x, float y, float width, float height, string text, bool relative, Element parent){ throw new NotImplementedException(); }
		public static bool BreakObject (Element theObject){ throw new NotImplementedException(); }
		public static bool IsObjectBreakable (Element theObject){ throw new NotImplementedException(); }
		public static float GetObjectMass (Element theObject){ throw new NotImplementedException(); }
		public static bool RespawnObject (Element theObject){ throw new NotImplementedException(); }
		public static bool SetObjectBreakable (Element theObject, bool breakable){ throw new NotImplementedException(); }
		public static bool SetObjectMass (Element theObject, float mass){ throw new NotImplementedException(); }
		public static bool ToggleObjectRespawn (Element theObject, bool respawn){ throw new NotImplementedException(); }
		public static bool IsChatVisible (){ throw new NotImplementedException(); }
		public static bool SetObjectProperty (Element theObject, string property, dynamic value){ throw new NotImplementedException(); }
		public static dynamic GetObjectProperty (Element theObject, string property){ throw new NotImplementedException(); }
		public static float GetPedAnalogControlState (Element thePed, string controlName){ throw new NotImplementedException(); }
		public static bool CanPedBeKnockedOffBike (Element thePed){ throw new NotImplementedException(); }
		public static float GetPedCameraRotation (Element thePed){ throw new NotImplementedException(); }
		public static Tuple<string, string> GetPedAnimation (Element thePed){ throw new NotImplementedException(); }
		public static string GetPedMoveState (Element thePed){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetPedBonePosition (Element thePed, int bone){ throw new NotImplementedException(); }
		public static bool GetPedControlState (Element thePed, string control){ throw new NotImplementedException(); }
		public static float GetPedOxygenLevel (Element thePed){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetPedTargetStart (Element targetingPed){ throw new NotImplementedException(); }
		public static string GetPedSimplestTask (Element thePed){ throw new NotImplementedException(); }
		public static Tuple<string, string, string, string> GetPedTask (Element thePed, string priority, int taskType){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetPedTargetCollision (Element targetingPed){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetPedTargetEnd (Element targetingPed){ throw new NotImplementedException(); }
		public static Tuple<string, string> GetPedVoice (Element thePed){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetPedWeaponMuzzlePosition (Element thePed){ throw new NotImplementedException(); }
		public static bool GivePedWeapon (Element thePed, int weapon, int ammo, bool setAsCurrent){ throw new NotImplementedException(); }
		public static bool IsPedDoingTask (Element thePed, string taskName){ throw new NotImplementedException(); }
		public static bool IsPedReloadingWeapon (Element thePed){ throw new NotImplementedException(); }
		public static bool IsPedTargetingMarkerEnabled (){ throw new NotImplementedException(); }
		public static bool SetAnalogControlState (string control, float state){ throw new NotImplementedException(); }
		public static bool SetPedAimTarget (Element thePed, float x, float y, float z){ throw new NotImplementedException(); }
		public static bool SetPedAnalogControlState (Element thePed, string control, float state){ throw new NotImplementedException(); }
		public static bool SetPedCameraRotation (Element thePed, float cameraRotation){ throw new NotImplementedException(); }
		public static bool SetPedControlState (Element thePed, string control, bool state){ throw new NotImplementedException(); }
		public static bool SetPedCanBeKnockedOffBike (Element thePed, bool canBeKnockedOffBike){ throw new NotImplementedException(); }
		public static bool SetPedFootBloodEnabled (Element thePlayer, bool enabled){ throw new NotImplementedException(); }
		public static bool SetPedLookAt (Element thePed, float x, float y, float z, int time, int blend, Element target){ throw new NotImplementedException(); }
		public static bool SetPedOxygenLevel (Element thePed, float oxygen){ throw new NotImplementedException(); }
		public static bool SetPedTargetingMarkerEnabled (bool enabled){ throw new NotImplementedException(); }
		public static bool SetPedVoice (Element thePed, string voiceType, string voiceName){ throw new NotImplementedException(); }
		public static Element GetLocalPlayer (){ throw new NotImplementedException(); }
		public static Tuple<int, int, int, int> GetPlayerMapBoundingBox (){ throw new NotImplementedException(); }
		public static bool IsPlayerHudComponentVisible (string component){ throw new NotImplementedException(); }
		public static bool IsPlayerMapVisible (){ throw new NotImplementedException(); }
		public static Element CreateProjectile (Element creator, int weaponType, float posX, float posY, float posZ, float force, Element target, float rotX, float rotY, float rotZ, float velX, float velY, float velZ, int model){ throw new NotImplementedException(); }
		public static int GetProjectileCounter (Element projectile){ throw new NotImplementedException(); }
		public static Element GetProjectileCreator (Element theProjectile){ throw new NotImplementedException(); }
		public static float GetProjectileForce (Element theProjectile){ throw new NotImplementedException(); }
		public static int GetProjectileType (Element theProjectile){ throw new NotImplementedException(); }
		public static Element GetProjectileTarget (Element theProjectile){ throw new NotImplementedException(); }
		public static bool SetProjectileCounter (Element projectile, int timeToDetonate){ throw new NotImplementedException(); }
		public static Element GetResourceGUIElement (Element theResource){ throw new NotImplementedException(); }
		public static Element GetSearchLightEndRadius (Element theSearchLight){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetSearchLightEndPosition (Element theSearchLight){ throw new NotImplementedException(); }
		public static Element GetSearchLightStartRadius (Element theSearchLight){ throw new NotImplementedException(); }
		public static Element CreateSearchLight (float startX, float startY, float startZ, float endX, float endY, float endZ, float startRadius, float endRadius, bool renderSpot){ throw new NotImplementedException(); }
		public static Element SetSearchLightEndPosition (Element theSearchLight, float endX, float endY, float endZ){ throw new NotImplementedException(); }
		public static Element SetSearchLightEndRadius (Element theSearchlight, float endRadius){ throw new NotImplementedException(); }
		public static Element GetSearchLightStartPosition (Element theSearchLight){ throw new NotImplementedException(); }
		public static Element SetSearchLightStartRadius (Element theSearchlight, float startRadius){ throw new NotImplementedException(); }
		public static Element SetSearchLightStartPosition (Element theSearchLight, float startX, float startY, float startZ){ throw new NotImplementedException(); }
		public static bool CreateTrayNotification (string notificationText, string iconType, bool useSound){ throw new NotImplementedException(); }
		public static bool DownloadFile (string fileName){ throw new NotImplementedException(); }
		public static dynamic GetLocalization (){ throw new NotImplementedException(); }
		public static bool IsTrayNotificationEnabled (){ throw new NotImplementedException(); }
		public static bool SetClipboard (string theText){ throw new NotImplementedException(); }
		public static bool SetWindowFlashing (bool shouldFlash, int count){ throw new NotImplementedException(); }
		public static bool GetHeliBladeCollisionsEnabled (Element theVehicle){ throw new NotImplementedException(); }
		public static float GetHelicopterRotorSpeed (Element heli){ throw new NotImplementedException(); }
		public static int GetVehicleAdjustableProperty (Element theVehicle){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetVehicleComponentRotation (Element theVehicle, string theComponent, string argument_base){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetVehicleComponentPosition (Element theVehicle, string theComponent, string argument_base){ throw new NotImplementedException(); }
		public static dynamic GetVehicleComponents (Element theVehicle){ throw new NotImplementedException(); }
		public static bool GetVehicleComponentVisible (Element theVehicle, string theComponent){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetVehicleGravity (Element theVehicle){ throw new NotImplementedException(); }
		public static int GetVehicleCurrentGear (Element theVehicle){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetVehicleModelExhaustFumesPosition (int modelID){ throw new NotImplementedException(); }
		public static int GetVehicleNitroCount (Element theVehicle){ throw new NotImplementedException(); }
		public static float GetVehicleNitroLevel (Element theVehicle){ throw new NotImplementedException(); }
		public static bool IsTrainChainEngine (Element theTrain){ throw new NotImplementedException(); }
		public static bool IsVehicleNitroActivated (Element theVehicle){ throw new NotImplementedException(); }
		public static bool IsVehicleNitroRecharging (Element theVehicle){ throw new NotImplementedException(); }
		public static bool SetHeliBladeCollisionsEnabled (Element theVehicle, bool collisions){ throw new NotImplementedException(); }
		public static bool IsVehicleWheelOnGround (Element theVehicle, dynamic wheel){ throw new NotImplementedException(); }
		public static bool SetHelicopterRotorSpeed (Element heli, float speed){ throw new NotImplementedException(); }
		public static bool ResetVehicleComponentPosition (Element theVehicle, string theComponent){ throw new NotImplementedException(); }
		public static bool IsVehicleWindowOpen (Element theVehicle, int window){ throw new NotImplementedException(); }
		public static bool ResetVehicleComponentRotation (Element theVehicle, string theComponent){ throw new NotImplementedException(); }
		public static bool SetVehicleGravity (Element theVehicle, float x, float y, float z){ throw new NotImplementedException(); }
		public static bool SetVehicleAdjustableProperty (Element theVehicle, int value){ throw new NotImplementedException(); }
		public static bool SetVehicleComponentPosition (Element theVehicle, string theComponent, float posX, float posY, float posZ, string argument_base){ throw new NotImplementedException(); }
		public static bool SetVehicleComponentVisible (Element theVehicle, string theComponent, bool visible){ throw new NotImplementedException(); }
		public static bool SetVehicleComponentRotation (Element theVehicle, string theComponent, float rotX, float rotY, float rotZ, string argument_base){ throw new NotImplementedException(); }
		public static bool SetVehicleNitroLevel (Element theVehicle, float level){ throw new NotImplementedException(); }
		public static bool SetVehicleModelExhaustFumesPosition (int modelID, float posX, float posY, float posZ){ throw new NotImplementedException(); }
		public static bool SetVehicleNitroActivated (Element theVehicle, bool state){ throw new NotImplementedException(); }
		public static bool SetVehicleNitroCount (Element theVehicle, int count){ throw new NotImplementedException(); }
		public static bool SetVehicleWindowOpen (Element theVehicle, int window, bool open){ throw new NotImplementedException(); }
		public static float GetWaterLevel (float posX, float posY, float posZ, bool bCheckWaves){ throw new NotImplementedException(); }
		public static bool IsWaterDrawnLast (){ throw new NotImplementedException(); }
		public static bool SetWaterDrawnLast (bool bEnabled){ throw new NotImplementedException(); }
		public static bool FireWeapon (Element theWeapon){ throw new NotImplementedException(); }
		public static Element CreateWeapon (string theType, float x, float y, float z){ throw new NotImplementedException(); }
		public static int GetWeaponAmmo (Element theWeapon){ throw new NotImplementedException(); }
		public static int GetWeaponFiringRate (Element theWeapon){ throw new NotImplementedException(); }
		public static bool GetWeaponOwner (Element theWeapon){ throw new NotImplementedException(); }
		public static int GetWeaponClipAmmo (Element theWeapon){ throw new NotImplementedException(); }
		public static dynamic GetWeaponTarget (Element theWeapon){ throw new NotImplementedException(); }
		public static bool GetWeaponFlags (Element theWeapon, string theFlag){ throw new NotImplementedException(); }
		public static bool ResetWeaponFiringRate (Element theWeapon){ throw new NotImplementedException(); }
		public static string GetWeaponState (Element theWeapon){ throw new NotImplementedException(); }
		public static bool SetWeaponFiringRate (Element theWeapon, int firingRate){ throw new NotImplementedException(); }
		public static bool SetWeaponState (Element theWeapon, string theState){ throw new NotImplementedException(); }
		public static bool SetWeaponClipAmmo (Element theWeapon, int clipAmmo){ throw new NotImplementedException(); }
		public static bool SetWeaponFlags (Element theWeapon, string theFlag, bool enable){ throw new NotImplementedException(); }
		public static bool GetBirdsEnabled (){ throw new NotImplementedException(); }
		public static bool CreateSWATRope (float fx, float fy, float fZ, int duration){ throw new NotImplementedException(); }
		public static Tuple<float, float, float, float> GetGarageBoundingBox (int garageID){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetGaragePosition (int garageID){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetGarageSize (int garageID){ throw new NotImplementedException(); }
		public static float GetGroundPosition (float x, float y, float z){ throw new NotImplementedException(); }
		public static bool GetInteriorFurnitureEnabled (int roomID){ throw new NotImplementedException(); }
		public static bool GetInteriorSoundsEnabled (){ throw new NotImplementedException(); }
		public static float GetNearClipDistance (){ throw new NotImplementedException(); }
		public static bool SetPedsLODDistance (float distance){ throw new NotImplementedException(); }
		public static float GetPedsLODDistance (){ throw new NotImplementedException(); }
		public static bool ResetPedsLODDistance (){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetScreenFromWorldPosition (float x, float y, float z, float edgeTolerance, bool relative){ throw new NotImplementedException(); }
		public static Tuple<float, float> GetVehiclesLODDistance (){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetWorldFromScreenPosition (float x, float y, float depth){ throw new NotImplementedException(); }
		public static bool IsAmbientSoundEnabled (string theType){ throw new NotImplementedException(); }
		public static bool IsWorldSoundEnabled (int group, int index){ throw new NotImplementedException(); }
		public static bool IsWorldSpecialPropertyEnabled (string propname){ throw new NotImplementedException(); }
		public static Tuple<bool, float, float, float, Element, float, float, Tuple<float, int, float, int, int, float, float, Tuple<float, float, float, float, int>>> ProcessLineOfSight (float startX, float startY, float startZ, float endX, float endY, float endZ, bool checkBuildings, bool checkVehicles, bool checkPlayers, bool checkObjects, bool checkDummies, bool seeThroughStuff, bool ignoreSomeObjectsForCamera, bool shootThroughStuff, Element ignoredElement, bool includeWorldModelInformation, bool bIncludeCarTyres){ throw new NotImplementedException(); }
		public static bool ResetAmbientSounds (){ throw new NotImplementedException(); }
		public static bool IsLineOfSightClear (float startX, float startY, float startZ, float endX, float endY, float endZ, bool checkBuildings, bool checkVehicles, bool checkPeds, bool checkObjects, bool checkDummies, bool seeThroughStuff, bool ignoreSomeObjectsForCamera, Element ignoredElement){ throw new NotImplementedException(); }
		public static bool ResetVehiclesLODDistance (){ throw new NotImplementedException(); }
		public static bool ResetWorldSounds (){ throw new NotImplementedException(); }
		public static bool SetAmbientSoundEnabled (string theType, bool enable){ throw new NotImplementedException(); }
		public static bool SetBirdsEnabled (bool enable){ throw new NotImplementedException(); }
		public static bool SetInteriorFurnitureEnabled (int roomID, bool enabled){ throw new NotImplementedException(); }
		public static bool SetNearClipDistance (float distance){ throw new NotImplementedException(); }
		public static bool SetVehiclesLODDistance (float vehiclesDistance, float trainsAndPlanesDistance){ throw new NotImplementedException(); }
		public static bool SetWorldSpecialPropertyEnabled (string propname, bool enable){ throw new NotImplementedException(); }
		public static bool SetWorldSoundEnabled (int group, int index){ throw new NotImplementedException(); }
		public static Tuple<bool, float, float, float> TestLineAgainstWater (float startX, float startY, float startZ, float endX, float endY, float endZ){ throw new NotImplementedException(); }
	}
}