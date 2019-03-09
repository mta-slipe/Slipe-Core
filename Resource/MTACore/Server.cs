using System;

namespace MultiTheftAuto {
	public class Server {
		public static dynamic GetAccounts (){ throw new NotImplementedException(); }
		public static bool RemoveAccount (Element theAccount){ throw new NotImplementedException(); }
		public static int GetAccountID (Element theAccount){ throw new NotImplementedException(); }
		public static dynamic GetAllAccountData (Element theAccount){ throw new NotImplementedException(); }
		public static string GetAccountSerial (Element theAccount){ throw new NotImplementedException(); }
		public static bool LogOut (Element thePlayer){ throw new NotImplementedException(); }
		public static Element AddAccount (string name, string pass, bool allowCaseVariations){ throw new NotImplementedException(); }
		public static string GetAccountName (Element theAccount){ throw new NotImplementedException(); }
		public static dynamic GetAccountsBySerial (string serial){ throw new NotImplementedException(); }
		public static Element GetPlayerAccount (Element thePlayer){ throw new NotImplementedException(); }
		public static bool LogIn (Element thePlayer, Element theAccount, string thePassword){ throw new NotImplementedException(); }
		public static bool IsGuestAccount (Element theAccount){ throw new NotImplementedException(); }
		public static Element GetAccountPlayer (Element theAccount){ throw new NotImplementedException(); }
		public static string GetAccountData (Element theAccount, string key){ throw new NotImplementedException(); }
		public static bool CopyAccountData (Element theAccount, Element fromAccount){ throw new NotImplementedException(); }
		public static Element GetAccount (string username, string password, bool caseSensitive){ throw new NotImplementedException(); }
		public static bool SetAccountPassword (Element theAccount, string password){ throw new NotImplementedException(); }
		public static bool SetAccountData (Element theAccount, string key, string value){ throw new NotImplementedException(); }
		public static dynamic GetAccountsByData (string dataName, string value){ throw new NotImplementedException(); }
		public static Element GetAccountByID (int id){ throw new NotImplementedException(); }
		public static string GetAccountIP (Element theAccount){ throw new NotImplementedException(); }
		public static Element AclCreate (string aclName){ throw new NotImplementedException(); }
		public static dynamic GetAccountsByIP (string ip){ throw new NotImplementedException(); }
		public static bool SetAccountName (Element theAccount, string name, bool allowCaseVariations){ throw new NotImplementedException(); }
		public static Element AclGetGroup (string groupName){ throw new NotImplementedException(); }
		public static bool AclDestroy (Element theACL){ throw new NotImplementedException(); }
		public static bool AclDestroyGroup (Element aclGroup){ throw new NotImplementedException(); }
		public static Element AclCreateGroup (string groupName){ throw new NotImplementedException(); }
		public static Element AclGet (string aclName){ throw new NotImplementedException(); }
		public static string AclGetName (Element theAcl){ throw new NotImplementedException(); }
		public static bool AclGetRight (Element theAcl, string rightName){ throw new NotImplementedException(); }
		public static string AclGroupGetName (Element aclGroup){ throw new NotImplementedException(); }
		public static bool AclGroupAddACL (Element theGroup, Element theACL){ throw new NotImplementedException(); }
		public static bool AclGroupAddObject (Element theGroup, string theObjectName){ throw new NotImplementedException(); }
		public static dynamic AclGroupListObjects (Element theGroup){ throw new NotImplementedException(); }
		public static bool AclGroupRemoveACL (Element theGroup, Element theACL){ throw new NotImplementedException(); }
		public static dynamic AclGroupList (){ throw new NotImplementedException(); }
		public static bool AclGroupRemoveObject (Element theGroup, string theObjectString){ throw new NotImplementedException(); }
		public static dynamic AclGroupListACL (Element theGroup){ throw new NotImplementedException(); }
		public static dynamic AclListRights (Element theACL, string allowedType){ throw new NotImplementedException(); }
		public static dynamic AclList (){ throw new NotImplementedException(); }
		public static bool AclRemoveRight (Element theAcl, string rightName){ throw new NotImplementedException(); }
		public static bool AclSave (){ throw new NotImplementedException(); }
		public static bool AclSetRight (Element theAcl, string rightName, bool hasAccess){ throw new NotImplementedException(); }
		public static bool IsObjectInACLGroup (string theObject, Element theGroup){ throw new NotImplementedException(); }
		public static Element AddBan (string IP, string Username, string Serial, Element responsibleElement, string reason, int seconds){ throw new NotImplementedException(); }
		public static bool HasObjectPermissionTo (string parameter0, string theAction, bool defaultPermission){ throw new NotImplementedException(); }
		public static string GetBanAdmin (Element theBan){ throw new NotImplementedException(); }
		public static string GetBanIP (Element theBan){ throw new NotImplementedException(); }
		public static Element BanPlayer (Element bannedPlayer, bool IP, bool Username, bool Serial, dynamic responsiblePlayer, string reason, int seconds){ throw new NotImplementedException(); }
		public static string GetBanNick (Element theBan){ throw new NotImplementedException(); }
		public static int GetBanTime (Element theBan){ throw new NotImplementedException(); }
		public static string GetBanSerial (Element theBan){ throw new NotImplementedException(); }
		public static string GetBanReason (Element theBan){ throw new NotImplementedException(); }
		public static dynamic GetBans (){ throw new NotImplementedException(); }
		public static string GetBanUsername (Element theBan){ throw new NotImplementedException(); }
		public static bool IsBan (Element theBan){ throw new NotImplementedException(); }
		public static int GetUnbanTime (Element theBan){ throw new NotImplementedException(); }
		public static bool KickPlayer (Element kickedPlayer, dynamic responsiblePlayer, string reason){ throw new NotImplementedException(); }
		public static bool SetBanNick (Element theBan, string theNick){ throw new NotImplementedException(); }
		public static bool AclReload (){ throw new NotImplementedException(); }
		public static bool SetBanReason (Element theBan, string theReason){ throw new NotImplementedException(); }
		public static bool SetBanAdmin (Element theBan, string theAdmin){ throw new NotImplementedException(); }
		public static bool RemoveBan (Element theBan, Element responsibleElement){ throw new NotImplementedException(); }
		public static bool ReloadBans (){ throw new NotImplementedException(); }
		public static bool SetUnbanTime (Element theBan, int theTime){ throw new NotImplementedException(); }
		public static string GetGameType (){ throw new NotImplementedException(); }
		public static bool PlaySoundFrontEnd (Element thePlayer, int sound){ throw new NotImplementedException(); }
		public static string GetMapName (){ throw new NotImplementedException(); }
		public static string GetRuleValue (string key){ throw new NotImplementedException(); }
		public static bool RemoveRuleValue (string key){ throw new NotImplementedException(); }
		public static bool SetGameType (string gameType){ throw new NotImplementedException(); }
		public static bool SetMapName (string mapName){ throw new NotImplementedException(); }
		public static bool SetRuleValue (string key, string value){ throw new NotImplementedException(); }
		public static Element CreateBlipAttachedTo (Element elementToAttachTo, int icon, int size, int r, int g, int b, int a, int ordering, float visibleDistance, Element visibleTo){ throw new NotImplementedException(); }
		public static Element CreateBlip (float x, float y, float z, int icon, int size, int r, int g, int b, int a, int ordering, float visibleDistance, Element visibleTo){ throw new NotImplementedException(); }
		public static bool FadeCamera (Element thePlayer, bool fadeIn, float timeToFade, int red, int green, int blue){ throw new NotImplementedException(); }
		public static Tuple<float, float, float, float, float, float, float, float> GetCameraMatrix (Element thePlayer){ throw new NotImplementedException(); }
		public static int GetCameraInterior (Element thePlayer){ throw new NotImplementedException(); }
		public static Element GetCameraTarget (Element thePlayer){ throw new NotImplementedException(); }
		public static bool SetCameraInterior (Element thePlayer, int interior){ throw new NotImplementedException(); }
		public static bool SetCameraMatrix (Element thePlayer, float positionX, float positionY, float positionZ, float lookAtX, float lookAtY, float lookAtZ, float roll, float fov){ throw new NotImplementedException(); }
		public static bool SetCameraTarget (Element thePlayer, Element target){ throw new NotImplementedException(); }
		public static bool IsCursorShowing (Element thePlayer){ throw new NotImplementedException(); }
		public static bool ShowCursor (Element thePlayer, bool show, bool toggleControls){ throw new NotImplementedException(); }
		public static bool ClearElementVisibleTo (Element theElement){ throw new NotImplementedException(); }
		public static Element CloneElement (Element theElement, float xPos, float yPos, float zPos, bool cloneChildren){ throw new NotImplementedException(); }
		public static dynamic GetAllElementData (Element theElement){ throw new NotImplementedException(); }
		public static Element GetElementByIndex (string theType, int index){ throw new NotImplementedException(); }
		public static dynamic GetElementsByType (string theType, Element startat){ throw new NotImplementedException(); }
		public static Element GetElementSyncer (Element theElement){ throw new NotImplementedException(); }
		public static string GetElementZoneName (Element theElement, bool citiesonly){ throw new NotImplementedException(); }
		public static bool RemoveElementData (Element theElement, string key){ throw new NotImplementedException(); }
		public static bool IsElementVisibleTo (Element theElement, Element visibleTo){ throw new NotImplementedException(); }
		public static bool SetElementVisibleTo (Element theElement, Element visibleTo, bool visible){ throw new NotImplementedException(); }
		public static bool SetElementSyncer (Element theElement, Element thePlayer){ throw new NotImplementedException(); }
		public static bool CancelEvent (bool cancel, string reason){ throw new NotImplementedException(); }
		public static string GetCancelReason (){ throw new NotImplementedException(); }
		public static bool CancelLatentEvent (Element thePlayer, int handle){ throw new NotImplementedException(); }
		public static dynamic GetLatentEventHandles (Element thePlayer){ throw new NotImplementedException(); }
		public static dynamic GetLatentEventStatus (Element thePlayer, int handle){ throw new NotImplementedException(); }
		public static bool TriggerClientEvent (dynamic sendTo){ throw new NotImplementedException(); }
		public static bool TriggerLatentClientEvent (dynamic sendTo){ throw new NotImplementedException(); }
		public static bool CreateExplosion (float x, float y, float z, int theType, Element creator){ throw new NotImplementedException(); }
		public static bool BindKey (Element thePlayer, string key, string keyState, dynamic handlerFunction, dynamic arguments){ throw new NotImplementedException(); }
		public static bool AddCommandHandler (string commandName, dynamic handlerFunction, bool restricted, bool caseSensitive){ throw new NotImplementedException(); }
		public static string GetKeyBoundToFunction (Element thePlayer, dynamic theFunction){ throw new NotImplementedException(); }
		public static bool GetControlState (Element thePlayer, string controlName){ throw new NotImplementedException(); }
		public static bool IsKeyBound (Element thePlayer, string key, string keyState, dynamic handler){ throw new NotImplementedException(); }
		public static bool IsControlEnabled (Element thePlayer, string control){ throw new NotImplementedException(); }
		public static bool ExecuteCommandHandler (string commandName, Element thePlayer, string args){ throw new NotImplementedException(); }
		public static dynamic GetFunctionsBoundToKey (Element thePlayer, string key, string keyState){ throw new NotImplementedException(); }
		public static bool ToggleAllControls (Element thePlayer, bool enabled, bool gtaControls, bool mtaControls){ throw new NotImplementedException(); }
		public static Element LoadMapData (Element node, Element parent){ throw new NotImplementedException(); }
		public static bool ToggleControl (Element thePlayer, string control, bool enabled){ throw new NotImplementedException(); }
		public static bool ResetMapInfo (Element thePlayer){ throw new NotImplementedException(); }
		public static bool SaveMapData (Element node, Element baseElement, bool childrenOnly){ throw new NotImplementedException(); }
		public static bool UnbindKey (Element thePlayer, string key, string keyState, string command){ throw new NotImplementedException(); }
		public static Element CreateMarker (float x, float y, float z, string theType, float size, int r, int g, int b, int a, bool visibleTo){ throw new NotImplementedException(); }
		public static dynamic GetLoadedModules (){ throw new NotImplementedException(); }
		public static dynamic GetModuleInfo (string moduleName){ throw new NotImplementedException(); }
		public static bool ClearChatBox (Element clearFor){ throw new NotImplementedException(); }
		public static bool OutputChatBox (string text, Element visibleTo){ throw new NotImplementedException(); }
		public static bool OutputConsole (string text, Element visibleTo){ throw new NotImplementedException(); }
		public static bool ShowChat (Element thePlayer, bool show){ throw new NotImplementedException(); }
		public static bool OutputServerLog (string text){ throw new NotImplementedException(); }
		public static Element CreatePed (int modelid, float x, float y, float z, float rot, bool synced){ throw new NotImplementedException(); }
		public static float GetPedGravity (Element thePed){ throw new NotImplementedException(); }
		public static bool ReloadPedWeapon (Element thePed){ throw new NotImplementedException(); }
		public static bool SetPedChoking (Element thePed, bool choking){ throw new NotImplementedException(); }
		public static bool SetPedArmor (Element thePed, float armor){ throw new NotImplementedException(); }
		public static bool SetPedFightingStyle (Element thePed, int style){ throw new NotImplementedException(); }
		public static bool SetPedGravity (Element thePed, float gravity){ throw new NotImplementedException(); }
		public static bool SetPedWearingJetpack (Element thePed, bool state){ throw new NotImplementedException(); }
		public static int GetPickupRespawnInterval (Element thePickup){ throw new NotImplementedException(); }
		public static bool IsPickupSpawned (Element thePickup){ throw new NotImplementedException(); }
		public static bool SetPickupRespawnInterval (Element thePickup, int ms){ throw new NotImplementedException(); }
		public static dynamic GetAlivePlayers (){ throw new NotImplementedException(); }
		public static bool ForcePlayerMap (Element thePlayer, bool forceOn){ throw new NotImplementedException(); }
		public static dynamic GetDeadPlayers (){ throw new NotImplementedException(); }
		public static dynamic GetPlayerACInfo (Element thePlayer){ throw new NotImplementedException(); }
		public static string GetPlayerAnnounceValue (Element thePlayer, string key){ throw new NotImplementedException(); }
		public static int GetPlayerBlurLevel (Element thePlayer){ throw new NotImplementedException(); }
		public static int GetPlayerCount (){ throw new NotImplementedException(); }
		public static string GetPlayerIP (Element thePlayer){ throw new NotImplementedException(); }
		public static int GetPlayerIdleTime (Element thePlayer){ throw new NotImplementedException(); }
		public static int GetPlayerMoney (Element thePlayer){ throw new NotImplementedException(); }
		public static string GetPlayerVersion (Element thePlayer){ throw new NotImplementedException(); }
		public static Element GetRandomPlayer (){ throw new NotImplementedException(); }
		public static int GetPlayerWantedLevel (Element thePlayer){ throw new NotImplementedException(); }
		public static string GetPlayerSerial (Element thePlayer){ throw new NotImplementedException(); }
		public static bool GivePlayerMoney (Element thePlayer, int amount){ throw new NotImplementedException(); }
		public static bool IsPlayerMapForced (Element thePlayer){ throw new NotImplementedException(); }
		public static bool IsPlayerMuted (Element thePlayer){ throw new NotImplementedException(); }
		public static bool RedirectPlayer (Element thePlayer, string serverIP, int serverPort, string serverPassword){ throw new NotImplementedException(); }
		public static bool ResendPlayerACInfo (Element thePlayer){ throw new NotImplementedException(); }
		public static bool ResendPlayerModInfo (Element thePlayer){ throw new NotImplementedException(); }
		public static bool SetPlayerAnnounceValue (Element thePlayer, string key, string value){ throw new NotImplementedException(); }
		public static bool SetPlayerBlurLevel (Element thePlayer, int level){ throw new NotImplementedException(); }
		public static bool SetPlayerHudComponentVisible (Element thePlayer, string component, bool show){ throw new NotImplementedException(); }
		public static bool SetPlayerMoney (Element thePlayer, int amount, bool instant){ throw new NotImplementedException(); }
		public static bool SetPlayerMuted (Element thePlayer, bool state){ throw new NotImplementedException(); }
		public static bool SetPlayerName (Element thePlayer, string newName){ throw new NotImplementedException(); }
		public static bool SetPlayerTeam (Element thePlayer, Element theTeam){ throw new NotImplementedException(); }
		public static bool SetPlayerVoiceBroadcastTo (Element thePlayer, dynamic broadcastTo){ throw new NotImplementedException(); }
		public static bool SetPlayerWantedLevel (Element thePlayer, int stars){ throw new NotImplementedException(); }
		public static bool SpawnPlayer (Element thePlayer, float x, float y, float z, int rotation, int skinID, int interior, int dimension, Element theTeam){ throw new NotImplementedException(); }
		public static bool SetPlayerVoiceIgnoreFrom (Element thePlayer, dynamic ignoreFrom){ throw new NotImplementedException(); }
		public static bool DetonateSatchels (Element Player){ throw new NotImplementedException(); }
		public static bool TakePlayerMoney (Element thePlayer, int amount){ throw new NotImplementedException(); }
		public static bool TakePlayerScreenShot (Element thePlayer, int width, int height, string tag, int quality, int maxBandwith, int maxPacketSize){ throw new NotImplementedException(); }
		public static Element AddResourceConfig (string filePath, string filetype){ throw new NotImplementedException(); }
		public static Element AddResourceMap (string filePath, int dimension){ throw new NotImplementedException(); }
		public static Element CopyResource (Element theResource, string newResourceName, string organizationalDir){ throw new NotImplementedException(); }
		public static bool CallRemote (string host, string queueName, int connectionAttempts, int connectTimeout, string resourceName, string functionName, dynamic callbackFunction){ throw new NotImplementedException(); }
		public static Element CreateResource (string resourceName, string organizationalDir){ throw new NotImplementedException(); }
		public static dynamic GetResourceACLRequests (Element theResource){ throw new NotImplementedException(); }
		public static bool DeleteResource (string resourceName){ throw new NotImplementedException(); }
		public static string GetResourceInfo (Element theResource, string attribute){ throw new NotImplementedException(); }
		public static string GetResourceLoadFailureReason (Element theResource){ throw new NotImplementedException(); }
		public static int GetResourceLoadTime (Element res){ throw new NotImplementedException(); }
		public static Element GetResourceMapRootElement (Element theResource, string mapName){ throw new NotImplementedException(); }
		public static int GetResourceLastStartTime (Element theResource){ throw new NotImplementedException(); }
		public static string GetResourceOrganizationalPath (Element theResource){ throw new NotImplementedException(); }
		public static dynamic GetResources (){ throw new NotImplementedException(); }
		public static bool RefreshResources (bool refreshAll, Element targetResource){ throw new NotImplementedException(); }
		public static bool IsResourceArchived (Element resourceElement){ throw new NotImplementedException(); }
		public static bool RenameResource (string resourceName, string newResourceName, string organizationalPath){ throw new NotImplementedException(); }
		public static bool RemoveResourceFile (Element theResource, string fileName){ throw new NotImplementedException(); }
		public static bool StartResource (Element resourceToStart, bool persistent, bool startIncludedResources, bool loadServerConfigs, bool loadMaps, bool loadServerScripts, bool loadHTML, bool loadClientConfigs, bool loadClientScripts, bool loadFiles){ throw new NotImplementedException(); }
		public static bool RestartResource (Element theResource, bool persistent, bool configs, bool maps, bool scripts, bool html, bool clientConfigs, bool clientScripts, bool clientFiles){ throw new NotImplementedException(); }
		public static bool StopResource (Element theResource){ throw new NotImplementedException(); }
		public static bool SetResourceInfo (Element theResource, string attribute, string value){ throw new NotImplementedException(); }
		public static bool UpdateResourceACLRequest (Element theResource, string rightName, bool access, string byWho){ throw new NotImplementedException(); }
		public static int GetMaxPlayers (){ throw new NotImplementedException(); }
		public static string GetServerName (){ throw new NotImplementedException(); }
		public static string GetServerPassword (){ throw new NotImplementedException(); }
		public static int GetServerHttpPort (){ throw new NotImplementedException(); }
		public static int GetServerPort (){ throw new NotImplementedException(); }
		public static bool IsGlitchEnabled (string glitchName){ throw new NotImplementedException(); }
		public static bool SetMaxPlayers (int slots){ throw new NotImplementedException(); }
		public static bool Shutdown (string reason){ throw new NotImplementedException(); }
		public static bool SetServerPassword (string thePassword){ throw new NotImplementedException(); }
		public static bool SetGlitchEnabled (string glitchName, bool enable){ throw new NotImplementedException(); }
		public static dynamic Get (string settingName){ throw new NotImplementedException(); }
		public static bool Set (string settingName, dynamic value){ throw new NotImplementedException(); }
		public static dynamic ExecuteSQLQuery (string query, dynamic param1, dynamic param2){ throw new NotImplementedException(); }
		public static bool DbExec (Element databaseConnection, string query, dynamic param1, dynamic param2){ throw new NotImplementedException(); }
		public static Element DbConnect (string databaseType, string host, string username, string password, string options){ throw new NotImplementedException(); }
		public static bool DbFree (Element queryHandle){ throw new NotImplementedException(); }
		public static string DbPrepareString (Element databaseConnection, string query, dynamic param1, dynamic param2){ throw new NotImplementedException(); }
		public static dynamic DbPoll (Element queryHandle, int timeout, bool multipleResults){ throw new NotImplementedException(); }
		public static Element DbQuery (dynamic callbackFunction, dynamic callbackArguments, Element databaseConnection, string query, dynamic param1, dynamic param2){ throw new NotImplementedException(); }
		public static Element CreateTeam (string teamName, int colorR, int colorG, int colorB){ throw new NotImplementedException(); }
		public static bool SetTeamColor (Element theTeam, int colorR, int colorG, int colorB){ throw new NotImplementedException(); }
		public static bool SetTeamFriendlyFire (Element theTeam, bool friendlyFire){ throw new NotImplementedException(); }
		public static bool SetTeamName (Element theTeam, string newName){ throw new NotImplementedException(); }
		public static Element TextCreateDisplay (){ throw new NotImplementedException(); }
		public static Element TextCreateTextItem (string text, float x, float y, string priority, int red, int green, int blue, int alpha, float scale, string alignX, string alignY, int shadowAlpha){ throw new NotImplementedException(); }
		public static bool TextDestroyDisplay (Element display){ throw new NotImplementedException(); }
		public static dynamic TextDestroyTextItem (Element theTextitem){ throw new NotImplementedException(); }
		public static dynamic TextDisplayAddObserver (Element display, Element playerToAdd){ throw new NotImplementedException(); }
		public static dynamic TextDisplayAddText (Element displayToAddTo, Element itemToAdd){ throw new NotImplementedException(); }
		public static dynamic TextDisplayGetObservers (Element theDisplay){ throw new NotImplementedException(); }
		public static bool TextDisplayRemoveObserver (Element display, Element playerToRemove){ throw new NotImplementedException(); }
		public static bool TextDisplayIsObserver (Element display, Element thePlayer){ throw new NotImplementedException(); }
		public static Tuple<int, int, int, int> TextItemGetColor (Element theTextItem){ throw new NotImplementedException(); }
		public static dynamic TextDisplayRemoveText (Element displayToRemoveFrom, Element itemToRemove){ throw new NotImplementedException(); }
		public static Tuple<float, float> TextItemGetPosition (Element theTextItem){ throw new NotImplementedException(); }
		public static int TextItemGetPriority (Element textitemToCheck){ throw new NotImplementedException(); }
		public static float TextItemGetScale (Element theTextitem){ throw new NotImplementedException(); }
		public static string TextItemGetText (Element theTextitem){ throw new NotImplementedException(); }
		public static bool TextItemSetColor (Element theTextItem, int r, int g, int b, int a){ throw new NotImplementedException(); }
		public static bool TextItemSetPosition (Element theTextItem, float x, float y){ throw new NotImplementedException(); }
		public static bool TextItemSetScale (Element theTextitem, float scale){ throw new NotImplementedException(); }
		public static dynamic TextItemSetPriority (Element theTextItem, string priority){ throw new NotImplementedException(); }
		public static dynamic TextItemSetText (Element theTextitem, string text){ throw new NotImplementedException(); }
		public static dynamic GetNetworkStats (Element thePlayer){ throw new NotImplementedException(); }
		public static string GetServerConfigSetting (string name){ throw new NotImplementedException(); }
		public static bool SetServerConfigSetting (string name, string value, bool bSave){ throw new NotImplementedException(); }
		public static dynamic GetModelHandling (int modelId){ throw new NotImplementedException(); }
		public static bool BlowVehicle (Element vehicleToBlow, bool explode){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetVehicleRespawnRotation (Element theVehicle){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetVehicleRespawnPosition (Element theVehicle){ throw new NotImplementedException(); }
		public static bool ResetVehicleExplosionTime (Element theVehicle){ throw new NotImplementedException(); }
		public static dynamic GetVehiclesOfType (int model){ throw new NotImplementedException(); }
		public static bool ResetVehicleIdleTime (Element theVehicle){ throw new NotImplementedException(); }
		public static bool RemoveVehicleSirens (Element theVehicle){ throw new NotImplementedException(); }
		public static bool AddVehicleSirens (Element theVehicle, int sirenCount, int sirenType, bool argument_360flag, bool checkLosFlag, bool useRandomiser, bool silentFlag){ throw new NotImplementedException(); }
		public static bool SetModelHandling (int modelId, string property, dynamic value){ throw new NotImplementedException(); }
		public static bool RespawnVehicle (Element theVehicle){ throw new NotImplementedException(); }
		public static bool SetVehicleIdleRespawnDelay (Element theVehicle, int timeDelay){ throw new NotImplementedException(); }
		public static bool SetVehicleRespawnPosition (Element theVehicle, float x, float y, float z, float rx, float ry, float rz){ throw new NotImplementedException(); }
		public static bool SetVehicleRespawnDelay (Element theVehicle, int timeDelay){ throw new NotImplementedException(); }
		public static bool SetVehicleVariant (Element theVehicle, int variant1, int variant2){ throw new NotImplementedException(); }
		public static bool SpawnVehicle (Element theVehicle, float x, float y, float z, float rx, float ry, float rz){ throw new NotImplementedException(); }
		public static bool SetVehicleRespawnRotation (Element theVehicle, float rx, float ry, float rz){ throw new NotImplementedException(); }
		public static bool ToggleVehicleRespawn (Element theVehicle, bool Respawn){ throw new NotImplementedException(); }
		public static bool GiveWeapon (Element thePlayer, int weapon, int ammo, bool setAsCurrent){ throw new NotImplementedException(); }
		public static bool TakeAllWeapons (Element thePed){ throw new NotImplementedException(); }
		public static bool TakeWeapon (Element thePlayer, int weaponId, int ammo){ throw new NotImplementedException(); }
		public static bool GetJetpackWeaponEnabled (string weapon){ throw new NotImplementedException(); }
		public static bool SetJetpackWeaponEnabled (string weapon, bool enabled){ throw new NotImplementedException(); }
	}
}