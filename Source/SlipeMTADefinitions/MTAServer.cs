using System;

namespace Slipe.MTADefinitions {
	public class MTAServer {
		public static dynamic GetAccounts (){ throw new NotImplementedException(); }
		public static string GetAccountSerial (MTAAccount theAccount){ throw new NotImplementedException(); }
		public static dynamic GetAccountsBySerial (string serial){ throw new NotImplementedException(); }
		public static string GetAccountData (MTAAccount theAccount, string key){ throw new NotImplementedException(); }
		public static MTAAccount AddAccount (string name, string pass, bool allowCaseVariations){ throw new NotImplementedException(); }
		public static MTAAccount GetPlayerAccount (MTAElement thePlayer){ throw new NotImplementedException(); }
		public static dynamic GetAllAccountData (MTAAccount theAccount){ throw new NotImplementedException(); }
		public static int GetAccountID (MTAAccount theAccount){ throw new NotImplementedException(); }
		public static bool SetAccountPassword (MTAAccount theAccount, string password){ throw new NotImplementedException(); }
		public static bool LogOut (MTAElement thePlayer){ throw new NotImplementedException(); }
		public static string GetAccountName (MTAAccount theAccount){ throw new NotImplementedException(); }
		public static MTAAccount GetAccountByID (int id){ throw new NotImplementedException(); }
		public static string GetAccountIP (MTAAccount theAccount){ throw new NotImplementedException(); }
		public static bool LogIn (MTAElement thePlayer, MTAAccount theAccount, string thePassword){ throw new NotImplementedException(); }
		public static bool SetAccountData (MTAAccount theAccount, string key, string value){ throw new NotImplementedException(); }
		public static bool RemoveAccount (MTAAccount theAccount){ throw new NotImplementedException(); }
		public static bool SetAccountName (MTAAccount theAccount, string name, bool allowCaseVariations){ throw new NotImplementedException(); }
		public static MTAElement GetAccountPlayer (MTAAccount theAccount){ throw new NotImplementedException(); }
		public static MTAAccount GetAccount (string username, string password, bool caseSensitive){ throw new NotImplementedException(); }
		public static bool IsGuestAccount (MTAAccount theAccount){ throw new NotImplementedException(); }
		public static dynamic GetAccountsByData (string dataName, string value){ throw new NotImplementedException(); }
		public static bool CopyAccountData (MTAAccount theAccount, MTAAccount fromAccount){ throw new NotImplementedException(); }
		public static dynamic GetAccountsByIP (string ip){ throw new NotImplementedException(); }
		public static MTAAclGroup AclCreateGroup (string groupName){ throw new NotImplementedException(); }
		public static MTAAcl AclCreate (string aclName){ throw new NotImplementedException(); }
		public static MTAAcl AclGet (string aclName){ throw new NotImplementedException(); }
		public static bool AclDestroy (MTAAcl theACL){ throw new NotImplementedException(); }
		public static MTAAclGroup AclGetGroup (string groupName){ throw new NotImplementedException(); }
		public static bool AclDestroyGroup (MTAAclGroup aclGroup){ throw new NotImplementedException(); }
		public static string AclGetName (MTAAcl theAcl){ throw new NotImplementedException(); }
		public static bool AclGetRight (MTAAcl theAcl, string rightName){ throw new NotImplementedException(); }
		public static bool AclGroupAddObject (MTAAclGroup theGroup, string theObjectName){ throw new NotImplementedException(); }
		public static bool AclGroupAddACL (MTAAclGroup theGroup, MTAAcl theACL){ throw new NotImplementedException(); }
		public static string AclGroupGetName (MTAAclGroup aclGroup){ throw new NotImplementedException(); }
		public static bool AclGroupRemoveACL (MTAAclGroup theGroup, MTAAcl theACL){ throw new NotImplementedException(); }
		public static dynamic AclGroupList (){ throw new NotImplementedException(); }
		public static dynamic AclGroupListACL (MTAAclGroup theGroup){ throw new NotImplementedException(); }
		public static dynamic AclGroupListObjects (MTAAclGroup theGroup){ throw new NotImplementedException(); }
		public static bool AclGroupRemoveObject (MTAAclGroup theGroup, string theObjectString){ throw new NotImplementedException(); }
		public static dynamic AclList (){ throw new NotImplementedException(); }
		public static bool AclReload (){ throw new NotImplementedException(); }
		public static bool AclSave (){ throw new NotImplementedException(); }
		public static dynamic AclListRights (MTAAcl theACL, string allowedType){ throw new NotImplementedException(); }
		public static bool AclRemoveRight (MTAAcl theAcl, string rightName){ throw new NotImplementedException(); }
		public static bool IsObjectInACLGroup (string theObject, MTAAclGroup theGroup){ throw new NotImplementedException(); }
		public static bool HasObjectPermissionTo (string parameter0, string theAction, bool defaultPermission){ throw new NotImplementedException(); }
		public static bool AclSetRight (MTAAcl theAcl, string rightName, bool hasAccess){ throw new NotImplementedException(); }
		public static MTABan AddBan (string IP, string Username, string Serial, MTAElement responsibleElement, string reason, int seconds){ throw new NotImplementedException(); }
		public static MTABan BanPlayer (MTAElement bannedPlayer, bool IP, bool Username, bool Serial, dynamic responsiblePlayer, string reason, int seconds){ throw new NotImplementedException(); }
		public static string GetBanAdmin (MTABan theBan){ throw new NotImplementedException(); }
		public static string GetBanIP (MTABan theBan){ throw new NotImplementedException(); }
		public static string GetBanNick (MTABan theBan){ throw new NotImplementedException(); }
		public static int GetBanTime (MTABan theBan){ throw new NotImplementedException(); }
		public static dynamic GetBans (){ throw new NotImplementedException(); }
		public static string GetBanReason (MTABan theBan){ throw new NotImplementedException(); }
		public static string GetBanSerial (MTABan theBan){ throw new NotImplementedException(); }
		public static bool IsBan (MTABan theBan){ throw new NotImplementedException(); }
		public static bool KickPlayer (MTAElement kickedPlayer, dynamic responsiblePlayer, string reason){ throw new NotImplementedException(); }
		public static string GetBanUsername (MTABan theBan){ throw new NotImplementedException(); }
		public static int GetUnbanTime (MTABan theBan){ throw new NotImplementedException(); }
		public static bool SetBanAdmin (MTABan theBan, string theAdmin){ throw new NotImplementedException(); }
		public static bool SetBanNick (MTABan theBan, string theNick){ throw new NotImplementedException(); }
		public static string GetMapName (){ throw new NotImplementedException(); }
		public static bool SetUnbanTime (MTABan theBan, int theTime){ throw new NotImplementedException(); }
		public static bool SetBanReason (MTABan theBan, string theReason){ throw new NotImplementedException(); }
		public static bool ReloadBans (){ throw new NotImplementedException(); }
		public static bool RemoveBan (MTABan theBan, MTAElement responsibleElement){ throw new NotImplementedException(); }
		public static bool PlaySoundFrontEnd (MTAElement thePlayer, int sound){ throw new NotImplementedException(); }
		public static string GetRuleValue (string key){ throw new NotImplementedException(); }
		public static string GetGameType (){ throw new NotImplementedException(); }
		public static bool SetGameType (string gameType){ throw new NotImplementedException(); }
		public static bool SetMapName (string mapName){ throw new NotImplementedException(); }
		public static bool RemoveRuleValue (string key){ throw new NotImplementedException(); }
		public static MTAElement CreateBlip (float x, float y, float z, int icon, int size, int r, int g, int b, int a, int ordering, float visibleDistance, MTAElement visibleTo){ throw new NotImplementedException(); }
		public static MTAElement CreateBlipAttachedTo (MTAElement elementToAttachTo, int icon, int size, int r, int g, int b, int a, int ordering, float visibleDistance, MTAElement visibleTo){ throw new NotImplementedException(); }
		public static bool SetRuleValue (string key, string value){ throw new NotImplementedException(); }
		public static bool FadeCamera (MTAElement thePlayer, bool fadeIn, float timeToFade, int red, int green, int blue){ throw new NotImplementedException(); }
		public static Tuple<float, float, float, float, float, float, float, float> GetCameraMatrix (MTAElement thePlayer){ throw new NotImplementedException(); }
		public static int GetCameraInterior (MTAElement thePlayer){ throw new NotImplementedException(); }
		public static MTAElement GetCameraTarget (MTAElement thePlayer){ throw new NotImplementedException(); }
		public static bool SetCameraInterior (MTAElement thePlayer, int interior){ throw new NotImplementedException(); }
		public static bool SetCameraTarget (MTAElement thePlayer, MTAElement target){ throw new NotImplementedException(); }
		public static bool SetCameraMatrix (MTAElement thePlayer, float positionX, float positionY, float positionZ, float lookAtX, float lookAtY, float lookAtZ, float roll, float fov){ throw new NotImplementedException(); }
		public static bool IsCursorShowing (MTAElement thePlayer){ throw new NotImplementedException(); }
		public static bool ShowCursor (MTAElement thePlayer, bool show, bool toggleControls){ throw new NotImplementedException(); }
		public static MTAElement CloneElement (MTAElement theElement, float xPos, float yPos, float zPos, bool cloneChildren){ throw new NotImplementedException(); }
		public static bool ClearElementVisibleTo (MTAElement theElement){ throw new NotImplementedException(); }
		public static dynamic GetAllElementData (MTAElement theElement){ throw new NotImplementedException(); }
		public static MTAElement GetElementByIndex (string theType, int index){ throw new NotImplementedException(); }
		public static MTAElement GetElementSyncer (MTAElement theElement){ throw new NotImplementedException(); }
		public static dynamic GetElementsByType (string theType, MTAElement startat){ throw new NotImplementedException(); }
		public static string GetElementZoneName (MTAElement theElement, bool citiesonly){ throw new NotImplementedException(); }
		public static bool IsElementVisibleTo (MTAElement theElement, MTAElement visibleTo){ throw new NotImplementedException(); }
		public static bool RemoveElementData (MTAElement theElement, string key){ throw new NotImplementedException(); }
		public static bool SetElementSyncer (MTAElement theElement, MTAElement thePlayer){ throw new NotImplementedException(); }
		public static bool CancelEvent (bool cancel, string reason){ throw new NotImplementedException(); }
		public static bool SetElementVisibleTo (MTAElement theElement, MTAElement visibleTo, bool visible){ throw new NotImplementedException(); }
		public static bool CancelLatentEvent (MTAElement thePlayer, int handle){ throw new NotImplementedException(); }
		public static dynamic GetLatentEventHandles (MTAElement thePlayer){ throw new NotImplementedException(); }
		public static dynamic GetLatentEventStatus (MTAElement thePlayer, int handle){ throw new NotImplementedException(); }
		public static string GetCancelReason (){ throw new NotImplementedException(); }
		public static bool TriggerClientEvent (MTAElement targetElement, string eventName, MTAElement sourceElement, dynamic arguments){ throw new NotImplementedException(); }
		public static bool TriggerLatentClientEvent (dynamic sendTo){ throw new NotImplementedException(); }
		public static bool CreateExplosion (float x, float y, float z, int theType, MTAElement creator){ throw new NotImplementedException(); }
		public static bool BindKey (MTAElement thePlayer, string key, string keyState, dynamic handlerFunction, dynamic arguments){ throw new NotImplementedException(); }
		public static bool AddCommandHandler (string commandName, dynamic handlerFunction, bool restricted, bool caseSensitive){ throw new NotImplementedException(); }
		public static bool ExecuteCommandHandler (string commandName, MTAElement thePlayer, string args){ throw new NotImplementedException(); }
		public static dynamic GetFunctionsBoundToKey (MTAElement thePlayer, string key, string keyState){ throw new NotImplementedException(); }
		public static string GetKeyBoundToFunction (MTAElement thePlayer, dynamic theFunction){ throw new NotImplementedException(); }
		public static bool IsControlEnabled (MTAElement thePlayer, string control){ throw new NotImplementedException(); }
		public static bool IsKeyBound (MTAElement thePlayer, string key, string keyState, dynamic handler){ throw new NotImplementedException(); }
		public static bool GetControlState (MTAElement thePlayer, string controlName){ throw new NotImplementedException(); }
		public static bool ToggleAllControls (MTAElement thePlayer, bool enabled, bool gtaControls, bool mtaControls){ throw new NotImplementedException(); }
		public static bool ToggleControl (MTAElement thePlayer, string control, bool enabled){ throw new NotImplementedException(); }
		public static MTAElement LoadMapData (MTAElement node, MTAElement parent){ throw new NotImplementedException(); }
		public static bool UnbindKey (MTAElement thePlayer, string key, string keyState, string command){ throw new NotImplementedException(); }
		public static bool ResetMapInfo (MTAElement thePlayer){ throw new NotImplementedException(); }
		public static MTAElement CreateMarker (float x, float y, float z, string theType, float size, int r, int g, int b, int a, MTAElement visibleTo){ throw new NotImplementedException(); }
		public static bool SaveMapData (MTAElement node, MTAElement baseElement, bool childrenOnly){ throw new NotImplementedException(); }
		public static dynamic GetModuleInfo (string moduleName){ throw new NotImplementedException(); }
		public static dynamic GetLoadedModules (){ throw new NotImplementedException(); }
		public static bool ClearChatBox (MTAElement clearFor){ throw new NotImplementedException(); }
		public static bool OutputConsole (string text, MTAElement visibleTo){ throw new NotImplementedException(); }
		public static bool OutputChatBox (string text, MTAElement visibleTo){ throw new NotImplementedException(); }
		public static bool ShowChat (MTAElement thePlayer, bool show){ throw new NotImplementedException(); }
		public static bool OutputServerLog (string text){ throw new NotImplementedException(); }
		public static MTAElement CreatePed (int modelid, float x, float y, float z, float rot, bool synced){ throw new NotImplementedException(); }
		public static float GetPedGravity (MTAElement thePed){ throw new NotImplementedException(); }
		public static bool ReloadPedWeapon (MTAElement thePed){ throw new NotImplementedException(); }
		public static bool SetPedArmor (MTAElement thePed, float armor){ throw new NotImplementedException(); }
		public static bool SetPedChoking (MTAElement thePed, bool choking){ throw new NotImplementedException(); }
		public static bool SetPedFightingStyle (MTAElement thePed, int style){ throw new NotImplementedException(); }
		public static bool SetPedGravity (MTAElement thePed, float gravity){ throw new NotImplementedException(); }
		public static bool SetPedWearingJetpack (MTAElement thePed, bool state){ throw new NotImplementedException(); }
		public static int GetPickupRespawnInterval (MTAElement thePickup){ throw new NotImplementedException(); }
		public static bool IsPickupSpawned (MTAElement thePickup){ throw new NotImplementedException(); }
		public static bool SetPickupRespawnInterval (MTAElement thePickup, int ms){ throw new NotImplementedException(); }
		public static bool ForcePlayerMap (MTAElement thePlayer, bool forceOn){ throw new NotImplementedException(); }
		public static dynamic GetAlivePlayers (){ throw new NotImplementedException(); }
		public static dynamic GetDeadPlayers (){ throw new NotImplementedException(); }
		public static int GetPlayerBlurLevel (MTAElement thePlayer){ throw new NotImplementedException(); }
		public static dynamic GetPlayerACInfo (MTAElement thePlayer){ throw new NotImplementedException(); }
		public static string GetPlayerIP (MTAElement thePlayer){ throw new NotImplementedException(); }
		public static int GetPlayerMoney (MTAElement thePlayer){ throw new NotImplementedException(); }
		public static int GetPlayerCount (){ throw new NotImplementedException(); }
		public static int GetPlayerIdleTime (MTAElement thePlayer){ throw new NotImplementedException(); }
		public static string GetPlayerSerial (MTAElement thePlayer){ throw new NotImplementedException(); }
		public static string GetPlayerVersion (MTAElement thePlayer){ throw new NotImplementedException(); }
		public static MTAElement GetRandomPlayer (){ throw new NotImplementedException(); }
		public static bool IsPlayerMapForced (MTAElement thePlayer){ throw new NotImplementedException(); }
		public static bool GivePlayerMoney (MTAElement thePlayer, int amount){ throw new NotImplementedException(); }
		public static int GetPlayerWantedLevel (MTAElement thePlayer){ throw new NotImplementedException(); }
		public static bool IsPlayerMuted (MTAElement thePlayer){ throw new NotImplementedException(); }
		public static bool ResendPlayerACInfo (MTAElement thePlayer){ throw new NotImplementedException(); }
		public static bool ResendPlayerModInfo (MTAElement thePlayer){ throw new NotImplementedException(); }
		public static bool SetPlayerBlurLevel (MTAElement thePlayer, int level){ throw new NotImplementedException(); }
		public static bool SetPlayerAnnounceValue (MTAElement thePlayer, string key, string value){ throw new NotImplementedException(); }
		public static bool SetPlayerMoney (MTAElement thePlayer, int amount, bool instant){ throw new NotImplementedException(); }
		public static bool SetPlayerMuted (MTAElement thePlayer, bool state){ throw new NotImplementedException(); }
		public static bool SetPlayerHudComponentVisible (MTAElement thePlayer, string component, bool show){ throw new NotImplementedException(); }
		public static bool RedirectPlayer (MTAElement thePlayer, string serverIP, int serverPort, string serverPassword){ throw new NotImplementedException(); }
		public static bool SetPlayerName (MTAElement thePlayer, string newName){ throw new NotImplementedException(); }
		public static bool SetPlayerTeam (MTAElement thePlayer, MTAElement theTeam){ throw new NotImplementedException(); }
		public static bool TakePlayerMoney (MTAElement thePlayer, int amount){ throw new NotImplementedException(); }
		public static bool SetPlayerVoiceIgnoreFrom (MTAElement thePlayer, dynamic ignoreFrom){ throw new NotImplementedException(); }
		public static bool TakePlayerScreenShot (MTAElement thePlayer, int width, int height, string tag, int quality, int maxBandwith, int maxPacketSize){ throw new NotImplementedException(); }
		public static bool SpawnPlayer (MTAElement thePlayer, float x, float y, float z, int rotation, int skinID, int interior, int dimension, MTAElement theTeam){ throw new NotImplementedException(); }
		public static bool DetonateSatchels (MTAElement Player){ throw new NotImplementedException(); }
		public static bool SetPlayerVoiceBroadcastTo (MTAElement thePlayer, dynamic broadcastTo){ throw new NotImplementedException(); }
		public static bool SetPlayerWantedLevel (MTAElement thePlayer, int stars){ throw new NotImplementedException(); }
		public static MTAResource CreateResource (string resourceName, string organizationalDir){ throw new NotImplementedException(); }
		public static MTAResource CopyResource (MTAResource theResource, string newResourceName, string organizationalDir){ throw new NotImplementedException(); }
		public static MTAElement AddResourceConfig (string filePath, string filetype){ throw new NotImplementedException(); }
		public static bool DeleteResource (string resourceName){ throw new NotImplementedException(); }
		public static bool CallRemote (string host, string queueName, int connectionAttempts, int connectTimeout, string resourceName, string functionName, dynamic callbackFunction){ throw new NotImplementedException(); }
		public static MTAElement AddResourceMap (string filePath, int dimension){ throw new NotImplementedException(); }
		public static dynamic GetResourceACLRequests (MTAResource theResource){ throw new NotImplementedException(); }
		public static string GetResourceInfo (MTAResource theResource, string attribute){ throw new NotImplementedException(); }
		public static int GetResourceLastStartTime (MTAResource theResource){ throw new NotImplementedException(); }
		public static int GetResourceLoadTime (MTAResource res){ throw new NotImplementedException(); }
		public static string GetResourceOrganizationalPath (MTAResource theResource){ throw new NotImplementedException(); }
		public static MTAElement GetResourceMapRootElement (MTAResource theResource, string mapName){ throw new NotImplementedException(); }
		public static string GetResourceLoadFailureReason (MTAResource theResource){ throw new NotImplementedException(); }
		public static dynamic GetResources (){ throw new NotImplementedException(); }
		public static bool RefreshResources (bool refreshAll, MTAResource targetResource){ throw new NotImplementedException(); }
		public static bool IsResourceArchived (MTAResource resourceElement){ throw new NotImplementedException(); }
		public static bool RemoveResourceFile (MTAResource theResource, string fileName){ throw new NotImplementedException(); }
		public static string GetPlayerAnnounceValue (MTAElement thePlayer, string key){ throw new NotImplementedException(); }
		public static bool RenameResource (string resourceName, string newResourceName, string organizationalPath){ throw new NotImplementedException(); }
		public static bool SetResourceInfo (MTAResource theResource, string attribute, string value){ throw new NotImplementedException(); }
		public static bool RestartResource (MTAResource theResource, bool persistent, bool configs, bool maps, bool scripts, bool html, bool clientConfigs, bool clientScripts, bool clientFiles){ throw new NotImplementedException(); }
		public static bool StartResource (MTAResource resourceToStart, bool persistent, bool startIncludedResources, bool loadServerConfigs, bool loadMaps, bool loadServerScripts, bool loadHTML, bool loadClientConfigs, bool loadClientScripts, bool loadFiles){ throw new NotImplementedException(); }
		public static bool StopResource (MTAResource theResource){ throw new NotImplementedException(); }
		public static bool UpdateResourceACLRequest (MTAResource theResource, string rightName, bool access, string byWho){ throw new NotImplementedException(); }
		public static int GetServerHttpPort (){ throw new NotImplementedException(); }
		public static int GetMaxPlayers (){ throw new NotImplementedException(); }
		public static string GetServerName (){ throw new NotImplementedException(); }
		public static int GetServerPort (){ throw new NotImplementedException(); }
		public static bool IsGlitchEnabled (string glitchName){ throw new NotImplementedException(); }
		public static bool SetGlitchEnabled (string glitchName, bool enable){ throw new NotImplementedException(); }
		public static bool SetMaxPlayers (int slots){ throw new NotImplementedException(); }
		public static string GetServerPassword (){ throw new NotImplementedException(); }
		public static bool SetServerPassword (string thePassword){ throw new NotImplementedException(); }
		public static bool Shutdown (string reason){ throw new NotImplementedException(); }
		public static bool Set (string settingName, dynamic value){ throw new NotImplementedException(); }
		public static dynamic Get (string settingName){ throw new NotImplementedException(); }
		public static dynamic ExecuteSQLQuery (string query, dynamic param1, dynamic param2){ throw new NotImplementedException(); }
		public static bool DbExec (MTAElement databaseConnection, string query, dynamic param1, dynamic param2){ throw new NotImplementedException(); }
		public static bool DbFree (MTAElement queryHandle){ throw new NotImplementedException(); }
		public static dynamic DbPoll (MTAElement queryHandle, int timeout, bool multipleResults){ throw new NotImplementedException(); }
		public static string DbPrepareString (MTAElement databaseConnection, string query, dynamic param1, dynamic param2){ throw new NotImplementedException(); }
		public static MTAElement DbQuery (dynamic callbackFunction, dynamic callbackArguments, MTAElement databaseConnection, string query, dynamic param1, dynamic param2){ throw new NotImplementedException(); }
		public static MTAElement CreateTeam (string teamName, int colorR, int colorG, int colorB){ throw new NotImplementedException(); }
		public static MTAElement DbConnect (string databaseType, string host, string username, string password, string options){ throw new NotImplementedException(); }
		public static bool SetTeamColor (MTAElement theTeam, int colorR, int colorG, int colorB){ throw new NotImplementedException(); }
		public static MTAElement TextCreateDisplay (){ throw new NotImplementedException(); }
		public static bool SetTeamFriendlyFire (MTAElement theTeam, bool friendlyFire){ throw new NotImplementedException(); }
		public static bool SetTeamName (MTAElement theTeam, string newName){ throw new NotImplementedException(); }
		public static MTAElement TextCreateTextItem (string text, float x, float y, string priority, int red, int green, int blue, int alpha, float scale, string alignX, string alignY, int shadowAlpha){ throw new NotImplementedException(); }
		public static dynamic TextDestroyTextItem (MTAElement theTextitem){ throw new NotImplementedException(); }
		public static dynamic TextDisplayAddObserver (MTAElement display, MTAElement playerToAdd){ throw new NotImplementedException(); }
		public static bool TextDestroyDisplay (MTAElement display){ throw new NotImplementedException(); }
		public static dynamic TextDisplayAddText (MTAElement displayToAddTo, MTAElement itemToAdd){ throw new NotImplementedException(); }
		public static dynamic TextDisplayGetObservers (MTAElement theDisplay){ throw new NotImplementedException(); }
		public static dynamic TextDisplayRemoveText (MTAElement displayToRemoveFrom, MTAElement itemToRemove){ throw new NotImplementedException(); }
		public static bool TextDisplayRemoveObserver (MTAElement display, MTAElement playerToRemove){ throw new NotImplementedException(); }
		public static Tuple<float, float> TextItemGetPosition (MTAElement theTextItem){ throw new NotImplementedException(); }
		public static Tuple<int, int, int, int> TextItemGetColor (MTAElement theTextItem){ throw new NotImplementedException(); }
		public static float TextItemGetScale (MTAElement theTextitem){ throw new NotImplementedException(); }
		public static int TextItemGetPriority (MTAElement textitemToCheck){ throw new NotImplementedException(); }
		public static string TextItemGetText (MTAElement theTextitem){ throw new NotImplementedException(); }
		public static bool TextDisplayIsObserver (MTAElement display, MTAElement thePlayer){ throw new NotImplementedException(); }
		public static dynamic TextItemSetPriority (MTAElement theTextItem, string priority){ throw new NotImplementedException(); }
		public static bool TextItemSetColor (MTAElement theTextItem, int r, int g, int b, int a){ throw new NotImplementedException(); }
		public static bool TextItemSetPosition (MTAElement theTextItem, float x, float y){ throw new NotImplementedException(); }
		public static dynamic TextItemSetText (MTAElement theTextitem, string text){ throw new NotImplementedException(); }
		public static bool TextItemSetScale (MTAElement theTextitem, float scale){ throw new NotImplementedException(); }
		public static dynamic GetNetworkStats (MTAElement thePlayer){ throw new NotImplementedException(); }
		public static string GetServerConfigSetting (string name){ throw new NotImplementedException(); }
		public static bool SetServerConfigSetting (string name, string value, bool bSave){ throw new NotImplementedException(); }
		public static bool AddVehicleSirens (MTAElement theVehicle, int sirenCount, int sirenType, bool argument_360flag, bool checkLosFlag, bool useRandomiser, bool silentFlag){ throw new NotImplementedException(); }
		public static bool BlowVehicle (MTAElement vehicleToBlow, bool explode){ throw new NotImplementedException(); }
		public static dynamic GetModelHandling (int modelId){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetVehicleRespawnPosition (MTAElement theVehicle){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetVehicleRespawnRotation (MTAElement theVehicle){ throw new NotImplementedException(); }
		public static dynamic GetVehiclesOfType (int model){ throw new NotImplementedException(); }
		public static bool RemoveVehicleSirens (MTAElement theVehicle){ throw new NotImplementedException(); }
		public static bool ResetVehicleExplosionTime (MTAElement theVehicle){ throw new NotImplementedException(); }
		public static bool ResetVehicleIdleTime (MTAElement theVehicle){ throw new NotImplementedException(); }
		public static bool SetModelHandling (int modelId, string property, dynamic value){ throw new NotImplementedException(); }
		public static bool RespawnVehicle (MTAElement theVehicle){ throw new NotImplementedException(); }
		public static bool SetVehicleIdleRespawnDelay (MTAElement theVehicle, int timeDelay){ throw new NotImplementedException(); }
		public static bool SetVehicleRespawnRotation (MTAElement theVehicle, float rx, float ry, float rz){ throw new NotImplementedException(); }
		public static bool SetVehicleRespawnPosition (MTAElement theVehicle, float x, float y, float z, float rx, float ry, float rz){ throw new NotImplementedException(); }
		public static bool SetVehicleRespawnDelay (MTAElement theVehicle, int timeDelay){ throw new NotImplementedException(); }
		public static bool SetVehicleVariant (MTAElement theVehicle, int variant1, int variant2){ throw new NotImplementedException(); }
		public static bool SpawnVehicle (MTAElement theVehicle, float x, float y, float z, float rx, float ry, float rz){ throw new NotImplementedException(); }
		public static bool ToggleVehicleRespawn (MTAElement theVehicle, bool Respawn){ throw new NotImplementedException(); }
		public static bool GiveWeapon (MTAElement thePlayer, int weapon, int ammo, bool setAsCurrent){ throw new NotImplementedException(); }
		public static bool TakeAllWeapons (MTAElement thePed){ throw new NotImplementedException(); }
		public static bool TakeWeapon (MTAElement thePlayer, int weaponId, int ammo){ throw new NotImplementedException(); }
		public static bool GetJetpackWeaponEnabled (string weapon){ throw new NotImplementedException(); }
		public static bool SetJetpackWeaponEnabled (string weapon, bool enabled){ throw new NotImplementedException(); }
	}
}