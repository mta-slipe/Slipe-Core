using System;
using System.Xml;

namespace Slipe.MTADefinitions {
	public class MTAShared {
		public static Tuple<int, int, int, int> GetBlipColor (MTAElement theBlip){ throw new NotImplementedException(); }
		public static int GetBlipIcon (MTAElement theBlip){ throw new NotImplementedException(); }
		public static int GetBlipOrdering (MTAElement theBlip){ throw new NotImplementedException(); }
		public static int GetBlipSize (MTAElement theBlip){ throw new NotImplementedException(); }
		public static float GetBlipVisibleDistance (MTAElement theBlip){ throw new NotImplementedException(); }
		public static bool SetBlipColor (MTAElement theBlip, int red, int green, int blue, int alpha){ throw new NotImplementedException(); }
		public static bool SetBlipIcon (MTAElement theBlip, int icon){ throw new NotImplementedException(); }
		public static bool SetBlipSize (MTAElement theBlip, int iconSize){ throw new NotImplementedException(); }
		public static bool SetBlipVisibleDistance (MTAElement theBlip, float theDistance){ throw new NotImplementedException(); }
		public static bool SetBlipOrdering (MTAElement theBlip, int ordering){ throw new NotImplementedException(); }
		public static Tuple<string, string> GetClothesByTypeIndex (int clothesType, int clothesIndex){ throw new NotImplementedException(); }
		public static string GetBodyPartName (int bodyPartID){ throw new NotImplementedException(); }
		public static Tuple<int, int> GetTypeIndexFromClothes (string clothesTexture, string clothesModel){ throw new NotImplementedException(); }
		public static string GetClothesTypeName (int clothesType){ throw new NotImplementedException(); }
		public static MTAElement CreateColCircle (float fX, float fY, float radius){ throw new NotImplementedException(); }
		public static MTAElement CreateColPolygon (float fX, float fY, float fX1, float fY1, float fX2, float fY2, float fX3, float fY3){ throw new NotImplementedException(); }
		public static MTAElement CreateColCuboid (float fX, float fY, float fZ, float fWidth, float fDepth, float fHeight){ throw new NotImplementedException(); }
		public static MTAElement CreateColSphere (float fX, float fY, float fZ, float fRadius){ throw new NotImplementedException(); }
		public static MTAElement CreateColTube (float fX, float fY, float fZ, float fRadius, float fHeight){ throw new NotImplementedException(); }
		public static MTAElement CreateColRectangle (float fX, float fY, float fWidth, float fHeight){ throw new NotImplementedException(); }
		public static string GetColShapeType (MTAElement shape){ throw new NotImplementedException(); }
		public static MTAElement GetElementColShape (MTAElement theElement){ throw new NotImplementedException(); }
		public static dynamic GetElementsWithinColShape (MTAElement theShape, string elemType){ throw new NotImplementedException(); }
		public static bool IsInsideColShape (MTAElement theShape, float posX, float posY, float posZ){ throw new NotImplementedException(); }
		public static bool IsElementWithinColShape (MTAElement theElement, MTAElement theShape){ throw new NotImplementedException(); }
		public static bool AttachElements (MTAElement theElement, MTAElement theAttachToElement, float xPosOffset, float yPosOffset, float zPosOffset, float xRotOffset, float yRotOffset, float zRotOffset){ throw new NotImplementedException(); }
		public static bool DestroyElement (MTAElement elementToDestroy){ throw new NotImplementedException(); }
		public static MTAElement CreateElement (string elementType, string elementID){ throw new NotImplementedException(); }
		public static bool DetachElements (MTAElement theElement, MTAElement theAttachToElement){ throw new NotImplementedException(); }
		public static int GetElementAlpha (MTAElement theElement){ throw new NotImplementedException(); }
		public static dynamic GetAttachedElements (MTAElement theElement){ throw new NotImplementedException(); }
		public static Tuple<float, float, float, float, float, float> GetElementAttachedOffsets (MTAElement theElement){ throw new NotImplementedException(); }
		public static MTAElement GetElementByID (string id, int index){ throw new NotImplementedException(); }
		public static MTAElement GetElementAttachedTo (MTAElement theElement){ throw new NotImplementedException(); }
		public static MTAElement GetElementChild (MTAElement parent, int index){ throw new NotImplementedException(); }
		public static bool GetElementCollisionsEnabled (MTAElement theElement){ throw new NotImplementedException(); }
		public static dynamic GetElementChildren (MTAElement parent, string theType){ throw new NotImplementedException(); }
		public static int GetElementChildrenCount (MTAElement parent){ throw new NotImplementedException(); }
		public static int GetElementDimension (MTAElement theElement){ throw new NotImplementedException(); }
		public static dynamic GetElementData (MTAElement theElement, string key, bool inherit){ throw new NotImplementedException(); }
		public static string GetElementID (MTAElement theElement){ throw new NotImplementedException(); }
		public static float GetElementHealth (MTAElement theElement){ throw new NotImplementedException(); }
		public static dynamic GetElementMatrix (MTAElement theElement, bool legacy){ throw new NotImplementedException(); }
		public static MTAElement GetElementParent (MTAElement theElement){ throw new NotImplementedException(); }
		public static int GetElementInterior (MTAElement theElement){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetElementVelocity (MTAElement theElement){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetElementRotation (MTAElement theElement, string rotOrder){ throw new NotImplementedException(); }
		public static string GetElementType (MTAElement theElement){ throw new NotImplementedException(); }
		public static int GetElementModel (MTAElement theElement){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetElementPosition (MTAElement theElement){ throw new NotImplementedException(); }
		public static bool IsElement (dynamic theValue){ throw new NotImplementedException(); }
		public static bool IsElementDoubleSided (MTAElement theElement){ throw new NotImplementedException(); }
		public static MTAElement GetLowLODElement (MTAElement theElement){ throw new NotImplementedException(); }
		public static MTAElement GetRootElement (){ throw new NotImplementedException(); }
		public static bool IsElementCallPropagationEnabled (MTAElement theElement){ throw new NotImplementedException(); }
		public static bool IsElementAttached (MTAElement theElement){ throw new NotImplementedException(); }
		public static bool IsElementFrozen (MTAElement theElement){ throw new NotImplementedException(); }
		public static bool IsElementInWater (MTAElement theElement){ throw new NotImplementedException(); }
		public static bool IsElementLowLOD (MTAElement theElement){ throw new NotImplementedException(); }
		public static bool SetElementAlpha (MTAElement theElement, int alpha){ throw new NotImplementedException(); }
		public static bool IsElementWithinMarker (MTAElement theElement, MTAElement theMarker){ throw new NotImplementedException(); }
		public static bool GetElementAngularVelocity (MTAElement theElement){ throw new NotImplementedException(); }
		public static bool SetElementAngularVelocity (MTAElement theElement, float rx, float ry, float rz){ throw new NotImplementedException(); }
		public static bool SetElementAttachedOffsets (MTAElement theElement, float xPosOffset, float yPosOffset, float zPosOffset, float xRotOffset, float yRotOffset, float zRotOffset){ throw new NotImplementedException(); }
		public static bool SetElementCallPropagationEnabled (MTAElement theElement, bool enabled){ throw new NotImplementedException(); }
		public static bool SetElementCollisionsEnabled (MTAElement theElement, bool enabled){ throw new NotImplementedException(); }
		public static bool SetElementDimension (MTAElement theElement, int dimension){ throw new NotImplementedException(); }
		public static bool SetElementData (MTAElement theElement, string key, dynamic value, bool synchronize){ throw new NotImplementedException(); }
		public static bool SetElementFrozen (MTAElement theElement, bool freezeStatus){ throw new NotImplementedException(); }
		public static bool SetElementPosition (MTAElement theElement, float x, float y, float z, bool warp){ throw new NotImplementedException(); }
		public static bool SetElementInterior (MTAElement theElement, int interior, float x, float y, float z){ throw new NotImplementedException(); }
		public static bool SetElementDoubleSided (MTAElement theElement, bool enable){ throw new NotImplementedException(); }
		public static bool SetElementHealth (MTAElement theElement, float newHealth){ throw new NotImplementedException(); }
		public static bool SetElementID (MTAElement theElement, string name){ throw new NotImplementedException(); }
		public static bool SetElementParent (MTAElement theElement, MTAElement parent){ throw new NotImplementedException(); }
		public static bool SetElementModel (MTAElement theElement, int model){ throw new NotImplementedException(); }
		public static bool SetElementRotation (MTAElement theElement, float rotX, float rotY, float rotZ, string rotOrder, bool conformPedRotation){ throw new NotImplementedException(); }
		public static bool SetElementVelocity (MTAElement theElement, float speedX, float speedY, float speedZ){ throw new NotImplementedException(); }
		public static bool SetLowLODElement (MTAElement theElement, MTAElement lowLODElement){ throw new NotImplementedException(); }
		public static bool AddEventHandler (string eventName, MTAElement attachedTo, dynamic handlerFunction, bool getPropagated, string priority){ throw new NotImplementedException(); }
		public static bool AddEvent (string eventName, bool allowRemoteTrigger){ throw new NotImplementedException(); }
		public static dynamic GetEventHandlers (string eventName, MTAElement attachedTo){ throw new NotImplementedException(); }
		public static bool TriggerEvent (string eventName, MTAElement baseElement, dynamic argument1){ throw new NotImplementedException(); }
		public static bool RemoveEventHandler (string eventName, MTAElement attachedTo, dynamic functionVar){ throw new NotImplementedException(); }
		public static bool WasEventCancelled (){ throw new NotImplementedException(); }
		public static bool FileCopy (string filePath, string copyToFilePath, bool overwrite){ throw new NotImplementedException(); }
		public static bool FileClose (MTAElement theFile){ throw new NotImplementedException(); }
		public static bool FileDelete (string filePath){ throw new NotImplementedException(); }
		public static MTAElement FileCreate (string filePath){ throw new NotImplementedException(); }
		public static bool FileExists (string filePath){ throw new NotImplementedException(); }
		public static bool FileFlush (MTAElement theFile){ throw new NotImplementedException(); }
		public static string FileGetPath (MTAElement theFile){ throw new NotImplementedException(); }
		public static int FileGetSize (MTAElement theFile){ throw new NotImplementedException(); }
		public static int FileGetPos (MTAElement theFile){ throw new NotImplementedException(); }
		public static bool FileIsEOF (MTAElement theFile){ throw new NotImplementedException(); }
		public static int FileWrite (MTAElement theFile, string string1, string string2, string string3){ throw new NotImplementedException(); }
		public static MTAElement FileOpen (string filePath, bool readOnly){ throw new NotImplementedException(); }
		public static bool FileRename (string filePath, string newFilePath){ throw new NotImplementedException(); }
		public static int FileSetPos (MTAElement theFile, int offset){ throw new NotImplementedException(); }
		public static string FileRead (MTAElement theFile, int count){ throw new NotImplementedException(); }
		public static bool HttpSetResponseCode (int code){ throw new NotImplementedException(); }
		public static bool HttpRequestLogin (){ throw new NotImplementedException(); }
		public static bool HttpClear (){ throw new NotImplementedException(); }
		public static bool HttpSetResponseCookie (string cookieName, string cookieValue){ throw new NotImplementedException(); }
		public static bool HttpSetResponseHeader (string headerName, string headerValue){ throw new NotImplementedException(); }
		public static bool HttpWrite (string data, int length){ throw new NotImplementedException(); }
		public static dynamic GetCommandHandlers (MTAResource theResource){ throw new NotImplementedException(); }
		public static bool RemoveCommandHandler (string commandName, dynamic handler){ throw new NotImplementedException(); }
		public static bool SetControlState (MTAElement thePlayer, string control, bool state){ throw new NotImplementedException(); }
		public static Tuple<int, int, int, int> GetMarkerColor (MTAElement theMarker){ throw new NotImplementedException(); }
		public static int GetMarkerCount (){ throw new NotImplementedException(); }
		public static string GetMarkerIcon (MTAElement theMarker){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetMarkerTarget (MTAElement theMarker){ throw new NotImplementedException(); }
		public static bool SetMarkerIcon (MTAElement theMarker, string icon){ throw new NotImplementedException(); }
		public static string GetMarkerType (MTAElement theMarker){ throw new NotImplementedException(); }
		public static bool SetMarkerColor (MTAElement theMarker, int r, int g, int b, int a){ throw new NotImplementedException(); }
		public static float GetMarkerSize (MTAElement myMarker){ throw new NotImplementedException(); }
		public static bool SetMarkerSize (MTAElement theMarker, float size){ throw new NotImplementedException(); }
		public static bool SetMarkerTarget (MTAElement theMarker, float x, float y, float z){ throw new NotImplementedException(); }
		public static bool SetMarkerType (MTAElement theMarker, string markerType){ throw new NotImplementedException(); }
		public static MTAElement CreateObject (int modelid, float x, float y, float z, float rx, float ry, float rz, bool isLowLOD){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetObjectScale (MTAElement theObject){ throw new NotImplementedException(); }
		public static bool MoveObject (MTAElement theObject, int time, float targetx, float targety, float targetz, float moverx, float movery, float moverz, string strEasingType, float fEasingPeriod, float fEasingAmplitude, float fEasingOvershoot){ throw new NotImplementedException(); }
		public static bool StopObject (MTAElement theobject){ throw new NotImplementedException(); }
		public static bool SetObjectScale (MTAElement theObject, float scale, float scaleY, float scaleZ){ throw new NotImplementedException(); }
		public static bool OutputDebugString (string text, int level, int red, int green, int blue){ throw new NotImplementedException(); }
		public static bool AddPedClothes (MTAElement thePed, string clothesTexture, string clothesModel, int clothesType){ throw new NotImplementedException(); }
		public static float GetPedArmor (MTAElement thePed){ throw new NotImplementedException(); }
		public static int GetPedAmmoInClip (MTAElement thePed, int weaponSlot){ throw new NotImplementedException(); }
		public static Tuple<string, string> GetPedClothes (MTAElement thePed, int clothesType){ throw new NotImplementedException(); }
		public static MTAElement GetPedContactElement (MTAElement thePed){ throw new NotImplementedException(); }
		public static int GetPedFightingStyle (MTAElement thePed){ throw new NotImplementedException(); }
		public static MTAElement GetPedOccupiedVehicle (MTAElement thePed){ throw new NotImplementedException(); }
		public static int GetPedOccupiedVehicleSeat (MTAElement thePed){ throw new NotImplementedException(); }
		public static MTAElement GetPedTarget (MTAElement thePed){ throw new NotImplementedException(); }
		public static int GetPedWeapon (MTAElement thePed, int weaponSlot){ throw new NotImplementedException(); }
		public static int GetPedTotalAmmo (MTAElement thePed, int weaponSlot){ throw new NotImplementedException(); }
		public static float GetPedStat (MTAElement thePed, int stat){ throw new NotImplementedException(); }
		public static int GetPedWalkingStyle (MTAElement thePed){ throw new NotImplementedException(); }
		public static int GetPedWeaponSlot (MTAElement thePed){ throw new NotImplementedException(); }
		public static bool IsPedChoking (MTAElement thePed){ throw new NotImplementedException(); }
		public static dynamic GetValidPedModels (){ throw new NotImplementedException(); }
		public static bool IsPedDoingGangDriveby (MTAElement thePed){ throw new NotImplementedException(); }
		public static bool IsPedDead (MTAElement thePed){ throw new NotImplementedException(); }
		public static bool IsPedHeadless (MTAElement thePed){ throw new NotImplementedException(); }
		public static bool IsPedInVehicle (MTAElement thePed){ throw new NotImplementedException(); }
		public static bool IsPedDucked (MTAElement thePed){ throw new NotImplementedException(); }
		public static bool IsPedOnGround (MTAElement thePed){ throw new NotImplementedException(); }
		public static bool IsPedOnFire (MTAElement thePed){ throw new NotImplementedException(); }
		public static bool KillPed (MTAElement thePed, MTAElement theKiller, int weapon, int bodyPart, bool stealth){ throw new NotImplementedException(); }
		public static bool IsPedWearingJetpack (MTAElement thePed){ throw new NotImplementedException(); }
		public static bool RemovePedClothes (MTAElement thePed, int clothesType, string clothesTexture, string clothesModel){ throw new NotImplementedException(); }
		public static bool RemovePedFromVehicle (MTAElement thePed){ throw new NotImplementedException(); }
		public static bool SetPedAnimation (MTAElement thePed, string block, string anim, int time, bool freezeLastFrame, int blendTime){ throw new NotImplementedException(); }
		public static bool SetPedAnimationSpeed (MTAElement thePed, string anim, float speed){ throw new NotImplementedException(); }
		public static bool SetPedAnimationProgress (MTAElement thePed, string anim, float progress){ throw new NotImplementedException(); }
		public static bool SetPedDoingGangDriveby (MTAElement thePed, bool state){ throw new NotImplementedException(); }
		public static bool SetPedHeadless (MTAElement thePed, bool headState){ throw new NotImplementedException(); }
		public static bool SetPedOnFire (MTAElement thePed, bool isOnFire){ throw new NotImplementedException(); }
		public static bool SetPedStat (MTAElement thePed, int stat, float value){ throw new NotImplementedException(); }
		public static MTAElement CreatePickup (float x, float y, float z, int theType, int amount, int respawnTime, int ammo){ throw new NotImplementedException(); }
		public static bool SetPedWeaponSlot (MTAElement thePed, int weaponSlot){ throw new NotImplementedException(); }
		public static int GetPickupAmmo (MTAElement thePickup){ throw new NotImplementedException(); }
		public static bool SetPedWalkingStyle (MTAElement thePed, int style){ throw new NotImplementedException(); }
		public static bool WarpPedIntoVehicle (MTAElement thePed, MTAElement theVehicle, int seat){ throw new NotImplementedException(); }
		public static int GetPickupAmount (MTAElement thePickup){ throw new NotImplementedException(); }
		public static int GetPickupWeapon (MTAElement thePickup){ throw new NotImplementedException(); }
		public static int GetPickupType (MTAElement thePickup){ throw new NotImplementedException(); }
		public static bool SetPickupType (MTAElement thePickup, int theType, int amount, int ammo){ throw new NotImplementedException(); }
		public static bool UsePickup (MTAElement thePickup, MTAElement thePlayer){ throw new NotImplementedException(); }
		public static Tuple<int, int, int> GetPlayerNametagColor (MTAElement thePlayer){ throw new NotImplementedException(); }
		public static string GetPlayerName (MTAElement thePlayer){ throw new NotImplementedException(); }
		public static MTAElement GetPlayerFromName (string playerName){ throw new NotImplementedException(); }
		public static int GetPlayerPing (MTAElement thePlayer){ throw new NotImplementedException(); }
		public static string GetPlayerNametagText (MTAElement thePlayer){ throw new NotImplementedException(); }
		public static MTAElement GetPlayerTeam (MTAElement thePlayer){ throw new NotImplementedException(); }
		public static bool IsPlayerNametagShowing (MTAElement thePlayer){ throw new NotImplementedException(); }
		public static bool IsVoiceEnabled (){ throw new NotImplementedException(); }
		public static bool SetPlayerNametagShowing (MTAElement thePlayer, bool showing){ throw new NotImplementedException(); }
		public static bool SetPlayerNametagColor (MTAElement thePlayer, int r, int g, int b){ throw new NotImplementedException(); }
		public static bool SetPlayerNametagText (MTAElement thePlayer, string text){ throw new NotImplementedException(); }
		public static MTAElement CreateRadarArea (float startPosX, float startPosY, float sizeX, float sizeY, int r, int g, int b, int a, MTAElement visibleTo){ throw new NotImplementedException(); }
		public static Tuple<float, float> GetRadarAreaSize (MTAElement theRadararea){ throw new NotImplementedException(); }
		public static Tuple<int, int, int, int> GetRadarAreaColor (MTAElement theRadararea){ throw new NotImplementedException(); }
		public static bool IsRadarAreaFlashing (MTAElement theRadararea){ throw new NotImplementedException(); }
		public static bool SetRadarAreaColor (MTAElement theRadarArea, int r, int g, int b, int a){ throw new NotImplementedException(); }
		public static bool IsInsideRadarArea (MTAElement theArea, float posX, float posY){ throw new NotImplementedException(); }
		public static bool SetRadarAreaFlashing (MTAElement theRadarArea, bool flash){ throw new NotImplementedException(); }
		public static bool SetRadarAreaSize (MTAElement theRadararea, float x, float y){ throw new NotImplementedException(); }
		public static dynamic Call (MTAResource theResource, string theFunction){ throw new NotImplementedException(); }
		public static bool FetchRemote (string URL, string queueName, int connectionAttempts, int connectTimeout, dynamic callbackFunction, string postData, bool postIsBinary){ throw new NotImplementedException(); }
		public static MTAElement GetResourceDynamicElementRoot (MTAResource theResource){ throw new NotImplementedException(); }
		public static XmlNode GetResourceConfig (string filePath){ throw new NotImplementedException(); }
		public static MTAResource GetResourceFromName (string resourceName){ throw new NotImplementedException(); }
		public static dynamic GetResourceExportedFunctions (MTAResource theResource){ throw new NotImplementedException(); }
		public static string GetResourceName (MTAResource res){ throw new NotImplementedException(); }
		public static string GetResourceState (MTAResource theResource){ throw new NotImplementedException(); }
		public static MTAElement GetResourceRootElement (MTAResource theResource){ throw new NotImplementedException(); }
		public static MTAResource GetThisResource (){ throw new NotImplementedException(); }
		public static int GetFPSLimit (){ throw new NotImplementedException(); }
		public static dynamic GetVersion (){ throw new NotImplementedException(); }
		public static bool SetFPSLimit (int fpsLimit){ throw new NotImplementedException(); }
		public static dynamic GetPlayersInTeam (MTAElement theTeam){ throw new NotImplementedException(); }
		public static Tuple<int, int, int> GetTeamColor (MTAElement theTeam){ throw new NotImplementedException(); }
		public static bool GetTeamFriendlyFire (MTAElement theTeam){ throw new NotImplementedException(); }
		public static MTAElement GetTeamFromName (string teamName){ throw new NotImplementedException(); }
		public static int CountPlayersInTeam (MTAElement theTeam){ throw new NotImplementedException(); }
		public static string GetTeamName (MTAElement theTeam){ throw new NotImplementedException(); }
		public static string Base64Decode (string data){ throw new NotImplementedException(); }
		public static int BitNot (int var){ throw new NotImplementedException(); }
		public static int BitOr (int var1, int var2){ throw new NotImplementedException(); }
		public static int BitXor (int var1, int var2){ throw new NotImplementedException(); }
		public static int BitAnd (int var1, int var2){ throw new NotImplementedException(); }
		public static int BitLRotate (int value, int n){ throw new NotImplementedException(); }
		public static int BitRShift (int value, int n){ throw new NotImplementedException(); }
		public static bool BitTest (int var1, int var2){ throw new NotImplementedException(); }
		public static int BitReplace (int var, int replaceValue, int field, int width){ throw new NotImplementedException(); }
		public static int BitArShift (int value, int n){ throw new NotImplementedException(); }
		public static Tuple<int, int, int, int> GetColorFromString (string theColor){ throw new NotImplementedException(); }
		public static string DecodeString (string algorithm, string input, dynamic options){ throw new NotImplementedException(); }
		public static dynamic FromJSON (string json){ throw new NotImplementedException(); }
		public static string EncodeString (string algorithm, string input, dynamic options){ throw new NotImplementedException(); }
		public static int BitLShift (int value, int n){ throw new NotImplementedException(); }
		public static bool GetDevelopmentMode (){ throw new NotImplementedException(); }
		public static float GetDistanceBetweenPoints3D (float x1, float y1, float z1, float x2, float y2, float z2){ throw new NotImplementedException(); }
		public static float GetEasingValue (float fProgress, string strEasingType, float fEasingPeriod, float fEasingAmplitude, float fEasingOvershoot){ throw new NotImplementedException(); }
		public static dynamic GetNetworkUsageData (){ throw new NotImplementedException(); }
		public static bool DebugSleep (int sleep){ throw new NotImplementedException(); }
		public static float GetDistanceBetweenPoints2D (float x1, float y1, float x2, float y2){ throw new NotImplementedException(); }
		public static int GetTickCount (){ throw new NotImplementedException(); }
		public static dynamic GetRealTime (int seconds, bool localTime){ throw new NotImplementedException(); }
		public static dynamic GetTimers (int theTime){ throw new NotImplementedException(); }
		public static Tuple<dynamic, dynamic> GetPerformanceStats (string category, string options, string filter){ throw new NotImplementedException(); }
		public static string Hash (string algorithm, string dataToHash){ throw new NotImplementedException(); }
		public static string Inspect (dynamic var, dynamic options){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> InterpolateBetween (float x1, float y1, float z1, float x2, float y2, float z2, float fProgress, string strEasingType, float fEasingPeriod, float fEasingAmplitude, float fEasingOvershoot){ throw new NotImplementedException(); }
		public static bool Iprint (dynamic var1, dynamic var2, dynamic var3){ throw new NotImplementedException(); }
		public static bool Killdynamic (dynamic theTimer){ throw new NotImplementedException(); }
		public static bool IsOOPEnabled (){ throw new NotImplementedException(); }
		public static string Md5 (string str){ throw new NotImplementedException(); }
		public static string Gettok (string text, int tokenNumber, string parameter2){ throw new NotImplementedException(); }
		public static bool PasswordVerify (string password, string hash, dynamic options, dynamic callback){ throw new NotImplementedException(); }
		public static bool PregFind (string subject, string pattern, dynamic flags){ throw new NotImplementedException(); }
		public static dynamic PregMatch (string argument_base, string pattern, dynamic flags, int maxResults){ throw new NotImplementedException(); }
		public static bool SetDevelopmentMode (bool enable, bool enableWeb){ throw new NotImplementedException(); }
		public static bool Resetdynamic (dynamic theTimer){ throw new NotImplementedException(); }
		public static bool RemoveDebugHook (string hookType, dynamic callbackFunction){ throw new NotImplementedException(); }
		public static string PregReplace (string subject, string pattern, string replacement, dynamic flags){ throw new NotImplementedException(); }
		public static dynamic Split (string stringToSplit, string parameter1){ throw new NotImplementedException(); }
		public static string Sha256 (string str){ throw new NotImplementedException(); }
		public static dynamic Setdynamic (dynamic theFunction, int timeInterval, int timesToExecute, dynamic arguments){ throw new NotImplementedException(); }
		public static string TeaDecode (string data, string key){ throw new NotImplementedException(); }
		public static string PasswordHash (string password, string algorithm, dynamic options, dynamic callback){ throw new NotImplementedException(); }
		public static string TeaEncode (string text, string key){ throw new NotImplementedException(); }
		public static string ToJSON (dynamic value, bool compact, string prettyType){ throw new NotImplementedException(); }
		public static int Tocolor (int red, int green, int blue, int alpha){ throw new NotImplementedException(); }
		public static int UtfLen (string theString){ throw new NotImplementedException(); }
		public static string UtfChar (int characterCode){ throw new NotImplementedException(); }
		public static int UtfCode (string theString){ throw new NotImplementedException(); }
		public static dynamic Utf8_byte (string input, int i, int j){ throw new NotImplementedException(); }
		public static int UtfSeek (string theString, int position){ throw new NotImplementedException(); }
		public static string UtfSub (string theString, int Start, int End){ throw new NotImplementedException(); }
		public static string Utf8_char (int codepoints){ throw new NotImplementedException(); }
		public static string Utf8_escape (string input){ throw new NotImplementedException(); }
		public static Tuple<int, int> Utf8_charpos (string input, int charpos, int offset){ throw new NotImplementedException(); }
		public static string Utf8_find (string input, string pattern, int startpos, bool plain){ throw new NotImplementedException(); }
		public static dynamic Utf8_fold (dynamic input){ throw new NotImplementedException(); }
		public static dynamic Utf8_gmatch (string input, string pattern){ throw new NotImplementedException(); }
		public static string Utf8_insert (string input, int insert_pos){ throw new NotImplementedException(); }
		public static int Utf8_len (string input, int i, int j){ throw new NotImplementedException(); }
		public static bool AddDebugHook (string hookType, dynamic callbackFunction, dynamic nameList){ throw new NotImplementedException(); }
		public static string Utf8_gsub (string input, string pattern, dynamic replace, int match_limit){ throw new NotImplementedException(); }
		public static dynamic Utf8_match (string input, string pattern, int index){ throw new NotImplementedException(); }
		public static string Utf8_reverse (string input){ throw new NotImplementedException(); }
		public static int Utf8_ncasecmp (string a, string b){ throw new NotImplementedException(); }
		public static string Base64Encode (string data){ throw new NotImplementedException(); }
		public static Tuple<int, int> Utf8_next (string input, int charpos, int offset){ throw new NotImplementedException(); }
		public static string Utf8_remove (string input, int start, int stop){ throw new NotImplementedException(); }
		public static int BitRRotate (int value, int n){ throw new NotImplementedException(); }
		public static Tuple<int, int, int> Utf8_widthindex (string input, int location, bool ambi_is_double, int default_width){ throw new NotImplementedException(); }
		public static int BitExtract (int var, int field, int width){ throw new NotImplementedException(); }
		public static string Utf8_title (dynamic input){ throw new NotImplementedException(); }
		public static string Utf8_sub (string input, int i, int j){ throw new NotImplementedException(); }
		public static bool AddVehicleUpgrade (MTAElement theVehicle, int upgrade){ throw new NotImplementedException(); }
		public static int Utf8_width (dynamic input, bool ambi_is_double, int default_width){ throw new NotImplementedException(); }
		public static bool AttachTrailerToVehicle (MTAElement theVehicle, MTAElement theTrailer){ throw new NotImplementedException(); }
		public static bool DetachTrailerFromVehicle (MTAElement theVehicle, MTAElement theTrailer){ throw new NotImplementedException(); }
		public static bool FixVehicle (MTAElement theVehicle){ throw new NotImplementedException(); }
		public static float GetTrainPosition (MTAElement train){ throw new NotImplementedException(); }
		public static float GetTrainSpeed (MTAElement train){ throw new NotImplementedException(); }
		public static MTAElement CreateVehicle (int model, float x, float y, float z, float rx, float ry, float rz, string numberplate, bool bDirection, int variant1, int variant2){ throw new NotImplementedException(); }
		public static int GetTrainTrack (MTAElement train){ throw new NotImplementedException(); }
		public static bool GetTrainDirection (MTAElement train){ throw new NotImplementedException(); }
		public static dynamic GetOriginalHandling (int modelID){ throw new NotImplementedException(); }
		public static Tuple<int, int, int, int> GetVehicleColor (MTAElement theVehicle){ throw new NotImplementedException(); }
		public static MTAElement GetVehicleController (MTAElement theVehicle){ throw new NotImplementedException(); }
		public static float GetVehicleDoorOpenRatio (MTAElement theVehicle, int door){ throw new NotImplementedException(); }
		public static int GetVehicleDoorState (MTAElement theVehicle, int door){ throw new NotImplementedException(); }
		public static bool GetVehicleEngineState (MTAElement theVehicle){ throw new NotImplementedException(); }
		public static string GetUserdataType (MTAElement value){ throw new NotImplementedException(); }
		public static dynamic GetVehicleHandling (MTAElement theVehicle){ throw new NotImplementedException(); }
		public static Tuple<int, int, int> GetVehicleHeadLightColor (MTAElement theVehicle){ throw new NotImplementedException(); }
		public static dynamic GetVehicleCompatibleUpgrades (MTAElement theVehicle, int slot){ throw new NotImplementedException(); }
		public static int GetVehicleLightState (MTAElement theVehicle, int light){ throw new NotImplementedException(); }
		public static int GetVehicleMaxPassengers (MTAElement theVehicle){ throw new NotImplementedException(); }
		public static bool GetVehicleLandingGearDown (MTAElement theVehicle){ throw new NotImplementedException(); }
		public static int GetVehicleModelFromName (string name){ throw new NotImplementedException(); }
		public static string GetVehicleName (MTAElement theVehicle){ throw new NotImplementedException(); }
		public static MTAElement GetVehicleOccupant (MTAElement theVehicle, int seat){ throw new NotImplementedException(); }
		public static string GetVehicleNameFromModel (int model){ throw new NotImplementedException(); }
		public static dynamic GetVehicleOccupants (MTAElement theVehicle){ throw new NotImplementedException(); }
		public static int GetVehiclePanelState (MTAElement theVehicle, int panel){ throw new NotImplementedException(); }
		public static int GetVehiclePaintjob (MTAElement theVehicle){ throw new NotImplementedException(); }
		public static int GetVehicleOverrideLights (MTAElement theVehicle){ throw new NotImplementedException(); }
		public static string GetVehiclePlateText (MTAElement theVehicle){ throw new NotImplementedException(); }
		public static dynamic GetVehicleSirenParams (MTAElement theVehicle){ throw new NotImplementedException(); }
		public static dynamic GetVehicleSirens (MTAElement theVehicle){ throw new NotImplementedException(); }
		public static bool GetVehicleSirensOn (MTAElement theVehicle){ throw new NotImplementedException(); }
		public static MTAElement GetVehicleTowedByVehicle (MTAElement theVehicle){ throw new NotImplementedException(); }
		public static Tuple<float, float> GetVehicleTurretPosition (MTAElement turretVehicle){ throw new NotImplementedException(); }
		public static MTAElement GetVehicleTowingVehicle (MTAElement theVehicle){ throw new NotImplementedException(); }
		public static string GetVehicleUpgradeSlotName (int slot){ throw new NotImplementedException(); }
		public static int GetVehicleUpgradeOnSlot (MTAElement theVehicle, int slot){ throw new NotImplementedException(); }
		public static string GetVehicleType (MTAElement theVehicle){ throw new NotImplementedException(); }
		public static dynamic GetVehicleUpgrades (MTAElement theVehicle){ throw new NotImplementedException(); }
		public static Tuple<int, int> GetVehicleVariant (MTAElement theVehicle){ throw new NotImplementedException(); }
		public static bool IsTrainDerailable (MTAElement vehicleToCheck){ throw new NotImplementedException(); }
		public static Tuple<int, int, int, int> GetVehicleWheelStates (MTAElement theVehicle){ throw new NotImplementedException(); }
		public static bool IsVehicleBlown (MTAElement theVehicle){ throw new NotImplementedException(); }
		public static bool IsTrainDerailed (MTAElement vehicleToCheck){ throw new NotImplementedException(); }
		public static bool IsVehicleDamageProof (MTAElement theVehicle){ throw new NotImplementedException(); }
		public static bool IsVehicleFuelTankExplodable (MTAElement theVehicle){ throw new NotImplementedException(); }
		public static bool IsVehicleLocked (MTAElement theVehicle){ throw new NotImplementedException(); }
		public static bool IsVehicleOnGround (MTAElement theVehicle){ throw new NotImplementedException(); }
		public static bool IsVehicleTaxiLightOn (MTAElement taxi){ throw new NotImplementedException(); }
		public static bool RemoveVehicleUpgrade (MTAElement theVehicle, int upgrade){ throw new NotImplementedException(); }
		public static bool SetTrainDirection (MTAElement train, bool clockwise){ throw new NotImplementedException(); }
		public static bool SetTrainDerailable (MTAElement derailableVehicle, bool derailable){ throw new NotImplementedException(); }
		public static bool SetTrainSpeed (MTAElement train, float speed){ throw new NotImplementedException(); }
		public static bool SetTrainTrack (MTAElement train, int track){ throw new NotImplementedException(); }
		public static bool SetTrainPosition (MTAElement train, float position){ throw new NotImplementedException(); }
		public static bool SetVehicleColor (MTAElement theVehicle, int r1, int g1, int b1, int r2, int g2, int b2, int r3, int g3, int b3, int r4, int g4, int b4){ throw new NotImplementedException(); }
		public static bool SetVehicleDamageProof (MTAElement theVehicle, bool damageProof){ throw new NotImplementedException(); }
		public static bool SetVehicleDoorState (MTAElement theVehicle, int door, int state){ throw new NotImplementedException(); }
		public static bool SetVehicleEngineState (MTAElement theVehicle, bool engineState){ throw new NotImplementedException(); }
		public static bool SetVehicleDoorsUndamageable (MTAElement theVehicle, bool state){ throw new NotImplementedException(); }
		public static bool SetVehicleFuelTankExplodable (MTAElement theVehicle, bool explodable){ throw new NotImplementedException(); }
		public static bool SetVehicleDoorOpenRatio (MTAElement theVehicle, int door, float ratio, int time){ throw new NotImplementedException(); }
		public static bool SetVehicleHandling (MTAElement theVehicle, string property, dynamic value){ throw new NotImplementedException(); }
		public static bool SetVehicleLandingGearDown (MTAElement theVehicle, bool gearState){ throw new NotImplementedException(); }
		public static bool SetVehicleHeadLightColor (MTAElement theVehicle, int red, int green, int blue){ throw new NotImplementedException(); }
		public static bool SetVehicleOverrideLights (MTAElement theVehicle, int value){ throw new NotImplementedException(); }
		public static bool SetVehiclePaintjob (MTAElement theVehicle, int value){ throw new NotImplementedException(); }
		public static bool SetVehicleLightState (MTAElement theVehicle, int light, int state){ throw new NotImplementedException(); }
		public static bool SetVehiclePlateText (MTAElement theVehicle, string numberplate){ throw new NotImplementedException(); }
		public static bool SetVehicleLocked (MTAElement theVehicle, bool locked){ throw new NotImplementedException(); }
		public static bool SetVehiclePanelState (MTAElement theVehicle, int panelID, int state){ throw new NotImplementedException(); }
		public static bool SetVehicleSirens (MTAElement theVehicle, int sirenPoint, float posX, float posY, float posZ, float red, float green, float blue, float alpha, float minAlpha){ throw new NotImplementedException(); }
		public static bool SetVehicleSirensOn (MTAElement theVehicle, bool sirensOn){ throw new NotImplementedException(); }
		public static bool SetVehicleTurretPosition (MTAElement turretVehicle, float positionX, float positionY){ throw new NotImplementedException(); }
		public static bool SetVehicleTaxiLightOn (MTAElement taxi, bool LightState){ throw new NotImplementedException(); }
		public static bool SetVehicleWheelStates (MTAElement theVehicle, int frontLeft, int rearLeft, int frontRight, int rearRight){ throw new NotImplementedException(); }
		public static MTAElement CreateWater (float x1, float y1, float z1, float x2, float y2, float z2, float x3, float y3, float z3, float x4, float y4, float z4, bool bShallow){ throw new NotImplementedException(); }
        public static MTAElement CreateWater(float x1, float y1, float z1, float x2, float y2, float z2, float x3, float y3, float z3, bool bShallow) { throw new NotImplementedException(); }
        public static Tuple<int, int, float> GetWaterVertexPosition (MTAElement theWater, int vertexIndex){ throw new NotImplementedException(); }
		public static float GetWaveHeight (){ throw new NotImplementedException(); }
		public static bool SetWaterColor (int red, int green, int blue, int alpha){ throw new NotImplementedException(); }
		public static Tuple<int, int, int, int> GetWaterColor (){ throw new NotImplementedException(); }
		public static bool SetWaterLevel (MTAElement theWater, float level){ throw new NotImplementedException(); }
        public static bool SetWaterLevel(float level, bool includeWaterFeatures, bool includeWaterElements) { throw new NotImplementedException(); }
        public static bool ResetWaterColor (){ throw new NotImplementedException(); }
		public static bool ResetWaterLevel (){ throw new NotImplementedException(); }
		public static bool SetWaveHeight (float height){ throw new NotImplementedException(); }
		public static bool SetWaterVertexPosition (MTAElement theWater, int vertexIndex, int x, int y, float z){ throw new NotImplementedException(); }
		public static int GetSlotFromWeapon (int weaponid){ throw new NotImplementedException(); }
		public static int GetWeaponProperty (int weaponID, string weaponSkill, string property){ throw new NotImplementedException(); }
		public static string GetWeaponNameFromID (int id){ throw new NotImplementedException(); }
		public static bool SetWeaponAmmo (MTAElement thePlayer, int weapon, int totalAmmo, int ammoInClip){ throw new NotImplementedException(); }
		public static bool AreTrafficLightsLocked (){ throw new NotImplementedException(); }
		public static bool SetWeaponProperty (int weaponID, string weaponSkill, string property, dynamic theValue){ throw new NotImplementedException(); }
		public static float GetFarClipDistance (){ throw new NotImplementedException(); }
		public static bool GetCloudsEnabled (){ throw new NotImplementedException(); }
		public static float GetAircraftMaxVelocity (){ throw new NotImplementedException(); }
		public static float GetFogDistance (){ throw new NotImplementedException(); }
		public static float GetGameSpeed (){ throw new NotImplementedException(); }
		public static float GetGravity (){ throw new NotImplementedException(); }
		public static Tuple<int, int, int, int, int, int, int, Tuple<int, bool>> GetHeatHaze (){ throw new NotImplementedException(); }
		public static float GetJetpackMaxHeight (){ throw new NotImplementedException(); }
		public static bool GetOcclusionsEnabled (){ throw new NotImplementedException(); }
		public static int GetMinuteDuration (){ throw new NotImplementedException(); }
		public static int GetOriginalWeaponProperty (int weaponID, string weaponSkill, string property){ throw new NotImplementedException(); }
		public static Tuple<int, int, int, int, int, int> GetSkyGradient (){ throw new NotImplementedException(); }
		public static float GetRainLevel (){ throw new NotImplementedException(); }
		public static int GetMoonSize (){ throw new NotImplementedException(); }
		public static Tuple<int, int, int, int, int, int> GetSunColor (){ throw new NotImplementedException(); }
		public static int GetTrafficLightState (){ throw new NotImplementedException(); }
		public static float GetSunSize (){ throw new NotImplementedException(); }
		public static Tuple<int, int> GetTime (){ throw new NotImplementedException(); }
		public static Tuple<int, int> GetWeather (){ throw new NotImplementedException(); }
		public static Tuple<int, int, int> GetWindVelocity (){ throw new NotImplementedException(); }
		public static string GetZoneName (float x, float y, float z, bool citiesonly){ throw new NotImplementedException(); }
		public static bool IsGarageOpen (int garageID){ throw new NotImplementedException(); }
		public static bool SetTrainDerailed (MTAElement vehicleToDerail, bool derailed){ throw new NotImplementedException(); }
		public static bool RemoveWorldModel (int modelID, float radius, float x, float y, float z, int interior){ throw new NotImplementedException(); }
		public static bool ResetFogDistance (){ throw new NotImplementedException(); }
		public static bool ResetFarClipDistance (){ throw new NotImplementedException(); }
		public static bool ResetHeatHaze (){ throw new NotImplementedException(); }
		public static bool ResetRainLevel (){ throw new NotImplementedException(); }
		public static bool ResetMoonSize (){ throw new NotImplementedException(); }
		public static bool ResetSkyGradient (){ throw new NotImplementedException(); }
		public static bool ResetSunColor (){ throw new NotImplementedException(); }
		public static bool ResetSunSize (){ throw new NotImplementedException(); }
		public static bool ResetWindVelocity (){ throw new NotImplementedException(); }
		public static bool RestoreAllWorldModels (){ throw new NotImplementedException(); }
		public static bool RestoreWorldModel (int modelID, float radius, float x, float y, float z, int iInterior){ throw new NotImplementedException(); }
		public static bool SetAircraftMaxVelocity (float velocity){ throw new NotImplementedException(); }
		public static bool SetCloudsEnabled (bool enabled){ throw new NotImplementedException(); }
		public static bool SetFarClipDistance (float distance){ throw new NotImplementedException(); }
		public static bool SetGameSpeed (float value){ throw new NotImplementedException(); }
		public static bool SetFogDistance (float distance){ throw new NotImplementedException(); }
		public static bool SetHeatHaze (int intensity, int randomShift, int speedMin, int speedMax, int scanSizeX, int scanSizeY, int renderSizeX, int renderSizeY, bool bShowInside){ throw new NotImplementedException(); }
		public static bool SetGravity (float level){ throw new NotImplementedException(); }
		public static bool SetInteriorSoundsEnabled (bool enabled){ throw new NotImplementedException(); }
		public static bool SetGarageOpen (int garageID, bool open){ throw new NotImplementedException(); }
		public static bool SetMoonSize (int size){ throw new NotImplementedException(); }
		public static bool SetMinuteDuration (int milliseconds){ throw new NotImplementedException(); }
		public static bool SetOcclusionsEnabled (bool enabled){ throw new NotImplementedException(); }
		public static bool SetRainLevel (float level){ throw new NotImplementedException(); }
		public static bool SetSunColor (int aRed, int aGreen, int aBlue, int bRed, int bGreen, int bBlue){ throw new NotImplementedException(); }
		public static bool SetSkyGradient (int topRed, int topGreen, int topBlue, int bottomRed, int bottomGreen, int bottomBlue){ throw new NotImplementedException(); }
		public static bool SetSunSize (int Size){ throw new NotImplementedException(); }
		public static bool SetTrafficLightState (dynamic state){ throw new NotImplementedException(); }
        public static bool SetTime (int hour, int minute){ throw new NotImplementedException(); }
		public static bool SetTrafficLightsLocked (bool toggle){ throw new NotImplementedException(); }
		public static bool SetWeather (int weatherID){ throw new NotImplementedException(); }
		public static bool SetWeatherBlended (int weatherID){ throw new NotImplementedException(); }
		public static MTAElement XmlCopyFile (MTAElement nodeToCopy, string newFilePath){ throw new NotImplementedException(); }
		public static bool SetWindVelocity (float velocityX, float velocityY, float velocityZ){ throw new NotImplementedException(); }
		public static MTAElement XmlFindChild (MTAElement parent, string tagName, int index){ throw new NotImplementedException(); }
		public static bool XmlDestroyNode (MTAElement theXMLNode){ throw new NotImplementedException(); }
		public static MTAElement XmlCreateChild (MTAElement parentNode, string tagName){ throw new NotImplementedException(); }
		public static MTAElement XmlCreateFile (string filePath, string rootNodeName){ throw new NotImplementedException(); }
		public static MTAElement XmlLoadFile (string filePath, bool readOnly){ throw new NotImplementedException(); }
		public static string XmlNodeGetAttribute (MTAElement node, string name){ throw new NotImplementedException(); }
		public static dynamic XmlNodeGetAttributes (MTAElement node){ throw new NotImplementedException(); }
		public static dynamic XmlNodeGetChildren (MTAElement parent, int index){ throw new NotImplementedException(); }
		public static string XmlNodeGetName (MTAElement node){ throw new NotImplementedException(); }
		public static string XmlNodeGetValue (MTAElement theXMLNode){ throw new NotImplementedException(); }
		public static int GetWeaponIDFromName (string name){ throw new NotImplementedException(); }
		public static MTAElement XmlNodeGetParent (MTAElement node){ throw new NotImplementedException(); }
		public static bool XmlNodeSetAttribute (MTAElement node, string name, dynamic value){ throw new NotImplementedException(); }
		public static bool XmlNodeSetName (MTAElement node, string name){ throw new NotImplementedException(); }
		public static bool XmlUnloadFile (MTAElement node){ throw new NotImplementedException(); }
		public static bool XmlSaveFile (MTAElement rootNode){ throw new NotImplementedException(); }
		public static bool XmlNodeSetValue (MTAElement theXMLNode, string value, bool setCDATA){ throw new NotImplementedException(); }
		public static dynamic GetElementsWithinRange (float x, float y, float z, float range, string elemType){ throw new NotImplementedException(); }
		public static bool SetVehicleDirtLevel (MTAElement theVehicle, int dirtLevel){ throw new NotImplementedException(); }
		public static float GetAircraftMaxHeight (){ throw new NotImplementedException(); }
		public static bool SetAircraftMaxHeight (float Height){ throw new NotImplementedException(); }
		public static bool SetJetpackMaxHeight (float Height){ throw new NotImplementedException(); }
		public static System.Collections.Generic.List<dynamic> GetListFromTable (dynamic table, string listType){ throw new NotImplementedException(); }
        public static dynamic[] GetArrayFromTable(dynamic table, string arrayType) { throw new NotImplementedException(); }
        public static System.Collections.Generic.Dictionary<dynamic, dynamic> GetDictionaryFromTable(dynamic table, string tKey, string tValue) { throw new NotImplementedException(); }
        public static DateTime GetDateTimeFromSecondStamp(int seconds = 0) { throw new NotImplementedException(); }

    }
}