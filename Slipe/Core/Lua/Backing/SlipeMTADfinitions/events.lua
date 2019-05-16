function initEvents()

	local unpack = unpack
	local tInsert = table.insert

	local System = System
	local cast = System.cast
	local new = System.new
	local string = System.String
	local boolean = System.Boolean
	local single = System.Single
	local int32 = System.Int32
	local byte = System.Byte
	local vector3 = System.Numerics.Vector3
	local vector2 = System.Numerics.Vector2
	local color = Slipe.Shared.Utilities.Color
	local arrayFromTable = System.arrayFromTable
	local parseEnum = System.Enum.Parse
	local typeOf = System.typeof

	local m = Slipe.Shared.Elements.ElementManager.getInstance()

	local mouseButton = Slipe.Shared.IO.MouseButton
	local mouseButtonState = Slipe.Shared.IO.MouseButtonState
	local quitType = Slipe.Shared.Peds.QuitType

	local _byte = {1, function(e) return cast(byte, e) end}
	local _string = {1, function(e) return cast(string, e) end}
	local _boolean = {1, function(e) return cast(boolean, e) end}	
	local _int = {1, function(e) return cast(int32, e) end}
	local _float = {1, function(e) return cast(single, e) end}
	local _vector3 = {3, function(x, y, z) return vector3(_float[2](x), _float[2](y), _float[2](z)) end}
	local _vector2 = {2, function(x, y) return vector2(_float[2](x), _float[2](y)) end}
	local _color3 = {3, function(r, g, b) return new(color, 4, _byte[2](r), _byte[2](g), _byte[2](b)) end}
	local _color4 = {4, function(r, g, b, a) return new(color, 3, _byte[2](r), _byte[2](g), _byte[2](b), _byte[2](a)) end}
	local _element = {1, function(e) return m:GetElement1(e) end}
	local _stringArray = {1, function(e) return arrayFromTable(e, "System.String") end}		
	local _enum = {1, function(e, en) return _int[2](parseEnum(typeOf(en), _string[2](e):Replace(" ", "_"), true)) end}

	local _elementEvents = Slipe.Shared.Elements.Events
	local _colShapeEvents = Slipe.Shared.CollisionShapes.Events
	local _sharedPickupEvents = Slipe.Shared.Pickups.Events
	local _markerEvents = Slipe.Shared.Markers.Events

	local events = {}

	-- 1: MTA event name
	-- 2: events namespace
	-- 3: table reference to static class, if static event (optional)

	if triggerServerEvent == nil then

		local acM = Slipe.Server.Accounts.Account
		local reM = Slipe.Server.Resources.Resource
		local _resource = {1, function(e) return reM:Get1(e) end}	

		local ban = Slipe.Server.Accounts.Ban
		local _ban = {1, function(e) return new(ban, 2, e) end}
		local _account = {1, function(e) return acM:Get(e) end}

		local weaponModel = Slipe.Server.Weapons.WeaponModel
		local _weaponModel = {1, function(e) return new(weaponModel, 2, e) end}

		local _pickupEvents = Slipe.Server.Pickups.Events
		local _pedEvents = Slipe.Server.Peds.Events
		local _vehicleEvents = Slipe.Server.Vehicles.Events
		local _accountEvents = Slipe.Server.Accounts.Events
		local _gameEvents = Slipe.Server.Game.Events
		local _ioEvents = Slipe.Server.IO.Events

		-- Root Element
		events.onAccountDataChange = {"OnAccountDataChange", _accountEvents, Slipe.Server.Accounts.Account}
		events.onBan = {"OnBanAdded", _accountEvents, Slipe.Server.Accounts.Ban}
		events.onUnban = {"OnBanRemoved", _accountEvents, Slipe.Server.Accounts.Ban}
		events.onPlayerConnect = {"OnPlayerConnect", _gameEvents, Slipe.Server.Game.GameServer}
		events.onResourcePreStart = {"OnPreStart", _gameEvents, Slipe.Server.Game.GameServer }
		events.onResourceStart = {"OnStart", _gameEvents, Slipe.Server.Game.GameServer}
		events.onResourceStop = {"OnStop", _gameEvents, Slipe.Server.Game.GameServer}
		events.onChatMessage = {"OnChatMessage", _ioEvents, Slipe.Server.IO.ChatBox}
		events.onDebugMessage = {"OnDebugMessage", _ioEvents, Slipe.Server.IO.MtaDebug}
		events.onSettingChange = {"OnSettingChange", _gameEvents, Slipe.Server.Game.GameServer}

		-- PhysicalElement
		events.onElementColShapeHit = {"OnCollisionShapeHit", _elementEvents}
		events.onElementColShapeLeave = {"OnCollisionShapeLeave", _elementEvents}
		events.onElementClicked = {"OnClicked", _elementEvents}
		events.onElementModelChange = {"OnModelChange", _elementEvents}
		events.onElementStartSync = {"OnStartSync", _elementEvents}
		events.onElementStopSync = {"OnStopSync", _elementEvents}

		-- Collisionshape
		events.onColShapeHit = {"OnHit", _colShapeEvents}
		events.onColShapeLeave = {"OnLeave", _colShapeEvents}

		-- Element
		events.onElementDestroy = {"OnDestroy", _elementEvents}

		-- Pickup
		events.onPickupHit = {"OnHit", _sharedPickupEvents}
		events.onPickupLeave = {"OnLeave", _sharedPickupEvents}
		events.onPickupSpawn = {"OnSpawn", _pickupEvents}
		events.onPickupUse = {"OnUse", _pickupEvents}

		-- Marker
		events.onMarkerHit = {"OnHit", _markerEvents}
		events.onMarkerLeave = {"OnLeave", _markerEvents}
		
		-- Ped
		events.onPedWasted = {"OnWasted", _pedEvents}
		events.onPedWeaponSwitch = {"OnWeaponSwitch", _pedEvents}

		-- Player
		events.onPlayerJoin = {"OnJoin", _pedEvents, Slipe.Server.Peds.Player}

		events.onConsole = {"OnConsole", _pedEvents}
		events.onPlayerACInfo = {"OnAcInfo", _pedEvents}
		events.onBan = {"OnBanAdded", _pedEvents}
		events.onPlayerBan = {"OnBanned", _pedEvents}
		events.onPlayerChangeNick = {"OnNicknameChanged", _pedEvents}
		events.onPlayerChat = {"OnChat", _pedEvents}
		events.onPlayerClick = {"OnClick", _pedEvents}
		events.onPlayerCommand = {"OnCommand", _pedEvents}
		events.onPlayerContact = {"OnContact", _pedEvents}
		events.onPlayerDamage = {"OnDamage", _pedEvents}
		events.onPlayerWasted = {"OnWasted", _pedEvents}
		events.onPlayerLogin = {"OnLogin", _pedEvents}
		events.onPlayerLogout = {"OnLogout", _pedEvents}
		events.onPlayerMarkerHit = {"OnMarkerHit", _pedEvents}
		events.onPlayerMarkerLeave = {"OnMarkerLeave", _pedEvents}
		events.onPlayerModInfo = {"OnModInfo", _pedEvents}
		events.onPlayerMute = {"OnMuted", _pedEvents}
		events.onPlayerUnMute = {"OnUnmuted", _pedEvents}
		events.onPlayerNetworkStatus = {"OnNetworkInteruption", _pedEvents}
		events.onPlayerPickupHit = {"OnPickupHit", _pedEvents}
		events.onPlayerPickupLeave = {"OnPickupLeave", _pedEvents}
		events.onPlayerPickupUse = {"OnPickupUse", _pedEvents}
		events.onPlayerPrivateMessage = {"OnPrivateMessage", _pedEvents}
		events.onPlayerQuit = {"OnQuit", _pedEvents}
		events.onPlayerScreenShot = {"OnScreenShot", _pedEvents}
		events.onPlayerSpawn = {"OnSpawn", _pedEvents}
		events.onPlayerStealthKill = {"OnStealthKill", _pedEvents}
		events.onPlayerTarget = {"OnTarget", _pedEvents}
		events.onPlayerVehicleEnter = {"OnVehicleEnter", _pedEvents}
		events.onPlayerVehicleExit = {"OnVehicleExit", _pedEvents}
		events.onPlayerVoiceStart = {"OnVoiceStart", _pedEvents}
		events.onPlayerVoiceStop = {"OnVoiceStop", _pedEvents}
		events.onPlayerWeaponFire = {"OnWeaponFire", _pedEvents}
		events.onPlayerWeaponSwitch = {"OnWeaponSwitch", _pedEvents}

		-- Vehicle
		events.onTrailerAttach = {"OnAttach", _vehicleEvents}
		events.onTrailerDetach = {"OnDetach", _vehicleEvents}
		events.onVehicleDamage = {"OnDamage", _vehicleEvents}
		events.onVehicleEnter = {"OnEnter", _vehicleEvents}
		events.onVehicleExit = {"OnExit", _vehicleEvents}
		events.onVehicleStartEnter = {"OnStartEnter", _vehicleEvents}
		events.onVehicleStartExit = {"OnStartExit", _vehicleEvents}
		events.onVehicleExplode = {"OnExplode", _vehicleEvents}
		events.onVehicleRespawn = {"OnRespawn", _vehicleEvents}

	else

		local weaponModel = Slipe.Shared.Weapons.SharedWeaponModel
		local _weaponModel = {1, function(e) return new(weaponModel, 2, e) end}

		local reM = Slipe.Client.Resources.Resource
		local _resource = {1, function(e) return reM:Get(e) end}	

		-- Browser
		events.onClientBrowserCreated = {"OnCreated"}
		events.onClientBrowserCursorChange = {"OnCursorChange", {_int}}
		events.onClientBrowserDocumentReady = {"OnDocumentReady", {_string}}
		events.onClientBrowserInputFocusChanged = {"OnInputFocusChange", {_boolean}}
		events.onClientBrowserLoadingFailed = {"OnLoadFail", {_string, _int, _string}}
		events.onClientBrowserLoadingStart = {"OnLoadStart", {_string}}
		events.onClientBrowserNavigate = {"OnNavigate", {_string, _boolean}}
		events.onClientBrowserPopup = {"OnPopup", {_string, _string, _int}}
		events.onClientBrowserResourceBlocked = {"OnResourceBlocked", {_string, _string, _int}}
		events.onClientBrowserTooltip = {"OnTooltip", {_string}}

		-- Resource root element
		events.onClientFileDownloadComplete = {"OnFileDownloadComplete", {_string, _boolean}}

		-- Root element
		events.onClientKey = {"OnKey", {_string, _boolean}}
		events.onClientRender = {"OnRender"}
		events.onClientPreRender = {"OnPreRender", {_float}}
		events.onClientHUDRender = {"OnHUDRender"}
		events.onClientBrowserWhitelistChange = {"OnBrowserWhiteListChange", {_stringArray}}
		events.onClientCharacter = {"OnCharacter", {_string}}
		events.onClientClick = {"OnClick", {{_enum, mouseButton}, {_enum, mouseButtonState}, _vector2, _vector3, _element}}
		events.onClientCursorMove = {"OnCursorMove", {_vector2, _vector2, _vector3}}
		events.onClientDoubleClick = {"OnDoubleClick", {{_enum, mouseButton}, _vector2, _vector3, _element}}
		events.onClientChatMessage = {"OnChatMessage", {_string, _color3}}
		events.onClientDebugMessage = {"OnDebugMessage", {_string, _int, _string, _int, _color3}}
		events.onClientMinimize = {"OnMinimize"}
		events.onClientPlayerNetworkStatus = {"OnNetworkInteruption", {_int, _int}}
		events.onClientRestore = {"OnRestore", {_boolean}}

		-- Misc
		events.onClientExplosion = {"OnExplosion", {_vector3, _int}}

		-- Colshape
		events.onClientColShapeHit = {"OnHit", {_element, _boolean}}
		events.onClientColShapeLeave = {"OnLeave", {_element, _boolean}}

		-- Element
		events.onClientElementDestroy = {"OnDestroy"}

		-- Physical Element
		events.onClientElementColShapeHit = {"OnCollisionShapeHit", {_element, _boolean}}
		events.onClientElementColShapeLeave = {"OnCollisionShapeLeave", {_element, _boolean}}
		events.onClientElementStreamIn = {"OnStreamIn"}
		events.onClientElementStreamOut = {"OnStreamOut"}

		-- Marker
		events.onClientMarkerHit = {"OnHit", {_element, _boolean}}
		events.onClientMarkerLeave = {"OnLeave", {_element, _boolean}}

		-- Gui
		events.onClientGUIAccepted = {"OnAccepted"}
		events.onClientGUIBlur = {"OnBlur"}
		events.onClientGUIFocus = {"OnFocus"}
		events.onClientGUIChanged = {"OnChanged"}
		events.onClientGUIClick = {"OnClick", {{_enum, mouseButton}, {_enum, mouseButtonState}, _vector2}}
		events.onClientGUIComboBoxAccepted = {"OnAccepted"}
		events.onClientGUIDoubleClick = {"OnDoubleClick", {{_enum, mouseButton}, {_enum, mouseButtonState}, _vector2}}
		events.onClientGUIMouseDown = {"OnMouseDown", {{_enum, mouseButton}, {_enum, mouseButtonState}, _vector2}}
		events.onClientGUIMouseUp = {"OnMouseUp", {{_enum, mouseButton}, {_enum, mouseButtonState}, _vector2}}
		events.onClientGUIMove = {"OnMove"}
		events.onClientGUIScroll = {"OnScroll"}
		events.onClientGUISize = {"OnResize"}
		events.onClientGUITabSwitched = {"OnOpen"}
		events.onClientMouseEnter = {"OnMouseEnter", {_vector2, _element}}
		events.onClientMouseLeave = {"OnMouseLeave", {_vector2, _element}}
		events.onClientMouseMove = {"OnMouseMove", {_vector2}}
		events.onClientMouseWheel = {"OnMouseWheel", {_int}}

		-- Pickup
		events.onClientPickupHit = {"OnHit", {_element, _boolean}}
		events.onClientPickupLeave = {"OnLeave", {_element, _boolean}}

		local _peds = Slipe.Client.Peds.Events
		-- Ped
		events.onClientPedDamage = {"OnDamage", {_element, _int, _int, _float}}
		events.onClientPedHeliKilled = {"OnHeliKilled", {_element}}
		events.onClientPedHitByWaterCannon = {"OnPedHit", {_element}}
		events.onClientPedWasted = {"OnWasted", {_element, _int, _int, _boolean}}
		events.onClientPedWeaponFire = {"OnWeaponFire", {_weaponModel, _int, _int, _vector3, _element}}
		events.onClientPedStep = {"OnStep", {_boolean}}

		-- Player
		events.onClientConsole = {"OnConsole", {_string}}
		events.onPlayerChangeNick = {"OnNicknameChanged", {_string, _string}}
		events.onClientPlayerChoke = {"OnChoke", {_weaponModel, _element}}
		events.onClientPlayerDamage = {"OnDamage", {_element, _int, _int, _float}}
		events.onClientPlayerHeliKilled = {"OnHeliKilled", {_element}}
		events.onClientPlayerHitByWaterCannon = {"OnPedHit", {_element}}
		events.onClientPlayerPickupHit = {"OnPickupHit", {_element, _boolean}}
		events.onClientPlayerPickupLeave = {"OnPickupLeave", {_element, _boolean}}
		events.onClientPlayerQuit = {"OnQuit", {_enum, quitType}}
		events.onClientPlayerRadioSwitch = {"OnRadioSwitch", {_int}}
		events.onClientPlayerSpawn = {"OnSpawn", {_element}}
		events.onClientPlayerStealthKill = {"OnStealthKill", {_element}}
		events.onClientPlayerStuntStart = {"OnStuntStart", {_string}}
		events.onClientPlayerStuntFinish = {"OnStuntFinish", {_string, _int, _float}}
		events.onClientPlayerTarget = {"OnTarget", {_element}}
		events.onClientPlayerVehicleEnter = {"OnVehicleEnter", {_element, _int}}
		events.onClientPlayerVehicleExit = {"OnVehicleExit", {_element, _int}}
		events.onClientPlayerVoicePause = {"OnVoicePaused"}
		events.onClientPlayerVoiceResumed = {"OnVoiceResumed"}
		events.onClientPlayerVoiceStart = {"OnVoiceStart"}
		events.onClientPlayerVoiceStop = {"OnVoiceStop"}
		events.onClientPlayerWasted = {"OnWasted", {_element, _int, _int, _boolean}}
		events.onClientPlayerWeaponFire = {"OnWeaponFire", {_weaponModel, _int, _int, _vector3, _element}}
		events.onClientPlayerWeaponSwitch = {"OnWeaponSwitch", {_weaponModel, _weaponModel}}
		events.onClientPlayerJoin = {"OnJoin", {}, _peds, Slipe.Client.Peds.Player}

		-- Object
		events.onClientObjectBreak = {"OnBreak", {_element}}
		events.onClientObjectDamage = {"OnDamage", {_float, _element}}

		-- Projectile
		events.onClientProjectileCreation = {"OnCreated", {_element}}

		-- Resource
		events.onClientResourceStart = {"OnStart", {_resource}}
		events.onClientResourceStop = {"OnStop", {_resource}}

		-- Sound
		events.onClientSoundBeat = {"OnBeat", {_float}}
		events.onClientSoundChangedMeta = {"OnMetaChanged", {_string}}
		events.onClientSoundFinishedDownload = {"OnDownloadFinished", {_int}}
		events.onClientSoundStarted = {"OnStart", {_string}}
		events.onClientSoundStopped = {"OnStop", {_string}}
		events.onClientSoundStream = {"OnStream", {_boolean, _int, _string, _string}}

		-- Vehicle
		events.onClientTrailerAttach = {"OnAttach", {_element}}
		events.onClientTrailerDetach = {"OnDetach", {_element}}
		events.onClientVehicleCollision = {"OnCollision", {_element, _float, _int, _vector3, _vector3, _int}}
		events.onClientVehicleDamage = {"OnDamage", {_element, _weaponModel, _float, _vector3, _int}}
		events.onVehicleEnter = {"OnEnter", {_element, _int}}
		events.onVehicleExit = {"OnExit", {_element, _int}}
		events.onVehicleStartEnter = {"OnStartEnter", {_element, _int, _int}}
		events.onVehicleStartExit = {"OnStartExit", {_element, _int, _int}}
		events.onVehicleExplode = {"OnExplode"}
		events.onVehicleRespawn = {"OnRespawn"}
		events.onClientVehicleNitroStateChange = {"OnNitroStateChange", {_boolean}}

		-- Custom Weapon
		events.onClientWeaponFire = {"OnFire", {_element, _vector3, _vector3, _int, _float, _int}}
		
	end

	for e, v in pairs(events) do
		addEventHandler(e, root, function(...)
			local src = m:GetElement1(source)
			local cls = v[3] and v[3] or src
			if cls and cls[v[1]] then
				cls[v[1]](src, v[2][v[1] .. "EventArgs"](...))
			end
		end)
	end

	local allElementTypes = {
		"player",
		"ped",
		"water",
		"sound",
		"vehicle",
		"object",
		"pickup",
		"marker",
		"colshape",
		"blip",
		"radararea",
		"team",
		"projectile",
		"effect",
		"light",
		"searchlight",
		"weapon"
	}

	for _,type in ipairs(allElementTypes) do
		for _, element in pairs(getElementsByType(type)) do
			m:GetElement1(element)
		end
	end
end



