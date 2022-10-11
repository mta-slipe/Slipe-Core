using System;
using System.Collections.Generic;
using System.Text;
using SlipeLua.MtaDefinitions;
using SlipeLua.Shared.Elements;
using SlipeLua.Server.Acl;
using System.ComponentModel;
using SlipeLua.Server.Peds;
using SlipeLua.Server.Accounts.Events;
using SlipeLua.Server.Elements;

namespace SlipeLua.Server.Accounts
{
    /// <summary>
    /// The account class represents a player's server account. 
    /// </summary>
    public sealed class Account : IAclObject
    {
        private static Dictionary<object, Account> accounts = new Dictionary<object, Account>();

        #region Properties

        internal MtaAccount MTAAccount { get; }

        /// <summary>
        /// This function checks to see if an account is a guest account. 
        /// </summary>
        public bool IsGuestAccount
        {
            get
            {
                return MtaServer.IsGuestAccount(MTAAccount);
            }
        }

        /// <summary>
        /// Get the username of this account
        /// </summary>
        public string Name
        {
            get
            {
                return MtaServer.GetAccountName(MTAAccount);
            }
        }

        /// <summary>
        /// Get the ID of the account
        /// </summary>
        public int Id
        {
            get
            {
                return MtaServer.GetAccountID(MTAAccount);
            }
        }

        /// <summary>
        /// Get the IP of the account
        /// </summary>
        public string Ip
        {
            get
            {
                return MtaServer.GetAccountIP(MTAAccount);
            }
        }

        /// <summary>
        /// Get the serial of this account
        /// </summary>
        public string Serial
        {
            get
            {
                return MtaServer.GetAccountSerial(MTAAccount);
            }
        }

        /// <summary>
        /// Get the player currently playing on this account if any
        /// </summary>
        public Player Player
        {
            get
            {
                try
                {
                    return ElementManager.Instance.GetElement<Player>(MtaServer.GetAccountPlayer(MTAAccount));
                }
                catch (MtaException)
                {
                    throw new AccountException("No player can be found using this account");
                }
            }
        }

        /// <summary>
        /// Returns the identifiable string user.{name}
        /// </summary>
        public string AclIdentifier
        {
            get
            {
                return "user." + Name;
            }
        }

        /// <summary>
        /// Returns a dictionary of all the data stored in this account
        /// </summary>
        public Dictionary<string, string> Data
        {
            get
            {
                return MtaShared.GetDictionaryFromTable(MtaServer.GetAllAccountData(MTAAccount), "System.String", "System.String");
            }
        }

        #endregion

        #region Static Properties

        /// <summary>
        /// Returns an array of all existing accounts
        /// </summary>
        public static Account[] All
        {
            get
            {
                MtaAccount[] array = MtaShared.GetArrayFromTable(MtaServer.GetAccounts(), "account");
                return CastMultiple(array);
            }
        }

        /// <summary>
        /// Returns an array of all accounts that were logged onto from a serial
        /// </summary>
        public static Account[] GetAccountsBySerial(string serial)
        {
            MtaAccount[] array = MtaShared.GetArrayFromTable(MtaServer.GetAccountsBySerial(serial), "account");
            return CastMultiple(array);
        }

        /// <summary>
        /// Returns an array containing all accounts that were logged onto from specified IP-address.
        /// </summary>
        public static Account[] GetAccountsByIP(string ip)
        {
            MtaAccount[] array = MtaShared.GetArrayFromTable(MtaServer.GetAccountsByIP(ip), "account");
            return CastMultiple(array);
        }

        /// <summary>
        /// Returns an array containing all accounts with specified dataName and value (
        /// </summary>
        public static Account[] GetAccountsByData(string key, string value)
        {
            MtaAccount[] array = MtaShared.GetArrayFromTable(MtaServer.GetAccountsByData(key, value), "account");
            return CastMultiple(array);
        }

        #endregion

        #region Constructors

        [EditorBrowsable(EditorBrowsableState.Never)]
        internal Account(MtaAccount account)
        {
            MTAAccount = account;
            accounts.Add(MTAAccount, this);
        }

