function initEvents()
	
	local m = Slipe.Shared.Elements.ElementManager.getInstance()

	local _elementEvents = Slipe.Shared.Elements.Events
	local _colShapeEvents = Slipe.Shared.CollisionShapes.Events
	local _sharedPickupEvents = Slipe.Shared.Pickups.Events
	local _markerEvents = Slipe.Shared.Markers.Events

	local events = {}

	-- 1: MTA event name
	-- 2: events namespace
	-- 3: table reference to static class, if static event (optional)

	if triggerServerEvent == nil then

		local _pickupEvents = Slipe.Server.Pickups.Events
		local _pedEvents = Slipe.Server.Peds.Events
		local _vehicleEvents = Slipe.Server.Vehicles.Events
		local _accountEvents = Slipe.Server.Accounts.Events
		local _gameEvents = Slipe.Server.Game.Events
		local _ioEvents = Slipe.Server.IO.Events

		-- Root Element
		events.onAccountDataChange = {"OnDataChange", _accountEvents, Slipe.Server.Accounts.Account}
		events.onBan = {"OnAdded", _accountEvents, Slipe.Server.Accounts.Ban}
		events.onUnban = {"OnRemoved", _accountEvents, Slipe.Server.Accounts.Ban}
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

		local _browserEvents = Slipe.Client.Browsers.Events
		local _ioEvents = Slipe.Client.IO.Events
		local _renderEvents = Slipe.Client.Rendering.Events
		local _gameEvents = Slipe.Client.Game.Events
		local _clientElementEvents = Slipe.Client.Elements.Events
		local _guiEvents = Slipe.Client.Gui.Events
		local _pedEvents = Slipe.Client.Peds.Events
		local _worldEvents = Slipe.Client.GameWorld.Events
		local _weaponEvents = Slipe.Client.Weapons.Events
		local _soundEvents = Slipe.Client.Sounds.Events
		local _vehicleEvents = Slipe.Client.Vehicles.Events

		-- Browser
		events.onClientBrowserCreated = {"OnCreated", _browserEvents}
		events.onClientBrowserCursorChange = {"OnCursorChange", _browserEvents}
		events.onClientBrowserDocumentReady = {"OnDocumentReady", _browserEvents}
		events.onClientBrowserInputFocusChanged = {"OnInputFocusChange", _browserEvents}
		events.onClientBrowserLoadingFailed = {"OnLoadFail", _browserEvents}
		events.onClientBrowserLoadingStart = {"OnLoadStart", _browserEvents}
		events.onClientBrowserNavigate = {"OnNavigate", _browserEvents}
		events.onClientBrowserPopup = {"OnPopup", _browserEvents}
		events.onClientBrowserResourceBlocked = {"OnResourceBlocked", _browserEvents}
		events.onClientBrowserTooltip = {"OnTooltip", _browserEvents}

		-- Resource root element
		events.onClientFileDownloadComplete = {"OnFileDownloadComplete", _gameEvents, Slipe.Client.Game.GameClient}
		events.onClientResourceStart = {"OnStart", _gameEvents, Slipe.Client.Game.GameClient}
		events.onClientResourceStop = {"OnStop", _gameEvents, Slipe.Client.Game.GameClient}

		-- Root element
		events.onClientKey = {"OnKey", _ioEvents, Slipe.Client.IO.Input}
		events.onClientRender = {"OnRender", _renderEvents, Slipe.Client.Rendering.Renderer}
		events.onClientPreRender = {"OnUpdate", _gameEvents, Slipe.Client.Game.GameClient}
		events.onClientHUDRender = {"OnHUDRender", _renderEvents, Slipe.Client.Rendering.Renderer}
		events.onClientBrowserWhitelistChange = {"OnWhiteListChange", _browserEvents, Slipe.Client.Browsers.Browser}
		events.onClientCharacter = {"OnCharacter", _ioEvents, Slipe.Client.IO.Input}
		events.onClientClick = {"OnClick", _ioEvents, Slipe.Client.IO.Cursor}
		events.onClientCursorMove = {"OnCursorMove", _ioEvents, Slipe.Client.IO.Cursor}
		events.onClientDoubleClick = {"OnDoubleClick", _ioEvents, Slipe.Client.IO.Cursor}
		events.onClientChatMessage = {"OnChatMessage", _ioEvents, Slipe.Client.IO.ChatBox}
		events.onClientDebugMessage = {"OnDebugMessage", _ioEvents, Slipe.Client.IO.MtaDebug}
		events.onClientMinimize = {"OnMinimize", _gameEvents, Slipe.Client.Game.GameClient}
		events.onClientPlayerNetworkStatus = {"OnNetworkInteruption", _gameEvents, Slipe.Client.Game.GameClient}
		events.onClientRestore = {"OnRestore", _gameEvents, Slipe.Client.Game.GameClient}

		-- Misc
		events.onClientExplosion = {"OnExplosion", _clientElementEvents}

		-- Colshape
		events.onClientColShapeHit = {"OnHit", _colShapeEvents}
		events.onClientColShapeLeave = {"OnLeave", _colShapeEvents}

		-- Element
		events.onClientElementDestroy = {"OnDestroy", _elementEvents}

		-- Physical Element
		events.onClientElementColShapeHit = {"OnCollisionShapeHit", _elementEvents}
		events.onClientElementColShapeLeave = {"OnCollisionShapeLeave", _elementEvents}
		events.onClientElementStreamIn = {"OnStreamIn", _elementEvents}
		events.onClientElementStreamOut = {"OnStreamOut", _elementEvents}
		events.onClientWorldSound = {"OnWorldSound", _clientElementEvents}

		-- Marker
		events.onClientMarkerHit = {"OnHit", _markerEvents}
		events.onClientMarkerLeave = {"OnLeave", _markerEvents}

		-- Gui
		events.onClientGUIAccepted = {"OnAccepted", _guiEvents}
		events.onClientGUIBlur = {"OnBlur", _guiEvents}
		events.onClientGUIFocus = {"OnFocus", _guiEvents}
		events.onClientGUIChanged = {"OnChanged", _guiEvents}
		events.onClientGUIClick = {"OnClick", _guiEvents}
		events.onClientGUIComboBoxAccepted = {"OnAccepted", _guiEvents}
		events.onClientGUIDoubleClick = {"OnDoubleClick", _guiEvents}
		events.onClientGUIMouseDown = {"OnMouseDown", _guiEvents}
		events.onClientGUIMouseUp = {"OnMouseUp", _guiEvents}
		events.onClientGUIMove = {"OnMove", _guiEvents}
		events.onClientGUIScroll = {"OnScroll"}
		events.onClientGUISize = {"OnResize", _guiEvents}
		events.onClientGUITabSwitched = {"OnOpen", _guiEvents}
		events.onClientMouseEnter = {"OnMouseEnter", _guiEvents}
		events.onClientMouseLeave = {"OnMouseLeave", _guiEvents}
		events.onClientMouseMove = {"OnMouseMove", _guiEvents}
		events.onClientMouseWheel = {"OnMouseWheel", _guiEvents}

		-- Pickup
		events.onClientPickupHit = {"OnHit", _sharedPickupEvents}
		events.onClientPickupLeave = {"OnLeave", _sharedPickupEvents}

		-- Ped
		events.onClientPedDamage = {"OnDamage", _pedEvents}
		events.onClientPedHeliKilled = {"OnHeliKilled", _pedEvents}
		events.onClientPedWasted = {"OnWasted", _pedEvents}
		events.onClientPedWeaponFire = {"OnWeaponFire", _pedEvents}
		events.onClientPedStep = {"OnStep", _pedEvents}

		-- Player
		events.onClientPlayerJoin = {"OnJoin", _pedEvents, Slipe.Client.Peds.Player}
		events.onClientConsole = {"OnConsole", _pedEvents}
		events.onPlayerChangeNick = {"OnNicknameChanged", _pedEvents}
		events.onClientPlayerChoke = {"OnChoke", _pedEvents}
		events.onClientPlayerDamage = {"OnDamage", _pedEvents}
		events.onClientPlayerHeliKilled = {"OnHeliKilled", _pedEvents}
		events.onClientPlayerPickupHit = {"OnPickupHit", _pedEvents}
		events.onClientPlayerPickupLeave = {"OnPickupLeave", _pedEvents}
		events.onClientPlayerQuit = {"OnQuit", _pedEvents}
		events.onClientPlayerRadioSwitch = {"OnRadioSwitch", _pedEvents}
		events.onClientPlayerSpawn = {"OnSpawn", _pedEvents}
		events.onClientPlayerStealthKill = {"OnStealthKill", _pedEvents}
		events.onClientPlayerStuntStart = {"OnStuntStart", _pedEvents}
		events.onClientPlayerStuntFinish = {"OnStuntFinish", _pedEvents}
		events.onClientPlayerTarget = {"OnTarget", _pedEvents}
		events.onClientPlayerVehicleEnter = {"OnVehicleEnter", _pedEvents}
		events.onClientPlayerVehicleExit = {"OnVehicleExit", _pedEvents}
		events.onClientPlayerVoicePause = {"OnVoicePaused", _pedEvents}
		events.onClientPlayerVoiceResumed = {"OnVoiceResumed", _pedEvents}
		events.onClientPlayerVoiceStart = {"OnVoiceStart", _pedEvents}
		events.onClientPlayerVoiceStop = {"OnVoiceStop", _pedEvents}
		events.onClientPlayerWasted = {"OnWasted", _pedEvents}
		events.onClientPlayerWeaponFire = {"OnWeaponFire", _pedEvents}
		events.onClientPlayerWeaponSwitch = {"OnWeaponSwitch", _pedEvents}

		-- Object
		events.onClientObjectBreak = {"OnBreak", _worldEvents}
		events.onClientObjectDamage = {"OnDamage", _worldEvents}

		-- Projectile
		events.onClientProjectileCreation = {"OnCreated", _weaponEvents}

		-- Sound
		events.onClientSoundBeat = {"OnBeat", _soundEvents}
		events.onClientSoundChangedMeta = {"OnMetaChanged", _soundEvents}
		events.onClientSoundFinishedDownload = {"OnDownloadFinished", _soundEvents}
		events.onClientSoundStarted = {"OnStart", _soundEvents}
		events.onClientSoundStopped = {"OnStop", _soundEvents}
		events.onClientSoundStream = {"OnStream", _soundEvents}

		-- Vehicle
		events.onClientTrailerAttach = {"OnAttach", _vehicleEvents}
		events.onClientTrailerDetach = {"OnDetach", _vehicleEvents}
		events.onClientVehicleCollision = {"OnCollision", _vehicleEvents}
		events.onClientVehicleDamage = {"OnDamage", _vehicleEvents}
		events.onVehicleEnter = {"OnEnter", _vehicleEvents}
		events.onVehicleExit = {"OnExit", _vehicleEvents}
		events.onVehicleStartEnter = {"OnStartEnter", _vehicleEvents}
		events.onVehicleStartExit = {"OnStartExit", _vehicleEvents}
		events.onVehicleExplode = {"OnExplode", _vehicleEvents}
		events.onVehicleRespawn = {"OnRespawn", _vehicleEvents}
		events.onClientVehicleNitroStateChange = {"OnNitroStateChange", _vehicleEvents}
		events.onClientPedHitByWaterCannon = {"OnPedHit", _vehicleEvents}
		events.onClientPlayerHitByWaterCannon = {"OnPedHit", _vehicleEvents}
		events.onClientVehicleWeaponHit = {"OnWeaponHit", _vehicleEvents}

		-- Custom Weapon
		events.onClientWeaponFire = {"OnFire", _weaponEvents}
		
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



