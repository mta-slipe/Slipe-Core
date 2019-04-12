using System;

namespace Slipe.MtaDefinitions {
	public class MtaShared {
		public static Tuple<int, int, int, int> GetBlipColor (MtaElement theBlip){ throw new NotImplementedException(); }
		public static int GetBlipIcon (MtaElement theBlip){ throw new NotImplementedException(); }
		public static int GetBlipOrdering (MtaElement theBlip){ throw new NotImplementedException(); }
		public static int GetBlipSize (MtaElement theBlip){ throw new NotImplementedException(); }
		public static float GetBlipVisibleDistance (MtaElement theBlip){ throw new NotImplementedException(); }
		public static bool SetBlipColor (MtaElement theBlip, int red, int green, int blue, int alpha){ throw new NotImplementedException(); }
		public static bool SetBlipSize (MtaElement theBlip, int iconSize){ throw new NotImplementedException(); }
		public static bool SetBlipIcon (MtaElement theBlip, int icon){ throw new NotImplementedException(); }
		public static bool SetBlipOrdering (MtaElement theBlip, int ordering){ throw new NotImplementedException(); }
		public static bool SetBlipVisibleDistance (MtaElement theBlip, float theDistance){ throw new NotImplementedException(); }
		public static string GetBodyPartName (int bodyPartID){ throw new NotImplementedException(); }
		public static Tuple<string, string> GetClothesByTypeIndex (int clothesType, int clothesIndex){ throw new NotImplementedException(); }
		public static Tuple<int, int> GetTypeIndexFromClothes (string clothesTexture, string clothesModel){ throw new NotImplementedException(); }
		public static string GetClothesTypeName (int clothesType){ throw new NotImplementedException(); }
		public static MtaElement CreateColCuboid (float fX, float fY, float fZ, float fWidth, float fDepth, float fHeight){ throw new NotImplementedException(); }
		public static MtaElement CreateColCircle (float fX, float fY, float radius){ throw new NotImplementedException(); }
		public static MtaElement CreateColPolygon (float fX, float fY, float fX1, float fY1, float fX2, float fY2, float fX3, float fY3){ throw new NotImplementedException(); }
		public static MtaElement CreateColRectangle (float fX, float fY, float fWidth, float fHeight){ throw new NotImplementedException(); }
		public static MtaElement CreateColSphere (float fX, float fY, float fZ, float fRadius){ throw new NotImplementedException(); }
		public static MtaElement CreateColTube (float fX, float fY, float fZ, float fRadius, float fHeight){ throw new NotImplementedException(); }
		public static string GetColShapeType (MtaElement shape){ throw new NotImplementedException(); }
		public static MtaElement GetElementColShape (MtaElement theElement){ throw new NotImplementedException(); }
		public static dynamic GetElementsWithinColShape (MtaElement theShape, string elemType){ throw new NotImplementedException(); }
		public static bool IsElementWithinColShape (MtaElement theElement, MtaElement theShape){ throw new NotImplementedException(); }
		public static bool IsInsideColShape (MtaElement theShape, float posX, float posY, float posZ){ throw new NotImplementedException(); }
		public static bool AttachElements (MtaElement theElement, MtaElement theAttachToElement, float xPosOffset, float yPosOffset, float zPosOffset, float xRotOffset, float yRotOffset, float zRotOffset){ throw new NotImplementedException(); }
		public static bool DestroyElement (MtaElement elementToDestroy){ throw new NotImplementedException(); }
		public static bool DetachElements (MtaElement theElement, MtaElement theAttachToElement){ throw new NotImplementedException(); }
		public static MtaElement CreateElement (string elementType, string elementID){ throw new NotImplementedException(); }
		public static dynamic GetAttachedElements (MtaElement theElement){ throw new NotImplementedException(); }
		public static int GetElementAlpha (MtaElement theElement){ throw new NotImplementedException(); }
		public static Tuple<float, float, float, float, float, float> GetElementAttachedOffsets (MtaElement theElement){ throw new NotImplementedException(); }
		public static bool GetElementCollisionsEnabled (MtaElement theElement){ throw new NotImplementedException(); }
		public static MtaElement GetElementByID (string id, int index){ throw new NotImplementedException(); }
		public static dynamic GetElementChildren (MtaElement parent, string theType){ throw new NotImplementedException(); }
		public static MtaElement GetElementChild (MtaElement parent, int index){ throw new NotImplementedException(); }
		public static MtaElement GetElementAttachedTo (MtaElement theElement){ throw new NotImplementedException(); }
		public static int GetElementChildrenCount (MtaElement parent){ throw new NotImplementedException(); }
		public static int GetElementDimension (MtaElement theElement){ throw new NotImplementedException(); }
		public static dynamic GetElementData (MtaElement theElement, string key, bool inherit){ throw new NotImplementedException(); }
		public static float GetElementHealth (MtaElement theElement){ throw new NotImplementedException(); }
		public static int GetElementInterior (MtaElement theElement){ throw new NotImplementedException(); }
		public static string GetElementID (MtaElement theElement){ throw new NotImplementedException(); }
		public static dynamic GetElementMatrix (MtaElement theElement, bool legacy){ throw new NotImplementedException(); }
		public static int GetElementModel (MtaElement theElement){ throw new NotImplementedException(); }
		public static MtaElement GetElementParent (MtaElement theElement){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetElementPosition (MtaElement theElement){ throw new NotImplementedException(); }
		public static string GetElementType (MtaElement theElement){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetElementRotation (MtaElement theElement, string rotOrder){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetElementVelocity (MtaElement theElement){ throw new NotImplementedException(); }
		public static bool IsElementAttached (MtaElement theElement){ throw new NotImplementedException(); }
		public static MtaElement GetLowLODElement (MtaElement theElement){ throw new NotImplementedException(); }
		public static MtaElement GetRootElement (){ throw new NotImplementedException(); }
		public static bool IsElement (dynamic theValue){ throw new NotImplementedException(); }
		public static bool IsElementInWater (MtaElement theElement){ throw new NotImplementedException(); }
		public static bool IsElementCallPropagationEnabled (MtaElement theElement){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetElementAngularVelocity (MtaElement theElement){ throw new NotImplementedException(); }
		public static bool IsElementDoubleSided (MtaElement theElement){ throw new NotImplementedException(); }
		public static bool IsElementFrozen (MtaElement theElement){ throw new NotImplementedException(); }
		public static bool IsElementLowLOD (MtaElement theElement){ throw new NotImplementedException(); }
		public static bool SetElementAlpha (MtaElement theElement, int alpha){ throw new NotImplementedException(); }
		public static bool SetElementAngularVelocity (MtaElement theElement, float rx, float ry, float rz){ throw new NotImplementedException(); }
		public static bool SetElementCallPropagationEnabled (MtaElement theElement, bool enabled){ throw new NotImplementedException(); }
		public static bool SetElementCollisionsEnabled (MtaElement theElement, bool enabled){ throw new NotImplementedException(); }
		public static bool IsElementWithinMarker (MtaElement theElement, MtaElement theMarker){ throw new NotImplementedException(); }
		public static bool SetElementDimension (MtaElement theElement, int dimension){ throw new NotImplementedException(); }
		public static bool SetElementData (MtaElement theElement, string key, dynamic value, bool synchronize){ throw new NotImplementedException(); }
		public static bool SetElementAttachedOffsets (MtaElement theElement, float xPosOffset, float yPosOffset, float zPosOffset, float xRotOffset, float yRotOffset, float zRotOffset){ throw new NotImplementedException(); }
		public static bool SetElementDoubleSided (MtaElement theElement, bool enable){ throw new NotImplementedException(); }
		public static bool SetElementFrozen (MtaElement theElement, bool freezeStatus){ throw new NotImplementedException(); }
		public static bool SetElementHealth (MtaElement theElement, float newHealth){ throw new NotImplementedException(); }
		public static bool SetElementID (MtaElement theElement, string name){ throw new NotImplementedException(); }
		public static bool SetElementParent (MtaElement theElement, MtaElement parent){ throw new NotImplementedException(); }
		public static bool SetElementInterior (MtaElement theElement, int interior, float x, float y, float z){ throw new NotImplementedException(); }
		public static bool SetElementPosition (MtaElement theElement, float x, float y, float z, bool warp){ throw new NotImplementedException(); }
		public static bool SetElementModel (MtaElement theElement, int model){ throw new NotImplementedException(); }
		public static bool SetElementRotation (MtaElement theElement, float rotX, float rotY, float rotZ, string rotOrder, bool conformPedRotation){ throw new NotImplementedException(); }
		public static bool SetElementVelocity (MtaElement theElement, float speedX, float speedY, float speedZ){ throw new NotImplementedException(); }
		public static bool AddEvent (string eventName, bool allowRemoteTrigger){ throw new NotImplementedException(); }
		public static bool SetLowLODElement (MtaElement theElement, MtaElement lowLODElement){ throw new NotImplementedException(); }
		public static dynamic GetEventHandlers (string eventName, MtaElement attachedTo){ throw new NotImplementedException(); }
		public static bool AddEventHandler (string eventName, MtaElement attachedTo, dynamic handlerFunction, bool getPropagated, string priority){ throw new NotImplementedException(); }
		public static bool RemoveEventHandler (string eventName, MtaElement attachedTo, dynamic functionVar){ throw new NotImplementedException(); }
		public static bool TriggerEvent (string eventName, MtaElement baseElement, dynamic argument1){ throw new NotImplementedException(); }
		public static bool FileClose (MtaElement theFile){ throw new NotImplementedException(); }
		public static bool WasEventCancelled (){ throw new NotImplementedException(); }
		public static bool FileCopy (string filePath, string copyToFilePath, bool overwrite){ throw new NotImplementedException(); }
		public static MtaElement FileCreate (string filePath){ throw new NotImplementedException(); }
		public static bool FileExists (string filePath){ throw new NotImplementedException(); }
		public static bool FileFlush (MtaElement theFile){ throw new NotImplementedException(); }
		public static bool FileDelete (string filePath){ throw new NotImplementedException(); }
		public static string FileGetPath (MtaElement theFile){ throw new NotImplementedException(); }
		public static int FileGetPos (MtaElement theFile){ throw new NotImplementedException(); }
		public static MtaElement FileOpen (string filePath, bool readOnly){ throw new NotImplementedException(); }
		public static int FileGetSize (MtaElement theFile){ throw new NotImplementedException(); }
		public static bool FileIsEOF (MtaElement theFile){ throw new NotImplementedException(); }
		public static string FileRead (MtaElement theFile, int count){ throw new NotImplementedException(); }
		public static int FileSetPos (MtaElement theFile, int offset){ throw new NotImplementedException(); }
		public static bool HttpClear (){ throw new NotImplementedException(); }
		public static int FileWrite (MtaElement theFile, string string1, string string2, string string3){ throw new NotImplementedException(); }
		public static bool HttpRequestLogin (){ throw new NotImplementedException(); }
		public static bool HttpSetResponseCookie (string cookieName, string cookieValue){ throw new NotImplementedException(); }
		public static bool HttpSetResponseCode (int code){ throw new NotImplementedException(); }
		public static bool HttpWrite (string data, int length){ throw new NotImplementedException(); }
		public static bool HttpSetResponseHeader (string headerName, string headerValue){ throw new NotImplementedException(); }
		public static bool FileRename (string filePath, string newFilePath){ throw new NotImplementedException(); }
		public static dynamic GetCommandHandlers (MtaResource theResource){ throw new NotImplementedException(); }
		public static bool RemoveCommandHandler (string commandName, dynamic handler){ throw new NotImplementedException(); }
		public static bool SetControlState (MtaElement thePlayer, string control, bool state){ throw new NotImplementedException(); }
		public static int GetMarkerCount (){ throw new NotImplementedException(); }
		public static string GetMarkerIcon (MtaElement theMarker){ throw new NotImplementedException(); }
		public static Tuple<int, int, int, int> GetMarkerColor (MtaElement theMarker){ throw new NotImplementedException(); }
		public static float GetMarkerSize (MtaElement myMarker){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetMarkerTarget (MtaElement theMarker){ throw new NotImplementedException(); }
		public static string GetMarkerType (MtaElement theMarker){ throw new NotImplementedException(); }
		public static bool SetMarkerIcon (MtaElement theMarker, string icon){ throw new NotImplementedException(); }
		public static bool SetMarkerColor (MtaElement theMarker, int r, int g, int b, int a){ throw new NotImplementedException(); }
		public static bool SetMarkerSize (MtaElement theMarker, float size){ throw new NotImplementedException(); }
		public static bool SetMarkerType (MtaElement theMarker, string markerType){ throw new NotImplementedException(); }
		public static bool SetMarkerTarget (MtaElement theMarker, float x, float y, float z){ throw new NotImplementedException(); }
		public static MtaElement CreateObject (int modelid, float x, float y, float z, float rx, float ry, float rz, bool isLowLOD){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetObjectScale (MtaElement theObject){ throw new NotImplementedException(); }
		public static bool MoveObject (MtaElement theObject, int time, float targetx, float targety, float targetz, float moverx, float movery, float moverz, string strEasingType, float fEasingPeriod, float fEasingAmplitude, float fEasingOvershoot){ throw new NotImplementedException(); }
		public static bool StopObject (MtaElement theobject){ throw new NotImplementedException(); }
		public static bool SetObjectScale (MtaElement theObject, float scale, float scaleY, float scaleZ){ throw new NotImplementedException(); }
		public static bool OutputDebugString (string text, int level, int red, int green, int blue){ throw new NotImplementedException(); }
		public static bool AddPedClothes (MtaElement thePed, string clothesTexture, string clothesModel, int clothesType){ throw new NotImplementedException(); }
		public static Tuple<string, string> GetPedClothes (MtaElement thePed, int clothesType){ throw new NotImplementedException(); }
		public static float GetPedArmor (MtaElement thePed){ throw new NotImplementedException(); }
		public static int GetPedAmmoInClip (MtaElement thePed, int weaponSlot){ throw new NotImplementedException(); }
		public static MtaElement GetPedContactElement (MtaElement thePed){ throw new NotImplementedException(); }
		public static int GetPedFightingStyle (MtaElement thePed){ throw new NotImplementedException(); }
		public static int GetPedOccupiedVehicleSeat (MtaElement thePed){ throw new NotImplementedException(); }
		public static MtaElement GetPedOccupiedVehicle (MtaElement thePed){ throw new NotImplementedException(); }
		public static int GetPedTotalAmmo (MtaElement thePed, int weaponSlot){ throw new NotImplementedException(); }
		public static float GetPedStat (MtaElement thePed, int stat){ throw new NotImplementedException(); }
		public static MtaElement GetPedTarget (MtaElement thePed){ throw new NotImplementedException(); }
		public static int GetPedWalkingStyle (MtaElement thePed){ throw new NotImplementedException(); }
		public static int GetPedWeapon (MtaElement thePed, int weaponSlot){ throw new NotImplementedException(); }
		public static bool IsPedChoking (MtaElement thePed){ throw new NotImplementedException(); }
		public static int GetPedWeaponSlot (MtaElement thePed){ throw new NotImplementedException(); }
		public static bool IsPedDucked (MtaElement thePed){ throw new NotImplementedException(); }
		public static dynamic GetValidPedModels (){ throw new NotImplementedException(); }
		public static bool IsPedDead (MtaElement thePed){ throw new NotImplementedException(); }
		public static bool IsPedHeadless (MtaElement thePed){ throw new NotImplementedException(); }
		public static bool IsPedDoingGangDriveby (MtaElement thePed){ throw new NotImplementedException(); }
		public static bool IsPedInVehicle (MtaElement thePed){ throw new NotImplementedException(); }
		public static bool IsPedOnFire (MtaElement thePed){ throw new NotImplementedException(); }
		public static bool IsPedOnGround (MtaElement thePed){ throw new NotImplementedException(); }
		public static bool IsPedWearingJetpack (MtaElement thePed){ throw new NotImplementedException(); }
		public static bool SetPedAnimationProgress (MtaElement thePed, string anim, float progress){ throw new NotImplementedException(); }
		public static bool RemovePedFromVehicle (MtaElement thePed){ throw new NotImplementedException(); }
		public static bool KillPed (MtaElement thePed, MtaElement theKiller, int weapon, int bodyPart, bool stealth){ throw new NotImplementedException(); }
		public static bool RemovePedClothes (MtaElement thePed, int clothesType, string clothesTexture, string clothesModel){ throw new NotImplementedException(); }
		public static bool SetPedAnimationSpeed (MtaElement thePed, string anim, float speed){ throw new NotImplementedException(); }
		public static bool SetPedDoingGangDriveby (MtaElement thePed, bool state){ throw new NotImplementedException(); }
		public static bool SetPedAnimation (MtaElement thePed, string block, string anim, int time, bool freezeLastFrame, int blendTime){ throw new NotImplementedException(); }
		public static bool SetPedHeadless (MtaElement thePed, bool headState){ throw new NotImplementedException(); }
		public static bool SetPedOnFire (MtaElement thePed, bool isOnFire){ throw new NotImplementedException(); }
		public static bool WarpPedIntoVehicle (MtaElement thePed, MtaElement theVehicle, int seat){ throw new NotImplementedException(); }
		public static int GetPickupAmmo (MtaElement thePickup){ throw new NotImplementedException(); }
		public static MtaElement CreatePickup (float x, float y, float z, int theType, int amount, int respawnTime, int ammo){ throw new NotImplementedException(); }
		public static bool SetPedWeaponSlot (MtaElement thePed, int weaponSlot){ throw new NotImplementedException(); }
		public static bool SetPedWalkingStyle (MtaElement thePed, int style){ throw new NotImplementedException(); }
		public static bool SetPedStat (MtaElement thePed, int stat, float value){ throw new NotImplementedException(); }
		public static int GetPickupAmount (MtaElement thePickup){ throw new NotImplementedException(); }
		public static int GetPickupWeapon (MtaElement thePickup){ throw new NotImplementedException(); }
		public static int GetPickupType (MtaElement thePickup){ throw new NotImplementedException(); }
		public static bool SetPickupType (MtaElement thePickup, int theType, int amount, int ammo){ throw new NotImplementedException(); }
		public static bool UsePickup (MtaElement thePickup, MtaElement thePlayer){ throw new NotImplementedException(); }
		public static MtaElement GetPlayerFromName (string playerName){ throw new NotImplementedException(); }
		public static Tuple<int, int, int> GetPlayerNametagColor (MtaElement thePlayer){ throw new NotImplementedException(); }
		public static string GetPlayerName (MtaElement thePlayer){ throw new NotImplementedException(); }
		public static string GetPlayerNametagText (MtaElement thePlayer){ throw new NotImplementedException(); }
		public static int GetPlayerPing (MtaElement thePlayer){ throw new NotImplementedException(); }
		public static MtaElement GetPlayerTeam (MtaElement thePlayer){ throw new NotImplementedException(); }
		public static bool IsVoiceEnabled (){ throw new NotImplementedException(); }
		public static bool IsPlayerNametagShowing (MtaElement thePlayer){ throw new NotImplementedException(); }
		public static bool SetPlayerNametagShowing (MtaElement thePlayer, bool showing){ throw new NotImplementedException(); }
		public static bool SetPlayerNametagText (MtaElement thePlayer, string text){ throw new NotImplementedException(); }
		public static bool SetPlayerNametagColor (MtaElement thePlayer, int r, int g, int b){ throw new NotImplementedException(); }
		public static MtaElement CreateRadarArea (float startPosX, float startPosY, float sizeX, float sizeY, int r, int g, int b, int a, MtaElement visibleTo){ throw new NotImplementedException(); }
		public static Tuple<int, int, int, int> GetRadarAreaColor (MtaElement theRadararea){ throw new NotImplementedException(); }
		public static Tuple<float, float> GetRadarAreaSize (MtaElement theRadararea){ throw new NotImplementedException(); }
		public static bool IsInsideRadarArea (MtaElement theArea, float posX, float posY){ throw new NotImplementedException(); }
		public static bool SetRadarAreaColor (MtaElement theRadarArea, int r, int g, int b, int a){ throw new NotImplementedException(); }
		public static bool SetRadarAreaFlashing (MtaElement theRadarArea, bool flash){ throw new NotImplementedException(); }
		public static bool IsRadarAreaFlashing (MtaElement theRadararea){ throw new NotImplementedException(); }
		public static bool SetRadarAreaSize (MtaElement theRadararea, float x, float y){ throw new NotImplementedException(); }
		public static dynamic Call (MtaResource theResource, string theFunction){ throw new NotImplementedException(); }
		public static bool FetchRemote (string URL, string queueName, int connectionAttempts, int connectTimeout, dynamic callbackFunction, string postData, bool postIsBinary){ throw new NotImplementedException(); }
		public static MtaElement GetResourceConfig (string filePath){ throw new NotImplementedException(); }
		public static MtaElement GetResourceDynamicElementRoot (MtaResource theResource){ throw new NotImplementedException(); }
		public static MtaResource GetResourceFromName (string resourceName){ throw new NotImplementedException(); }
		public static dynamic GetResourceExportedFunctions (MtaResource theResource){ throw new NotImplementedException(); }
		public static string GetResourceName (MtaResource res){ throw new NotImplementedException(); }
		public static string GetResourceState (MtaResource theResource){ throw new NotImplementedException(); }
		public static MtaElement GetResourceRootElement (MtaResource theResource){ throw new NotImplementedException(); }
		public static MtaResource GetThisResource (){ throw new NotImplementedException(); }
		public static int GetFPSLimit (){ throw new NotImplementedException(); }
		public static bool SetFPSLimit (int fpsLimit){ throw new NotImplementedException(); }
		public static dynamic GetVersion (){ throw new NotImplementedException(); }
		public static dynamic GetPlayersInTeam (MtaElement theTeam){ throw new NotImplementedException(); }
		public static MtaElement GetTeamFromName (string teamName){ throw new NotImplementedException(); }
		public static bool GetTeamFriendlyFire (MtaElement theTeam){ throw new NotImplementedException(); }
		public static string GetTeamName (MtaElement theTeam){ throw new NotImplementedException(); }
		public static Tuple<int, int, int> GetTeamColor (MtaElement theTeam){ throw new NotImplementedException(); }
		public static int CountPlayersInTeam (MtaElement theTeam){ throw new NotImplementedException(); }
		public static bool AddDebugHook (string hookType, dynamic callbackFunction, dynamic nameList){ throw new NotImplementedException(); }
		public static string Base64Decode (string data){ throw new NotImplementedException(); }
		public static string Base64Encode (string data){ throw new NotImplementedException(); }
		public static int BitAnd (int var1, int var2){ throw new NotImplementedException(); }
		public static int BitNot (int var){ throw new NotImplementedException(); }
		public static int BitOr (int var1, int var2){ throw new NotImplementedException(); }
		public static int BitXor (int var1, int var2){ throw new NotImplementedException(); }
		public static bool BitTest (int var1, int var2){ throw new NotImplementedException(); }
		public static int BitLRotate (int value, int n){ throw new NotImplementedException(); }
		public static int BitLShift (int value, int n){ throw new NotImplementedException(); }
		public static int BitRRotate (int value, int n){ throw new NotImplementedException(); }
		public static int BitRShift (int value, int n){ throw new NotImplementedException(); }
		public static int BitArShift (int value, int n){ throw new NotImplementedException(); }
		public static int BitExtract (int var, int field, int width){ throw new NotImplementedException(); }
		public static int BitReplace (int var, int replaceValue, int field, int width){ throw new NotImplementedException(); }
		public static bool DebugSleep (int sleep){ throw new NotImplementedException(); }
		public static string DecodeString (string algorithm, string input, dynamic options){ throw new NotImplementedException(); }
		public static string EncodeString (string algorithm, string input, dynamic options){ throw new NotImplementedException(); }
		public static dynamic FromJSON (string json){ throw new NotImplementedException(); }
		public static Tuple<int, int, int, int> GetColorFromString (string theColor){ throw new NotImplementedException(); }
		public static bool GetDevelopmentMode (){ throw new NotImplementedException(); }
		public static float GetDistanceBetweenPoints2D (float x1, float y1, float x2, float y2){ throw new NotImplementedException(); }
		public static float GetEasingValue (float fProgress, string strEasingType, float fEasingPeriod, float fEasingAmplitude, float fEasingOvershoot){ throw new NotImplementedException(); }
		public static float GetDistanceBetweenPoints3D (float x1, float y1, float z1, float x2, float y2, float z2){ throw new NotImplementedException(); }
		public static dynamic GetNetworkUsageData (){ throw new NotImplementedException(); }
		public static Tuple<dynamic, dynamic> GetPerformanceStats (string category, string options, string filter){ throw new NotImplementedException(); }
		public static dynamic GetRealTime (int seconds, bool localTime){ throw new NotImplementedException(); }
		public static int GetTickCount (){ throw new NotImplementedException(); }
		public static Tuple<int, int, int> GetTimerDetails (MtaTimer theTimer){ throw new NotImplementedException(); }
		public static string Gettok (string text, int tokenNumber, string parameter2){ throw new NotImplementedException(); }
		public static dynamic GetTimers (int theTime){ throw new NotImplementedException(); }
		public static string GetUserdataType (MtaElement value){ throw new NotImplementedException(); }
		public static string Hash (string algorithm, string dataToHash){ throw new NotImplementedException(); }
		public static string Inspect (dynamic var, dynamic options){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> InterpolateBetween (float x1, float y1, float z1, float x2, float y2, float z2, float fProgress, string strEasingType, float fEasingPeriod, float fEasingAmplitude, float fEasingOvershoot){ throw new NotImplementedException(); }
		public static bool KillTimer (MtaTimer theTimer){ throw new NotImplementedException(); }
		public static bool Iprint (dynamic var1, dynamic var2, dynamic var3){ throw new NotImplementedException(); }
		public static bool IsOOPEnabled (){ throw new NotImplementedException(); }
		public static string Md5 (string str){ throw new NotImplementedException(); }
		public static string PasswordHash (string password, string algorithm, dynamic options){ throw new NotImplementedException(); }
		public static bool PasswordVerify (string password, string hash, dynamic options){ throw new NotImplementedException(); }
		public static bool PregFind (string subject, string pattern, dynamic flags){ throw new NotImplementedException(); }
		public static bool IsTimer (MtaTimer theTimer){ throw new NotImplementedException(); }
		public static string PregReplace (string subject, string pattern, string replacement, dynamic flags){ throw new NotImplementedException(); }
		public static dynamic PregMatch (string argument_base, string pattern, dynamic flags, int maxResults){ throw new NotImplementedException(); }
		public static bool RemoveDebugHook (string hookType, dynamic callbackFunction){ throw new NotImplementedException(); }
		public static bool SetDevelopmentMode (bool enable, bool enableWeb){ throw new NotImplementedException(); }
		public static bool ResetTimer (MtaTimer theTimer){ throw new NotImplementedException(); }
		public static MtaTimer SetTimer (dynamic theFunction, int timeInterval, int timesToExecute, dynamic arguments){ throw new NotImplementedException(); }
		public static string Sha256 (string str){ throw new NotImplementedException(); }
		public static dynamic Split (string stringToSplit, string parameter1){ throw new NotImplementedException(); }
		public static string TeaDecode (string data, string key){ throw new NotImplementedException(); }
		public static string TeaEncode (string text, string key){ throw new NotImplementedException(); }
		public static int Tocolor (int red, int green, int blue, int alpha){ throw new NotImplementedException(); }
		public static string ToJSON (dynamic value, bool compact, string prettyType){ throw new NotImplementedException(); }
		public static int UtfLen (string theString){ throw new NotImplementedException(); }
		public static string UtfChar (int characterCode){ throw new NotImplementedException(); }
		public static string UtfSub (string theString, int Start, int End){ throw new NotImplementedException(); }
		public static int UtfSeek (string theString, int position){ throw new NotImplementedException(); }
		public static int UtfCode (string theString){ throw new NotImplementedException(); }
		public static string Utf8_char (int codepoints){ throw new NotImplementedException(); }
		public static Tuple<int, int> Utf8_charpos (string input, int charpos, int offset){ throw new NotImplementedException(); }
		public static dynamic Utf8_byte (string input, int i, int j){ throw new NotImplementedException(); }
		public static string Utf8_escape (string input){ throw new NotImplementedException(); }
		public static string Utf8_find (string input, string pattern, int startpos, bool plain){ throw new NotImplementedException(); }
		public static dynamic Utf8_fold (dynamic input){ throw new NotImplementedException(); }
		public static dynamic Utf8_gmatch (string input, string pattern){ throw new NotImplementedException(); }
		public static string Utf8_insert (string input, int insert_pos){ throw new NotImplementedException(); }
		public static int Utf8_len (string input, int i, int j){ throw new NotImplementedException(); }
		public static string Utf8_title (dynamic input){ throw new NotImplementedException(); }
		public static string Utf8_remove (string input, int start, int stop){ throw new NotImplementedException(); }
		public static Tuple<int, int, int> Utf8_widthindex (string input, int location, bool ambi_is_double, int default_width){ throw new NotImplementedException(); }
		public static int Utf8_ncasecmp (string a, string b){ throw new NotImplementedException(); }
		public static bool AddVehicleUpgrade (MtaElement theVehicle, int upgrade){ throw new NotImplementedException(); }
		public static string Utf8_reverse (string input){ throw new NotImplementedException(); }
		public static Tuple<int, int> Utf8_next (string input, int charpos, int offset){ throw new NotImplementedException(); }
		public static string Utf8_sub (string input, int i, int j){ throw new NotImplementedException(); }
		public static string Utf8_gsub (string input, string pattern, dynamic replace, int match_limit){ throw new NotImplementedException(); }
		public static int Utf8_width (dynamic input, bool ambi_is_double, int default_width){ throw new NotImplementedException(); }
		public static bool DetachTrailerFromVehicle (MtaElement theVehicle, MtaElement theTrailer){ throw new NotImplementedException(); }
		public static MtaElement CreateVehicle (int model, float x, float y, float z, float rx, float ry, float rz, string numberplate, bool bDirection, int variant1, int variant2){ throw new NotImplementedException(); }
		public static bool FixVehicle (MtaElement theVehicle){ throw new NotImplementedException(); }
		public static dynamic GetOriginalHandling (int modelID){ throw new NotImplementedException(); }
		public static bool GetTrainDirection (MtaElement train){ throw new NotImplementedException(); }
		public static float GetTrainPosition (MtaElement train){ throw new NotImplementedException(); }
		public static float GetTrainSpeed (MtaElement train){ throw new NotImplementedException(); }
		public static int GetTrainTrack (MtaElement train){ throw new NotImplementedException(); }
		public static dynamic GetVehicleCompatibleUpgrades (MtaElement theVehicle, int slot){ throw new NotImplementedException(); }
		public static Tuple<int, int, int, int, int, int, int, Tuple<int, int, int, int, int>> GetVehicleColor (MtaElement theVehicle, bool bRGB){ throw new NotImplementedException(); }
		public static MtaElement GetVehicleController (MtaElement theVehicle){ throw new NotImplementedException(); }
		public static float GetVehicleDoorOpenRatio (MtaElement theVehicle, int door){ throw new NotImplementedException(); }
		public static int GetVehicleDoorState (MtaElement theVehicle, int door){ throw new NotImplementedException(); }
		public static bool GetVehicleEngineState (MtaElement theVehicle){ throw new NotImplementedException(); }
		public static dynamic Utf8_match (string input, string pattern, int index){ throw new NotImplementedException(); }
		public static Tuple<int, int, int> GetVehicleHeadLightColor (MtaElement theVehicle){ throw new NotImplementedException(); }
		public static dynamic GetVehicleHandling (MtaElement theVehicle){ throw new NotImplementedException(); }
		public static int GetVehicleLightState (MtaElement theVehicle, int light){ throw new NotImplementedException(); }
		public static bool GetVehicleLandingGearDown (MtaElement theVehicle){ throw new NotImplementedException(); }
		public static bool AttachTrailerToVehicle (MtaElement theVehicle, MtaElement theTrailer){ throw new NotImplementedException(); }
		public static int GetVehicleModelFromName (string name){ throw new NotImplementedException(); }
		public static string GetVehicleName (MtaElement theVehicle){ throw new NotImplementedException(); }
		public static int GetVehicleMaxPassengers (MtaElement theVehicle){ throw new NotImplementedException(); }
		public static string GetVehicleNameFromModel (int model){ throw new NotImplementedException(); }
		public static MtaElement GetVehicleOccupant (MtaElement theVehicle, int seat){ throw new NotImplementedException(); }
		public static dynamic GetVehicleOccupants (MtaElement theVehicle){ throw new NotImplementedException(); }
		public static string GetVehiclePlateText (MtaElement theVehicle){ throw new NotImplementedException(); }
		public static int GetVehiclePaintjob (MtaElement theVehicle){ throw new NotImplementedException(); }
		public static int GetVehiclePanelState (MtaElement theVehicle, int panel){ throw new NotImplementedException(); }
		public static dynamic GetVehicleSirenParams (MtaElement theVehicle){ throw new NotImplementedException(); }
		public static int GetVehicleOverrideLights (MtaElement theVehicle){ throw new NotImplementedException(); }
		public static MtaElement GetVehicleTowedByVehicle (MtaElement theVehicle){ throw new NotImplementedException(); }
		public static bool GetVehicleSirensOn (MtaElement theVehicle){ throw new NotImplementedException(); }
		public static dynamic GetVehicleSirens (MtaElement theVehicle){ throw new NotImplementedException(); }
		public static MtaElement GetVehicleTowingVehicle (MtaElement theVehicle){ throw new NotImplementedException(); }
		public static string GetVehicleType (MtaElement theVehicle){ throw new NotImplementedException(); }
		public static Tuple<float, float> GetVehicleTurretPosition (MtaElement turretVehicle){ throw new NotImplementedException(); }
		public static string GetVehicleUpgradeSlotName (int slot){ throw new NotImplementedException(); }
		public static int GetVehicleUpgradeOnSlot (MtaElement theVehicle, int slot){ throw new NotImplementedException(); }
		public static dynamic GetVehicleUpgrades (MtaElement theVehicle){ throw new NotImplementedException(); }
		public static bool IsTrainDerailable (MtaElement vehicleToCheck){ throw new NotImplementedException(); }
		public static Tuple<int, int, int, int> GetVehicleWheelStates (MtaElement theVehicle){ throw new NotImplementedException(); }
		public static Tuple<int, int> GetVehicleVariant (MtaElement theVehicle){ throw new NotImplementedException(); }
		public static bool IsVehicleDamageProof (MtaElement theVehicle){ throw new NotImplementedException(); }
		public static bool IsVehicleBlown (MtaElement theVehicle){ throw new NotImplementedException(); }
		public static bool IsTrainDerailed (MtaElement vehicleToCheck){ throw new NotImplementedException(); }
		public static bool IsVehicleFuelTankExplodable (MtaElement theVehicle){ throw new NotImplementedException(); }
		public static bool IsVehicleLocked (MtaElement theVehicle){ throw new NotImplementedException(); }
		public static bool IsVehicleOnGround (MtaElement theVehicle){ throw new NotImplementedException(); }
		public static bool IsVehicleTaxiLightOn (MtaElement taxi){ throw new NotImplementedException(); }
		public static bool RemoveVehicleUpgrade (MtaElement theVehicle, int upgrade){ throw new NotImplementedException(); }
		public static bool SetTrainDerailed (MtaElement vehicleToDerail, bool derailed){ throw new NotImplementedException(); }
		public static bool SetTrainDerailable (MtaElement derailableVehicle, bool derailable){ throw new NotImplementedException(); }
		public static bool SetTrainSpeed (MtaElement train, float speed){ throw new NotImplementedException(); }
		public static bool SetTrainDirection (MtaElement train, bool clockwise){ throw new NotImplementedException(); }
		public static bool SetTrainPosition (MtaElement train, float position){ throw new NotImplementedException(); }
		public static bool SetVehicleColor (MtaElement theVehicle, int r1, int g1, int b1, int r2, int g2, int b2, int r3, int g3, int b3, int r4, int g4, int b4){ throw new NotImplementedException(); }
		public static bool SetVehicleDamageProof (MtaElement theVehicle, bool damageProof){ throw new NotImplementedException(); }
		public static bool SetVehicleLandingGearDown (MtaElement theVehicle, bool gearState){ throw new NotImplementedException(); }
		public static bool SetVehicleDoorsUndamageable (MtaElement theVehicle, bool state){ throw new NotImplementedException(); }
		public static bool SetVehicleHeadLightColor (MtaElement theVehicle, int red, int green, int blue){ throw new NotImplementedException(); }
		public static bool SetVehicleFuelTankExplodable (MtaElement theVehicle, bool explodable){ throw new NotImplementedException(); }
		public static bool SetTrainTrack (MtaElement train, int track){ throw new NotImplementedException(); }
		public static bool SetVehicleLightState (MtaElement theVehicle, int light, int state){ throw new NotImplementedException(); }
		public static bool SetVehicleOverrideLights (MtaElement theVehicle, int value){ throw new NotImplementedException(); }
		public static bool SetVehicleDoorState (MtaElement theVehicle, int door, int state){ throw new NotImplementedException(); }
		public static bool SetVehicleEngineState (MtaElement theVehicle, bool engineState){ throw new NotImplementedException(); }
		public static bool SetVehicleDoorOpenRatio (MtaElement theVehicle, int door, float ratio, int time){ throw new NotImplementedException(); }
		public static bool SetVehiclePanelState (MtaElement theVehicle, int panelID, int state){ throw new NotImplementedException(); }
		public static bool SetVehicleLocked (MtaElement theVehicle, bool locked){ throw new NotImplementedException(); }
		public static bool SetVehicleHandling (MtaElement theVehicle, string property, dynamic value){ throw new NotImplementedException(); }
		public static bool SetVehiclePaintjob (MtaElement theVehicle, int value){ throw new NotImplementedException(); }
		public static bool SetVehiclePlateText (MtaElement theVehicle, string numberplate){ throw new NotImplementedException(); }
		public static Tuple<int, int, int, int> GetWaterColor (){ throw new NotImplementedException(); }
		public static Tuple<int, int, float> GetWaterVertexPosition (MtaElement theWater, int vertexIndex){ throw new NotImplementedException(); }
		public static bool SetVehicleTaxiLightOn (MtaElement taxi, bool LightState){ throw new NotImplementedException(); }
		public static bool SetVehicleSirensOn (MtaElement theVehicle, bool sirensOn){ throw new NotImplementedException(); }
		public static float GetWaveHeight (){ throw new NotImplementedException(); }
		public static bool ResetWaterColor (){ throw new NotImplementedException(); }
		public static bool SetVehicleTurretPosition (MtaElement turretVehicle, float positionX, float positionY){ throw new NotImplementedException(); }
		public static int GetSlotFromWeapon (int weaponid){ throw new NotImplementedException(); }
		public static bool SetWaveHeight (float height){ throw new NotImplementedException(); }
		public static bool SetWaterVertexPosition (MtaElement theWater, int vertexIndex, int x, int y, float z){ throw new NotImplementedException(); }
		public static bool ResetWaterLevel (){ throw new NotImplementedException(); }
		public static int GetWeaponIDFromName (string name){ throw new NotImplementedException(); }
		public static bool SetWaterLevel (MtaElement theWater, float level){ throw new NotImplementedException(); }
		public static int GetOriginalWeaponProperty (int weaponID, string weaponSkill, string property){ throw new NotImplementedException(); }
		public static bool SetVehicleSirens (MtaElement theVehicle, int sirenPoint, float posX, float posY, float posZ, float red, float green, float blue, float alpha, float minAlpha){ throw new NotImplementedException(); }
		public static MtaElement CreateWater (float x1, float y1, float z1, float x2, float y2, float z2, float x3, float y3, float z3, float x4, float y4, float z4, bool bShallow){ throw new NotImplementedException(); }
		public static int GetWeaponProperty (int weaponID, string weaponSkill, string property){ throw new NotImplementedException(); }
		public static bool SetVehicleWheelStates (MtaElement theVehicle, int frontLeft, int rearLeft, int frontRight, int rearRight){ throw new NotImplementedException(); }
		public static bool SetWaterColor (int red, int green, int blue, int alpha){ throw new NotImplementedException(); }
		public static bool SetWeaponAmmo (MtaElement thePlayer, int weapon, int totalAmmo, int ammoInClip){ throw new NotImplementedException(); }
		public static string GetWeaponNameFromID (int id){ throw new NotImplementedException(); }
		public static bool AreTrafficLightsLocked (){ throw new NotImplementedException(); }
		public static float GetAircraftMaxVelocity (){ throw new NotImplementedException(); }
		public static bool GetCloudsEnabled (){ throw new NotImplementedException(); }
		public static bool SetWeaponProperty (int weaponID, string weaponSkill, string property, dynamic theValue){ throw new NotImplementedException(); }
		public static float GetFogDistance (){ throw new NotImplementedException(); }
		public static float GetFarClipDistance (){ throw new NotImplementedException(); }
		public static float GetGameSpeed (){ throw new NotImplementedException(); }
		public static float GetGravity (){ throw new NotImplementedException(); }
		public static Tuple<int, int, int, int, int, int, int, Tuple<int, bool>> GetHeatHaze (){ throw new NotImplementedException(); }
		public static float GetJetpackMaxHeight (){ throw new NotImplementedException(); }
		public static bool GetOcclusionsEnabled (){ throw new NotImplementedException(); }
		public static float GetRainLevel (){ throw new NotImplementedException(); }
		public static int GetMoonSize (){ throw new NotImplementedException(); }
		public static int GetMinuteDuration (){ throw new NotImplementedException(); }
		public static Tuple<int, int, int, int, int, int> GetSkyGradient (){ throw new NotImplementedException(); }
		public static Tuple<int, int, int, int, int, int> GetSunColor (){ throw new NotImplementedException(); }
		public static Tuple<int, int> GetTime (){ throw new NotImplementedException(); }
		public static float GetSunSize (){ throw new NotImplementedException(); }
		public static int GetTrafficLightState (){ throw new NotImplementedException(); }
		public static Tuple<int, int> GetWeather (){ throw new NotImplementedException(); }
		public static Tuple<int, int, int> GetWindVelocity (){ throw new NotImplementedException(); }
		public static string GetZoneName (float x, float y, float z, bool citiesonly){ throw new NotImplementedException(); }
		public static bool IsGarageOpen (int garageID){ throw new NotImplementedException(); }
		public static bool RemoveWorldModel (int modelID, float radius, float x, float y, float z, int interior){ throw new NotImplementedException(); }
		public static bool ResetFogDistance (){ throw new NotImplementedException(); }
		public static bool ResetHeatHaze (){ throw new NotImplementedException(); }
		public static bool ResetFarClipDistance (){ throw new NotImplementedException(); }
		public static bool ResetRainLevel (){ throw new NotImplementedException(); }
		public static bool ResetMoonSize (){ throw new NotImplementedException(); }
		public static bool ResetSkyGradient (){ throw new NotImplementedException(); }
		public static bool ResetSunSize (){ throw new NotImplementedException(); }
		public static bool ResetSunColor (){ throw new NotImplementedException(); }
		public static bool ResetWindVelocity (){ throw new NotImplementedException(); }
		public static bool RestoreAllWorldModels (){ throw new NotImplementedException(); }
		public static bool RestoreWorldModel (int modelID, float radius, float x, float y, float z, int iInterior){ throw new NotImplementedException(); }
		public static bool SetFogDistance (float distance){ throw new NotImplementedException(); }
		public static bool SetCloudsEnabled (bool enabled){ throw new NotImplementedException(); }
		public static bool SetGameSpeed (float value){ throw new NotImplementedException(); }
		public static bool SetFarClipDistance (float distance){ throw new NotImplementedException(); }
		public static bool SetGarageOpen (int garageID, bool open){ throw new NotImplementedException(); }
		public static bool SetAircraftMaxVelocity (float velocity){ throw new NotImplementedException(); }
		public static bool SetGravity (float level){ throw new NotImplementedException(); }
		public static bool SetInteriorSoundsEnabled (bool enabled){ throw new NotImplementedException(); }
		public static bool SetHeatHaze (int intensity, int randomShift, int speedMin, int speedMax, int scanSizeX, int scanSizeY, int renderSizeX, int renderSizeY, bool bShowInside){ throw new NotImplementedException(); }
		public static bool SetMinuteDuration (int milliseconds){ throw new NotImplementedException(); }
		public static bool SetOcclusionsEnabled (bool enabled){ throw new NotImplementedException(); }
		public static bool SetMoonSize (int size){ throw new NotImplementedException(); }
		public static bool SetRainLevel (float level){ throw new NotImplementedException(); }
		public static bool SetSkyGradient (int topRed, int topGreen, int topBlue, int bottomRed, int bottomGreen, int bottomBlue){ throw new NotImplementedException(); }
		public static bool SetSunColor (int aRed, int aGreen, int aBlue, int bRed, int bGreen, int bBlue){ throw new NotImplementedException(); }
		public static bool SetSunSize (int Size){ throw new NotImplementedException(); }
		public static bool SetTime (int hour, int minute){ throw new NotImplementedException(); }
		public static bool SetTrafficLightState (int state){ throw new NotImplementedException(); }
		public static bool SetWeather (int weatherID){ throw new NotImplementedException(); }
		public static bool SetTrafficLightsLocked (bool toggle){ throw new NotImplementedException(); }
		public static bool SetWeatherBlended (int weatherID){ throw new NotImplementedException(); }
		public static bool SetWindVelocity (float velocityX, float velocityY, float velocityZ){ throw new NotImplementedException(); }
		public static MtaElement XmlCreateFile (string filePath, string rootNodeName){ throw new NotImplementedException(); }
		public static MtaElement XmlCreateChild (MtaElement parentNode, string tagName){ throw new NotImplementedException(); }
		public static bool XmlDestroyNode (MtaElement theXMLNode){ throw new NotImplementedException(); }
		public static MtaElement XmlCopyFile (MtaElement nodeToCopy, string newFilePath){ throw new NotImplementedException(); }
		public static MtaElement XmlLoadFile (string filePath, bool readOnly){ throw new NotImplementedException(); }
		public static string XmlNodeGetAttribute (MtaElement node, string name){ throw new NotImplementedException(); }
		public static MtaElement XmlFindChild (MtaElement parent, string tagName, int index){ throw new NotImplementedException(); }
		public static dynamic XmlNodeGetAttributes (MtaElement node){ throw new NotImplementedException(); }
		public static dynamic XmlNodeGetChildren (MtaElement parent, int index){ throw new NotImplementedException(); }
		public static MtaElement XmlNodeGetParent (MtaElement node){ throw new NotImplementedException(); }
		public static string XmlNodeGetName (MtaElement node){ throw new NotImplementedException(); }
		public static string XmlNodeGetValue (MtaElement theXMLNode){ throw new NotImplementedException(); }
		public static bool XmlNodeSetAttribute (MtaElement node, string name, dynamic value){ throw new NotImplementedException(); }
		public static bool XmlNodeSetName (MtaElement node, string name){ throw new NotImplementedException(); }
		public static bool XmlNodeSetValue (MtaElement theXMLNode, string value, bool setCDATA){ throw new NotImplementedException(); }
		public static bool XmlSaveFile (MtaElement rootNode){ throw new NotImplementedException(); }
		public static bool XmlUnloadFile (MtaElement node){ throw new NotImplementedException(); }
		public static dynamic GetElementsWithinRange (float x, float y, float z, float range, string elemType){ throw new NotImplementedException(); }
		public static bool SetVehicleDirtLevel (MtaElement theVehicle, int dirtLevel){ throw new NotImplementedException(); }
		public static float GetAircraftMaxHeight (){ throw new NotImplementedException(); }
		public static bool SetAircraftMaxHeight (float Height){ throw new NotImplementedException(); }
		public static bool SetJetpackMaxHeight (float Height){ throw new NotImplementedException(); }
		public static System.Collections.Generic.List<dynamic> GetListFromTable (object table, string listType){ throw new NotImplementedException(); }
		public static T[] GetArrayFromTable<T> (object table, string arrayType){ throw new NotImplementedException(); }
		public static dynamic GetDictionaryFromTable (object table, string tKey, string tValue){ throw new NotImplementedException(); }
		public static DateTime GetDateTimeFromSecondStamp (int seconds){ throw new NotImplementedException(); }
		public static MtaElement CreateWater (float x1, float y1, float z1, float x2, float y2, float z2, float x3, float y3, float z3, bool bShallow){ throw new NotImplementedException(); }
		public static bool SetWaterLevel (float level, bool includeWaterFeatures, bool includeWaterElements){ throw new NotImplementedException(); }
		public static bool SetTrafficLightState (dynamic state){ throw new NotImplementedException(); }
		public static bool SetPedAnimation (MtaElement thePed, string block, string anim, int time, bool loop, bool updatePosition, bool interruptable, bool freezeLastFrame, int blendTime){ throw new NotImplementedException(); }
	}
}