        /// <summary>
        /// This function adds an account to the list of registered accounts of the current server.
        /// </summary>
        public Account(string name, string password, bool caseSensitive = false)
            : this(MtaServer.AddAccount(name, password, caseSensitive)) { }
        #endregion

        #region Methods

        /// <summary>
        /// This function copies all of the data from one account to this account
        /// </summary>
        public bool CopyFrom(Account fromAccount)
        {
            return MtaServer.CopyAccountData(MTAAccount, fromAccount.MTAAccount);
        }

        /// <summary>
        /// This function retrieves a string that has been stored using SetData.
        /// </summary>
        public string GetData(string key)
        {
            return MtaServer.GetAccountData(MTAAccount, key);
        }

        /// <summary>
        /// This function tries to retrieve the data value and returns true if this was succesful
        /// </summary>
        /// <param name="key">The key at which data is stored</param>
        /// <param name="data">The string to which to write the data to</param>
        /// <returns>True if the data was succesfully retrieved, false otherwise</returns>
        public bool TryGetData(string key, out string data)
        {
            try
            {
                data = MtaServer.GetAccountData(MTAAccount, key);
                return true;
            } catch(Exception)
            {
                data = "";
                return false;
            }
        }

        /// <summary>
        /// This function sets a string to be stored in an account.
        /// </summary>
        public bool SetData(string key, string value)
        {
            return MtaServer.SetAccountData(MTAAccount, key, value);
        }

        /// <summary>
        /// This function removes data under a specific key
        /// </summary>
        public bool ClearData(string key)
        {
            return MtaServer.SetAccountData(MTAAccount, key, false);
        }

        /// <summary>
        /// Removes this account from the server
        /// </summary>
        public bool Remove()
        {
            return MtaServer.RemoveAccount(MTAAccount);
        }

        /// <summary>
        /// Sets the name of an account
        /// </summary>
        public bool SetName(string name, bool caseSensitive = false)
        {
            return MtaServer.SetAccountName(MTAAccount, name, caseSensitive);
        }

        /// <summary>
        /// Used to set the password of this account, encrypted with sha256
        /// </summary>
        public bool SetPassword(string value)
        {
            return MtaServer.SetAccountPassword(MTAAccount, value);
        }

        /// <summary>
        /// Check if the object has access to a given action
        /// </summary>
        public bool HasPermissionTo(string action, bool defaultPermission = true)
        {
            return MtaServer.HasObjectPermissionTo(AclIdentifier, action, defaultPermission);
        }

        /// <summary>
        /// Check if the object is in a certain ACL group
        /// </summary>
        public bool IsInACLGroup(AclGroup group)
        {
            return MtaServer.IsObjectInACLGroup(AclIdentifier, group.ACL);
        }

        #endregion

        #region Static Methods

        internal static Account Get(MtaAccount account)
        {
            if (account == null)
            {
                return null;
            }
            if (accounts == null)
            {
                accounts = new Dictionary<object, Account>();
            }
            if (!accounts.ContainsKey(account))
            {
                return new Account(account);
            }
            return accounts[account];
        }

        /// <summary>
        /// Get an account from some credentials
        /// </summary>
        public static Account Get(string username, string password = null, bool caseSensitive = true)
        {
            try
            {
                return Get(MtaServer.GetAccount(username, password, caseSensitive));
            }
            catch (MtaException)
            {
                throw new AccountException("No account with these credentials could be found");
            }
        }

        /// <summary>
        /// Get an account from an account ID
        /// </summary>
        public static Account Get(int ID)
        {
            try
            {
                return Get(MtaServer.GetAccountByID(ID));
            }
            catch (MtaException)
            {
                throw new AccountException("No account with this ID found");
            }
        }

        internal static Account[] CastMultiple(MtaAccount[] accounts)
        {
            Account[] result = new Account[accounts.Length];
            for (int i = 0; i < accounts.Length; i++)
            {
                result[i] = Get(accounts[i]);
            }
            return result;
        }

        #endregion

        #region Events

#pragma warning disable 67

        public delegate void OnDataChangeHandler(RootElement source, OnDataChangeEventArgs eventArgs);
        public static event OnDataChangeHandler OnDataChange;

#pragma warning restore 67

        #endregion

    }
}
