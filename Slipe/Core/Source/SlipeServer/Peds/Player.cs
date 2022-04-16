﻿using SlipeLua.MtaDefinitions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using SlipeLua.Shared.Exceptions;
using SlipeLua.Shared.Elements;
using SlipeLua.Shared.Utilities;
using SlipeLua.Server.Accounts;
using SlipeLua.Shared.Peds;
using SlipeLua.Server.Rendering;
using System.ComponentModel;
using SlipeLua.Server.Displays;
using SlipeLua.Shared.CollisionShapes;
using SlipeLua.Shared.IO;
using SlipeLua.Server.Markers;
using SlipeLua.Server.Pickups;
using SlipeLua.Server.Resources;
using SlipeLua.Server.Vehicles;
using SlipeLua.Shared.Vehicles;
using SlipeLua.Server.Weapons;
using SlipeLua.Shared.Helpers;
using SlipeLua.Server.Game;
using SlipeLua.Server.Peds.Events;
using SlipeLua.Shared.Elements.Events;

namespace SlipeLua.Server.Peds
{
    /// <summary>
    /// Class for a player in the MTA server
    /// </summary>
    [DefaultElementClass(ElementType.Player)]
    public class Player : Ped
    {
        #region Properties

        internal bool IsReadyForIncomingRequests { get; set; }

        /// <summary>
        /// Get the camera of the player
        /// </summary>
        public Camera Camera { get; }

        /// <summary>
        /// Get and set the wanted level of the player
        /// </summary>
        public int WantedLevel
        {
            get
            {
                return MtaServer.GetPlayerWantedLevel(element);
            }
            set
            {
                MtaServer.SetPlayerWantedLevel(element, value);
            }
        }

        /// <summary>
        /// Get and set the name of the player
        /// </summary>
        public string Name
        {
            get
            {
                return MtaShared.GetPlayerName(element);
            }
            set
            {
                MtaServer.SetPlayerName(element, value);
            }
        }

        /// <summary>
        /// Get and set the team of the player
        /// </summary>
        public Team Team
        {
            get
            {
                try
                {
                    return ElementManager.Instance.GetElement<Team>(MtaShared.GetPlayerTeam(element));
                } catch(MtaException)
                {
                    return null;
                }                
            }
            set
            {
                MtaServer.SetPlayerTeam(MTAElement, value.MTAElement);
            }
        }

        /// <summary>
        /// This function returns the specified player's account object.
        /// </summary>
        public Account Account
        {
            get
            {
                return Account.Get(MtaServer.GetPlayerAccount(element));
            }
        }

        /// <summary>
        /// Get and set if the player map forcefuly shows
        /// </summary>
        public bool ForceMap
        {
            get
            {
                return MtaServer.IsPlayerMapForced(element);
            }
            set
            {
                MtaServer.ForcePlayerMap(element, value);
            }
        }

        /// <summary>
        /// Get and set the motion blur level of the player
        /// </summary>
        public int BlurLevel
        {
            get
            {
                return MtaServer.GetPlayerBlurLevel(element);
            }
            set
            {
                MtaServer.SetPlayerBlurLevel(element, value);
            }
        }

        /// <summary>
        /// Get the amount of time in milliseconds that a players position has not changed.
        /// </summary>
        public int IdleTime
        {
            get
            {
                return MtaServer.GetPlayerIdleTime(element);
            }
        }

        /// <summary>
        /// Returns a string containing the IP address of the player.
        /// </summary>
        public string IP
        {
            get
            {
                return MtaServer.GetPlayerIP(element);
            }
        }

        /// <summary>
        /// Get and set the money of the player
        /// </summary>
        public int Money
        {
            get
            {
                return MtaServer.GetPlayerMoney(element);
            }
            set
            {
                MtaServer.SetPlayerMoney(element, value, false);
            }
        }

        /// <summary>
        /// Get and set the color of the player's nametag
        /// </summary>
        public Color NametagColor
        {
            get
            {
                Tuple<int, int, int> r = MtaShared.GetPlayerNametagColor(element);
                return new Color((byte)r.Item1, (byte)r.Item2, (byte)r.Item3);
            }
            set
            {
                MtaShared.SetPlayerNametagColor(element, value.R, value.G, value.B);
            }
        }

        /// <summary>
        /// This will change the text of a player's nickname in the world to something besides the nickname he chose. This will not change the player's actual nickname, it only changes the visible aspect inside the world
        /// </summary>
        public string NametagText
        {
            get
            {
                return MtaShared.GetPlayerNametagText(element);
            }
            set
            {
                MtaShared.SetPlayerNametagText(element, value);
            }
        }

