using System;

namespace MultiTheftAuto {
	public class Client {
		public static int GetBlipIcon (Element theBlip){ throw new NotImplementedException(); }
		public static int GetBlipOrdering (Element theBlip){ throw new NotImplementedException(); }
		public static int GetBlipSize (Element theBlip){ throw new NotImplementedException(); }
		public static Tuple<int, int, int, int> GetBlipColor (Element theBlip){ throw new NotImplementedException(); }
		public static float GetBlipVisibleDistance (Element theBlip){ throw new NotImplementedException(); }
		public static bool SetBlipColor (Element theBlip, int red, int green, int blue, int alpha){ throw new NotImplementedException(); }
		public static bool SetBlipVisibleDistance (Element theBlip, float theDistance){ throw new NotImplementedException(); }
		public static bool SetBlipIcon (Element theBlip, int icon){ throw new NotImplementedException(); }
		public static bool SetBlipOrdering (Element theBlip, int ordering){ throw new NotImplementedException(); }
		public static bool SetBlipSize (Element theBlip, int iconSize){ throw new NotImplementedException(); }
		public static string GetBodyPartName (int bodyPartID){ throw new NotImplementedException(); }
		public static Tuple<int, int> GetTypeIndexFromClothes (string clothesTexture, string clothesModel){ throw new NotImplementedException(); }
		public static Tuple<string, string> GetClothesByTypeIndex (int clothesType, int clothesIndex){ throw new NotImplementedException(); }
		public static string GetClothesTypeName (int clothesType){ throw new NotImplementedException(); }
		public static Element CreateColCuboid (float fX, float fY, float fZ, float fWidth, float fDepth, float fHeight){ throw new NotImplementedException(); }
		public static Element CreateColCircle (float fX, float fY, float radius){ throw new NotImplementedException(); }
		public static Element CreateColPolygon (float fX, float fY, float fX1, float fY1, float fX2, float fY2, float fX3, float fY3){ throw new NotImplementedException(); }
		public static Element CreateColSphere (float fX, float fY, float fZ, float fRadius){ throw new NotImplementedException(); }
		public static Element CreateColTube (float fX, float fY, float fZ, float fRadius, float fHeight){ throw new NotImplementedException(); }
		public static string GetColShapeType (Element shape){ throw new NotImplementedException(); }
		public static dynamic GetElementsWithinColShape (Element theShape, string elemType){ throw new NotImplementedException(); }
		public static bool IsInsideColShape (Element theShape, float posX, float posY, float posZ){ throw new NotImplementedException(); }
		public static Element CreateColRectangle (float fX, float fY, float fWidth, float fHeight){ throw new NotImplementedException(); }
		public static Element GetElementColShape (Element theElement){ throw new NotImplementedException(); }
		public static bool IsElementWithinColShape (Element theElement, Element theShape){ throw new NotImplementedException(); }
		public static bool AttachElements (Element theElement, Element theAttachToElement, float xPosOffset, float yPosOffset, float zPosOffset, float xRotOffset, float yRotOffset, float zRotOffset){ throw new NotImplementedException(); }
		public static Element CreateElement (string elementType, string elementID){ throw new NotImplementedException(); }
		public static bool DestroyElement (Element elementToDestroy){ throw new NotImplementedException(); }
		public static bool DetachElements (Element theElement, Element theAttachToElement){ throw new NotImplementedException(); }
		public static dynamic GetAttachedElements (Element theElement){ throw new NotImplementedException(); }
		public static int GetElementAlpha (Element theElement){ throw new NotImplementedException(); }
		public static bool GetElementCollisionsEnabled (Element theElement){ throw new NotImplementedException(); }
		public static Tuple<float, float, float, float, float, float> GetElementAttachedOffsets (Element theElement){ throw new NotImplementedException(); }
		public static Element GetElementAttachedTo (Element theElement){ throw new NotImplementedException(); }
		public static Element GetElementChild (Element parent, int index){ throw new NotImplementedException(); }
		public static Element GetElementByID (string id, int index){ throw new NotImplementedException(); }
		public static dynamic GetElementChildren (Element parent, string theType){ throw new NotImplementedException(); }
		public static int GetElementChildrenCount (Element parent){ throw new NotImplementedException(); }
		public static int GetElementInterior (Element theElement){ throw new NotImplementedException(); }
		public static float GetElementHealth (Element theElement){ throw new NotImplementedException(); }
		public static string GetElementID (Element theElement){ throw new NotImplementedException(); }
		public static int GetElementDimension (Element theElement){ throw new NotImplementedException(); }
		public static int GetElementModel (Element theElement){ throw new NotImplementedException(); }
		public static Element GetElementParent (Element theElement){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetElementPosition (Element theElement){ throw new NotImplementedException(); }
		public static string GetElementType (Element theElement){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetElementVelocity (Element theElement){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetElementRotation (Element theElement, string rotOrder){ throw new NotImplementedException(); }
		public static dynamic GetElementMatrix (Element theElement, bool legacy){ throw new NotImplementedException(); }
		public static Element GetLowLODElement (Element theElement){ throw new NotImplementedException(); }
		public static bool IsElementAttached (Element theElement){ throw new NotImplementedException(); }
		public static Element GetRootElement (){ throw new NotImplementedException(); }
		public static bool IsElement (dynamic theValue){ throw new NotImplementedException(); }
		public static bool IsElementCallPropagationEnabled (Element theElement){ throw new NotImplementedException(); }
		public static bool IsElementDoubleSided (Element theElement){ throw new NotImplementedException(); }
		public static bool IsElementFrozen (Element theElement){ throw new NotImplementedException(); }
		public static bool IsElementInWater (Element theElement){ throw new NotImplementedException(); }
		public static bool IsElementLowLOD (Element theElement){ throw new NotImplementedException(); }
		public static bool IsElementWithinMarker (Element theElement, Element theMarker){ throw new NotImplementedException(); }
		public static bool SetElementAngularVelocity (Element theElement, float rx, float ry, float rz){ throw new NotImplementedException(); }
		public static bool SetElementAlpha (Element theElement, int alpha){ throw new NotImplementedException(); }
		public static bool GetElementAngularVelocity (Element theElement){ throw new NotImplementedException(); }
		public static bool SetElementAttachedOffsets (Element theElement, float xPosOffset, float yPosOffset, float zPosOffset, float xRotOffset, float yRotOffset, float zRotOffset){ throw new NotImplementedException(); }
		public static bool SetElementCallPropagationEnabled (Element theElement, bool enabled){ throw new NotImplementedException(); }
		public static bool SetElementCollisionsEnabled (Element theElement, bool enabled){ throw new NotImplementedException(); }
		public static bool SetElementData (Element theElement, string key, dynamic value, bool synchronize){ throw new NotImplementedException(); }
		public static bool SetElementDimension (Element theElement, int dimension){ throw new NotImplementedException(); }
		public static bool SetElementDoubleSided (Element theElement, bool enable){ throw new NotImplementedException(); }
		public static bool SetElementFrozen (Element theElement, bool freezeStatus){ throw new NotImplementedException(); }
		public static bool SetElementHealth (Element theElement, float newHealth){ throw new NotImplementedException(); }
		public static bool SetElementID (Element theElement, string name){ throw new NotImplementedException(); }
		public static bool SetElementInterior (Element theElement, int interior, float x, float y, float z){ throw new NotImplementedException(); }
		public static bool SetElementModel (Element theElement, int model){ throw new NotImplementedException(); }
		public static bool SetElementParent (Element theElement, Element parent){ throw new NotImplementedException(); }
		public static bool SetElementPosition (Element theElement, float x, float y, float z, bool warp){ throw new NotImplementedException(); }
		public static bool SetElementRotation (Element theElement, float rotX, float rotY, float rotZ, string rotOrder, bool conformPedRotation){ throw new NotImplementedException(); }
		public static bool SetElementVelocity (Element theElement, float speedX, float speedY, float speedZ){ throw new NotImplementedException(); }
		public static bool AddEvent (string eventName, bool allowRemoteTrigger){ throw new NotImplementedException(); }
		public static bool SetLowLODElement (Element theElement, Element lowLODElement){ throw new NotImplementedException(); }
		public static bool AddEventHandler (string eventName, Element attachedTo, dynamic handlerFunction, bool getPropagated, string priority){ throw new NotImplementedException(); }
		public static dynamic GetEventHandlers (string eventName, Element attachedTo){ throw new NotImplementedException(); }
		public static bool RemoveEventHandler (string eventName, Element attachedTo, dynamic functionVar){ throw new NotImplementedException(); }
		public static bool WasEventCancelled (){ throw new NotImplementedException(); }
		public static bool TriggerEvent (string eventName, Element baseElement, dynamic argument1){ throw new NotImplementedException(); }
		public static bool FileClose (Element theFile){ throw new NotImplementedException(); }
		public static Element FileCreate (string filePath){ throw new NotImplementedException(); }
		public static bool FileExists (string filePath){ throw new NotImplementedException(); }
		public static bool FileDelete (string filePath){ throw new NotImplementedException(); }
		public static bool FileCopy (string filePath, string copyToFilePath, bool overwrite){ throw new NotImplementedException(); }
		public static bool FileFlush (Element theFile){ throw new NotImplementedException(); }
		public static string FileGetPath (Element theFile){ throw new NotImplementedException(); }
		public static int FileGetSize (Element theFile){ throw new NotImplementedException(); }
		public static int FileGetPos (Element theFile){ throw new NotImplementedException(); }
		public static bool FileIsEOF (Element theFile){ throw new NotImplementedException(); }
		public static string FileRead (Element theFile, int count){ throw new NotImplementedException(); }
		public static Element FileOpen (string filePath, bool readOnly){ throw new NotImplementedException(); }
		public static bool FileRename (string filePath, string newFilePath){ throw new NotImplementedException(); }
		public static int FileSetPos (Element theFile, int offset){ throw new NotImplementedException(); }
		public static bool HttpRequestLogin (){ throw new NotImplementedException(); }
		public static bool HttpClear (){ throw new NotImplementedException(); }
		public static int FileWrite (Element theFile, string string1, string string2, string string3){ throw new NotImplementedException(); }
		public static bool HttpSetResponseCode (int code){ throw new NotImplementedException(); }
		public static bool HttpSetResponseCookie (string cookieName, string cookieValue){ throw new NotImplementedException(); }
		public static bool HttpWrite (string data, int length){ throw new NotImplementedException(); }
		public static bool HttpSetResponseHeader (string headerName, string headerValue){ throw new NotImplementedException(); }
		public static dynamic GetCommandHandlers (Element theResource){ throw new NotImplementedException(); }
		public static bool RemoveCommandHandler (string commandName, dynamic handler){ throw new NotImplementedException(); }
		public static bool SetControlState (Element thePlayer, string control, bool state){ throw new NotImplementedException(); }
		public static Tuple<int, int, int, int> GetMarkerColor (Element theMarker){ throw new NotImplementedException(); }
		public static int GetMarkerCount (){ throw new NotImplementedException(); }
		public static string GetMarkerIcon (Element theMarker){ throw new NotImplementedException(); }
		public static float GetMarkerSize (Element myMarker){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetMarkerTarget (Element theMarker){ throw new NotImplementedException(); }
		public static bool SetMarkerColor (Element theMarker, int r, int g, int b, int a){ throw new NotImplementedException(); }
		public static bool SetMarkerTarget (Element theMarker, float x, float y, float z){ throw new NotImplementedException(); }
		public static bool SetMarkerIcon (Element theMarker, string icon){ throw new NotImplementedException(); }
		public static bool SetMarkerSize (Element theMarker, float size){ throw new NotImplementedException(); }
		public static bool SetMarkerType (Element theMarker, string markerType){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetObjectScale (Element theObject){ throw new NotImplementedException(); }
		public static Element CreateObject (int modelid, float x, float y, float z, float rx, float ry, float rz, bool isLowLOD){ throw new NotImplementedException(); }
		public static bool MoveObject (Element theObject, int time, float targetx, float targety, float targetz, float moverx, float movery, float moverz, string strEasingType, float fEasingPeriod, float fEasingAmplitude, float fEasingOvershoot){ throw new NotImplementedException(); }
		public static bool StopObject (Element theobject){ throw new NotImplementedException(); }
		public static bool SetObjectScale (Element theObject, float scale, float scaleY, float scaleZ){ throw new NotImplementedException(); }
		public static bool OutputDebugString (string text, int level, int red, int green, int blue){ throw new NotImplementedException(); }
		public static string GetMarkerType (Element theMarker){ throw new NotImplementedException(); }
		public static bool AddPedClothes (Element thePed, string clothesTexture, string clothesModel, int clothesType){ throw new NotImplementedException(); }
		public static int GetPedAmmoInClip (Element thePed, int weaponSlot){ throw new NotImplementedException(); }
		public static Element GetPedContactElement (Element thePed){ throw new NotImplementedException(); }
		public static float GetPedArmor (Element thePed){ throw new NotImplementedException(); }
		public static Tuple<string, string> GetPedClothes (Element thePed, int clothesType){ throw new NotImplementedException(); }
		public static int GetPedFightingStyle (Element thePed){ throw new NotImplementedException(); }
		public static Element GetPedOccupiedVehicle (Element thePed){ throw new NotImplementedException(); }
		public static float GetPedStat (Element thePed, int stat){ throw new NotImplementedException(); }
		public static dynamic GetElementData (Element theElement, string key, dynamic parameter2){ throw new NotImplementedException(); }
		public static int GetPedOccupiedVehicleSeat (Element thePed){ throw new NotImplementedException(); }
		public static Tuple<dynamic, dynamic, dynamic> GetElementsByType (dynamic parameter0, dynamic argument_in){ throw new NotImplementedException(); }
		public static Element GetPedTarget (Element thePed){ throw new NotImplementedException(); }
		public static int GetPedTotalAmmo (Element thePed, int weaponSlot){ throw new NotImplementedException(); }
		public static int GetPedWalkingStyle (Element thePed){ throw new NotImplementedException(); }
		public static bool IsPedDoingGangDriveby (Element thePed){ throw new NotImplementedException(); }
		public static dynamic GetValidPedModels (){ throw new NotImplementedException(); }
		public static bool IsPedDucked (Element thePed){ throw new NotImplementedException(); }
		public static bool IsPedDead (Element thePed){ throw new NotImplementedException(); }
		public static bool IsPedOnFire (Element thePed){ throw new NotImplementedException(); }
		public static bool IsPedHeadless (Element thePed){ throw new NotImplementedException(); }
		public static bool IsPedChoking (Element thePed){ throw new NotImplementedException(); }
		public static int GetPedWeaponSlot (Element thePed){ throw new NotImplementedException(); }
		public static bool IsPedOnGround (Element thePed){ throw new NotImplementedException(); }
		public static bool IsPedInVehicle (Element thePed){ throw new NotImplementedException(); }
		public static int GetPedWeapon (Element thePed, int weaponSlot){ throw new NotImplementedException(); }
		public static bool IsPedWearingJetpack (Element thePed){ throw new NotImplementedException(); }
		public static bool KillPed (Element thePed, Element theKiller, int weapon, int bodyPart, bool stealth){ throw new NotImplementedException(); }
		public static bool SetPedAnimationSpeed (Element thePed, string anim, float speed){ throw new NotImplementedException(); }
		public static bool RemovePedFromVehicle (Element thePed){ throw new NotImplementedException(); }
		public static bool SetPedAnimationProgress (Element thePed, string anim, float progress){ throw new NotImplementedException(); }
		public static bool RemovePedClothes (Element thePed, int clothesType, string clothesTexture, string clothesModel){ throw new NotImplementedException(); }
		public static bool SetPedAnimation (Element thePed, string block, string anim, int time, bool loop, bool updatePosition, bool interruptable, bool freezeLastFrame, int blendTime){ throw new NotImplementedException(); }
		public static bool SetPedDoingGangDriveby (Element thePed, bool state){ throw new NotImplementedException(); }
		public static bool SetPedOnFire (Element thePed, bool isOnFire){ throw new NotImplementedException(); }
		public static bool SetPedHeadless (Element thePed, bool headState){ throw new NotImplementedException(); }
		public static bool SetPedWeaponSlot (Element thePed, int weaponSlot){ throw new NotImplementedException(); }
		public static bool SetPedStat (Element thePed, int stat, float value){ throw new NotImplementedException(); }
		public static bool SetPedWalkingStyle (Element thePed, int style){ throw new NotImplementedException(); }
		public static bool WarpPedIntoVehicle (Element thePed, Element theVehicle, int seat){ throw new NotImplementedException(); }
		public static Element CreatePickup (float x, float y, float z, int theType, int amount, int respawnTime, int ammo){ throw new NotImplementedException(); }
		public static int GetPickupAmmo (Element thePickup){ throw new NotImplementedException(); }
		public static int GetPickupAmount (Element thePickup){ throw new NotImplementedException(); }
		public static int GetPickupWeapon (Element thePickup){ throw new NotImplementedException(); }
		public static bool UsePickup (Element thePickup, Element thePlayer){ throw new NotImplementedException(); }
		public static int GetPickupType (Element thePickup){ throw new NotImplementedException(); }
		public static bool SetPickupType (Element thePickup, int theType, int amount, int ammo){ throw new NotImplementedException(); }
		public static Element GetPlayerFromName (string playerName){ throw new NotImplementedException(); }
		public static Tuple<dynamic, dynamic, dynamic, Element, dynamic, dynamic, dynamic> ForcePlayerMap (dynamic parameter0){ throw new NotImplementedException(); }
		public static string GetPlayerName (Element thePlayer){ throw new NotImplementedException(); }
		public static int GetPlayerPing (Element thePlayer){ throw new NotImplementedException(); }
		public static Tuple<int, int, int> GetPlayerNametagColor (Element thePlayer){ throw new NotImplementedException(); }
		public static string GetPlayerNametagText (Element thePlayer){ throw new NotImplementedException(); }
		public static Element GetPlayerTeam (Element thePlayer){ throw new NotImplementedException(); }
		public static bool IsPlayerNametagShowing (Element thePlayer){ throw new NotImplementedException(); }
		public static bool IsVoiceEnabled (){ throw new NotImplementedException(); }
		public static dynamic SetPlayerMoney (dynamic parameter2){ throw new NotImplementedException(); }
		public static bool SetPlayerNametagShowing (Element thePlayer, bool showing){ throw new NotImplementedException(); }
		public static bool SetPlayerNametagColor (Element thePlayer, int r, int g, int b){ throw new NotImplementedException(); }
		public static bool SetPlayerNametagText (Element thePlayer, string text){ throw new NotImplementedException(); }
		public static Element CreateRadarArea (float startPosX, float startPosY, float sizeX, float sizeY, int r, int g, int b, int a, Element visibleTo){ throw new NotImplementedException(); }
		public static Tuple<float, float> GetRadarAreaSize (Element theRadararea){ throw new NotImplementedException(); }
		public static Tuple<int, int, int, int> GetRadarAreaColor (Element theRadararea){ throw new NotImplementedException(); }
		public static bool IsInsideRadarArea (Element theArea, float posX, float posY){ throw new NotImplementedException(); }
		public static bool SetRadarAreaFlashing (Element theRadarArea, bool flash){ throw new NotImplementedException(); }
		public static bool SetRadarAreaColor (Element theRadarArea, int r, int g, int b, int a){ throw new NotImplementedException(); }
		public static bool SetRadarAreaSize (Element theRadararea, float x, float y){ throw new NotImplementedException(); }
		public static bool IsRadarAreaFlashing (Element theRadararea){ throw new NotImplementedException(); }
		public static dynamic Call (Element theResource, string theFunction){ throw new NotImplementedException(); }
		public static bool FetchRemote (string URL, string queueName, int connectionAttempts, int connectTimeout, dynamic callbackFunction, string postData, bool postIsBinary){ throw new NotImplementedException(); }
		public static Element GetResourceConfig (string filePath){ throw new NotImplementedException(); }
		public static dynamic GetResourceExportedFunctions (Element theResource){ throw new NotImplementedException(); }
		public static Element GetResourceDynamicElementRoot (Element theResource){ throw new NotImplementedException(); }
		public static Element GetResourceFromName (string resourceName){ throw new NotImplementedException(); }
		public static string GetResourceName (Element res){ throw new NotImplementedException(); }
		public static Element GetResourceRootElement (Element theResource){ throw new NotImplementedException(); }
		public static string GetResourceState (Element theResource){ throw new NotImplementedException(); }
		public static Element GetThisResource (){ throw new NotImplementedException(); }
		public static int GetFPSLimit (){ throw new NotImplementedException(); }
		public static dynamic GetVersion (){ throw new NotImplementedException(); }
		public static bool SetFPSLimit (int fpsLimit){ throw new NotImplementedException(); }
		public static int CountPlayersInTeam (Element theTeam){ throw new NotImplementedException(); }
		public static bool GetTeamFriendlyFire (Element theTeam){ throw new NotImplementedException(); }
		public static dynamic GetPlayersInTeam (Element theTeam){ throw new NotImplementedException(); }
		public static Tuple<int, int, int> GetTeamColor (Element theTeam){ throw new NotImplementedException(); }
		public static Element GetTeamFromName (string teamName){ throw new NotImplementedException(); }
		public static string GetTeamName (Element theTeam){ throw new NotImplementedException(); }
		public static bool AddDebugHook (string hookType, dynamic callbackFunction, dynamic nameList){ throw new NotImplementedException(); }
		public static string Base64Encode (string data){ throw new NotImplementedException(); }
		public static string Base64Decode (string data){ throw new NotImplementedException(); }
		public static int BitAnd (int var1, int var2){ throw new NotImplementedException(); }
		public static int BitNot (int var){ throw new NotImplementedException(); }
		public static int BitOr (int var1, int var2){ throw new NotImplementedException(); }
		public static int BitXor (int var1, int var2){ throw new NotImplementedException(); }
		public static bool BitTest (int var1, int var2){ throw new NotImplementedException(); }
		public static int BitLRotate (int value, int n){ throw new NotImplementedException(); }
		public static int BitRRotate (int value, int n){ throw new NotImplementedException(); }
		public static int BitLShift (int value, int n){ throw new NotImplementedException(); }
		public static int BitRShift (int value, int n){ throw new NotImplementedException(); }
		public static int BitExtract (int var, int field, int width){ throw new NotImplementedException(); }
		public static int BitArShift (int value, int n){ throw new NotImplementedException(); }
		public static int BitReplace (int var, int replaceValue, int field, int width){ throw new NotImplementedException(); }
		public static bool DebugSleep (int sleep){ throw new NotImplementedException(); }
		public static string EncodeString (string algorithm, string input, dynamic options){ throw new NotImplementedException(); }
		public static string DecodeString (string algorithm, string input, dynamic options){ throw new NotImplementedException(); }
		public static Tuple<int, int, int, int> GetColorFromString (string theColor){ throw new NotImplementedException(); }
		public static dynamic FromJSON (string json){ throw new NotImplementedException(); }
		public static bool GetDevelopmentMode (){ throw new NotImplementedException(); }
		public static float GetDistanceBetweenPoints2D (float x1, float y1, float x2, float y2){ throw new NotImplementedException(); }
		public static float GetEasingValue (float fProgress, string strEasingType, float fEasingPeriod, float fEasingAmplitude, float fEasingOvershoot){ throw new NotImplementedException(); }
		public static float GetDistanceBetweenPoints3D (float x1, float y1, float z1, float x2, float y2, float z2){ throw new NotImplementedException(); }
		public static dynamic GetNetworkUsageData (){ throw new NotImplementedException(); }
		public static dynamic GetRealTime (int seconds, bool localTime){ throw new NotImplementedException(); }
		public static Tuple<dynamic, dynamic> GetPerformanceStats (string category, string options, string filter){ throw new NotImplementedException(); }
		public static int GetTickCount (){ throw new NotImplementedException(); }
		public static dynamic GetTimers (int theTime){ throw new NotImplementedException(); }
		public static Tuple<int, int, int> GetTimerDetails (Element theTimer){ throw new NotImplementedException(); }
		public static string Gettok (string text, int tokenNumber, string parameter2){ throw new NotImplementedException(); }
		public static string Inspect (dynamic var, dynamic options){ throw new NotImplementedException(); }
		public static string Hash (string algorithm, string dataToHash){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> InterpolateBetween (float x1, float y1, float z1, float x2, float y2, float z2, float fProgress, string strEasingType, float fEasingPeriod, float fEasingAmplitude, float fEasingOvershoot){ throw new NotImplementedException(); }
		public static string GetUserdataType (Element value){ throw new NotImplementedException(); }
		public static bool Iprint (dynamic var1, dynamic var2, dynamic var3){ throw new NotImplementedException(); }
		public static bool IsOOPEnabled (){ throw new NotImplementedException(); }
		public static bool IsTimer (Element theTimer){ throw new NotImplementedException(); }
		public static bool KillTimer (Element theTimer){ throw new NotImplementedException(); }
		public static string Md5 (string str){ throw new NotImplementedException(); }
		public static string PasswordHash (string password, string algorithm, dynamic options, dynamic callback){ throw new NotImplementedException(); }
		public static bool PasswordVerify (string password, string hash, dynamic options, dynamic callback){ throw new NotImplementedException(); }
		public static bool PregFind (string subject, string pattern, dynamic flags){ throw new NotImplementedException(); }
		public static bool RemoveDebugHook (string hookType, dynamic callbackFunction){ throw new NotImplementedException(); }
		public static string PregReplace (string subject, string pattern, string replacement, dynamic flags){ throw new NotImplementedException(); }
		public static dynamic PregMatch (string argument_base, string pattern, dynamic flags, int maxResults){ throw new NotImplementedException(); }
		public static bool ResetTimer (Element theTimer){ throw new NotImplementedException(); }
		public static bool SetDevelopmentMode (bool enable, bool enableWeb){ throw new NotImplementedException(); }
		public static Element SetTimer (dynamic theFunction, int timeInterval, int timesToExecute, dynamic arguments){ throw new NotImplementedException(); }
		public static dynamic Split (string stringToSplit, string parameter1){ throw new NotImplementedException(); }
		public static int Tocolor (int red, int green, int blue, int alpha){ throw new NotImplementedException(); }
		public static string Sha256 (string str){ throw new NotImplementedException(); }
		public static string TeaDecode (string data, string key){ throw new NotImplementedException(); }
		public static string TeaEncode (string text, string key){ throw new NotImplementedException(); }
		public static string UtfChar (int characterCode){ throw new NotImplementedException(); }
		public static string ToJSON (dynamic value, bool compact, string prettyType){ throw new NotImplementedException(); }
		public static int UtfCode (string theString){ throw new NotImplementedException(); }
		public static int UtfLen (string theString){ throw new NotImplementedException(); }
		public static int UtfSeek (string theString, int position){ throw new NotImplementedException(); }
		public static string UtfSub (string theString, int Start, int End){ throw new NotImplementedException(); }
		public static dynamic Utf8_byte (string input, int i, int j){ throw new NotImplementedException(); }
		public static string Utf8_char (int codepoints){ throw new NotImplementedException(); }
		public static Tuple<int, int> Utf8_charpos (string input, int charpos, int offset){ throw new NotImplementedException(); }
		public static string Utf8_escape (string input){ throw new NotImplementedException(); }
		public static dynamic Utf8_fold (dynamic input){ throw new NotImplementedException(); }
		public static string Utf8_find (string input, string pattern, int startpos, bool plain){ throw new NotImplementedException(); }
		public static dynamic Utf8_gmatch (string input, string pattern){ throw new NotImplementedException(); }
		public static int Utf8_len (string input, int i, int j){ throw new NotImplementedException(); }
		public static string Utf8_insert (string input, int insert_pos){ throw new NotImplementedException(); }
		public static string Utf8_gsub (string input, string pattern, dynamic replace, int match_limit){ throw new NotImplementedException(); }
		public static int Utf8_ncasecmp (string a, string b){ throw new NotImplementedException(); }
		public static dynamic Utf8_match (string input, string pattern, int index){ throw new NotImplementedException(); }
		public static Tuple<int, int> Utf8_next (string input, int charpos, int offset){ throw new NotImplementedException(); }
		public static string Utf8_reverse (string input){ throw new NotImplementedException(); }
		public static string Utf8_remove (string input, int start, int stop){ throw new NotImplementedException(); }
		public static string Utf8_sub (string input, int i, int j){ throw new NotImplementedException(); }
		public static string Utf8_title (dynamic input){ throw new NotImplementedException(); }
		public static int Utf8_width (dynamic input, bool ambi_is_double, int default_width){ throw new NotImplementedException(); }
		public static Tuple<int, int, int> Utf8_widthindex (string input, int location, bool ambi_is_double, int default_width){ throw new NotImplementedException(); }
		public static bool AddVehicleUpgrade (Element theVehicle, int upgrade){ throw new NotImplementedException(); }
		public static bool AttachTrailerToVehicle (Element theVehicle, Element theTrailer){ throw new NotImplementedException(); }
		public static bool DetachTrailerFromVehicle (Element theVehicle, Element theTrailer){ throw new NotImplementedException(); }
		public static Element CreateVehicle (int model, float x, float y, float z, float rx, float ry, float rz, string numberplate, bool bDirection, int variant1, int variant2){ throw new NotImplementedException(); }
		public static bool FixVehicle (Element theVehicle){ throw new NotImplementedException(); }
		public static dynamic GetOriginalHandling (int modelID){ throw new NotImplementedException(); }
		public static bool GetTrainDirection (Element train){ throw new NotImplementedException(); }
		public static float GetTrainPosition (Element train){ throw new NotImplementedException(); }
		public static float GetTrainSpeed (Element train){ throw new NotImplementedException(); }
		public static int GetTrainTrack (Element train){ throw new NotImplementedException(); }
		public static int GetVehicleDoorState (Element theVehicle, int door){ throw new NotImplementedException(); }
		public static Element GetVehicleController (Element theVehicle){ throw new NotImplementedException(); }
		public static float GetVehicleDoorOpenRatio (Element theVehicle, int door){ throw new NotImplementedException(); }
		public static Tuple<int, int, int, int> GetVehicleColor (Element theVehicle){ throw new NotImplementedException(); }
		public static dynamic GetVehicleCompatibleUpgrades (Element theVehicle, int slot){ throw new NotImplementedException(); }
		public static Tuple<int, int, int> GetVehicleHeadLightColor (Element theVehicle){ throw new NotImplementedException(); }
		public static bool GetVehicleEngineState (Element theVehicle){ throw new NotImplementedException(); }
		public static dynamic GetVehicleHandling (Element theVehicle){ throw new NotImplementedException(); }
		public static bool GetVehicleLandingGearDown (Element theVehicle){ throw new NotImplementedException(); }
		public static int GetVehicleLightState (Element theVehicle, int light){ throw new NotImplementedException(); }
		public static int GetVehicleMaxPassengers (Element theVehicle){ throw new NotImplementedException(); }
		public static string GetVehicleName (Element theVehicle){ throw new NotImplementedException(); }
		public static int GetVehicleModelFromName (string name){ throw new NotImplementedException(); }
		public static string GetVehicleNameFromModel (int model){ throw new NotImplementedException(); }
		public static Element GetVehicleOccupant (Element theVehicle, int seat){ throw new NotImplementedException(); }
		public static int GetVehicleOverrideLights (Element theVehicle){ throw new NotImplementedException(); }
		public static dynamic GetVehicleOccupants (Element theVehicle){ throw new NotImplementedException(); }
		public static int GetVehiclePaintjob (Element theVehicle){ throw new NotImplementedException(); }
		public static string GetVehiclePlateText (Element theVehicle){ throw new NotImplementedException(); }
		public static int GetVehiclePanelState (Element theVehicle, int panel){ throw new NotImplementedException(); }
		public static dynamic GetVehicleSirenParams (Element theVehicle){ throw new NotImplementedException(); }
		public static dynamic GetVehicleSirens (Element theVehicle){ throw new NotImplementedException(); }
		public static bool GetVehicleSirensOn (Element theVehicle){ throw new NotImplementedException(); }
		public static Element GetVehicleTowingVehicle (Element theVehicle){ throw new NotImplementedException(); }
		public static Element GetVehicleTowedByVehicle (Element theVehicle){ throw new NotImplementedException(); }
		public static Tuple<float, float> GetVehicleTurretPosition (Element turretVehicle){ throw new NotImplementedException(); }
		public static string GetVehicleType (Element theVehicle){ throw new NotImplementedException(); }
		public static int GetVehicleUpgradeOnSlot (Element theVehicle, int slot){ throw new NotImplementedException(); }
		public static dynamic GetVehicleUpgrades (Element theVehicle){ throw new NotImplementedException(); }
		public static string GetVehicleUpgradeSlotName (int slot){ throw new NotImplementedException(); }
		public static Tuple<int, int, int, int> GetVehicleWheelStates (Element theVehicle){ throw new NotImplementedException(); }
		public static Tuple<int, int> GetVehicleVariant (Element theVehicle){ throw new NotImplementedException(); }
		public static bool IsTrainDerailed (Element vehicleToCheck){ throw new NotImplementedException(); }
		public static bool IsTrainDerailable (Element vehicleToCheck){ throw new NotImplementedException(); }
		public static bool IsVehicleBlown (Element theVehicle){ throw new NotImplementedException(); }
		public static bool IsVehicleDamageProof (Element theVehicle){ throw new NotImplementedException(); }
		public static bool IsVehicleLocked (Element theVehicle){ throw new NotImplementedException(); }
		public static bool IsVehicleFuelTankExplodable (Element theVehicle){ throw new NotImplementedException(); }
		public static bool IsVehicleTaxiLightOn (Element taxi){ throw new NotImplementedException(); }
		public static bool IsVehicleOnGround (Element theVehicle){ throw new NotImplementedException(); }
		public static bool SetTrainDerailable (Element derailableVehicle, bool derailable){ throw new NotImplementedException(); }
		public static bool SetTrainPosition (Element train, float position){ throw new NotImplementedException(); }
		public static bool SetTrainDirection (Element train, bool clockwise){ throw new NotImplementedException(); }
		public static bool SetTrainSpeed (Element train, float speed){ throw new NotImplementedException(); }
		public static bool SetTrainTrack (Element train, int track){ throw new NotImplementedException(); }
		public static bool SetVehicleDamageProof (Element theVehicle, bool damageProof){ throw new NotImplementedException(); }
		public static bool SetTrainDerailed (Element vehicleToDerail, bool derailed){ throw new NotImplementedException(); }
		public static bool SetVehicleColor (Element theVehicle, int r1, int g1, int b1, int r2, int g2, int b2, int r3, int g3, int b3, int r4, int g4, int b4){ throw new NotImplementedException(); }
		public static bool SetVehicleDoorOpenRatio (Element theVehicle, int door, float ratio, int time){ throw new NotImplementedException(); }
		public static bool SetVehicleDoorState (Element theVehicle, int door, int state){ throw new NotImplementedException(); }
		public static bool SetVehicleEngineState (Element theVehicle, bool engineState){ throw new NotImplementedException(); }
		public static bool RemoveVehicleUpgrade (Element theVehicle, int upgrade){ throw new NotImplementedException(); }
		public static bool SetVehicleDoorsUndamageable (Element theVehicle, bool state){ throw new NotImplementedException(); }
		public static bool SetVehicleFuelTankExplodable (Element theVehicle, bool explodable){ throw new NotImplementedException(); }
		public static bool SetVehicleHeadLightColor (Element theVehicle, int red, int green, int blue){ throw new NotImplementedException(); }
		public static bool SetVehicleHandling (Element theVehicle, string property, dynamic value){ throw new NotImplementedException(); }
		public static bool SetVehicleLightState (Element theVehicle, int light, int state){ throw new NotImplementedException(); }
		public static bool SetVehicleLandingGearDown (Element theVehicle, bool gearState){ throw new NotImplementedException(); }
		public static bool SetVehicleLocked (Element theVehicle, bool locked){ throw new NotImplementedException(); }
		public static bool SetVehiclePaintjob (Element theVehicle, int value){ throw new NotImplementedException(); }
		public static bool SetVehicleOverrideLights (Element theVehicle, int value){ throw new NotImplementedException(); }
		public static bool SetVehiclePanelState (Element theVehicle, int panelID, int state){ throw new NotImplementedException(); }
		public static bool SetVehiclePlateText (Element theVehicle, string numberplate){ throw new NotImplementedException(); }
		public static bool SetVehicleSirensOn (Element theVehicle, bool sirensOn){ throw new NotImplementedException(); }
		public static bool SetVehicleTaxiLightOn (Element taxi, bool LightState){ throw new NotImplementedException(); }
		public static Element CreateWater (int x1, int y1, float z1, int x2, int y2, float z2, int x3, int y3, float z3, int x4, int y4, float z4, bool bShallow){ throw new NotImplementedException(); }
		public static bool SetVehicleTurretPosition (Element turretVehicle, float positionX, float positionY){ throw new NotImplementedException(); }
		public static Tuple<int, int, int, int> GetWaterColor (){ throw new NotImplementedException(); }
		public static Tuple<int, int, float> GetWaterVertexPosition (Element theWater, int vertexIndex){ throw new NotImplementedException(); }
		public static float GetWaveHeight (){ throw new NotImplementedException(); }
		public static bool ResetWaterColor (){ throw new NotImplementedException(); }
		public static bool SetVehicleWheelStates (Element theVehicle, int frontLeft, int rearLeft, int frontRight, int rearRight){ throw new NotImplementedException(); }
		public static bool ResetWaterLevel (){ throw new NotImplementedException(); }
		public static bool SetWaterLevel (Element theWater, float level){ throw new NotImplementedException(); }
		public static bool SetWaterColor (int red, int green, int blue, int alpha){ throw new NotImplementedException(); }
		public static bool SetWaterVertexPosition (Element theWater, int vertexIndex, int x, int y, float z){ throw new NotImplementedException(); }
		public static bool SetWaveHeight (float height){ throw new NotImplementedException(); }
		public static int GetOriginalWeaponProperty (int weaponID, string weaponSkill, string property){ throw new NotImplementedException(); }
		public static int GetSlotFromWeapon (int weaponid){ throw new NotImplementedException(); }
		public static int GetWeaponIDFromName (string name){ throw new NotImplementedException(); }
		public static string GetWeaponNameFromID (int id){ throw new NotImplementedException(); }
		public static bool SetWeaponAmmo (Element thePlayer, int weapon, int totalAmmo, int ammoInClip){ throw new NotImplementedException(); }
		public static int GetWeaponProperty (int weaponID, string weaponSkill, string property){ throw new NotImplementedException(); }
		public static bool SetVehicleSirens (Element theVehicle, int sirenPoint, float posX, float posY, float posZ, float red, float green, float blue, float alpha, float minAlpha){ throw new NotImplementedException(); }
		public static bool AreTrafficLightsLocked (){ throw new NotImplementedException(); }
		public static bool GetCloudsEnabled (){ throw new NotImplementedException(); }
		public static float GetAircraftMaxVelocity (){ throw new NotImplementedException(); }
		public static float GetFarClipDistance (){ throw new NotImplementedException(); }
		public static float GetFogDistance (){ throw new NotImplementedException(); }
		public static float GetJetpackMaxHeight (){ throw new NotImplementedException(); }
		public static float GetGravity (){ throw new NotImplementedException(); }
		public static float GetGameSpeed (){ throw new NotImplementedException(); }
		public static Tuple<int, int, int, int, int, int, int, Tuple<int, bool>> GetHeatHaze (){ throw new NotImplementedException(); }
		public static int GetMinuteDuration (){ throw new NotImplementedException(); }
		public static int GetMoonSize (){ throw new NotImplementedException(); }
		public static float GetRainLevel (){ throw new NotImplementedException(); }
		public static float GetSunSize (){ throw new NotImplementedException(); }
		public static Tuple<int, int, int, int, int, int> GetSkyGradient (){ throw new NotImplementedException(); }
		public static Tuple<int, int, int, int, int, int> GetSunColor (){ throw new NotImplementedException(); }
		public static Tuple<int, int> GetTime (){ throw new NotImplementedException(); }
		public static bool GetOcclusionsEnabled (){ throw new NotImplementedException(); }
		public static int GetTrafficLightState (){ throw new NotImplementedException(); }
		public static Tuple<int, int> GetWeather (){ throw new NotImplementedException(); }
		public static Tuple<int, int, int> GetWindVelocity (){ throw new NotImplementedException(); }
		public static string GetZoneName (float x, float y, float z, bool citiesonly){ throw new NotImplementedException(); }
		public static bool ResetFogDistance (){ throw new NotImplementedException(); }
		public static bool IsGarageOpen (int garageID){ throw new NotImplementedException(); }
		public static bool ResetFarClipDistance (){ throw new NotImplementedException(); }
		public static bool RemoveWorldModel (int modelID, float radius, float x, float y, float z, int interior){ throw new NotImplementedException(); }
		public static bool ResetMoonSize (){ throw new NotImplementedException(); }
		public static bool ResetHeatHaze (){ throw new NotImplementedException(); }
		public static bool ResetRainLevel (){ throw new NotImplementedException(); }
		public static bool ResetSkyGradient (){ throw new NotImplementedException(); }
		public static bool ResetSunColor (){ throw new NotImplementedException(); }
		public static bool ResetSunSize (){ throw new NotImplementedException(); }
		public static bool ResetWindVelocity (){ throw new NotImplementedException(); }
		public static bool RestoreAllWorldModels (){ throw new NotImplementedException(); }
		public static bool RestoreWorldModel (int modelID, float radius, float x, float y, float z, int iInterior){ throw new NotImplementedException(); }
		public static bool SetAircraftMaxVelocity (float velocity){ throw new NotImplementedException(); }
		public static bool SetCloudsEnabled (bool enabled){ throw new NotImplementedException(); }
		public static bool SetFogDistance (float distance){ throw new NotImplementedException(); }
		public static bool SetFarClipDistance (float distance){ throw new NotImplementedException(); }
		public static bool SetGameSpeed (float value){ throw new NotImplementedException(); }
		public static bool SetGravity (float level){ throw new NotImplementedException(); }
		public static bool SetHeatHaze (int intensity, int randomShift, int speedMin, int speedMax, int scanSizeX, int scanSizeY, int renderSizeX, int renderSizeY, bool bShowInside){ throw new NotImplementedException(); }
		public static bool SetGarageOpen (int garageID, bool open){ throw new NotImplementedException(); }
		public static bool SetInteriorSoundsEnabled (bool enabled){ throw new NotImplementedException(); }
		public static bool SetMinuteDuration (int milliseconds){ throw new NotImplementedException(); }
		public static bool SetOcclusionsEnabled (bool enabled){ throw new NotImplementedException(); }
		public static bool SetMoonSize (int size){ throw new NotImplementedException(); }
		public static bool SetSkyGradient (int topRed, int topGreen, int topBlue, int bottomRed, int bottomGreen, int bottomBlue){ throw new NotImplementedException(); }
		public static bool SetSunColor (int aRed, int aGreen, int aBlue, int bRed, int bGreen, int bBlue){ throw new NotImplementedException(); }
		public static bool SetRainLevel (float level){ throw new NotImplementedException(); }
		public static bool SetSunSize (int Size){ throw new NotImplementedException(); }
		public static bool SetTime (int hour, int minute){ throw new NotImplementedException(); }
		public static bool SetTrafficLightState (int state){ throw new NotImplementedException(); }
		public static bool SetTrafficLightsLocked (bool toggle){ throw new NotImplementedException(); }
		public static bool SetWeatherBlended (int weatherID){ throw new NotImplementedException(); }
		public static bool SetWeather (int weatherID){ throw new NotImplementedException(); }
		public static Element XmlCreateChild (Element parentNode, string tagName){ throw new NotImplementedException(); }
		public static Element XmlCopyFile (Element nodeToCopy, string newFilePath){ throw new NotImplementedException(); }
		public static bool SetWindVelocity (float velocityX, float velocityY, float velocityZ){ throw new NotImplementedException(); }
		public static Element XmlCreateFile (string filePath, string rootNodeName){ throw new NotImplementedException(); }
		public static bool XmlDestroyNode (Element theXMLNode){ throw new NotImplementedException(); }
		public static string XmlNodeGetAttribute (Element node, string name){ throw new NotImplementedException(); }
		public static dynamic XmlNodeGetChildren (Element parent, int index){ throw new NotImplementedException(); }
		public static Element XmlLoadFile (string filePath, bool readOnly){ throw new NotImplementedException(); }
		public static dynamic XmlNodeGetAttributes (Element node){ throw new NotImplementedException(); }
		public static bool XmlNodeSetValue (Element theXMLNode, string value, bool setCDATA){ throw new NotImplementedException(); }
		public static string XmlNodeGetValue (Element theXMLNode){ throw new NotImplementedException(); }
		public static string XmlNodeGetName (Element node){ throw new NotImplementedException(); }
		public static bool XmlNodeSetAttribute (Element node, string name, dynamic value){ throw new NotImplementedException(); }
		public static bool XmlSaveFile (Element rootNode){ throw new NotImplementedException(); }
		public static bool XmlNodeSetName (Element node, string name){ throw new NotImplementedException(); }
		public static bool XmlUnloadFile (Element node){ throw new NotImplementedException(); }
		public static Element XmlNodeGetParent (Element node){ throw new NotImplementedException(); }
		public static Element XmlFindChild (Element parent, string tagName, int index){ throw new NotImplementedException(); }
		public static int GetRadioChannel (){ throw new NotImplementedException(); }
		public static string GetRadioChannelName (int id){ throw new NotImplementedException(); }
		public static int GetSoundBPM (Element sound){ throw new NotImplementedException(); }
		public static bool GetSFXStatus (string audioContainer){ throw new NotImplementedException(); }
		public static dynamic GetSoundFFTData (Element sound, int iSamples, int iBands){ throw new NotImplementedException(); }
		public static float GetSoundLength (Element theSound){ throw new NotImplementedException(); }
		public static float GetSoundBufferLength (Element theSound){ throw new NotImplementedException(); }
		public static dynamic GetSoundEffects (Element sound){ throw new NotImplementedException(); }
		public static dynamic GetSoundMetaTags (Element sound, string format){ throw new NotImplementedException(); }
		public static Tuple<int, int> GetSoundLevelData (Element theSound){ throw new NotImplementedException(); }
		public static int GetSoundMaxDistance (Element sound){ throw new NotImplementedException(); }
		public static int GetSoundMinDistance (Element sound){ throw new NotImplementedException(); }
		public static float GetSoundPan (Element theSound){ throw new NotImplementedException(); }
		public static float GetSoundPosition (Element theSound){ throw new NotImplementedException(); }
		public static Tuple<float, float, float, bool> GetSoundProperties (Element sound){ throw new NotImplementedException(); }
		public static float GetSoundSpeed (Element theSound){ throw new NotImplementedException(); }
		public static bool IsSoundPanningEnabled (Element theSound){ throw new NotImplementedException(); }
		public static dynamic GetSoundWaveData (Element sound, int iSamples){ throw new NotImplementedException(); }
		public static bool IsSoundPaused (Element theSound){ throw new NotImplementedException(); }
		public static float GetSoundVolume (Element theSound){ throw new NotImplementedException(); }
		public static Element PlaySFX (string containerName, int bankId, int soundId, bool looped){ throw new NotImplementedException(); }
		public static Element PlaySFX3D (string containerName, int bankId, int soundId, float x, float y, float z, bool looped){ throw new NotImplementedException(); }
		public static Element PlaySound3D (string soundPath, float x, float y, float z, bool looped){ throw new NotImplementedException(); }
		public static Element PlaySound (string soundPath, bool looped, bool throttled){ throw new NotImplementedException(); }
		public static bool SetSoundEffectEnabled (Element sound, string effectName, bool bEnable){ throw new NotImplementedException(); }
		public static bool SetRadioChannel (int ID){ throw new NotImplementedException(); }
		public static bool SetSoundMaxDistance (Element sound, int distance){ throw new NotImplementedException(); }
		public static bool SetSoundMinDistance (Element sound, int distance){ throw new NotImplementedException(); }
		public static bool SetSoundPan (Element theSound, float pan){ throw new NotImplementedException(); }
		public static bool SetSoundPanningEnabled (Element sound, bool enable){ throw new NotImplementedException(); }
		public static bool SetSoundPaused (Element theSound, bool paused){ throw new NotImplementedException(); }
		public static bool SetSoundPosition (Element theSound, float pos){ throw new NotImplementedException(); }
		public static bool SetSoundVolume (Element theSound, float volume){ throw new NotImplementedException(); }
		public static bool SetSoundSpeed (Element theSound, float speed){ throw new NotImplementedException(); }
		public static bool SetSoundProperties (Element sound, float fSampleRate, float fTempo, float fPitch, bool bReverse){ throw new NotImplementedException(); }
		public static bool StopSound (Element theSound){ throw new NotImplementedException(); }
		public static bool CanBrowserNavigateForward (Element webBrowser){ throw new NotImplementedException(); }
		public static bool CanBrowserNavigateBack (Element webBrowser){ throw new NotImplementedException(); }
		public static Element CreateBrowser (int width, int height, bool isLocal, bool transparent){ throw new NotImplementedException(); }
		public static bool ExecuteBrowserJavascript (Element webBrowser, string jsCode){ throw new NotImplementedException(); }
		public static bool FocusBrowser (Element webBrowser){ throw new NotImplementedException(); }
		public static bool GetBrowserProperty (Element theBrowser, string key){ throw new NotImplementedException(); }
		public static dynamic GetBrowserSettings (){ throw new NotImplementedException(); }
		public static bool GetBrowserSource (Element webBrowser, dynamic callback){ throw new NotImplementedException(); }
		public static string GetBrowserTitle (Element webBrowser){ throw new NotImplementedException(); }
		public static bool IsBrowserFocused (Element webBrowser){ throw new NotImplementedException(); }
		public static bool InjectBrowserMouseUp (Element webBrowser, string mouseButton){ throw new NotImplementedException(); }
		public static bool InjectBrowserMouseWheel (Element webBrowser, int verticalScroll, int horizontalScroll){ throw new NotImplementedException(); }
		public static bool InjectBrowserMouseMove (Element webBrowser, int posX, int posY){ throw new NotImplementedException(); }
		public static string GetBrowserURL (Element webBrowser){ throw new NotImplementedException(); }
		public static bool InjectBrowserMouseDown (Element webBrowser, string mouseButton){ throw new NotImplementedException(); }
		public static bool IsBrowserDomainBlocked (string address, bool isURL){ throw new NotImplementedException(); }
		public static bool NavigateBrowserBack (Element webBrowser){ throw new NotImplementedException(); }
		public static bool IsBrowserLoading (Element webBrowser){ throw new NotImplementedException(); }
		public static bool LoadBrowserURL (Element webBrowser, string url, string postData, bool urlEncoded){ throw new NotImplementedException(); }
		public static bool NavigateBrowserForward (Element webBrowser){ throw new NotImplementedException(); }
		public static bool RequestBrowserDomains (dynamic pages, bool parseAsURL, dynamic callback){ throw new NotImplementedException(); }
		public static bool ReloadBrowserPage (Element webBrowser){ throw new NotImplementedException(); }
		public static bool ResizeBrowser (Element webBrowser, float width, float height){ throw new NotImplementedException(); }
		public static bool SetBrowserRenderingPaused (Element webBrowser, bool paused){ throw new NotImplementedException(); }
		public static bool SetBrowserAjaxHandler (Element webBrowser, string url, dynamic handler){ throw new NotImplementedException(); }
		public static bool SetBrowserProperty (Element theBrowser, string key, string value){ throw new NotImplementedException(); }
		public static bool SetBrowserVolume (Element webBrowser, float volume){ throw new NotImplementedException(); }
		public static bool ToggleBrowserDevTools (Element webBrowser, bool visible){ throw new NotImplementedException(); }
		public static Element GuiCreateBrowser (float x, float y, float width, float height, bool isLocal, bool isTransparent, bool isRelative, Element parent){ throw new NotImplementedException(); }
		public static Element GuiGetBrowser (Element theBrowser){ throw new NotImplementedException(); }
		public static Tuple<bool, bool> GetCameraClip (){ throw new NotImplementedException(); }
		public static Element GetCamera (){ throw new NotImplementedException(); }
		public static float GetCameraFieldOfView (string cameraMode){ throw new NotImplementedException(); }
		public static string GetCameraGoggleEffect (){ throw new NotImplementedException(); }
		public static int GetCameraShakeLevel (){ throw new NotImplementedException(); }
		public static bool SetCameraClip (bool objects, bool vehicles){ throw new NotImplementedException(); }
		public static int GetCameraViewMode (){ throw new NotImplementedException(); }
		public static bool SetCameraGoggleEffect (string goggleEffect, bool noiseEnabled){ throw new NotImplementedException(); }
		public static bool SetCameraShakeLevel (int shakeLevel){ throw new NotImplementedException(); }
		public static bool SetCameraFieldOfView (string cameraMode, float fieldOfView){ throw new NotImplementedException(); }
		public static bool SetCameraViewMode (int viewMode){ throw new NotImplementedException(); }
		public static Tuple<float, float, float, float, float> GetCursorPosition (){ throw new NotImplementedException(); }
		public static bool SetCursorAlpha (int alpha){ throw new NotImplementedException(); }
		public static bool SetCursorPosition (int cursorX, int cursorY){ throw new NotImplementedException(); }
		public static int GetCursorAlpha (){ throw new NotImplementedException(); }
		public static string DxConvertPixels (string pixels, string newFormat, int quality){ throw new NotImplementedException(); }
		public static Tuple<Element, string> DxCreateShader (string filepath, float priority, float maxDistance, bool layered, string elementTypes){ throw new NotImplementedException(); }
		public static Element DxCreateScreenSource (int width, int height){ throw new NotImplementedException(); }
		public static Element DxCreateRenderTarget (int width, int height, bool withAlpha){ throw new NotImplementedException(); }
		public static Element DxCreateFont (string filepath, int size, bool bold, string quality){ throw new NotImplementedException(); }
		public static Element DxCreateTexture (string pixels, string textureFormat, bool mipmaps, string textureEdge){ throw new NotImplementedException(); }
		public static bool DxDrawLine (int startX, int startY, int endX, int endY, int color, float width, bool postGUI){ throw new NotImplementedException(); }
		public static bool DxDrawImage (float posX, float posY, float width, float height, dynamic image, float rotation, float rotationCenterOffsetX, float rotationCenterOffsetY, int color){ throw new NotImplementedException(); }
		public static bool DxDrawCircle (float posX, float posY, float radius, float startAngle, float stopAngle, Element theColor, Element theCenterColor, int segments, int ratio, bool postGUI){ throw new NotImplementedException(); }
		public static bool DxDrawImageSection (float posX, float posY, float width, float height, float u, float v, float usize, float vsize, dynamic image, float rotation, float rotationCenterOffsetX, float rotationCenterOffsetY, int color, bool postGUI){ throw new NotImplementedException(); }
		public static bool DxDrawMaterialSectionLine3D (float startX, float startY, float startZ, float endX, float endY, float endZ, float u, float v, float usize, float vsize, Element material, int width, int color, bool postGUI, float faceTowardX, float faceTowardY, float faceTowardZ){ throw new NotImplementedException(); }
		public static bool DxDrawLine3D (float startX, float startY, float startZ, float endX, float endY, float endZ, int color, float width, bool postGUI){ throw new NotImplementedException(); }
		public static bool DxDrawPrimitive (string pType, bool postGUI, dynamic vertice1, dynamic vertice2){ throw new NotImplementedException(); }
		public static bool DxDrawMaterialPrimitive (Element pType, dynamic material, bool postGUI, dynamic vertice1, dynamic vertice2){ throw new NotImplementedException(); }
		public static bool DxDrawMaterialLine3D (float startX, float startY, float startZ, float endX, float endY, float endZ, Element material, float width, int color, bool postGUI, float faceTowardX, float faceTowardY, float faceTowardZ){ throw new NotImplementedException(); }
		public static bool DxDrawText (string text, float left, float top, float right, float bottom, int color, float scaleXY, float scaleY, dynamic font, string alignX, string alignY, bool clip, bool wordBreak, bool postGUI, bool colorCoded, bool subPixelPositioning, float fRotation, float fRotationCenterX, float fRotationCenterY){ throw new NotImplementedException(); }
		public static int DxGetFontHeight (float scale, dynamic font){ throw new NotImplementedException(); }
		public static string DxGetBlendMode (){ throw new NotImplementedException(); }
		public static Tuple<int, int, int, int> DxGetPixelColor (string pixels, int x, int y){ throw new NotImplementedException(); }
		public static bool DxDrawRectangle (float startX, float startY, float width, float height, int color, bool postGUI, bool subPixelPositioning){ throw new NotImplementedException(); }
		public static Tuple<int, int, dynamic, dynamic> DxGetMaterialSize (Element material){ throw new NotImplementedException(); }
		public static string DxGetPixelsFormat (string pixels){ throw new NotImplementedException(); }
		public static bool DxSetAspectRatioAdjustmentEnabled (bool bEnabled, float sourceRatio){ throw new NotImplementedException(); }
		public static dynamic DxGetStatus (){ throw new NotImplementedException(); }
		public static bool DxSetBlendMode (string blendMode){ throw new NotImplementedException(); }
		public static string DxGetTexturePixels (int surfaceIndex, Element texture, int x, int y, int width, int height){ throw new NotImplementedException(); }
		public static float DxGetTextWidth (string text, float scale, dynamic font, bool bColorCoded){ throw new NotImplementedException(); }
		public static bool DxSetShaderValue (Element theShader, string parameterName, dynamic value){ throw new NotImplementedException(); }
		public static bool DxSetPixelColor (string pixels, int x, int y, int r, int g, int b, int a){ throw new NotImplementedException(); }
		public static bool DxSetRenderTarget (Element renderTarget, bool clear){ throw new NotImplementedException(); }
		public static bool DxSetShaderTessellation (Element theShader, int tessellationX, int tessellationY){ throw new NotImplementedException(); }
		public static bool DxSetShaderTransform (Element theShader, float rotationX, float rotationY, float rotationZ, float rotationCenterOffsetX, float rotationCenterOffsetY, float rotationCenterOffsetZ, bool bRotationCenterOffsetOriginIsScreen, float perspectiveCenterOffsetX, float perspectiveCenterOffsetY, bool bPerspectiveCenterOffsetOriginIsScreen){ throw new NotImplementedException(); }
		public static bool DxSetTexturePixels (int surfaceIndex, Element texture, string pixels, int x, int y, int width, int height){ throw new NotImplementedException(); }
		public static bool DxSetTextureEdge (Element theTexture, string textureEdge, int border){ throw new NotImplementedException(); }
		public static bool DxSetTestMode (string testMode){ throw new NotImplementedException(); }
		public static bool DxUpdateScreenSource (Element screenSource, bool resampleNow){ throw new NotImplementedException(); }
		public static Element CreateEffect (string name, float x, float y, float z, float rX, float rY, float rZ, float drawDistance, bool soundEnable){ throw new NotImplementedException(); }
		public static bool FxAddBlood (float posX, float posY, float posZ, float dirX, float dirY, float dirZ, int count, float brightness){ throw new NotImplementedException(); }
		public static bool FxAddBulletImpact (float posX, float posY, float posZ, float dirX, float dirY, float dirZ, int smokeSize, int sparkCount, float smokeIntensity){ throw new NotImplementedException(); }
		public static bool FxAddBulletSplash (float posX, float posY, float posZ){ throw new NotImplementedException(); }
		public static bool FxAddDebris (float posX, float posY, float posZ, int colorR, int colorG, int colorB, int colorA, float scale, int count){ throw new NotImplementedException(); }
		public static bool FxAddFootSplash (float posX, float posY, float posZ){ throw new NotImplementedException(); }
		public static bool FxAddPunchImpact (float posX, float posY, float posZ, float dirX, float dirY, float dirZ){ throw new NotImplementedException(); }
		public static bool FxAddGunshot (float posX, float posY, float posZ, float dirX, float dirY, float dirZ, bool includeSparks){ throw new NotImplementedException(); }
		public static bool FxAddGlass (float posX, float posY, float posZ, int colorR, int colorG, int colorB, int colorA, float scale, int count){ throw new NotImplementedException(); }
		public static bool FxAddTankFire (float posX, float posY, float posZ, float dirX, float dirY, float dirZ){ throw new NotImplementedException(); }
		public static bool FxAddSparks (float posX, float posY, float posZ, float dirX, float dirY, float dirZ, float force, int count, float acrossLineX, float acrossLineY, float acrossLineZ, bool blur, float spread, float life){ throw new NotImplementedException(); }
		public static bool FxAddTyreBurst (float posX, float posY, float posZ, float dirX, float dirY, float dirZ){ throw new NotImplementedException(); }
		public static bool FxAddWaterSplash (float posX, float posY, float posZ){ throw new NotImplementedException(); }
		public static bool FxAddWaterHydrant (float posX, float posY, float posZ){ throw new NotImplementedException(); }
		public static bool FxAddWood (float posX, float posY, float posZ, float dirX, float dirY, float dirZ, int count, float brightness){ throw new NotImplementedException(); }
		public static float GetEffectDensity (Element theEffect){ throw new NotImplementedException(); }
		public static float GetEffectSpeed (Element theEffect){ throw new NotImplementedException(); }
		public static bool SetEffectSpeed (Element theEffect, float speed){ throw new NotImplementedException(); }
		public static bool SetEffectDensity (Element theEffect, float density){ throw new NotImplementedException(); }
		public static Tuple<float, float, float, float, float, float> GetElementBoundingBox (Element theElement){ throw new NotImplementedException(); }
		public static float GetElementDistanceFromCentreOfMassToBaseOfModel (Element theElement){ throw new NotImplementedException(); }
		public static float GetElementRadius (Element theElement){ throw new NotImplementedException(); }
		public static dynamic GetElementsWithinRange (float x, float y, float z, float range, string elemType){ throw new NotImplementedException(); }
		public static bool IsElementCollidableWith (Element theElement, Element withElement){ throw new NotImplementedException(); }
		public static bool IsElementLocal (Element theElement){ throw new NotImplementedException(); }
		public static bool IsElementStreamable (Element theElement){ throw new NotImplementedException(); }
		public static bool IsElementOnScreen (Element theElement){ throw new NotImplementedException(); }
		public static bool IsElementStreamedIn (Element theElement){ throw new NotImplementedException(); }
		public static bool IsElementWaitingForGroundToLoad (Element theElement){ throw new NotImplementedException(); }
		public static bool IsElementSyncer (Element theElement){ throw new NotImplementedException(); }
		public static bool SetElementCollidableWith (Element theElement, Element withElement, bool enabled){ throw new NotImplementedException(); }
		public static bool SetElementMatrix (Element theElement, dynamic theMatrix){ throw new NotImplementedException(); }
		public static bool EngineApplyShaderToWorldTexture (Element shader, string textureName, Element targetElement, bool appendLayers){ throw new NotImplementedException(); }
		public static bool SetElementStreamable (Element theElement, bool streamable){ throw new NotImplementedException(); }
		public static int EngineGetModelIDFromName (string modelName){ throw new NotImplementedException(); }
		public static float EngineGetModelLODDistance (int model){ throw new NotImplementedException(); }
		public static string EngineGetModelNameFromID (int modelID){ throw new NotImplementedException(); }
		public static dynamic EngineGetModelTextureNames (string modelId){ throw new NotImplementedException(); }
		public static dynamic EngineGetVisibleTextureNames (string nameFilter, string modelId){ throw new NotImplementedException(); }
		public static bool EngineImportTXD (Element texture, int model_id){ throw new NotImplementedException(); }
		public static Element EngineLoadDFF (string dff_file){ throw new NotImplementedException(); }
		public static Element EngineLoadCOL (string col_file){ throw new NotImplementedException(); }
		public static Element EngineLoadIFP (string ifp_file, string CustomBlockName){ throw new NotImplementedException(); }
		public static Element EngineLoadTXD (string txd_file, bool filteringEnabled){ throw new NotImplementedException(); }
		public static bool EngineReplaceAnimation (Element thePed, string InternalBlockName, string InternalAnimName, string CustomBlockName, string CustomAnimName){ throw new NotImplementedException(); }
		public static bool EngineRemoveShaderFromWorldTexture (Element shader, string textureName, Element targetElement){ throw new NotImplementedException(); }
		public static bool EngineRestoreAnimation (Element thePed, string InternalBlockName, string InternalAnimName){ throw new NotImplementedException(); }
		public static bool EngineReplaceModel (Element theModel, int modelID, bool alphaTransparency){ throw new NotImplementedException(); }
		public static bool EngineReplaceCOL (Element theCol, int modelID){ throw new NotImplementedException(); }
		public static bool EngineRestoreCOL (int modelID){ throw new NotImplementedException(); }
		public static dynamic EngineResetSurfaceProperties (int surfaceID){ throw new NotImplementedException(); }
		public static bool EngineRestoreModel (int modelID){ throw new NotImplementedException(); }
		public static bool EngineSetSurfaceProperties (int surfaceID, string property, dynamic value){ throw new NotImplementedException(); }
		public static bool EngineSetAsynchronousLoading (bool enable, bool force){ throw new NotImplementedException(); }
		public static bool EngineSetModelLODDistance (int model, float distance){ throw new NotImplementedException(); }
		public static dynamic EngineGetSurfaceProperties (int surfaceID, string property){ throw new NotImplementedException(); }
		public static bool TriggerLatentServerEvent (string argument_event, int bandwidth, bool persist, Element theElement){ throw new NotImplementedException(); }
		public static bool TriggerServerEvent (string argument_event, Element theElement){ throw new NotImplementedException(); }
		public static bool ExtinguishFire (float x, float y, float z, float radius){ throw new NotImplementedException(); }
		public static bool CreateFire (float x, float y, float z, float size){ throw new NotImplementedException(); }
		public static bool GuiBringToFront (Element guiElement){ throw new NotImplementedException(); }
		public static Element GuiCreateFont (string filepath, int size){ throw new NotImplementedException(); }
		public static dynamic GetChatboxLayout (string CVar){ throw new NotImplementedException(); }
		public static bool GuiBlur (Element guiElement){ throw new NotImplementedException(); }
		public static bool GuiGetInputEnabled (){ throw new NotImplementedException(); }
		public static string GuiGetInputMode (){ throw new NotImplementedException(); }
		public static bool GuiFocus (Element guiElement){ throw new NotImplementedException(); }
		public static string GuiGetCursorType (){ throw new NotImplementedException(); }
		public static Tuple<string, Element> GuiGetFont (Element guiElement){ throw new NotImplementedException(); }
		public static float GuiGetAlpha (Element guiElement){ throw new NotImplementedException(); }
		public static bool GuiGetEnabled (Element guiElement){ throw new NotImplementedException(); }
		public static dynamic GuiGetProperties (Element guiElement){ throw new NotImplementedException(); }
		public static Tuple<float, float> GuiGetScreenSize (){ throw new NotImplementedException(); }
		public static string GuiGetProperty (Element guiElement, string property){ throw new NotImplementedException(); }
		public static Tuple<float, float> GuiGetPosition (Element guiElement, bool relative){ throw new NotImplementedException(); }
		public static Tuple<float, float> GuiGetSize (Element theElement, bool relative){ throw new NotImplementedException(); }
		public static bool GuiSetAlpha (Element guielement, float alpha){ throw new NotImplementedException(); }
		public static bool GuiMoveToBack (Element guiElement){ throw new NotImplementedException(); }
		public static string GuiGetText (Element guiElement){ throw new NotImplementedException(); }
		public static bool GuiSetEnabled (Element guiElement, bool enabled){ throw new NotImplementedException(); }
		public static bool GuiSetFont (Element guiElement, dynamic font){ throw new NotImplementedException(); }
		public static bool GuiGetVisible (Element guiElement){ throw new NotImplementedException(); }
		public static bool GuiSetInputEnabled (bool enabled){ throw new NotImplementedException(); }
		public static bool GuiSetPosition (Element theElement, float x, float y, bool relative){ throw new NotImplementedException(); }
		public static bool GuiSetProperty (Element guiElement, string property, string value){ throw new NotImplementedException(); }
		public static bool GuiSetSize (Element guiElement, float width, float height, bool relative){ throw new NotImplementedException(); }
		public static bool GuiSetVisible (Element guiElement, bool state){ throw new NotImplementedException(); }
		public static bool GuiSetText (Element guiElement, string text){ throw new NotImplementedException(); }
		public static bool GuiSetInputMode (string mode){ throw new NotImplementedException(); }
		public static bool IsChatBoxInputActive (){ throw new NotImplementedException(); }
		public static bool IsConsoleActive (){ throw new NotImplementedException(); }
		public static bool IsDebugViewActive (){ throw new NotImplementedException(); }
		public static bool IsMainMenuActive (){ throw new NotImplementedException(); }
		public static bool IsMTAWindowActive (){ throw new NotImplementedException(); }
		public static bool IsTransferBoxActive (){ throw new NotImplementedException(); }
		public static bool SetDebugViewActive (bool enabled){ throw new NotImplementedException(); }
		public static Element GuiCreateButton (float x, float y, float width, float height, string text, bool relative, Element parent){ throw new NotImplementedException(); }
		public static bool GuiCheckBoxGetSelected (Element theCheckbox){ throw new NotImplementedException(); }
		public static int GuiComboBoxAddItem (Element comboBox, string value){ throw new NotImplementedException(); }
		public static string GuiComboBoxGetItemText (Element comboBox, int itemId){ throw new NotImplementedException(); }
		public static bool GuiComboBoxClear (Element comboBox){ throw new NotImplementedException(); }
		public static bool GuiCheckBoxSetSelected (Element theCheckbox, bool state){ throw new NotImplementedException(); }
		public static Element GuiCreateComboBox (float x, float y, float width, float height, string caption, bool relative, Element parent){ throw new NotImplementedException(); }
		public static int GuiComboBoxGetSelected (Element comboBox){ throw new NotImplementedException(); }
		public static int GuiComboBoxGetItemCount (Element comboBox){ throw new NotImplementedException(); }
		public static bool GuiComboBoxIsOpen (Element comboBox){ throw new NotImplementedException(); }
		public static bool GuiComboBoxRemoveItem (Element comboBox, int itemId){ throw new NotImplementedException(); }
		public static bool GuiComboBoxSetItemText (Element comboBox, int itemId, string text){ throw new NotImplementedException(); }
		public static bool GuiComboBoxSetSelected (Element comboBox, int itemIndex){ throw new NotImplementedException(); }
		public static bool GuiComboBoxSetOpen (Element comboBox, bool state){ throw new NotImplementedException(); }
		public static Element GuiCreateCheckBox (float x, float y, float width, float height, string text, bool selected, bool relative, Element parent){ throw new NotImplementedException(); }
		public static bool GuiEditIsMasked (Element guiEdit){ throw new NotImplementedException(); }
		public static int GuiEditGetMaxLength (Element guiEdit){ throw new NotImplementedException(); }
		public static bool GuiEditSetCaretIndex (Element theElement, int index){ throw new NotImplementedException(); }
		public static Element GuiCreateEdit (float x, float y, float width, float height, string text, bool relative, Element parent){ throw new NotImplementedException(); }
		public static bool GuiEditIsReadOnly (Element guiEdit){ throw new NotImplementedException(); }
		public static int GuiEditGetCaretIndex (Element theElement){ throw new NotImplementedException(); }
		public static bool GuiEditSetMaxLength (Element guiEdit, int length){ throw new NotImplementedException(); }
		public static bool GuiEditSetMasked (Element theElement, bool status){ throw new NotImplementedException(); }
		public static bool GuiEditSetReadOnly (Element editField, bool status){ throw new NotImplementedException(); }
		public static int GuiGridListAddColumn (Element gridList, string title, float width){ throw new NotImplementedException(); }
		public static Element GuiCreateGridList (float x, float y, float width, float height, bool relative, Element parent){ throw new NotImplementedException(); }
		public static int GuiGridListAddRow (Element gridList, dynamic itemText1, dynamic itemText2){ throw new NotImplementedException(); }
		public static bool GuiGridListClear (Element gridList){ throw new NotImplementedException(); }
		public static bool GuiGridListAutoSizeColumn (Element gridList, int columnIndex){ throw new NotImplementedException(); }
		public static string GuiGridListGetColumnTitle (Element guiGridlist, int columnIndex){ throw new NotImplementedException(); }
		public static int GuiGridListGetColumnCount (Element gridList){ throw new NotImplementedException(); }
		public static float GuiGridListGetHorizontalScrollPosition (Element guiGridlist){ throw new NotImplementedException(); }
		public static bool GuiGridListGetColumnWidth (Element gridList, int columnIndex, bool relative){ throw new NotImplementedException(); }
		public static Tuple<int, int, int, int> GuiGridListGetItemColor (Element gridList, int rowIndex, int columnIndex){ throw new NotImplementedException(); }
		public static dynamic GuiGridListGetItemData (Element gridList, int rowIndex, int columnIndex){ throw new NotImplementedException(); }
		public static string GuiGridListGetItemText (Element gridList, int rowIndex, int columnIndex){ throw new NotImplementedException(); }
		public static int GuiGridListGetRowCount (Element gridList){ throw new NotImplementedException(); }
		public static int GuiGridListGetSelectedCount (Element gridList){ throw new NotImplementedException(); }
		public static Tuple<int, int> GuiGridListGetSelectedItem (Element gridList){ throw new NotImplementedException(); }
		public static dynamic GuiGridListGetSelectedItems (Element gridList){ throw new NotImplementedException(); }
		public static int GuiGridListInsertRowAfter (Element gridList, int rowIndex){ throw new NotImplementedException(); }
		public static bool GuiGridListRemoveColumn (Element gridList, int columnIndex){ throw new NotImplementedException(); }
		public static float GuiGridListGetVerticalScrollPosition (Element guiGridlist){ throw new NotImplementedException(); }
		public static bool GuiGridListRemoveRow (Element gridList, int rowIndex){ throw new NotImplementedException(); }
		public static bool GuiGridListSetColumnWidth (Element gridList, int columnIndex, float width, bool relative){ throw new NotImplementedException(); }
		public static bool GuiGridListSetColumnTitle (Element guiGridlist, int columnIndex, string title){ throw new NotImplementedException(); }
		public static bool GuiGridListSetHorizontalScrollPosition (Element guiGridlist, float fPosition){ throw new NotImplementedException(); }
		public static bool GuiGridListSetItemText (Element gridList, int rowIndex, int columnIndex, string text, bool section, bool number){ throw new NotImplementedException(); }
		public static bool GuiGridListSetItemColor (Element gridList, int rowIndex, int columnIndex, int red, int green, int blue, int alpha){ throw new NotImplementedException(); }
		public static bool GuiGridListSetScrollBars (Element guiGridlist, bool horizontalBar, bool verticalBar){ throw new NotImplementedException(); }
		public static bool GuiGridListSetSelectedItem (Element gridList, int rowIndex, int columnIndex, bool bReset){ throw new NotImplementedException(); }
		public static bool GuiGridListSetItemData (Element gridList, int rowIndex, int columnIndex, dynamic data){ throw new NotImplementedException(); }
		public static bool GuiGridListSetSortingEnabled (Element guiGridlist, bool enabled){ throw new NotImplementedException(); }
		public static bool GuiGridListSetVerticalScrollPosition (Element guiGridlist, float fPosition){ throw new NotImplementedException(); }
		public static bool GuiGridListSetSelectionMode (Element gridlist, int mode){ throw new NotImplementedException(); }
		public static Element GuiCreateMemo (float x, float y, float width, float height, string text, bool relative, Element parent){ throw new NotImplementedException(); }
		public static float GuiMemoGetVerticalScrollPosition (Element theMemo){ throw new NotImplementedException(); }
		public static int GuiMemoGetCaretIndex (Element theElement){ throw new NotImplementedException(); }
		public static bool GuiMemoSetCaretIndex (Element theMemo, int index){ throw new NotImplementedException(); }
		public static bool GuiMemoSetVerticalScrollPosition (Element theMemo, float position){ throw new NotImplementedException(); }
		public static bool GuiMemoSetReadOnly (Element theMemo, bool status){ throw new NotImplementedException(); }
		public static float GuiProgressBarGetProgress (Element theProgressbar){ throw new NotImplementedException(); }
		public static Element GuiCreateProgressBar (float x, float y, float width, float height, bool relative, Element parent){ throw new NotImplementedException(); }
		public static bool GuiProgressBarSetProgress (Element theProgressbar, float progress){ throw new NotImplementedException(); }
		public static bool GuiMemoIsReadOnly (Element theMemo){ throw new NotImplementedException(); }
		public static Element GuiCreateRadioButton (float x, float y, float width, float height, string text, bool relative, Element parent){ throw new NotImplementedException(); }
		public static bool GuiRadioButtonSetSelected (Element guiRadioButton, bool state){ throw new NotImplementedException(); }
		public static bool GuiRadioButtonGetSelected (Element guiRadioButton){ throw new NotImplementedException(); }
		public static Element GuiCreateScrollPane (float x, float y, float width, float height, bool relative, Element parent){ throw new NotImplementedException(); }
		public static bool GuiScrollBarSetScrollPosition (Element theScrollBar, float amount){ throw new NotImplementedException(); }
		public static Element GuiCreateScrollBar (float x, float y, float width, float height, bool horizontal, bool relative, Element parent){ throw new NotImplementedException(); }
		public static float GuiScrollPaneGetVerticalScrollPosition (Element verticalScrollPane){ throw new NotImplementedException(); }
		public static float GuiScrollBarGetScrollPosition (Element theScrollBar){ throw new NotImplementedException(); }
		public static float GuiScrollPaneGetHorizontalScrollPosition (Element horizontalScrollPane){ throw new NotImplementedException(); }
		public static Element GuiCreateStaticImage (float x, float y, float width, float height, string path, bool relative, Element parent){ throw new NotImplementedException(); }
		public static bool GuiScrollPaneSetVerticalScrollPosition (Element verticalScrollPane, float position){ throw new NotImplementedException(); }
		public static bool GuiScrollPaneSetHorizontalScrollPosition (Element horizontalScrollPane, float position){ throw new NotImplementedException(); }
		public static bool GuiSetSelectedTab (Element tabPanel, Element theTab){ throw new NotImplementedException(); }
		public static bool GuiScrollPaneSetScrollBars (Element scrollPane, bool horizontal, bool vertical){ throw new NotImplementedException(); }
		public static Element GuiCreateTabPanel (float x, float y, float width, float height, bool relative, Element parent){ throw new NotImplementedException(); }
		public static bool GuiStaticImageLoadImage (Element theElement, string filename){ throw new NotImplementedException(); }
		public static Tuple<int, int> GuiStaticImageGetNativeSize (Element theImage){ throw new NotImplementedException(); }
		public static Element GuiGetSelectedTab (Element tabPanel){ throw new NotImplementedException(); }
		public static Element GuiCreateTab (string text, Element parent){ throw new NotImplementedException(); }
		public static Tuple<int, int, int> GuiLabelGetColor (Element theLabel){ throw new NotImplementedException(); }
		public static bool GuiDeleteTab (Element tabToDelete, Element tabPanel){ throw new NotImplementedException(); }
		public static bool GuiWindowIsSizable (Element guiWindow){ throw new NotImplementedException(); }
		public static float GuiLabelGetFontHeight (Element theLabel){ throw new NotImplementedException(); }
		public static bool GuiLabelSetVerticalAlign (Element theLabel, string align){ throw new NotImplementedException(); }
		public static bool GuiWindowIsMovable (Element guiWindow){ throw new NotImplementedException(); }
		public static Element GuiCreateLabel (float x, float y, float width, float height, string text, bool relative, Element parent){ throw new NotImplementedException(); }
		public static float GetAnalogControlState (string control){ throw new NotImplementedException(); }
		public static Element GuiCreateWindow (float x, float y, float width, float height, string titleBarText, bool relative){ throw new NotImplementedException(); }
		public static bool GuiWindowSetSizable (Element theElement, bool status){ throw new NotImplementedException(); }
		public static dynamic GetCommandsBoundToKey (string theKey, string keyState){ throw new NotImplementedException(); }
		public static bool GuiLabelSetColor (Element theElement, int red, int green, int blue){ throw new NotImplementedException(); }
		public static string GetKeyBoundToCommand (string command){ throw new NotImplementedException(); }
		public static dynamic GetBoundKeys (string command){ throw new NotImplementedException(); }
		public static bool GuiWindowSetMovable (Element theElement, bool status){ throw new NotImplementedException(); }
		public static float GuiLabelGetTextExtent (Element theLabel){ throw new NotImplementedException(); }
		public static bool GuiLabelSetHorizontalAlign (Element theLabel, string align, bool wordwrap){ throw new NotImplementedException(); }
		public static bool GetKeyState (string keyName){ throw new NotImplementedException(); }
		public static Element CreateLight (int lightType, float posX, float posY, float posZ, float radius, int r, int g, int b, float dirX, float dirY, float dirZ, bool createsShadow){ throw new NotImplementedException(); }
		public static float GetLightRadius (Element theLight){ throw new NotImplementedException(); }
		public static bool SetLightColor (Element theLight, float r, float g, float b){ throw new NotImplementedException(); }
		public static Tuple<int, int, int> GetLightColor (Element theLight){ throw new NotImplementedException(); }
		public static bool SetLightDirection (Element theLight, float x, float y, float z){ throw new NotImplementedException(); }
		public static bool SetLightRadius (Element theLight, float radius){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetLightDirection (Element theLight){ throw new NotImplementedException(); }
		public static float GetObjectMass (Element theObject){ throw new NotImplementedException(); }
		public static bool BreakObject (Element theObject){ throw new NotImplementedException(); }
		public static int GetLightType (Element theLight){ throw new NotImplementedException(); }
		public static bool IsObjectBreakable (Element theObject){ throw new NotImplementedException(); }
		public static bool RespawnObject (Element theObject){ throw new NotImplementedException(); }
		public static bool SetObjectBreakable (Element theObject, bool breakable){ throw new NotImplementedException(); }
		public static bool SetObjectMass (Element theObject, float mass){ throw new NotImplementedException(); }
		public static bool ToggleObjectRespawn (Element theObject, bool respawn){ throw new NotImplementedException(); }
		public static bool SetObjectProperty (Element theObject, string property, dynamic value){ throw new NotImplementedException(); }
		public static dynamic GetObjectProperty (Element theObject, string property){ throw new NotImplementedException(); }
		public static bool IsChatVisible (){ throw new NotImplementedException(); }
		public static float GetPedAnalogControlState (Element thePed, string controlName){ throw new NotImplementedException(); }
		public static Tuple<string, string> GetPedAnimation (Element thePed){ throw new NotImplementedException(); }
		public static float GetPedCameraRotation (Element thePed){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetPedBonePosition (Element thePed, int bone){ throw new NotImplementedException(); }
		public static bool CanPedBeKnockedOffBike (Element thePed){ throw new NotImplementedException(); }
		public static bool GetPedControlState (Element thePed, string control){ throw new NotImplementedException(); }
		public static string GetPedSimplestTask (Element thePed){ throw new NotImplementedException(); }
		public static string GetPedMoveState (Element thePed){ throw new NotImplementedException(); }
		public static float GetPedOxygenLevel (Element thePed){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetPedTargetEnd (Element targetingPed){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetPedTargetCollision (Element targetingPed){ throw new NotImplementedException(); }
		public static Tuple<string, string, string, string> GetPedTask (Element thePed, string priority, int taskType){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetPedTargetStart (Element targetingPed){ throw new NotImplementedException(); }
		public static Tuple<string, string> GetPedVoice (Element thePed){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetPedWeaponMuzzlePosition (Element thePed){ throw new NotImplementedException(); }
		public static bool GivePedWeapon (Element thePed, int weapon, int ammo, bool setAsCurrent){ throw new NotImplementedException(); }
		public static bool IsPedDoingTask (Element thePed, string taskName){ throw new NotImplementedException(); }
		public static bool IsPedTargetingMarkerEnabled (){ throw new NotImplementedException(); }
		public static bool IsPedReloadingWeapon (Element thePed){ throw new NotImplementedException(); }
		public static bool SetAnalogControlState (string control, float state){ throw new NotImplementedException(); }
		public static bool SetPedAimTarget (Element thePed, float x, float y, float z){ throw new NotImplementedException(); }
		public static bool SetPedCameraRotation (Element thePed, float cameraRotation){ throw new NotImplementedException(); }
		public static bool SetPedControlState (Element thePed, string control, bool state){ throw new NotImplementedException(); }
		public static bool SetPedFootBloodEnabled (Element thePlayer, bool enabled){ throw new NotImplementedException(); }
		public static bool SetPedLookAt (Element thePed, float x, float y, float z, int time, int blend, Element target){ throw new NotImplementedException(); }
		public static bool SetPedVoice (Element thePed, string voiceType, string voiceName){ throw new NotImplementedException(); }
		public static bool SetPedTargetingMarkerEnabled (bool enabled){ throw new NotImplementedException(); }
		public static bool SetPedOxygenLevel (Element thePed, float oxygen){ throw new NotImplementedException(); }
		public static bool SetPedAnalogControlState (Element thePed, string control, float state){ throw new NotImplementedException(); }
		public static Element GetLocalPlayer (){ throw new NotImplementedException(); }
		public static Tuple<int, int, int, int> GetPlayerMapBoundingBox (){ throw new NotImplementedException(); }
		public static bool IsPlayerHudComponentVisible (string component){ throw new NotImplementedException(); }
		public static bool IsPlayerMapVisible (){ throw new NotImplementedException(); }
		public static int GetProjectileCounter (Element projectile){ throw new NotImplementedException(); }
		public static int GetProjectileType (Element theProjectile){ throw new NotImplementedException(); }
		public static Element GetProjectileCreator (Element theProjectile){ throw new NotImplementedException(); }
		public static bool SetProjectileCounter (Element projectile, int timeToDetonate){ throw new NotImplementedException(); }
		public static Element GetProjectileTarget (Element theProjectile){ throw new NotImplementedException(); }
		public static float GetProjectileForce (Element theProjectile){ throw new NotImplementedException(); }
		public static Element CreateProjectile (Element creator, int weaponType, float posX, float posY, float posZ, float force, Element target, float rotX, float rotY, float rotZ, float velX, float velY, float velZ, int model){ throw new NotImplementedException(); }
		public static bool SetPedCanBeKnockedOffBike (Element thePed, bool canBeKnockedOffBike){ throw new NotImplementedException(); }
		public static Element CreateSearchLight (float startX, float startY, float startZ, float endX, float endY, float endZ, float startRadius, float endRadius, bool renderSpot){ throw new NotImplementedException(); }
		public static Element GetResourceGUIElement (Element theResource){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetSearchLightEndPosition (Element theSearchLight){ throw new NotImplementedException(); }
		public static Element GetSearchLightEndRadius (Element theSearchLight){ throw new NotImplementedException(); }
		public static Element SetSearchLightEndPosition (Element theSearchLight, float endX, float endY, float endZ){ throw new NotImplementedException(); }
		public static Element GetSearchLightStartRadius (Element theSearchLight){ throw new NotImplementedException(); }
		public static Element GetSearchLightStartPosition (Element theSearchLight){ throw new NotImplementedException(); }
		public static Element SetSearchLightStartPosition (Element theSearchLight, float startX, float startY, float startZ){ throw new NotImplementedException(); }
		public static Element SetSearchLightStartRadius (Element theSearchlight, float startRadius){ throw new NotImplementedException(); }
		public static Element SetSearchLightEndRadius (Element theSearchlight, float endRadius){ throw new NotImplementedException(); }
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
		public static bool GetVehicleComponentVisible (Element theVehicle, string theComponent){ throw new NotImplementedException(); }
		public static dynamic GetVehicleComponents (Element theVehicle){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetVehicleComponentPosition (Element theVehicle, string theComponent, string argument_base){ throw new NotImplementedException(); }
		public static int GetVehicleCurrentGear (Element theVehicle){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetVehicleGravity (Element theVehicle){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetVehicleModelExhaustFumesPosition (int modelID){ throw new NotImplementedException(); }
		public static int GetVehicleNitroCount (Element theVehicle){ throw new NotImplementedException(); }
		public static float GetVehicleNitroLevel (Element theVehicle){ throw new NotImplementedException(); }
		public static bool IsTrainChainEngine (Element theTrain){ throw new NotImplementedException(); }
		public static bool IsVehicleWheelOnGround (Element theVehicle, dynamic wheel){ throw new NotImplementedException(); }
		public static bool IsVehicleNitroRecharging (Element theVehicle){ throw new NotImplementedException(); }
		public static bool IsVehicleNitroActivated (Element theVehicle){ throw new NotImplementedException(); }
		public static bool IsVehicleWindowOpen (Element theVehicle, int window){ throw new NotImplementedException(); }
		public static bool SetHeliBladeCollisionsEnabled (Element theVehicle, bool collisions){ throw new NotImplementedException(); }
		public static bool ResetVehicleComponentRotation (Element theVehicle, string theComponent){ throw new NotImplementedException(); }
		public static bool SetHelicopterRotorSpeed (Element heli, float speed){ throw new NotImplementedException(); }
		public static bool SetVehicleAdjustableProperty (Element theVehicle, int value){ throw new NotImplementedException(); }
		public static bool SetVehicleComponentRotation (Element theVehicle, string theComponent, float rotX, float rotY, float rotZ, string argument_base){ throw new NotImplementedException(); }
		public static bool SetVehicleComponentVisible (Element theVehicle, string theComponent, bool visible){ throw new NotImplementedException(); }
		public static bool SetVehicleComponentPosition (Element theVehicle, string theComponent, float posX, float posY, float posZ, string argument_base){ throw new NotImplementedException(); }
		public static bool SetVehicleDirtLevel (Element theVehicle, int dirtLevel){ throw new NotImplementedException(); }
		public static bool ResetVehicleComponentPosition (Element theVehicle, string theComponent){ throw new NotImplementedException(); }
		public static bool SetVehicleGravity (Element theVehicle, float x, float y, float z){ throw new NotImplementedException(); }
		public static bool SetVehicleModelExhaustFumesPosition (int modelID, float posX, float posY, float posZ){ throw new NotImplementedException(); }
		public static bool SetVehicleNitroActivated (Element theVehicle, bool state){ throw new NotImplementedException(); }
		public static bool SetVehicleNitroCount (Element theVehicle, int count){ throw new NotImplementedException(); }
		public static bool SetVehicleNitroLevel (Element theVehicle, float level){ throw new NotImplementedException(); }
		public static bool SetVehicleWindowOpen (Element theVehicle, int window, bool open){ throw new NotImplementedException(); }
		public static float GetWaterLevel (float posX, float posY, float posZ, bool bCheckWaves){ throw new NotImplementedException(); }
		public static bool IsWaterDrawnLast (){ throw new NotImplementedException(); }
		public static bool SetWaterDrawnLast (bool bEnabled){ throw new NotImplementedException(); }
		public static Element CreateWeapon (string theType, float x, float y, float z){ throw new NotImplementedException(); }
		public static bool FireWeapon (Element theWeapon){ throw new NotImplementedException(); }
		public static int GetWeaponAmmo (Element theWeapon){ throw new NotImplementedException(); }
		public static int GetWeaponFiringRate (Element theWeapon){ throw new NotImplementedException(); }
		public static bool GetWeaponOwner (Element theWeapon){ throw new NotImplementedException(); }
		public static bool GetWeaponFlags (Element theWeapon, string theFlag){ throw new NotImplementedException(); }
		public static string GetWeaponState (Element theWeapon){ throw new NotImplementedException(); }
		public static int GetWeaponClipAmmo (Element theWeapon){ throw new NotImplementedException(); }
		public static bool ResetWeaponFiringRate (Element theWeapon){ throw new NotImplementedException(); }
		public static bool SetWeaponFiringRate (Element theWeapon, int firingRate){ throw new NotImplementedException(); }
		public static dynamic GetWeaponTarget (Element theWeapon){ throw new NotImplementedException(); }
		public static bool SetWeaponFlags (Element theWeapon, string theFlag, bool enable){ throw new NotImplementedException(); }
		public static bool SetWeaponClipAmmo (Element theWeapon, int clipAmmo){ throw new NotImplementedException(); }
		public static bool SetWeaponState (Element theWeapon, string theState){ throw new NotImplementedException(); }
		public static bool CreateSWATRope (float fx, float fy, float fZ, int duration){ throw new NotImplementedException(); }
		public static float GetAircraftMaxHeight (){ throw new NotImplementedException(); }
		public static bool GetBirdsEnabled (){ throw new NotImplementedException(); }
		public static Tuple<float, float, float, float> GetGarageBoundingBox (int garageID){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetGaragePosition (int garageID){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetGarageSize (int garageID){ throw new NotImplementedException(); }
		public static bool GetInteriorSoundsEnabled (){ throw new NotImplementedException(); }
		public static bool GetInteriorFurnitureEnabled (int roomID){ throw new NotImplementedException(); }
		public static float GetGroundPosition (float x, float y, float z){ throw new NotImplementedException(); }
		public static float GetNearClipDistance (){ throw new NotImplementedException(); }
		public static bool SetPedsLODDistance (float distance){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetScreenFromWorldPosition (float x, float y, float z, float edgeTolerance, bool relative){ throw new NotImplementedException(); }
		public static bool ResetPedsLODDistance (){ throw new NotImplementedException(); }
		public static float GetPedsLODDistance (){ throw new NotImplementedException(); }
		public static Tuple<float, float> GetVehiclesLODDistance (){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetWorldFromScreenPosition (float x, float y, float depth){ throw new NotImplementedException(); }
		public static bool IsAmbientSoundEnabled (string theType){ throw new NotImplementedException(); }
		public static bool IsLineOfSightClear (float startX, float startY, float startZ, float endX, float endY, float endZ, bool checkBuildings, bool checkVehicles, bool checkPeds, bool checkObjects, bool checkDummies, bool seeThroughStuff, bool ignoreSomeObjectsForCamera, Element ignoredElement){ throw new NotImplementedException(); }
		public static bool IsWorldSoundEnabled (int group, int index){ throw new NotImplementedException(); }
		public static bool IsWorldSpecialPropertyEnabled (string propname){ throw new NotImplementedException(); }
		public static bool ResetAmbientSounds (){ throw new NotImplementedException(); }
		public static bool ResetVehiclesLODDistance (){ throw new NotImplementedException(); }
		public static bool ResetWorldSounds (){ throw new NotImplementedException(); }
		public static bool SetBirdsEnabled (bool enable){ throw new NotImplementedException(); }
		public static bool SetAircraftMaxHeight (float Height){ throw new NotImplementedException(); }
		public static bool SetAmbientSoundEnabled (string theType, bool enable){ throw new NotImplementedException(); }
		public static bool SetInteriorFurnitureEnabled (int roomID, bool enabled){ throw new NotImplementedException(); }
		public static bool SetNearClipDistance (float distance){ throw new NotImplementedException(); }
		public static bool SetJetpackMaxHeight (float Height){ throw new NotImplementedException(); }
		public static Tuple<bool, dynamic, dynamic, float, float, dynamic, dynamic, Tuple<dynamic, dynamic, dynamic, dynamic, float, float, dynamic, Tuple<dynamic, dynamic, dynamic, dynamic, dynamic, dynamic, dynamic>>> ProcessLineOfSight (float startX, float startY, float startZ, float endX, float endY, float endZ, bool checkBuildings, bool checkVehicles, bool checkPlayers, bool checkObjects, bool checkDummies, bool seeThroughStuff, bool ignoreSomeObjectsForCamera, bool shootThroughStuff, Element ignoredElement, bool includeWorldModelInformation, bool bIncludeCarTyres){ throw new NotImplementedException(); }
		public static bool SetVehiclesLODDistance (float vehiclesDistance, float trainsAndPlanesDistance){ throw new NotImplementedException(); }
		public static bool SetWorldSoundEnabled (int group, int index, bool enable, bool immediate){ throw new NotImplementedException(); }
		public static bool SetWorldSpecialPropertyEnabled (string propname, bool enable){ throw new NotImplementedException(); }
		public static Tuple<bool, float, float, float> TestLineAgainstWater (float startX, float startY, float startZ, float endX, float endY, float endZ){ throw new NotImplementedException(); }
	}
}