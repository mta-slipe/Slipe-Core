using System;

namespace Slipe.MtaDefinitions {
	public class MtaServer {
		public static dynamic GetAccounts (){ throw new NotImplementedException(); }
		public static MtaAccount AddAccount (string name, string pass, bool allowCaseVariations){ throw new NotImplementedException(); }
		public static dynamic GetAllAccountData (MtaAccount theAccount){ throw new NotImplementedException(); }
		public static bool CopyAccountData (MtaAccount theAccount, MtaAccount fromAccount){ throw new NotImplementedException(); }
		public static MtaElement GetAccountPlayer (MtaAccount theAccount){ throw new NotImplementedException(); }
		public static dynamic GetAccountsBySerial (string serial){ throw new NotImplementedException(); }
		public static MtaAccount GetAccount (string username, string password, bool caseSensitive){ throw new NotImplementedException(); }
		public static string GetAccountName (MtaAccount theAccount){ throw new NotImplementedException(); }
		public static bool IsGuestAccount (MtaAccount theAccount){ throw new NotImplementedException(); }
		public static bool RemoveAccount (MtaAccount theAccount){ throw new NotImplementedException(); }
		public static bool SetAccountData (MtaAccount theAccount, string key, string value){ throw new NotImplementedException(); }
		public static bool LogOut (MtaElement thePlayer){ throw new NotImplementedException(); }
		public static bool LogIn (MtaElement thePlayer, MtaAccount theAccount, string thePassword){ throw new NotImplementedException(); }
		public static MtaAccount GetPlayerAccount (MtaElement thePlayer){ throw new NotImplementedException(); }
		public static string GetAccountData (MtaAccount theAccount, string key){ throw new NotImplementedException(); }
		public static string GetAccountSerial (MtaAccount theAccount){ throw new NotImplementedException(); }
		public static MtaAccount GetAccountByID (int id){ throw new NotImplementedException(); }
		public static bool SetAccountPassword (MtaAccount theAccount, string password){ throw new NotImplementedException(); }
		public static bool SetAccountName (MtaAccount theAccount, string name, bool allowCaseVariations){ throw new NotImplementedException(); }
		public static string GetAccountIP (MtaAccount theAccount){ throw new NotImplementedException(); }
		public static int GetAccountID (MtaAccount theAccount){ throw new NotImplementedException(); }
		public static dynamic GetAccountsByIP (string ip){ throw new NotImplementedException(); }
		public static dynamic GetAccountsByData (string dataName, string value){ throw new NotImplementedException(); }
		public static MtaAcl AclCreate (string aclName){ throw new NotImplementedException(); }
		public static bool AclDestroy (MtaAcl theACL){ throw new NotImplementedException(); }
		public static MtaAclGroup AclCreateGroup (string groupName){ throw new NotImplementedException(); }
		public static MtaAclGroup AclGetGroup (string groupName){ throw new NotImplementedException(); }
		public static MtaAcl AclGet (string aclName){ throw new NotImplementedException(); }
		public static bool AclDestroyGroup (MtaAclGroup aclGroup){ throw new NotImplementedException(); }
		public static string AclGetName (MtaAcl theAcl){ throw new NotImplementedException(); }
		public static bool AclGetRight (MtaAcl theAcl, string rightName){ throw new NotImplementedException(); }
		public static dynamic AclGroupListACL (MtaAclGroup theGroup){ throw new NotImplementedException(); }
		public static dynamic AclGroupList (){ throw new NotImplementedException(); }
		public static dynamic AclGroupListObjects (MtaAclGroup theGroup){ throw new NotImplementedException(); }
		public static bool AclGroupAddACL (MtaAclGroup theGroup, MtaAcl theACL){ throw new NotImplementedException(); }
		public static bool AclGroupAddObject (MtaAclGroup theGroup, string theObjectName){ throw new NotImplementedException(); }
		public static bool AclGroupRemoveACL (MtaAclGroup theGroup, MtaAcl theACL){ throw new NotImplementedException(); }
		public static dynamic AclListRights (MtaAcl theACL, string allowedType){ throw new NotImplementedException(); }
		public static bool AclGroupRemoveObject (MtaAclGroup theGroup, string theObjectString){ throw new NotImplementedException(); }
		public static string GetBanIP (MtaBan theBan){ throw new NotImplementedException(); }
		public static string AclGroupGetName (MtaAclGroup aclGroup){ throw new NotImplementedException(); }
		public static bool AclReload (){ throw new NotImplementedException(); }
		public static bool AclSetRight (MtaAcl theAcl, string rightName, bool hasAccess){ throw new NotImplementedException(); }
		public static bool IsObjectInACLGroup (string theObject, MtaAclGroup theGroup){ throw new NotImplementedException(); }
		public static bool AclRemoveRight (MtaAcl theAcl, string rightName){ throw new NotImplementedException(); }
		public static dynamic AclList (){ throw new NotImplementedException(); }
		public static bool AclSave (){ throw new NotImplementedException(); }
		public static MtaBan AddBan (string IP, string Username, string Serial, MtaElement responsibleElement, string reason, int seconds){ throw new NotImplementedException(); }
		public static bool HasObjectPermissionTo (string parameter0, string theAction, bool defaultPermission){ throw new NotImplementedException(); }
		public static MtaBan BanPlayer (MtaElement bannedPlayer, bool IP, bool Username, bool Serial, dynamic responsiblePlayer, string reason, int seconds){ throw new NotImplementedException(); }
		public static string GetBanAdmin (MtaBan theBan){ throw new NotImplementedException(); }
		public static dynamic GetBans (){ throw new NotImplementedException(); }
		public static string GetBanSerial (MtaBan theBan){ throw new NotImplementedException(); }
		public static string GetBanNick (MtaBan theBan){ throw new NotImplementedException(); }
		public static int GetBanTime (MtaBan theBan){ throw new NotImplementedException(); }
		public static string GetBanReason (MtaBan theBan){ throw new NotImplementedException(); }
		public static string GetBanUsername (MtaBan theBan){ throw new NotImplementedException(); }
		public static bool IsBan (MtaBan theBan){ throw new NotImplementedException(); }
		public static bool KickPlayer (MtaElement kickedPlayer, dynamic responsiblePlayer, string reason){ throw new NotImplementedException(); }
		public static bool SetBanNick (MtaBan theBan, string theNick){ throw new NotImplementedException(); }
		public static bool SetBanAdmin (MtaBan theBan, string theAdmin){ throw new NotImplementedException(); }
		public static bool SetUnbanTime (MtaBan theBan, int theTime){ throw new NotImplementedException(); }
		public static bool SetBanReason (MtaBan theBan, string theReason){ throw new NotImplementedException(); }
		public static int GetUnbanTime (MtaBan theBan){ throw new NotImplementedException(); }
		public static bool ReloadBans (){ throw new NotImplementedException(); }
		public static bool RemoveBan (MtaBan theBan, MtaElement responsibleElement){ throw new NotImplementedException(); }
		public static string GetGameType (){ throw new NotImplementedException(); }
		public static bool SetGameType (string gameType){ throw new NotImplementedException(); }
		public static bool PlaySoundFrontEnd (MtaElement thePlayer, int sound){ throw new NotImplementedException(); }
		public static string GetRuleValue (string key){ throw new NotImplementedException(); }
		public static bool RemoveRuleValue (string key){ throw new NotImplementedException(); }
		public static string GetMapName (){ throw new NotImplementedException(); }
		public static bool SetRuleValue (string key, string value){ throw new NotImplementedException(); }
		public static bool SetMapName (string mapName){ throw new NotImplementedException(); }
		public static MtaElement CreateBlip (float x, float y, float z, int icon, int size, int r, int g, int b, int a, int ordering, float visibleDistance, MtaElement visibleTo){ throw new NotImplementedException(); }
		public static MtaElement CreateBlipAttachedTo (MtaElement elementToAttachTo, int icon, int size, int r, int g, int b, int a, int ordering, float visibleDistance, MtaElement visibleTo){ throw new NotImplementedException(); }
		public static bool FadeCamera (MtaElement thePlayer, bool fadeIn, float timeToFade, int red, int green, int blue){ throw new NotImplementedException(); }
		public static int GetCameraInterior (MtaElement thePlayer){ throw new NotImplementedException(); }
		public static MtaElement GetCameraTarget (MtaElement thePlayer){ throw new NotImplementedException(); }
		public static bool SetCameraTarget (MtaElement thePlayer, MtaElement target){ throw new NotImplementedException(); }
		public static Tuple<float, float, float, float, float, float, float, float> GetCameraMatrix (MtaElement thePlayer){ throw new NotImplementedException(); }
		public static bool SetCameraInterior (MtaElement thePlayer, int interior){ throw new NotImplementedException(); }
		public static bool SetCameraMatrix (MtaElement thePlayer, float positionX, float positionY, float positionZ, float lookAtX, float lookAtY, float lookAtZ, float roll, float fov){ throw new NotImplementedException(); }
		public static bool IsCursorShowing (MtaElement thePlayer){ throw new NotImplementedException(); }
		public static bool ShowCursor (MtaElement thePlayer, bool show, bool toggleControls){ throw new NotImplementedException(); }
		public static bool ClearElementVisibleTo (MtaElement theElement){ throw new NotImplementedException(); }
		public static MtaElement CloneElement (MtaElement theElement, float xPos, float yPos, float zPos, bool cloneChildren){ throw new NotImplementedException(); }
		public static dynamic GetAllElementData (MtaElement theElement){ throw new NotImplementedException(); }
		public static MtaElement GetElementByIndex (string theType, int index){ throw new NotImplementedException(); }
		public static MtaElement GetElementSyncer (MtaElement theElement){ throw new NotImplementedException(); }
		public static string GetElementZoneName (MtaElement theElement, bool citiesonly){ throw new NotImplementedException(); }
		public static dynamic GetElementsByType (string theType, MtaElement startat){ throw new NotImplementedException(); }
		public static bool IsElementVisibleTo (MtaElement theElement, MtaElement visibleTo){ throw new NotImplementedException(); }
		public static bool RemoveElementData (MtaElement theElement, string key){ throw new NotImplementedException(); }
		public static bool SetElementVisibleTo (MtaElement theElement, MtaElement visibleTo, bool visible){ throw new NotImplementedException(); }
		public static bool SetElementSyncer (MtaElement theElement, MtaElement thePlayer){ throw new NotImplementedException(); }
		public static string GetCancelReason (){ throw new NotImplementedException(); }
		public static bool CancelEvent (bool cancel, string reason){ throw new NotImplementedException(); }
		public static bool CancelLatentEvent (MtaElement thePlayer, int handle){ throw new NotImplementedException(); }
		public static dynamic GetLatentEventStatus (MtaElement thePlayer, int handle){ throw new NotImplementedException(); }
		public static dynamic GetLatentEventHandles (MtaElement thePlayer){ throw new NotImplementedException(); }
		public static bool TriggerClientEvent (MtaElement targetElement, string eventName, MtaElement sourceElement, dynamic arguments){ throw new NotImplementedException(); }
		public static bool TriggerLatentClientEvent (dynamic sendTo){ throw new NotImplementedException(); }
		public static bool CreateExplosion (float x, float y, float z, int theType, MtaElement creator){ throw new NotImplementedException(); }
		public static bool BindKey (MtaElement thePlayer, string key, string keyState, dynamic handlerFunction, dynamic arguments){ throw new NotImplementedException(); }
		public static bool AddCommandHandler (string commandName, Action<MtaElement, string, string[]> handlerFunction, bool restricted, bool caseSensitive){ throw new NotImplementedException(); }
		public static bool ExecuteCommandHandler (string commandName, MtaElement thePlayer, string args){ throw new NotImplementedException(); }
		// Removed because of deprecation
		// public static bool GetControlState (MtaElement thePlayer, string controlName){ throw new NotImplementedException(); }
		public static dynamic GetFunctionsBoundToKey (MtaElement thePlayer, string key, string keyState){ throw new NotImplementedException(); }
		public static string GetKeyBoundToFunction (MtaElement thePlayer, dynamic theFunction){ throw new NotImplementedException(); }
		public static bool IsKeyBound (MtaElement thePlayer, string key, string keyState, dynamic handler){ throw new NotImplementedException(); }
		public static bool IsControlEnabled (MtaElement thePlayer, string control){ throw new NotImplementedException(); }
		public static bool ToggleAllControls (MtaElement thePlayer, bool enabled, bool gtaControls, bool mtaControls){ throw new NotImplementedException(); }
		public static bool ResetMapInfo (MtaElement thePlayer){ throw new NotImplementedException(); }
		public static MtaElement LoadMapData (MtaElement node, MtaElement parent){ throw new NotImplementedException(); }
		public static bool ToggleControl (MtaElement thePlayer, string control, bool enabled){ throw new NotImplementedException(); }
		public static bool UnbindKey (MtaElement thePlayer, string key, string keyState, string command){ throw new NotImplementedException(); }
		public static bool SaveMapData (MtaElement node, MtaElement baseElement, bool childrenOnly){ throw new NotImplementedException(); }
		public static MtaElement CreateMarker (float x, float y, float z, string theType, float size, int r, int g, int b, int a, MtaElement visibleTo){ throw new NotImplementedException(); }
		public static dynamic GetLoadedModules (){ throw new NotImplementedException(); }
		public static dynamic GetModuleInfo (string moduleName){ throw new NotImplementedException(); }
		public static bool OutputChatBox (string text, MtaElement visibleTo, int r, int g, int b, bool colorCoded){ throw new NotImplementedException(); }
		public static bool ClearChatBox (MtaElement clearFor){ throw new NotImplementedException(); }
		public static bool OutputConsole (string text, MtaElement visibleTo){ throw new NotImplementedException(); }
		public static bool OutputServerLog (string text){ throw new NotImplementedException(); }
		public static bool ShowChat (MtaElement thePlayer, bool show){ throw new NotImplementedException(); }
		public static MtaElement CreatePed (int modelid, float x, float y, float z, float rot, bool synced){ throw new NotImplementedException(); }
		public static float GetPedGravity (MtaElement thePed){ throw new NotImplementedException(); }
		public static bool SetPedFightingStyle (MtaElement thePed, int style){ throw new NotImplementedException(); }
		public static bool ReloadPedWeapon (MtaElement thePed){ throw new NotImplementedException(); }
		public static bool SetPedArmor (MtaElement thePed, float armor){ throw new NotImplementedException(); }
		public static bool SetPedChoking (MtaElement thePed, bool choking){ throw new NotImplementedException(); }
		public static bool SetPedGravity (MtaElement thePed, float gravity){ throw new NotImplementedException(); }
		public static bool SetPedWearingJetpack (MtaElement thePed, bool state){ throw new NotImplementedException(); }
		public static int GetPickupRespawnInterval (MtaElement thePickup){ throw new NotImplementedException(); }
		public static bool IsPickupSpawned (MtaElement thePickup){ throw new NotImplementedException(); }
		public static bool SetPickupRespawnInterval (MtaElement thePickup, int ms){ throw new NotImplementedException(); }
		public static bool ForcePlayerMap (MtaElement thePlayer, bool forceOn){ throw new NotImplementedException(); }
		public static dynamic GetAlivePlayers (){ throw new NotImplementedException(); }
		public static dynamic GetPlayerACInfo (MtaElement thePlayer){ throw new NotImplementedException(); }
		public static dynamic GetDeadPlayers (){ throw new NotImplementedException(); }
		public static int GetPlayerBlurLevel (MtaElement thePlayer){ throw new NotImplementedException(); }
		public static int GetPlayerCount (){ throw new NotImplementedException(); }
		public static string GetPlayerAnnounceValue (MtaElement thePlayer, string key){ throw new NotImplementedException(); }
		public static int GetPlayerIdleTime (MtaElement thePlayer){ throw new NotImplementedException(); }
		public static int GetPlayerMoney (MtaElement thePlayer){ throw new NotImplementedException(); }
		public static string GetPlayerIP (MtaElement thePlayer){ throw new NotImplementedException(); }
		public static string GetPlayerSerial (MtaElement thePlayer){ throw new NotImplementedException(); }
		public static int GetPlayerWantedLevel (MtaElement thePlayer){ throw new NotImplementedException(); }
		public static MtaElement GetRandomPlayer (){ throw new NotImplementedException(); }
		public static string GetPlayerVersion (MtaElement thePlayer){ throw new NotImplementedException(); }
		public static bool IsPlayerMuted (MtaElement thePlayer){ throw new NotImplementedException(); }
		public static bool GivePlayerMoney (MtaElement thePlayer, int amount){ throw new NotImplementedException(); }
		public static bool IsPlayerMapForced (MtaElement thePlayer){ throw new NotImplementedException(); }
		public static bool RedirectPlayer (MtaElement thePlayer, string serverIP, int serverPort, string serverPassword){ throw new NotImplementedException(); }
		public static bool ResendPlayerModInfo (MtaElement thePlayer){ throw new NotImplementedException(); }
		public static bool ResendPlayerACInfo (MtaElement thePlayer){ throw new NotImplementedException(); }
		public static bool SetPlayerAnnounceValue (MtaElement thePlayer, string key, string value){ throw new NotImplementedException(); }
		public static bool SetPlayerBlurLevel (MtaElement thePlayer, int level){ throw new NotImplementedException(); }
		public static bool SetPlayerHudComponentVisible (MtaElement thePlayer, string component, bool show){ throw new NotImplementedException(); }
		public static bool SetPlayerMoney (MtaElement thePlayer, int amount, bool instant){ throw new NotImplementedException(); }
		public static bool SetPlayerName (MtaElement thePlayer, string newName){ throw new NotImplementedException(); }
		public static bool SetPlayerMuted (MtaElement thePlayer, bool state){ throw new NotImplementedException(); }
		public static bool SetPlayerWantedLevel (MtaElement thePlayer, int stars){ throw new NotImplementedException(); }
		public static bool SetPlayerTeam (MtaElement thePlayer, MtaElement theTeam){ throw new NotImplementedException(); }
		public static bool SetPlayerVoiceBroadcastTo (MtaElement thePlayer, dynamic broadcastTo){ throw new NotImplementedException(); }
		public static bool SetPlayerVoiceIgnoreFrom (MtaElement thePlayer, dynamic ignoreFrom){ throw new NotImplementedException(); }
		public static bool TakePlayerMoney (MtaElement thePlayer, int amount){ throw new NotImplementedException(); }
		public static bool TakePlayerScreenShot (MtaElement thePlayer, int width, int height, string tag, int quality, int maxBandwith, int maxPacketSize){ throw new NotImplementedException(); }
		public static bool SpawnPlayer (MtaElement thePlayer, float x, float y, float z, int rotation, int skinID, int interior, int dimension, MtaElement theTeam){ throw new NotImplementedException(); }
		public static bool DetonateSatchels (MtaElement Player){ throw new NotImplementedException(); }
		public static MtaElement AddResourceConfig (string filePath, string filetype){ throw new NotImplementedException(); }
		public static bool CallRemote (string host, string queueName, int connectionAttempts, int connectTimeout, string resourceName, string functionName, dynamic callbackFunction){ throw new NotImplementedException(); }
		public static MtaResource CopyResource (MtaResource theResource, string newResourceName, string organizationalDir){ throw new NotImplementedException(); }
		public static MtaResource CreateResource (string resourceName, string organizationalDir){ throw new NotImplementedException(); }
		public static MtaElement AddResourceMap (string filePath, int dimension){ throw new NotImplementedException(); }
		public static bool DeleteResource (string resourceName){ throw new NotImplementedException(); }
		public static dynamic GetResourceACLRequests (MtaResource theResource){ throw new NotImplementedException(); }
		public static string GetResourceInfo (MtaResource theResource, string attribute){ throw new NotImplementedException(); }
		public static int GetResourceLastStartTime (MtaResource theResource){ throw new NotImplementedException(); }
		public static string GetResourceLoadFailureReason (MtaResource theResource){ throw new NotImplementedException(); }
		public static MtaElement GetResourceMapRootElement (MtaResource theResource, string mapName){ throw new NotImplementedException(); }
		public static int GetResourceLoadTime (MtaResource res){ throw new NotImplementedException(); }
		public static string GetResourceOrganizationalPath (MtaResource theResource){ throw new NotImplementedException(); }
		public static bool IsResourceArchived (MtaResource resourceElement){ throw new NotImplementedException(); }
		public static dynamic GetResources (){ throw new NotImplementedException(); }
		public static bool RemoveResourceFile (MtaResource theResource, string fileName){ throw new NotImplementedException(); }
		public static bool RefreshResources (bool refreshAll, MtaResource targetResource){ throw new NotImplementedException(); }
		public static bool RenameResource (string resourceName, string newResourceName, string organizationalPath){ throw new NotImplementedException(); }
		public static bool RestartResource (MtaResource theResource, bool persistent, bool configs, bool maps, bool scripts, bool html, bool clientConfigs, bool clientScripts, bool clientFiles){ throw new NotImplementedException(); }
		public static bool SetResourceInfo (MtaResource theResource, string attribute, string value){ throw new NotImplementedException(); }
		public static bool StartResource (MtaResource resourceToStart, bool persistent, bool startIncludedResources, bool loadServerConfigs, bool loadMaps, bool loadServerScripts, bool loadHTML, bool loadClientConfigs, bool loadClientScripts, bool loadFiles){ throw new NotImplementedException(); }
		public static bool StopResource (MtaResource theResource){ throw new NotImplementedException(); }
		public static bool UpdateResourceACLRequest (MtaResource theResource, string rightName, bool access, string byWho){ throw new NotImplementedException(); }
		public static int GetMaxPlayers (){ throw new NotImplementedException(); }
		public static int GetServerHttpPort (){ throw new NotImplementedException(); }
		public static int GetServerPort (){ throw new NotImplementedException(); }
		public static string GetServerPassword (){ throw new NotImplementedException(); }
		public static string GetServerName (){ throw new NotImplementedException(); }
		public static bool IsGlitchEnabled (string glitchName){ throw new NotImplementedException(); }
		public static bool SetMaxPlayers (int slots){ throw new NotImplementedException(); }
		public static bool SetGlitchEnabled (string glitchName, bool enable){ throw new NotImplementedException(); }
		public static bool SetServerPassword (string thePassword){ throw new NotImplementedException(); }
		public static bool Shutdown (string reason){ throw new NotImplementedException(); }
		public static bool Set (string settingName, dynamic value){ throw new NotImplementedException(); }
		public static dynamic Get (string settingName){ throw new NotImplementedException(); }
		public static dynamic ExecuteSQLQuery (string query, dynamic param1, dynamic param2){ throw new NotImplementedException(); }
		public static MtaElement DbConnect (string databaseType, string host, string username, string password, string options){ throw new NotImplementedException(); }
		public static bool DbFree (MtaElement queryHandle){ throw new NotImplementedException(); }
		public static dynamic DbPoll (MtaElement queryHandle, int timeout, bool multipleResults){ throw new NotImplementedException(); }
		public static string DbPrepareString (MtaElement databaseConnection, string query, dynamic param1, dynamic param2){ throw new NotImplementedException(); }
		public static MtaElement CreateTeam (string teamName, int colorR, int colorG, int colorB){ throw new NotImplementedException(); }
		public static bool SetTeamFriendlyFire (MtaElement theTeam, bool friendlyFire){ throw new NotImplementedException(); }
		public static bool SetTeamColor (MtaElement theTeam, int colorR, int colorG, int colorB){ throw new NotImplementedException(); }
		public static MtaElement TextCreateDisplay (){ throw new NotImplementedException(); }
		public static bool SetTeamName (MtaElement theTeam, string newName){ throw new NotImplementedException(); }
		public static bool TextDestroyDisplay (MtaElement display){ throw new NotImplementedException(); }
		public static MtaElement TextCreateTextItem (string text, float x, float y, string priority, int red, int green, int blue, int alpha, float scale, string alignX, string alignY, int shadowAlpha){ throw new NotImplementedException(); }
		public static dynamic TextDestroyTextItem (MtaElement theTextitem){ throw new NotImplementedException(); }
		public static dynamic TextDisplayAddObserver (MtaElement display, MtaElement playerToAdd){ throw new NotImplementedException(); }
		public static dynamic TextDisplayAddText (MtaElement displayToAddTo, MtaElement itemToAdd){ throw new NotImplementedException(); }
		public static bool TextDisplayIsObserver (MtaElement display, MtaElement thePlayer){ throw new NotImplementedException(); }
		public static dynamic TextDisplayGetObservers (MtaElement theDisplay){ throw new NotImplementedException(); }
		public static bool TextDisplayRemoveObserver (MtaElement display, MtaElement playerToRemove){ throw new NotImplementedException(); }
		public static bool DbExec (MtaElement databaseConnection, string query, dynamic param1, dynamic param2){ throw new NotImplementedException(); }
		public static dynamic TextDisplayRemoveText (MtaElement displayToRemoveFrom, MtaElement itemToRemove){ throw new NotImplementedException(); }
		public static Tuple<int, int, int, int> TextItemGetColor (MtaElement theTextItem){ throw new NotImplementedException(); }
		public static int TextItemGetPriority (MtaElement textitemToCheck){ throw new NotImplementedException(); }
		public static float TextItemGetScale (MtaElement theTextitem){ throw new NotImplementedException(); }
		public static Tuple<float, float> TextItemGetPosition (MtaElement theTextItem){ throw new NotImplementedException(); }
		public static string TextItemGetText (MtaElement theTextitem){ throw new NotImplementedException(); }
		public static MtaElement DbQuery (dynamic callbackFunction, dynamic callbackArguments, MtaElement databaseConnection, string query, dynamic param1, dynamic param2){ throw new NotImplementedException(); }
		public static bool TextItemSetPosition (MtaElement theTextItem, float x, float y){ throw new NotImplementedException(); }
		public static dynamic TextItemSetPriority (MtaElement theTextItem, string priority){ throw new NotImplementedException(); }
		public static bool TextItemSetScale (MtaElement theTextitem, float scale){ throw new NotImplementedException(); }
		public static dynamic TextItemSetText (MtaElement theTextitem, string text){ throw new NotImplementedException(); }
		public static bool TextItemSetColor (MtaElement theTextItem, int r, int g, int b, int a){ throw new NotImplementedException(); }
		public static dynamic GetNetworkStats (MtaElement thePlayer){ throw new NotImplementedException(); }
		public static string GetServerConfigSetting (string name){ throw new NotImplementedException(); }
		public static bool SetServerConfigSetting (string name, string value, bool bSave){ throw new NotImplementedException(); }
        public static MtaElement CreateVehicle(int model, float x, float y, float z, float rx, float ry, float rz, string numberplate, bool bDirection, int variant1, int variant2) { throw new NotImplementedException(); }
        public static bool AddVehicleSirens (MtaElement theVehicle, int sirenCount, int sirenType, bool argument_360flag, bool checkLosFlag, bool useRandomiser, bool silentFlag){ throw new NotImplementedException(); }
		public static bool BlowVehicle (MtaElement vehicleToBlow, bool explode){ throw new NotImplementedException(); }
		public static dynamic GetModelHandling (int modelId){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetVehicleRespawnPosition (MtaElement theVehicle){ throw new NotImplementedException(); }
		public static Tuple<float, float, float> GetVehicleRespawnRotation (MtaElement theVehicle){ throw new NotImplementedException(); }
		public static dynamic GetVehiclesOfType (int model){ throw new NotImplementedException(); }
		public static bool RemoveVehicleSirens (MtaElement theVehicle){ throw new NotImplementedException(); }
		public static bool ResetVehicleExplosionTime (MtaElement theVehicle){ throw new NotImplementedException(); }
		public static bool RespawnVehicle (MtaElement theVehicle){ throw new NotImplementedException(); }
		public static bool ResetVehicleIdleTime (MtaElement theVehicle){ throw new NotImplementedException(); }
		public static bool SetModelHandling (int modelId, string property, dynamic value){ throw new NotImplementedException(); }
		public static bool SetVehicleIdleRespawnDelay (MtaElement theVehicle, int timeDelay){ throw new NotImplementedException(); }
		public static bool SetVehicleRespawnPosition (MtaElement theVehicle, float x, float y, float z, float rx, float ry, float rz){ throw new NotImplementedException(); }
		public static bool SetVehicleRespawnRotation (MtaElement theVehicle, float rx, float ry, float rz){ throw new NotImplementedException(); }
		public static bool SetVehicleRespawnDelay (MtaElement theVehicle, int timeDelay){ throw new NotImplementedException(); }
		public static bool ToggleVehicleRespawn (MtaElement theVehicle, bool Respawn){ throw new NotImplementedException(); }
		public static bool SpawnVehicle (MtaElement theVehicle, float x, float y, float z, float rx, float ry, float rz){ throw new NotImplementedException(); }
		public static bool SetVehicleVariant (MtaElement theVehicle, int variant1, int variant2){ throw new NotImplementedException(); }
		public static bool GiveWeapon (MtaElement thePlayer, int weapon, int ammo, bool setAsCurrent){ throw new NotImplementedException(); }
		public static bool TakeAllWeapons (MtaElement thePed){ throw new NotImplementedException(); }
		public static bool TakeWeapon (MtaElement thePlayer, int weaponId, int ammo){ throw new NotImplementedException(); }
		public static bool GetJetpackWeaponEnabled (string weapon){ throw new NotImplementedException(); }
		public static bool SetJetpackWeaponEnabled (string weapon, bool enabled){ throw new NotImplementedException(); }
	}
}