        /// <summary>
        /// Get and set wether the nametag is visible
        /// </summary>
        public bool NametagShowing
        {
            get
            {
                return MtaShared.IsPlayerNametagShowing(element);
            }
            set
            {
                MtaShared.SetPlayerNametagShowing(element, value);
            }
        }

        /// <summary>
        /// Get the ping in milliseconds
        /// </summary>
        public int Ping
        {
            get
            {
                return MtaShared.GetPlayerPing(element);
            }
        }

        /// <summary>
        /// Get the serial of the player
        /// </summary>
        public string Serial
        {
            get
            {
                return MtaServer.GetPlayerSerial(element);
            }
        }

        /// <summary>
        /// This function gets the client version of the specified player as a sortable string. 
        /// </summary>
        public string Version
        {
            get
            {
                return MtaServer.GetPlayerVersion(element);
            }
        }

        /// <summary>
        /// Get and set if the player is muted
        /// </summary>
        public bool Muted
        {
            get
            {
                return MtaServer.IsPlayerMuted(element);
            }
            set
            {
                MtaServer.SetPlayerMuted(element, value);
            }
        }

        #endregion

        #region Static Properties

        /// <summary>
        /// Get an array of all players in the server
        /// </summary>
        public static Player[] All
        {
            get
            {
                MtaElement[] elements = MtaShared.GetArrayFromTable(MtaServer.GetElementsByType("player", Root.MTAElement), "MTAElement");
                return ElementManager.Instance.CastArray<Player>(elements);
            }
        }

        /// <summary>
        /// Get an array of all alive players in the server
        /// </summary>
        public static Player[] Alive
        {
            get
            {
                MtaElement[] elements = MtaShared.GetArrayFromTable(MtaServer.GetAlivePlayers(), "MTAElement");
                return ElementManager.Instance.CastArray<Player>(elements);
            }
        }

        /// <summary>
        /// Get an array of all dead players in the server
        /// </summary>
        public static Player[] Dead
        {
            get
            {
                MtaElement[] elements = MtaShared.GetArrayFromTable(MtaServer.GetDeadPlayers(), "MTAElement");
                return ElementManager.Instance.CastArray<Player>(elements);
            }
        }

        /// <summary>
        /// Get a random player
        /// </summary>
        public static Player Random
        {
            get
            {
                try
                {
                    return ElementManager.Instance.GetElement<Player>(MtaServer.GetRandomPlayer());
                }catch(MtaException)
                {
                    return null;
                }
                
            }
        }

        /// <summary>
        /// Get the total amount of players in the server
        /// </summary>
        public static int Count
        {
            get
            {
                return MtaServer.GetPlayerCount();
            }
        }

        #endregion

        #region Constructor

