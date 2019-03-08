using System;

namespace MultiTheftAuto {
	public class Shared {
		public static int GetBlipOrdering (Element theBlip){ throw new NotImplementedException(); }
		public static bool SetBlipIcon (Element theBlip, int icon){ throw new NotImplementedException(); }
		public static int GetBlipSize (Element theBlip){ throw new NotImplementedException(); }
		public static float GetBlipVisibleDistance (Element theBlip){ throw new NotImplementedException(); }
		public static int GetBlipIcon (Element theBlip){ throw new NotImplementedException(); }
		public static bool SetBlipColor (Element theBlip, int red, int green, int blue, int alpha){ throw new NotImplementedException(); }
		public static Tuple<int, int, int, int> GetBlipColor (Element theBlip){ throw new NotImplementedException(); }
		public static bool SetBlipOrdering (Element theBlip, int ordering){ throw new NotImplementedException(); }
		public static bool SetBlipVisibleDistance (Element theBlip, float theDistance){ throw new NotImplementedException(); }
		public static bool SetBlipSize (Element theBlip, int iconSize){ throw new NotImplementedException(); }
		public static Tuple<int, int> GetTypeIndexFromClothes (string clothesTexture, string clothesModel){ throw new NotImplementedException(); }
		public static Tuple<string, string> GetClothesByTypeIndex (int clothesType, int clothesIndex){ throw new NotImplementedException(); }
		public static string GetBodyPartName (int bodyPartID){ throw new NotImplementedException(); }
		public static string GetClothesTypeName (int clothesType){ throw new NotImplementedException(); }
		public static Element CreateColCircle (float fX, float fY, float radius){ throw new NotImplementedException(); }
		public static Element CreateColCuboid (float fX, float fY, float fZ, float fWidth, float fDepth, float fHeight){ throw new NotImplementedException(); }
		public static Element CreateColPolygon (float fX, float fY, float fX1, float fY1, float fX2, float fY2, float fX3, float fY3){ throw new NotImplementedException(); }
		public static Element CreateColRectangle (float fX, float fY, float fWidth, float fHeight){ throw new NotImplementedException(); }
		public static Element CreateColSphere (float fX, float fY, float fZ, float fRadius){ throw new NotImplementedException(); }
		public static string GetColShapeType (Element shape){ throw new NotImplementedException(); }
		public static Element CreateColTube (float fX, float fY, float fZ, float fRadius, float fHeight){ throw new NotImplementedException(); }
		public static bool IsInsideColShape (Element theShape, float posX, float posY, float posZ){ throw new NotImplementedException(); }
		public static Element GetElementColShape (Element theElement){ throw new NotImplementedException(); }
		public static bool IsElementWithinColShape (Element theElement, Element theShape){ throw new NotImplementedException(); }
		public static dynamic GetElementsWithinColShape (Element theShape, string elemType){ throw new NotImplementedException(); }
		public static bool AttachElements (Element theElement, Element theAttachToElement, float xPosOffset, float yPosOffset, float zPosOffset, float xRotOffset, float yRotOffset, float zRotOffset){ throw new NotImplementedException(); }
		public static bool DestroyElement (Element elementToDestroy){ throw new NotImplementedException(); }
		public static Element CreateElement (string elementType, string elementID){ throw new NotImplementedException(); }
		public static bool DetachElements (Element theElement, Element theAttachToElement){ throw new NotImplementedException(); }
		public static int GetElementAlpha (Element theElement){ throw new NotImplementedException(); }
		public static dynamic GetAttachedElements (Element theElement){ throw new NotImplementedException(); }
		public static Tuple<float, float, float, float, float, float> GetElementAttachedOffsets (Element theElement){ throw new NotImplementedException(); }
		public static bool GetElementCollisionsEnabled (Element theElement){ throw new NotImplementedException(); }
		public static Element GetElementAttachedTo (Element theElement){ throw new NotImplementedException(); }
		public static dynamic GetElementChildren (Element parent, string theType){ throw new NotImplementedException(); }
		public static Element GetElementChild (Element parent, int index){ throw new NotImplementedException(); }
		public static int GetElementChildrenCount (Element parent){ throw new NotImplementedException(); }
		public static Element GetElementByID (string id, int index){ throw new NotImplementedException(); }
		public static dynamic GetElementData (Element theElement, string key, bool inherit){ throw new NotImplementedException(); }
		public static float GetElementHealth (Element theElement){ throw new NotImplementedException(); }
		public static int GetElementDimension (Element theElement){ throw new NotImplementedException(); }
		public static int GetElementInterior (Element theElement){ throw new NotImplementedException(); }
		public static string GetElementID (Element theElement){ throw new NotImplementedException(); }
		public static dynamic GetElementMatrix (Element theElement, bool legacy){ throw new NotImplementedException(); }
		public static int GetElementModel (Element theElement){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetElementRotation (Element theElement, string rotOrder){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetElementPosition (Element theElement){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetElementVelocity (Element theElement){ throw new NotImplementedException(); }
		public static Element GetElementParent (Element theElement){ throw new NotImplementedException(); }
		public static string GetElementType (Element theElement){ throw new NotImplementedException(); }
		public static Element GetLowLODElement (Element theElement){ throw new NotImplementedException(); }
		public static Element GetRootElement (){ throw new NotImplementedException(); }
		public static bool IsElementFrozen (Element theElement){ throw new NotImplementedException(); }
		public static bool IsElementCallPropagationEnabled (Element theElement){ throw new NotImplementedException(); }
		public static bool IsElementDoubleSided (Element theElement){ throw new NotImplementedException(); }
		public static bool IsElementInWater (Element theElement){ throw new NotImplementedException(); }
		public static bool IsElementLowLOD (Element theElement){ throw new NotImplementedException(); }
		public static bool IsElementAttached (Element theElement){ throw new NotImplementedException(); }
		public static bool IsElementWithinMarker (Element theElement, Element theMarker){ throw new NotImplementedException(); }
		public static bool SetElementAlpha (Element theElement, int alpha){ throw new NotImplementedException(); }
		public static bool IsElement (dynamic theValue){ throw new NotImplementedException(); }
		public static bool GetElementAngularVelocity (Element theElement){ throw new NotImplementedException(); }
		public static bool SetElementAngularVelocity (Element theElement, float rx, float ry, float rz){ throw new NotImplementedException(); }
		public static bool SetElementAttachedOffsets (Element theElement, float xPosOffset, float yPosOffset, float zPosOffset, float xRotOffset, float yRotOffset, float zRotOffset){ throw new NotImplementedException(); }
		public static bool SetElementCallPropagationEnabled (Element theElement, bool enabled){ throw new NotImplementedException(); }
		public static bool SetElementInterior (Element theElement, int interior, float x, float y, float z){ throw new NotImplementedException(); }
		public static bool SetElementModel (Element theElement, int model){ throw new NotImplementedException(); }
		public static bool SetElementHealth (Element theElement, float newHealth){ throw new NotImplementedException(); }
		public static bool SetElementData (Element theElement, string key, dynamic value, bool synchronize){ throw new NotImplementedException(); }
		public static bool SetElementFrozen (Element theElement, bool freezeStatus){ throw new NotImplementedException(); }
		public static bool SetElementCollisionsEnabled (Element theElement, bool enabled){ throw new NotImplementedException(); }
		public static bool SetElementParent (Element theElement, Element parent){ throw new NotImplementedException(); }
		public static bool SetElementID (Element theElement, string name){ throw new NotImplementedException(); }
		public static bool SetElementDimension (Element theElement, int dimension){ throw new NotImplementedException(); }
		public static bool SetElementDoubleSided (Element theElement, bool enable){ throw new NotImplementedException(); }
		public static bool SetElementPosition (Element theElement, float x, float y, float z, bool warp){ throw new NotImplementedException(); }
		public static bool SetElementRotation (Element theElement, float rotX, float rotY, float rotZ, string rotOrder, bool conformPedRotation){ throw new NotImplementedException(); }
		public static bool SetElementVelocity (Element theElement, float speedX, float speedY, float speedZ){ throw new NotImplementedException(); }
		public static bool SetLowLODElement (Element theElement, Element lowLODElement){ throw new NotImplementedException(); }
		public static dynamic GetEventHandlers (string eventName, Element attachedTo){ throw new NotImplementedException(); }
		public static bool AddEventHandler (string eventName, Element attachedTo, dynamic handlerFunction, bool getPropagated, string priority){ throw new NotImplementedException(); }
		public static bool AddEvent (string eventName, bool allowRemoteTrigger){ throw new NotImplementedException(); }
		public static bool RemoveEventHandler (string eventName, Element attachedTo, dynamic functionVar){ throw new NotImplementedException(); }
		public static bool TriggerEvent (string eventName, Element baseElement, dynamic argument1){ throw new NotImplementedException(); }
		public static bool FileClose (Element theFile){ throw new NotImplementedException(); }
		public static Element FileCreate (string filePath){ throw new NotImplementedException(); }
		public static bool FileCopy (string filePath, string copyToFilePath, bool overwrite){ throw new NotImplementedException(); }
		public static bool FileDelete (string filePath){ throw new NotImplementedException(); }
		public static bool FileExists (string filePath){ throw new NotImplementedException(); }
		public static bool FileIsEOF (Element theFile){ throw new NotImplementedException(); }
		public static string FileGetPath (Element theFile){ throw new NotImplementedException(); }
		public static int FileGetPos (Element theFile){ throw new NotImplementedException(); }
		public static int FileGetSize (Element theFile){ throw new NotImplementedException(); }
		public static bool FileFlush (Element theFile){ throw new NotImplementedException(); }
		public static Element FileOpen (string filePath, bool readOnly){ throw new NotImplementedException(); }
		public static string FileRead (Element theFile, int count){ throw new NotImplementedException(); }
		public static bool FileRename (string filePath, string newFilePath){ throw new NotImplementedException(); }
		public static int FileSetPos (Element theFile, int offset){ throw new NotImplementedException(); }
		public static bool HttpClear (){ throw new NotImplementedException(); }
		public static bool HttpRequestLogin (){ throw new NotImplementedException(); }
		public static bool HttpSetResponseCode (int code){ throw new NotImplementedException(); }
		public static int FileWrite (Element theFile, string string1, string string2, string string3){ throw new NotImplementedException(); }
		public static bool HttpSetResponseCookie (string cookieName, string cookieValue){ throw new NotImplementedException(); }
		public static bool HttpSetResponseHeader (string headerName, string headerValue){ throw new NotImplementedException(); }
		public static bool HttpWrite (string data, int length){ throw new NotImplementedException(); }
		public static bool WasEventCancelled (){ throw new NotImplementedException(); }
		public static dynamic GetCommandHandlers (Element theResource){ throw new NotImplementedException(); }
		public static bool RemoveCommandHandler (string commandName, dynamic handler){ throw new NotImplementedException(); }
		public static bool SetControlState (Element thePlayer, string control, bool state){ throw new NotImplementedException(); }
		public static Tuple<int, int, int, int> GetMarkerColor (Element theMarker){ throw new NotImplementedException(); }
		public static string GetMarkerIcon (Element theMarker){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetMarkerTarget (Element theMarker){ throw new NotImplementedException(); }
		public static int GetMarkerCount (){ throw new NotImplementedException(); }
		public static float GetMarkerSize (Element myMarker){ throw new NotImplementedException(); }
		public static string GetMarkerType (Element theMarker){ throw new NotImplementedException(); }
		public static bool SetMarkerColor (Element theMarker, int r, int g, int b, int a){ throw new NotImplementedException(); }
		public static bool SetMarkerIcon (Element theMarker, string icon){ throw new NotImplementedException(); }
		public static bool SetMarkerType (Element theMarker, string markerType){ throw new NotImplementedException(); }
		public static bool SetMarkerSize (Element theMarker, float size){ throw new NotImplementedException(); }
		public static bool SetMarkerTarget (Element theMarker, float x, float y, float z){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetObjectScale (Element theObject){ throw new NotImplementedException(); }
		public static Element CreateObject (int modelid, float x, float y, float z, float rx, float ry, float rz, bool isLowLOD){ throw new NotImplementedException(); }
		public static bool StopObject (Element theobject){ throw new NotImplementedException(); }
		public static bool SetObjectScale (Element theObject, float scale, float scaleY, float scaleZ){ throw new NotImplementedException(); }
		public static bool MoveObject (Element theObject, int time, float targetx, float targety, float targetz, float moverx, float movery, float moverz, string strEasingType, float fEasingPeriod, float fEasingAmplitude, float fEasingOvershoot){ throw new NotImplementedException(); }
		public static bool OutputDebugString (string text, int level, int red, int green, int blue){ throw new NotImplementedException(); }
		public static bool AddPedClothes (Element thePed, string clothesTexture, string clothesModel, int clothesType){ throw new NotImplementedException(); }
		public static int GetPedAmmoInClip (Element thePed, int weaponSlot){ throw new NotImplementedException(); }
		public static float GetPedArmor (Element thePed){ throw new NotImplementedException(); }
		public static Element GetPedContactElement (Element thePed){ throw new NotImplementedException(); }
		public static Tuple<string, string> GetPedClothes (Element thePed, int clothesType){ throw new NotImplementedException(); }
		public static int GetPedFightingStyle (Element thePed){ throw new NotImplementedException(); }
		public static Element GetPedOccupiedVehicle (Element thePed){ throw new NotImplementedException(); }
		public static int GetPedOccupiedVehicleSeat (Element thePed){ throw new NotImplementedException(); }
		public static float GetPedStat (Element thePed, int stat){ throw new NotImplementedException(); }
		public static int GetPedTotalAmmo (Element thePed, int weaponSlot){ throw new NotImplementedException(); }
		public static Element GetPedTarget (Element thePed){ throw new NotImplementedException(); }
		public static int GetPedWalkingStyle (Element thePed){ throw new NotImplementedException(); }
		public static int GetPedWeaponSlot (Element thePed){ throw new NotImplementedException(); }
		public static int GetPedWeapon (Element thePed, int weaponSlot){ throw new NotImplementedException(); }
		public static bool IsPedChoking (Element thePed){ throw new NotImplementedException(); }
		public static bool IsPedDucked (Element thePed){ throw new NotImplementedException(); }
		public static bool IsPedDoingGangDriveby (Element thePed){ throw new NotImplementedException(); }
		public static dynamic GetValidPedModels (){ throw new NotImplementedException(); }
		public static bool IsPedDead (Element thePed){ throw new NotImplementedException(); }
		public static bool IsPedInVehicle (Element thePed){ throw new NotImplementedException(); }
		public static bool IsPedHeadless (Element thePed){ throw new NotImplementedException(); }
		public static bool IsPedOnFire (Element thePed){ throw new NotImplementedException(); }
		public static bool IsPedOnGround (Element thePed){ throw new NotImplementedException(); }
		public static bool IsPedWearingJetpack (Element thePed){ throw new NotImplementedException(); }
		public static bool KillPed (Element thePed, Element theKiller, int weapon, int bodyPart, bool stealth){ throw new NotImplementedException(); }
		public static bool RemovePedClothes (Element thePed, int clothesType, string clothesTexture, string clothesModel){ throw new NotImplementedException(); }
		public static bool SetPedAnimation (Element thePed, string block, string anim, int time, bool loop, bool updatePosition, bool interruptable, bool freezeLastFrame, int blendTime){ throw new NotImplementedException(); }
		public static bool RemovePedFromVehicle (Element thePed){ throw new NotImplementedException(); }
		public static bool SetPedAnimationProgress (Element thePed, string anim, float progress){ throw new NotImplementedException(); }
		public static bool SetPedAnimationSpeed (Element thePed, string anim, float speed){ throw new NotImplementedException(); }
		public static bool SetPedDoingGangDriveby (Element thePed, bool state){ throw new NotImplementedException(); }
		public static bool SetPedHeadless (Element thePed, bool headState){ throw new NotImplementedException(); }
		public static bool SetPedStat (Element thePed, int stat, float value){ throw new NotImplementedException(); }
		public static bool SetPedOnFire (Element thePed, bool isOnFire){ throw new NotImplementedException(); }
		public static bool SetPedWalkingStyle (Element thePed, int style){ throw new NotImplementedException(); }
		public static bool SetPedWeaponSlot (Element thePed, int weaponSlot){ throw new NotImplementedException(); }
		public static bool WarpPedIntoVehicle (Element thePed, Element theVehicle, int seat){ throw new NotImplementedException(); }
		public static int GetPickupAmmo (Element thePickup){ throw new NotImplementedException(); }
		public static Element CreatePickup (float x, float y, float z, int theType, int amount, int respawnTime, int ammo){ throw new NotImplementedException(); }
		public static int GetPickupAmount (Element thePickup){ throw new NotImplementedException(); }
		public static int GetPickupType (Element thePickup){ throw new NotImplementedException(); }
		public static int GetPickupWeapon (Element thePickup){ throw new NotImplementedException(); }
		public static bool SetPickupType (Element thePickup, int theType, int amount, int ammo){ throw new NotImplementedException(); }
		public static bool UsePickup (Element thePickup, Element thePlayer){ throw new NotImplementedException(); }
		public static Element GetPlayerFromName (string playerName){ throw new NotImplementedException(); }
		public static string GetPlayerName (Element thePlayer){ throw new NotImplementedException(); }
		public static Tuple<int, int, int> GetPlayerNametagColor (Element thePlayer){ throw new NotImplementedException(); }
		public static string GetPlayerNametagText (Element thePlayer){ throw new NotImplementedException(); }
		public static int GetPlayerPing (Element thePlayer){ throw new NotImplementedException(); }
		public static Element GetPlayerTeam (Element thePlayer){ throw new NotImplementedException(); }
		public static bool IsVoiceEnabled (){ throw new NotImplementedException(); }
		public static bool IsPlayerNametagShowing (Element thePlayer){ throw new NotImplementedException(); }
		public static bool SetPlayerNametagColor (Element thePlayer, int r, int g, int b){ throw new NotImplementedException(); }
		public static bool SetPlayerNametagShowing (Element thePlayer, bool showing){ throw new NotImplementedException(); }
		public static bool SetPlayerNametagText (Element thePlayer, string text){ throw new NotImplementedException(); }
		public static Element CreateRadarArea (float startPosX, float startPosY, float sizeX, float sizeY, int r, int g, int b, int a, Element visibleTo){ throw new NotImplementedException(); }
		public static Tuple<float, float> GetRadarAreaSize (Element theRadararea){ throw new NotImplementedException(); }
		public static bool IsInsideRadarArea (Element theArea, float posX, float posY){ throw new NotImplementedException(); }
		public static Tuple<int, int, int, int> GetRadarAreaColor (Element theRadararea){ throw new NotImplementedException(); }
		public static bool IsRadarAreaFlashing (Element theRadararea){ throw new NotImplementedException(); }
		public static bool SetRadarAreaColor (Element theRadarArea, int r, int g, int b, int a){ throw new NotImplementedException(); }
		public static bool SetRadarAreaSize (Element theRadararea, float x, float y){ throw new NotImplementedException(); }
		public static bool SetRadarAreaFlashing (Element theRadarArea, bool flash){ throw new NotImplementedException(); }
		public static dynamic Call (Element theResource, string theFunction){ throw new NotImplementedException(); }
		public static Element GetResourceConfig (string filePath){ throw new NotImplementedException(); }
		public static Element GetResourceDynamicElementRoot (Element theResource){ throw new NotImplementedException(); }
		public static bool FetchRemote (string URL, string queueName, int connectionAttempts, int connectTimeout, dynamic callbackFunction, string postData, bool postIsBinary){ throw new NotImplementedException(); }
		public static dynamic GetResourceExportedFunctions (Element theResource){ throw new NotImplementedException(); }
		public static Element GetResourceFromName (string resourceName){ throw new NotImplementedException(); }
		public static string GetResourceName (Element res){ throw new NotImplementedException(); }
		public static Element GetResourceRootElement (Element theResource){ throw new NotImplementedException(); }
		public static Element GetThisResource (){ throw new NotImplementedException(); }
		public static string GetResourceState (Element theResource){ throw new NotImplementedException(); }
		public static int GetFPSLimit (){ throw new NotImplementedException(); }
		public static bool SetFPSLimit (int fpsLimit){ throw new NotImplementedException(); }
		public static dynamic GetVersion (){ throw new NotImplementedException(); }
		public static int CountPlayersInTeam (Element theTeam){ throw new NotImplementedException(); }
		public static bool GetTeamFriendlyFire (Element theTeam){ throw new NotImplementedException(); }
		public static dynamic GetPlayersInTeam (Element theTeam){ throw new NotImplementedException(); }
		public static Tuple<int, int, int> GetTeamColor (Element theTeam){ throw new NotImplementedException(); }
		public static Element GetTeamFromName (string teamName){ throw new NotImplementedException(); }
		public static string GetTeamName (Element theTeam){ throw new NotImplementedException(); }
		public static string Base64Encode (string data){ throw new NotImplementedException(); }
		public static bool AddDebugHook (string hookType, dynamic callbackFunction, dynamic nameList){ throw new NotImplementedException(); }
		public static int BitAnd (int var1, int var2){ throw new NotImplementedException(); }
		public static int BitOr (int var1, int var2){ throw new NotImplementedException(); }
		public static int BitNot (int var){ throw new NotImplementedException(); }
		public static int BitXor (int var1, int var2){ throw new NotImplementedException(); }
		public static string Base64Decode (string data){ throw new NotImplementedException(); }
		public static bool BitTest (int var1, int var2){ throw new NotImplementedException(); }
		public static int BitLRotate (int value, int n){ throw new NotImplementedException(); }
		public static int BitRRotate (int value, int n){ throw new NotImplementedException(); }
		public static int BitLShift (int value, int n){ throw new NotImplementedException(); }
		public static int BitRShift (int value, int n){ throw new NotImplementedException(); }
		public static int BitArShift (int value, int n){ throw new NotImplementedException(); }
		public static string EncodeString (string algorithm, string input, dynamic options){ throw new NotImplementedException(); }
		public static int BitReplace (int var, int replaceValue, int field, int width){ throw new NotImplementedException(); }
		public static int BitExtract (int var, int field, int width){ throw new NotImplementedException(); }
		public static bool DebugSleep (int sleep){ throw new NotImplementedException(); }
		public static bool GetDevelopmentMode (){ throw new NotImplementedException(); }
		public static Tuple<int, int, int, int> GetColorFromString (string theColor){ throw new NotImplementedException(); }
		public static float GetDistanceBetweenPoints2D (float x1, float y1, float x2, float y2){ throw new NotImplementedException(); }
		public static dynamic FromJSON (string json){ throw new NotImplementedException(); }
		public static string DecodeString (string algorithm, string input, dynamic options){ throw new NotImplementedException(); }
		public static float GetDistanceBetweenPoints3D (float x1, float y1, float z1, float x2, float y2, float z2){ throw new NotImplementedException(); }
		public static float GetEasingValue (float fProgress, string strEasingType, float fEasingPeriod, float fEasingAmplitude, float fEasingOvershoot){ throw new NotImplementedException(); }
		public static Tuple<dynamic, dynamic> GetPerformanceStats (string category, string options, string filter){ throw new NotImplementedException(); }
		public static dynamic GetNetworkUsageData (){ throw new NotImplementedException(); }
		public static int GetTickCount (){ throw new NotImplementedException(); }
		public static dynamic GetRealTime (int seconds, bool localTime){ throw new NotImplementedException(); }
		public static dynamic GetTimers (int theTime){ throw new NotImplementedException(); }
		public static string Gettok (string text, int tokenNumber, string parameter2){ throw new NotImplementedException(); }
		public static Tuple<int, int, int> GetTimerDetails (Element theTimer){ throw new NotImplementedException(); }
		public static string GetUserdataType (Element value){ throw new NotImplementedException(); }
		public static string Inspect (dynamic var, dynamic options){ throw new NotImplementedException(); }
		public static string Hash (string algorithm, string dataToHash){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> InterpolateBetween (float x1, float y1, float z1, float x2, float y2, float z2, float fProgress, string strEasingType, float fEasingPeriod, float fEasingAmplitude, float fEasingOvershoot){ throw new NotImplementedException(); }
		public static bool IsOOPEnabled (){ throw new NotImplementedException(); }
		public static bool Iprint (dynamic var1, dynamic var2, dynamic var3){ throw new NotImplementedException(); }
		public static bool IsTimer (Element theTimer){ throw new NotImplementedException(); }
		public static bool KillTimer (Element theTimer){ throw new NotImplementedException(); }
		public static string Md5 (string str){ throw new NotImplementedException(); }
		public static string PasswordHash (string password, string algorithm, dynamic options, dynamic callback){ throw new NotImplementedException(); }
		public static dynamic PregMatch (string argument_base, string pattern, dynamic flags, int maxResults){ throw new NotImplementedException(); }
		public static bool PasswordVerify (string password, string hash, dynamic options, dynamic callback){ throw new NotImplementedException(); }
		public static bool PregFind (string subject, string pattern, dynamic flags){ throw new NotImplementedException(); }
		public static string PregReplace (string subject, string pattern, string replacement, dynamic flags){ throw new NotImplementedException(); }
		public static bool SetDevelopmentMode (bool enable, bool enableWeb){ throw new NotImplementedException(); }
		public static bool ResetTimer (Element theTimer){ throw new NotImplementedException(); }
		public static bool RemoveDebugHook (string hookType, dynamic callbackFunction){ throw new NotImplementedException(); }
		public static string TeaDecode (string data, string key){ throw new NotImplementedException(); }
		public static string Sha256 (string str){ throw new NotImplementedException(); }
		public static dynamic Split (string stringToSplit, string parameter1){ throw new NotImplementedException(); }
		public static Element SetTimer (dynamic theFunction, int timeInterval, int timesToExecute, dynamic arguments){ throw new NotImplementedException(); }
		public static string TeaEncode (string text, string key){ throw new NotImplementedException(); }
		public static int Tocolor (int red, int green, int blue, int alpha){ throw new NotImplementedException(); }
		public static string ToJSON (dynamic value, bool compact, string prettyType){ throw new NotImplementedException(); }
		public static int UtfLen (string theString){ throw new NotImplementedException(); }
		public static string UtfChar (int characterCode){ throw new NotImplementedException(); }
		public static int UtfCode (string theString){ throw new NotImplementedException(); }
		public static string UtfSub (string theString, int Start, int End){ throw new NotImplementedException(); }
		public static string Utf8_char (int codepoints){ throw new NotImplementedException(); }
		public static int UtfSeek (string theString, int position){ throw new NotImplementedException(); }
		public static string Utf8_escape (string input){ throw new NotImplementedException(); }
		public static dynamic Utf8_byte (string input, int i, int j){ throw new NotImplementedException(); }
		public static Tuple<int, int> Utf8_charpos (string input, int charpos, int offset){ throw new NotImplementedException(); }
		public static dynamic Utf8_fold (dynamic input){ throw new NotImplementedException(); }
		public static dynamic Utf8_gmatch (string input, string pattern){ throw new NotImplementedException(); }
		public static string Utf8_find (string input, string pattern, int startpos, bool plain){ throw new NotImplementedException(); }
		public static string Utf8_insert (string input, int insert_pos){ throw new NotImplementedException(); }
		public static string Utf8_gsub (string input, string pattern, dynamic replace, int match_limit){ throw new NotImplementedException(); }
		public static int Utf8_len (string input, int i, int j){ throw new NotImplementedException(); }
		public static dynamic Utf8_match (string input, string pattern, int index){ throw new NotImplementedException(); }
		public static int Utf8_ncasecmp (string a, string b){ throw new NotImplementedException(); }
		public static Tuple<int, int> Utf8_next (string input, int charpos, int offset){ throw new NotImplementedException(); }
		public static string Utf8_remove (string input, int start, int stop){ throw new NotImplementedException(); }
		public static string Utf8_reverse (string input){ throw new NotImplementedException(); }
		public static string Utf8_sub (string input, int i, int j){ throw new NotImplementedException(); }
		public static string Utf8_title (dynamic input){ throw new NotImplementedException(); }
		public static Tuple<int, int, int> Utf8_widthindex (string input, int location, bool ambi_is_double, int default_width){ throw new NotImplementedException(); }
		public static int Utf8_width (dynamic input, bool ambi_is_double, int default_width){ throw new NotImplementedException(); }
		public static bool AttachTrailerToVehicle (Element theVehicle, Element theTrailer){ throw new NotImplementedException(); }
		public static bool AddVehicleUpgrade (Element theVehicle, int upgrade){ throw new NotImplementedException(); }
		public static Element CreateVehicle (int model, float x, float y, float z, float rx, float ry, float rz, string numberplate, bool bDirection, int variant1, int variant2){ throw new NotImplementedException(); }
		public static bool FixVehicle (Element theVehicle){ throw new NotImplementedException(); }
		public static bool DetachTrailerFromVehicle (Element theVehicle, Element theTrailer){ throw new NotImplementedException(); }
		public static dynamic GetOriginalHandling (int modelID){ throw new NotImplementedException(); }
		public static bool GetTrainDirection (Element train){ throw new NotImplementedException(); }
		public static float GetTrainPosition (Element train){ throw new NotImplementedException(); }
		public static float GetTrainSpeed (Element train){ throw new NotImplementedException(); }
		public static int GetTrainTrack (Element train){ throw new NotImplementedException(); }
		public static dynamic GetVehicleCompatibleUpgrades (Element theVehicle, int slot){ throw new NotImplementedException(); }
		public static Element GetVehicleController (Element theVehicle){ throw new NotImplementedException(); }
		public static float GetVehicleDoorOpenRatio (Element theVehicle, int door){ throw new NotImplementedException(); }
		public static Tuple<int, int, int, int> GetVehicleColor (Element theVehicle){ throw new NotImplementedException(); }
		public static int GetVehicleDoorState (Element theVehicle, int door){ throw new NotImplementedException(); }
		public static bool GetVehicleEngineState (Element theVehicle){ throw new NotImplementedException(); }
		public static Tuple<int, int, int> GetVehicleHeadLightColor (Element theVehicle){ throw new NotImplementedException(); }
		public static dynamic GetVehicleHandling (Element theVehicle){ throw new NotImplementedException(); }
		public static int GetVehicleLightState (Element theVehicle, int light){ throw new NotImplementedException(); }
		public static bool GetVehicleLandingGearDown (Element theVehicle){ throw new NotImplementedException(); }
		public static string GetVehicleName (Element theVehicle){ throw new NotImplementedException(); }
		public static int GetVehicleMaxPassengers (Element theVehicle){ throw new NotImplementedException(); }
		public static int GetVehicleModelFromName (string name){ throw new NotImplementedException(); }
		public static Element GetVehicleOccupant (Element theVehicle, int seat){ throw new NotImplementedException(); }
		public static string GetVehicleNameFromModel (int model){ throw new NotImplementedException(); }
		public static dynamic GetVehicleOccupants (Element theVehicle){ throw new NotImplementedException(); }
		public static int GetVehicleOverrideLights (Element theVehicle){ throw new NotImplementedException(); }
		public static int GetVehiclePaintjob (Element theVehicle){ throw new NotImplementedException(); }
		public static int GetVehiclePanelState (Element theVehicle, int panel){ throw new NotImplementedException(); }
		public static string GetVehiclePlateText (Element theVehicle){ throw new NotImplementedException(); }
		public static dynamic GetVehicleSirenParams (Element theVehicle){ throw new NotImplementedException(); }
		public static bool GetVehicleSirensOn (Element theVehicle){ throw new NotImplementedException(); }
		public static dynamic GetVehicleSirens (Element theVehicle){ throw new NotImplementedException(); }
		public static Element GetVehicleTowedByVehicle (Element theVehicle){ throw new NotImplementedException(); }
		public static Element GetVehicleTowingVehicle (Element theVehicle){ throw new NotImplementedException(); }
		public static Tuple<float, float> GetVehicleTurretPosition (Element turretVehicle){ throw new NotImplementedException(); }
		public static string GetVehicleType (Element theVehicle){ throw new NotImplementedException(); }
		public static int GetVehicleUpgradeOnSlot (Element theVehicle, int slot){ throw new NotImplementedException(); }
		public static string GetVehicleUpgradeSlotName (int slot){ throw new NotImplementedException(); }
		public static dynamic GetVehicleUpgrades (Element theVehicle){ throw new NotImplementedException(); }
		public static Tuple<int, int> GetVehicleVariant (Element theVehicle){ throw new NotImplementedException(); }
		public static Tuple<int, int, int, int> GetVehicleWheelStates (Element theVehicle){ throw new NotImplementedException(); }
		public static bool IsTrainDerailable (Element vehicleToCheck){ throw new NotImplementedException(); }
		public static bool IsTrainDerailed (Element vehicleToCheck){ throw new NotImplementedException(); }
		public static bool IsVehicleBlown (Element theVehicle){ throw new NotImplementedException(); }
		public static bool IsVehicleDamageProof (Element theVehicle){ throw new NotImplementedException(); }
		public static bool IsVehicleFuelTankExplodable (Element theVehicle){ throw new NotImplementedException(); }
		public static bool IsVehicleLocked (Element theVehicle){ throw new NotImplementedException(); }
		public static bool IsVehicleTaxiLightOn (Element taxi){ throw new NotImplementedException(); }
		public static bool IsVehicleOnGround (Element theVehicle){ throw new NotImplementedException(); }
		public static bool SetTrainDerailable (Element derailableVehicle, bool derailable){ throw new NotImplementedException(); }
		public static bool SetTrainDerailed (Element vehicleToDerail, bool derailed){ throw new NotImplementedException(); }
		public static bool RemoveVehicleUpgrade (Element theVehicle, int upgrade){ throw new NotImplementedException(); }
		public static bool SetTrainSpeed (Element train, float speed){ throw new NotImplementedException(); }
		public static bool SetTrainDirection (Element train, bool clockwise){ throw new NotImplementedException(); }
		public static bool SetTrainPosition (Element train, float position){ throw new NotImplementedException(); }
		public static bool SetVehicleColor (Element theVehicle, int r1, int g1, int b1, int r2, int g2, int b2, int r3, int g3, int b3, int r4, int g4, int b4){ throw new NotImplementedException(); }
		public static bool SetTrainTrack (Element train, int track){ throw new NotImplementedException(); }
		public static bool SetVehicleDoorOpenRatio (Element theVehicle, int door, float ratio, int time){ throw new NotImplementedException(); }
		public static bool SetVehicleDoorState (Element theVehicle, int door, int state){ throw new NotImplementedException(); }
		public static bool SetVehicleDamageProof (Element theVehicle, bool damageProof){ throw new NotImplementedException(); }
		public static bool SetVehicleEngineState (Element theVehicle, bool engineState){ throw new NotImplementedException(); }
		public static bool SetVehicleDoorsUndamageable (Element theVehicle, bool state){ throw new NotImplementedException(); }
		public static bool SetVehicleHeadLightColor (Element theVehicle, int red, int green, int blue){ throw new NotImplementedException(); }
		public static bool SetVehicleFuelTankExplodable (Element theVehicle, bool explodable){ throw new NotImplementedException(); }
		public static bool SetVehicleLandingGearDown (Element theVehicle, bool gearState){ throw new NotImplementedException(); }
		public static bool SetVehicleHandling (Element theVehicle, string property, dynamic value){ throw new NotImplementedException(); }
		public static bool SetVehicleLightState (Element theVehicle, int light, int state){ throw new NotImplementedException(); }
		public static bool SetVehicleLocked (Element theVehicle, bool locked){ throw new NotImplementedException(); }
		public static bool SetVehiclePaintjob (Element theVehicle, int value){ throw new NotImplementedException(); }
		public static bool SetVehiclePlateText (Element theVehicle, string numberplate){ throw new NotImplementedException(); }
		public static bool SetVehiclePanelState (Element theVehicle, int panelID, int state){ throw new NotImplementedException(); }
		public static bool SetVehicleSirens (Element theVehicle, int sirenPoint, float posX, float posY, float posZ, float red, float green, float blue, float alpha, float minAlpha){ throw new NotImplementedException(); }
		public static bool SetVehicleOverrideLights (Element theVehicle, int value){ throw new NotImplementedException(); }
		public static bool SetVehicleSirensOn (Element theVehicle, bool sirensOn){ throw new NotImplementedException(); }
		public static bool SetVehicleTaxiLightOn (Element taxi, bool LightState){ throw new NotImplementedException(); }
		public static bool SetVehicleWheelStates (Element theVehicle, int frontLeft, int rearLeft, int frontRight, int rearRight){ throw new NotImplementedException(); }
		public static bool SetVehicleTurretPosition (Element turretVehicle, float positionX, float positionY){ throw new NotImplementedException(); }
		public static Element CreateWater (int x1, int y1, float z1, int x2, int y2, float z2, int x3, int y3, float z3, int x4, int y4, float z4, bool bShallow){ throw new NotImplementedException(); }
		public static Tuple<int, int, float> GetWaterVertexPosition (Element theWater, int vertexIndex){ throw new NotImplementedException(); }
		public static Tuple<int, int, int, int> GetWaterColor (){ throw new NotImplementedException(); }
		public static float GetWaveHeight (){ throw new NotImplementedException(); }
		public static bool ResetWaterColor (){ throw new NotImplementedException(); }
		public static bool ResetWaterLevel (){ throw new NotImplementedException(); }
		public static bool SetWaterColor (int red, int green, int blue, int alpha){ throw new NotImplementedException(); }
		public static bool SetWaterLevel (Element theWater, float level){ throw new NotImplementedException(); }
		public static bool SetWaterVertexPosition (Element theWater, int vertexIndex, int x, int y, float z){ throw new NotImplementedException(); }
		public static int GetOriginalWeaponProperty (int weaponID, string weaponSkill, string property){ throw new NotImplementedException(); }
		public static bool SetWaveHeight (float height){ throw new NotImplementedException(); }
		public static int GetWeaponProperty (int weaponID, string weaponSkill, string property){ throw new NotImplementedException(); }
		public static int GetSlotFromWeapon (int weaponid){ throw new NotImplementedException(); }
		public static string GetWeaponNameFromID (int id){ throw new NotImplementedException(); }
		public static int GetWeaponIDFromName (string name){ throw new NotImplementedException(); }
		public static bool SetWeaponAmmo (Element thePlayer, int weapon, int totalAmmo, int ammoInClip){ throw new NotImplementedException(); }
		public static float GetAircraftMaxVelocity (){ throw new NotImplementedException(); }
		public static bool AreTrafficLightsLocked (){ throw new NotImplementedException(); }
		public static bool GetCloudsEnabled (){ throw new NotImplementedException(); }
		public static float GetFarClipDistance (){ throw new NotImplementedException(); }
		public static float GetFogDistance (){ throw new NotImplementedException(); }
		public static float GetGameSpeed (){ throw new NotImplementedException(); }
		public static Tuple<int, int, int, int, int, int, int, Tuple<int, bool>> GetHeatHaze (){ throw new NotImplementedException(); }
		public static float GetGravity (){ throw new NotImplementedException(); }
		public static float GetJetpackMaxHeight (){ throw new NotImplementedException(); }
		public static int GetMinuteDuration (){ throw new NotImplementedException(); }
		public static bool GetOcclusionsEnabled (){ throw new NotImplementedException(); }
		public static float GetRainLevel (){ throw new NotImplementedException(); }
		public static int GetMoonSize (){ throw new NotImplementedException(); }
		public static Tuple<int, int, int, int, int, int> GetSkyGradient (){ throw new NotImplementedException(); }
		public static Tuple<int, int, int, int, int, int> GetSunColor (){ throw new NotImplementedException(); }
		public static int GetTrafficLightState (){ throw new NotImplementedException(); }
		public static Tuple<int, int> GetWeather (){ throw new NotImplementedException(); }
		public static Tuple<int, int> GetTime (){ throw new NotImplementedException(); }
		public static Tuple<int, int, int> GetWindVelocity (){ throw new NotImplementedException(); }
		public static float GetSunSize (){ throw new NotImplementedException(); }
		public static bool RemoveWorldModel (int modelID, float radius, float x, float y, float z, int interior){ throw new NotImplementedException(); }
		public static string GetZoneName (float x, float y, float z, bool citiesonly){ throw new NotImplementedException(); }
		public static bool ResetFarClipDistance (){ throw new NotImplementedException(); }
		public static bool ResetFogDistance (){ throw new NotImplementedException(); }
		public static bool IsGarageOpen (int garageID){ throw new NotImplementedException(); }
		public static bool ResetRainLevel (){ throw new NotImplementedException(); }
		public static bool ResetSunColor (){ throw new NotImplementedException(); }
		public static bool ResetHeatHaze (){ throw new NotImplementedException(); }
		public static bool ResetMoonSize (){ throw new NotImplementedException(); }
		public static bool ResetSkyGradient (){ throw new NotImplementedException(); }
		public static bool ResetSunSize (){ throw new NotImplementedException(); }
		public static bool RestoreWorldModel (int modelID, float radius, float x, float y, float z, int iInterior){ throw new NotImplementedException(); }
		public static bool ResetWindVelocity (){ throw new NotImplementedException(); }
		public static bool SetCloudsEnabled (bool enabled){ throw new NotImplementedException(); }
		public static bool SetFogDistance (float distance){ throw new NotImplementedException(); }
		public static bool RestoreAllWorldModels (){ throw new NotImplementedException(); }
		public static bool SetFarClipDistance (float distance){ throw new NotImplementedException(); }
		public static bool SetAircraftMaxVelocity (float velocity){ throw new NotImplementedException(); }
		public static bool SetGameSpeed (float value){ throw new NotImplementedException(); }
		public static bool SetGarageOpen (int garageID, bool open){ throw new NotImplementedException(); }
		public static bool SetHeatHaze (int intensity, int randomShift, int speedMin, int speedMax, int scanSizeX, int scanSizeY, int renderSizeX, int renderSizeY, bool bShowInside){ throw new NotImplementedException(); }
		public static bool SetMinuteDuration (int milliseconds){ throw new NotImplementedException(); }
		public static bool SetInteriorSoundsEnabled (bool enabled){ throw new NotImplementedException(); }
		public static bool SetMoonSize (int size){ throw new NotImplementedException(); }
		public static bool SetOcclusionsEnabled (bool enabled){ throw new NotImplementedException(); }
		public static bool SetGravity (float level){ throw new NotImplementedException(); }
		public static bool SetSkyGradient (int topRed, int topGreen, int topBlue, int bottomRed, int bottomGreen, int bottomBlue){ throw new NotImplementedException(); }
		public static bool SetRainLevel (float level){ throw new NotImplementedException(); }
		public static bool SetSunSize (int Size){ throw new NotImplementedException(); }
		public static bool SetSunColor (int aRed, int aGreen, int aBlue, int bRed, int bGreen, int bBlue){ throw new NotImplementedException(); }
		public static bool SetTime (int hour, int minute){ throw new NotImplementedException(); }
		public static bool SetTrafficLightsLocked (bool toggle){ throw new NotImplementedException(); }
		public static bool SetTrafficLightState (int state){ throw new NotImplementedException(); }
		public static bool SetWeather (int weatherID){ throw new NotImplementedException(); }
		public static bool SetWindVelocity (float velocityX, float velocityY, float velocityZ){ throw new NotImplementedException(); }
		public static bool SetWeatherBlended (int weatherID){ throw new NotImplementedException(); }
		public static Element XmlCopyFile (Element nodeToCopy, string newFilePath){ throw new NotImplementedException(); }
		public static bool XmlDestroyNode (Element theXMLNode){ throw new NotImplementedException(); }
		public static Element XmlFindChild (Element parent, string tagName, int index){ throw new NotImplementedException(); }
		public static Element XmlCreateFile (string filePath, string rootNodeName){ throw new NotImplementedException(); }
		public static Element XmlCreateChild (Element parentNode, string tagName){ throw new NotImplementedException(); }
		public static string XmlNodeGetAttribute (Element node, string name){ throw new NotImplementedException(); }
		public static dynamic XmlNodeGetChildren (Element parent, int index){ throw new NotImplementedException(); }
		public static dynamic XmlNodeGetAttributes (Element node){ throw new NotImplementedException(); }
		public static Element XmlLoadFile (string filePath, bool readOnly){ throw new NotImplementedException(); }
		public static string XmlNodeGetName (Element node){ throw new NotImplementedException(); }
		public static Element XmlNodeGetParent (Element node){ throw new NotImplementedException(); }
		public static string XmlNodeGetValue (Element theXMLNode){ throw new NotImplementedException(); }
		public static bool XmlNodeSetName (Element node, string name){ throw new NotImplementedException(); }
		public static bool XmlNodeSetAttribute (Element node, string name, dynamic value){ throw new NotImplementedException(); }
		public static bool XmlUnloadFile (Element node){ throw new NotImplementedException(); }
		public static bool XmlSaveFile (Element rootNode){ throw new NotImplementedException(); }
		public static bool XmlNodeSetValue (Element theXMLNode, string value, bool setCDATA){ throw new NotImplementedException(); }
		public static dynamic GetElementsWithinRange (float x, float y, float z, float range, string elemType){ throw new NotImplementedException(); }
		public static bool SetVehicleDirtLevel (Element theVehicle, int dirtLevel){ throw new NotImplementedException(); }
		public static float GetAircraftMaxHeight (){ throw new NotImplementedException(); }
		public static bool SetAircraftMaxHeight (float Height){ throw new NotImplementedException(); }
		public static bool SetJetpackMaxHeight (float Height){ throw new NotImplementedException(); }
	}
}