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

	local events = {}

	if triggerServerEvent == nil then

		local acM = Slipe.Server.Accounts.Account
		local reM = Slipe.Server.Resources.Resource
		local _resource = {1, function(e) return reM:Get1(e) end}	

		local ban = Slipe.Server.Accounts.Ban
		local _ban = {1, function(e) return new(ban, 2, e) end}
		local _account = {1, function(e) return acM:Get(e) end}

		local weaponModel = Slipe.Server.Weapons.WeaponModel
		local _weaponModel = {1, function(e) return new(weaponModel, 2, e) end}

		-- Root Element
		events.onAccountDataChange = {"OnAccountDataChange", {_account, _string, _string}}
		events.onBan = {"OnBanAdded", {_ban}}
		events.onUnban = {"OnBanRemoved", {_ban, _element}}
		events.onPlayerConnect = {"OnPlayerConnect", {_string, _string, _string, _string, _int, _string}}
		events.onResourcePreStart = {"OnPreStart", {_resource}}
		events.onResourceStart = {"OnStart", {_resource}}
		events.onResourceStop = {"OnStop", {_resource, _boolean}}
		events.onChatMessage = {"OnChatMessage", {_string, _element}}
		events.onDebugMessage = {"OnDebugMessage", {_string, _int, _string, _int, _color3}}
		events.onSettingChange = {"OnSettingChange", {_string, _string, _string}}

		-- PhysicalElement
		events.onElementColShapeHit = {"OnCollisionShapeHit", {_element, _boolean}}
		events.onElementColShapeLeave = {"OnCollisionShapeLeave", {_element, _boolean}}
		events.onElementClicked = {"OnClicked", {{_enum, mouseButton}, {_enum, mouseButtonState}, _element, _vector3 }}
		events.onElementModelChange = {"OnModelChange", {_int, _int}}
		events.onElementStartSync = {"OnStartSync", {_element}}
		events.onElementStopSync = {"OnStopSync", {_element}}

		-- Collisionshape
		events.onColShapeHit = {"OnHit", {_element, _boolean}}
		events.onColShapeLeave = {"OnLeave", {_element, _boolean}}

		-- Element
		events.onElementDestroy = {"OnDestroy"}

		-- Pickup
		events.onPickupHit = {"OnHit", {_element, _boolean}}
		events.onPickupLeave = {"OnLeave", {_element, _boolean}}
		events.onPickupSpawn = {"OnSpawn"}
		events.onPickupUse = {"OnUse", {_element}}

		-- Marker
		events.onMarkerHit = {"OnHit", {_element, _boolean}}
		events.onMarkerLeave = {"OnLeave", {_element, _boolean}}

		-- Ped
		events.onPedWasted = {"OnWasted", {_int, _element, _int, _int, _boolean}}
		events.onPedWeaponSwitch = {"OnWeaponSwitch", {_weaponModel, _weaponModel}}

		-- Player
		events.onConsole = {"OnConsole", {_string}}
		events.onPlayerACInfo = {"OnAcInfo", {_stringArray, _string, _string, _string}}
		events.onBan = {"OnBanAdded", {_ban}}
		events.onPlayerBan = {"OnBanned", {_ban, _element}}
		events.onPlayerChangeNick = {"OnNicknameChanged", {_string, _string, _boolean}}
		events.onPlayerChat = {"OnChat", {_string, _int}}
		events.onPlayerClick = {"OnClick", {{_enum, mouseButton}, {_enum, mouseButtonState}, _element, _vector3, _vector2}}
		events.onPlayerCommand = {"OnCommand", {_string}}
		events.onPlayerContact = {"OnContact", {_element, _element}}
		events.onPlayerDamage = {"OnDamage", {_element, _int, _int, _float}}
		events.onPlayerWasted = {"OnWasted", {_int, _element, _int, _int, _boolean}}
		events.onPlayerLogin = {"OnLogin", {_account, _account}}
		events.onPlayerLogout = {"OnLogout", {_account, _account}}
		events.onPlayerMarkerHit = {"OnMarkerHit", {_element, _boolean}}
		events.onPlayerMarkerLeave = {"OnMarkerLeave", {_element, _boolean}}
		events.onPlayerModInfo = {"OnModInfo", {_string, _stringArray}}
		events.onPlayerMute = {"OnMuted"}
		events.onPlayerUnMute = {"OnUnmuted"}
		events.onPlayerNetworkStatus = {"OnNetworkInteruption", {_int, _int}}
		events.onPlayerPickupHit = {"OnPickupHit", {_element}}
		events.onPlayerPickupLeave = {"OnPickupLeave", {_element}}
		events.onPlayerPickupUse = {"OnPickupUse", {_element}}
		events.onPlayerPrivateMessage = {"OnPrivateMessage", {_string, _element}}
		events.onPlayerQuit = {"OnQuit", {{_enum, quitType}, _string, _element}}
		events.onPlayerScreenShot = {"OnScreenShot", {_resource, _int, _string, _int, _string}}
		events.onPlayerSpawn = {"OnSpawn", {_vector3, _float, _element, _int, _int, _int}}
		events.onPlayerStealthKill = {"OnStealthKill", {_element}}
		events.onPlayerTarget = {"OnTarget", {_element}}
		events.onPlayerVehicleEnter = {"OnVehicleEnter", {_element, _int, _element}}
		events.onPlayerVehicleExit = {"OnVehicleExit", {_element, _int, _element, _boolean}}
		events.onPlayerVoiceStart = {"OnVoiceStart"}
		events.onPlayerVoiceStop = {"OnVoiceStop"}
		events.onPlayerWeaponFire = {"OnWeaponFire", {_weaponModel, _vector3, _element, _vector3}}
		events.onPlayerWeaponSwitch = {"OnWeaponSwitch", {_weaponModel, _weaponModel}}

		-- Vehicle
		events.onTrailerAttach = {"OnAttach", {_element}}
		events.onTrailerDetach = {"OnDetach", {_element}}
		events.onVehicleDamage = {"OnDamage", {_float}}
		events.onVehicleEnter = {"OnEnter", {_element, _int, _element}}
		events.onVehicleExit = {"OnExit", {_element, _int, _element, _boolean}}
		events.onVehicleStartEnter = {"OnStartEnter", {_element, _int, _element, _int}}
		events.onVehicleStartExit = {"OnStartExit", {_element, _int, _element, _int}}
		events.onVehicleExplode = {"OnExplode"}
		events.onVehicleRespawn = {"OnRespawn", {_boolean}}

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

		-- Ped
		events.onClientPedDamage = {"OnDamage", {_element, _int, _int, _float}}
		events.onClientPedHeliKilled = {"OnHeliKilled", {_element}}
		events.onClientPedHitByWaterCannon = {"OnPedHit", {_element}}
		events.onClientPedWasted = {"OnWasted", {_element, _int, _int, _boolean}}
		events.onClientPedWeaponFire = {"OnWeaponFire", {_weaponModel, _int, _int, _vector3, _element}}
		events.onClientPedStep = {"OnStep", {_boolean}}

		-- Pickup
		events.onClientPickupHit = {"OnHit", {_element, _boolean}}
		events.onClientPickupLeave = {"OnLeave", {_element, _boolean}}

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
			local instance = m:GetElement1(source)
			if instance and instance[v[1]] then
				if v[2] == nil or #v[2] == 0 then
					instance[v[1]]()
				else
					local varArgs = {}
					local args = {...}
					local argStep = 1
					for i=1,#v[2],1 do
						local mPointer = v[2][i][2]
						local nArgs = v[2][i][1]
						local singleValFunc = true
						if type(mPointer) ~= "function" then
							mPointer = v[2][i][1][2]
							nArgs = v[2][i][1][1]
							singleValFunc = false
						end
						local stepArgs = {}
						for j=1,nArgs,1	do
							tInsert(stepArgs, args[argStep + j - 1])
						end

						if not singleValFunc then
							tInsert(stepArgs, v[2][i][2])
						end

						tInsert(varArgs, i, mPointer(unpack(stepArgs)))
						argStep = argStep + nArgs
					end	
					instance[v[1]](unpack(varArgs, 1, #v[2]))
				end
			end
		end)
	end

	-- Handle the static OnPlayerJoin event and register all player classes
	if triggerServerEvent == nil then
		addEventHandler("onPlayerJoin", getRootElement(), function()
			local player = m:GetElement1(source)
			local onJoinEvent = Slipe.Server.Peds.Player.OnJoin
			if onJoinEvent ~= nil then
				onJoinEvent(player)
			end
		end)
	else
		addEventHandler("onClientPlayerJoin", getRootElement(), function()
			local player = m:GetElement1(source)
			local onJoinEvent = Slipe.Client.Peds.Player.OnJoin
			if onJoinEvent ~= nil then
				onJoinEvent(player)
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