        [EditorBrowsable(EditorBrowsableState.Never)]
        public Player(MtaElement mtaElement) : base(mtaElement)
        {
            Camera = new Camera(this);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Check if this palyer can observe a certain display
        /// </summary>
        public bool IsDisplayObserver(Display display)
        {
            return MtaServer.TextDisplayIsObserver(display.DisplayElement, element);
        }

        /// <summary>
        /// Logs the player into an account
        /// </summary>
        public bool Login(Account account, string password)
        {
            return MtaServer.LogIn(element, account.MTAAccount, password);
        }

        /// <summary>
        /// Logs the player out of the account they're currently logged on
        /// </summary>
        public bool LogOut()
        {
            return MtaServer.LogOut(element);
        }

        /// <summary>
        /// Spawn the player at a certain position
        /// </summary>
        public void Spawn(Vector3 position, PedModel skin, int rotation = 0, int interior = 0, int dimension = 0, Team team = null)
        {
            MtaServer.SpawnPlayer(element, position.X, position.Y, position.Z, rotation, (int) skin, interior, dimension, team == null ? null : team.MTAElement);
        }

        /// <summary>
        /// This function allows you to change ASE announce values for any player using a specified key. As an example this can be used to change the "score" value which will be shown at game-monitor.com's server list.
        /// </summary>
        public bool SetAnnounceValue(string key, string value)
        {
            return MtaServer.SetPlayerAnnounceValue(element, key, value);
        }

        /// <summary>
        /// This function retrieves a players ASE announce value under a certain key.
        /// </summary>
        public string GetAnnounceValue(string key)
        {
            return MtaServer.GetPlayerAnnounceValue(element, key);
        }

        /// <summary>
        /// Adds money to the player's money
        /// </summary>
        public bool GiveMoney(int amount)
        {
            return MtaServer.GivePlayerMoney(element, amount);
        }

        /// <summary>
        /// Redirects the player to a different server
        /// </summary>
        public bool Redirect(string serverIP, int serverPort = 0, string serverPassword = "")
        {
            return MtaServer.RedirectPlayer(element, serverIP, serverPort, serverPassword);
        }

        /// <summary>
        /// This function will force the specified player to resend their AC info, triggering the onPlayerACInfo event again.
        /// </summary>
        public bool ResendACInfo()
        {
            return MtaServer.ResendPlayerACInfo(element);
        }

        /// <summary>
        /// This function will force the specified player to resend their mod info, triggering the onPlayerModInfo event again.
        /// </summary>
        public bool ResendModInfo()
        {
            return MtaServer.ResendPlayerModInfo(element);
        }

        /// <summary>
        /// Set the visibility of a Hud component
        /// </summary>
        public bool SetHudComponentVisible(HudComponent component, bool visible)
        {
            return MtaServer.SetPlayerHudComponentVisible(element, component.ToString().ToLower(), visible);
        }

        /// <summary>
        /// This function allows you to change who can hear the voice of a player.
        /// </summary>
        public bool SetVoiceBroadCastTo(Element[] targets)
        {
            return MtaServer.SetPlayerVoiceBroadcastTo(element, targets);
        }

        /// <summary>
        /// This function allows you to mute voices for a player
        /// </summary>
        public bool SetVoiceIgnoreFrom(Element[] targets)
        {
            return MtaServer.SetPlayerVoiceIgnoreFrom(element, targets);
        }

        /// <summary>
        /// Substract money from the player
        /// </summary>
        public bool TakeMoney(int amount)
        {
            return MtaServer.TakePlayerMoney(element, amount);
        }

        /// <summary>
        /// This function forces a client to capture the current screen output and send it back to the server. The image will contain the GTA HUD and the output of any dxDraw functions that are not flagged as 'post GUI'. The image specifically excludes the chat box and all GUI (including the client console). The result is received with the event onPlayerScreenShot.
        /// </summary>
        public bool TakeScreenShot(Vector2 dimensions, string tag = "", int quality = 30, int maxBandwith = 5000, int maxPacketSize = 500)
        {
            return MtaServer.TakePlayerScreenShot(element, (int)dimensions.X, (int)dimensions.Y, tag, quality, maxBandwith, maxPacketSize);
        }

        /// <summary>
        /// Play an internal GTA sound to this player
        /// </summary>
        public bool PlaySoundFrontEnd(FrontEndSound frontEndSound)
        {
            return MtaServer.PlaySoundFrontEnd(element, (int)frontEndSound);
        }

        /// <summary>
        /// Detonate the satchels this player has laid
        /// </summary>
        public bool DetonateSatchels()
        {
            return MtaServer.DetonateSatchels(element);
        }

        /// <summary>
        /// Kicks a player from the server
        /// </summary>
        /// <param name="reason"></param>
        /// <param name="responsiblePlayer"></param>
        /// <returns></returns>
        public bool Kick(string reason, Player responsiblePlayer = null)
        {
            return MtaServer.KickPlayer(this.MTAElement, responsiblePlayer.MTAElement, reason);
        }

        /// <summary>
        /// Kicks a player from the server
        /// </summary>
        /// <param name="reason"></param>
        /// <param name="responsiblePlayer"></param>
        /// <returns></returns>
        public bool Kick(string reason, string responsiblePlayer = null)
        {
            return MtaServer.KickPlayer(this.MTAElement, responsiblePlayer, reason);
        }

        #endregion

        #region Static Methods

        /// <summary>
        /// Retrieves a player class instance from a specified player name 
        /// </summary>
        public static Player GetFromName(string name)
        {
            try
            {
                return ElementManager.Instance.GetElement<Player>(MtaShared.GetPlayerFromName(name));
            }
            catch (MtaException)
            {
                throw new NullElementException("No player with the name " + name + " could be found.");
            }
        }

        #endregion

        #region Events

        #pragma warning disable 67

        public delegate void OnConsoleHandler(Player source, OnConsoleEventArgs eventArgs);
        public event OnConsoleHandler OnConsole;

        public delegate void OnCollisionShapeHitHandler(Player source, OnCollisionShapeHitEventArgs eventArgs);
        public event OnCollisionShapeHitHandler OnCollisionShapeHit;

        public delegate void OnCollisionShapeLeaveHandler(Player source, OnCollisionShapeLeaveEventArgs eventArgs);
        public event OnCollisionShapeLeaveHandler OnCollisionShapeLeave;

        public delegate void OnJoinHandler(Player source, OnJoinEventArgs eventArgs);
        public static event OnJoinHandler OnJoin;

        public delegate void OnAcInfoHandler(Player source, OnAcInfoEventArgs eventArgs);
        public event OnAcInfoHandler OnAcInfo;

        public delegate void OnBanAddedHandler(Player source, OnBanAddedEventArgs eventArgs);
        public event OnBanAddedHandler OnBanAdded;

        public delegate void OnBannedHandler(Player source, OnBannedEventArgs eventArgs);
        public event OnBannedHandler OnBanned;

        public delegate void OnNicknameChangedHandler(Player source, OnNicknameChangedEventArgs eventArgs);
        public event OnNicknameChangedHandler OnNicknameChanged;

        public delegate void OnChatHandler(Player source, OnChatEventArgs eventArgs);
        public event OnChatHandler OnChat;

        public delegate void OnClickHandler(Player source, OnClickEventArgs eventArgs);
        public event OnClickHandler OnClick;

        public delegate void OnCommandHandler(Player source, OnCommandEventArgs eventArgs);
        public event OnCommandHandler OnCommand;

        public delegate void OnContactHandler(Player source, OnContactEventArgs eventArgs);
        public event OnContactHandler OnContact;

        public delegate void OnDamageHandler(Player source, OnDamageEventArgs eventArgs);
        public event OnDamageHandler OnDamage;

        public delegate void OnLoginHandler(Player source, OnLoginEventArgs eventArgs);
        public event OnLoginHandler OnLogin;

        public delegate void OnLogoutHandler(Player source, OnLogoutEventArgs eventArgs);
        public event OnLogoutHandler OnLogout;

        public delegate void OnMarkerHitHandler(Player source, OnMarkerHitEventArgs eventArgs);
        public event OnMarkerHitHandler OnMarkerHit;

        public delegate void OnMarkerLeaveHandler(Player source, OnMarkerLeaveEventArgs eventArgs);
        public event OnMarkerLeaveHandler OnMarkerLeave;

        public delegate void OnPickupHitHandler(Player source, OnPickupHitEventArgs eventArgs);
        public event OnPickupHitHandler OnPickupHit;

        public delegate void OnPickupLeaveHandler(Player source, OnPickupLeaveEventArgs eventArgs);
        public event OnPickupLeaveHandler OnPickupLeave;

        public delegate void OnPickupUseHandler(Player source, OnPickupUseEventArgs eventArgs);
        public event OnPickupUseHandler OnPickupUse;

        public delegate void OnModInfoHandler(Player source, OnModInfoEventArgs eventArgs);
        public event OnModInfoHandler OnModInfo;

        public delegate void OnMutedHandler(Player source, OnMutedEventArgs eventArgs);
        public event OnMutedHandler OnMuted;

        public delegate void OnUnmutedHandler(Player source, OnUnmutedEventArgs eventArgs);
        public event OnUnmutedHandler OnUnmuted;

        public delegate void OnNetworkInteruptionHandler(Player source, OnNetworkInteruptionEventArgs eventArgs);
        public event OnNetworkInteruptionHandler OnNetworkInteruption;

        public delegate void OnPrivateMessageHandler(Player source, OnPrivateMessageEventArgs eventArgs);
        public event OnPrivateMessageHandler OnPrivateMessage;

        public delegate void OnQuitHandler(Player source, OnQuitEventArgs eventArgs);
        public event OnQuitHandler OnQuit;

        public delegate void OnScreenShotHandler(Player source, OnScreenShotEventArgs eventArgs);
        public event OnScreenShotHandler OnScreenShot;

        public delegate void OnSpawnHandler(Player source, OnSpawnEventArgs eventArgs);
        public event OnSpawnHandler OnSpawn;

        public delegate void OnStealthKillHandler(Player source, OnStealthKillEventArgs eventArgs);
        public event OnStealthKillHandler OnStealthKill;

        public delegate void OnTargetHandler(Player source, OnTargetEventArgs eventArgs);
        public event OnTargetHandler OnTarget;

        public delegate void OnVehicleEnterHandler(Player source, OnVehicleEnterEventArgs eventArgs);
        public event OnVehicleEnterHandler OnVehicleEnter;

        public delegate void OnVehicleExitHandler(Player source, OnVehicleExitEventArgs eventArgs);
        public event OnVehicleExitHandler OnVehicleExit;

        public delegate void OnVoiceStartHandler(Player source, OnVoiceStartEventArgs eventArgs);
        public event OnVoiceStartHandler OnVoiceStart;

        public delegate void OnVoiceStopHandler(Player source, OnVoiceStopEventArgs eventArgs);
        public event OnVoiceStopHandler OnVoiceStop;

        public delegate void OnWeaponFireHandler(Player source, OnWeaponFireEventArgs eventArgs);
        public event OnWeaponFireHandler OnWeaponFire;

        #pragma warning restore 67

        #endregion

    }
}
