using System;
using System.Collections.Generic;
using System.Text;
using Slipe.Server.Interfaces;
using Slipe.Server.Exceptions;
using Slipe.MTADefinitions;
using Slipe.Shared;

namespace Slipe.Server
{
    /// <summary>
    /// The account class represents a player's server account. 
    /// </summary>
    public class Account : IACLObject
    {
        private MTAAccount _account;

        public MTAAccount MTAAccount
        {
            get
            {
                return _account;
            }
        }

        /// <summary>
        /// Creates an Account class from an MTA account
        /// </summary>
        public Account(MTAAccount MTAAccount)
        {
            _account = MTAAccount;
        }

        /// <summary>
        /// This function adds an account to the list of registered accounts of the current server.
        /// </summary>
        public Account(string name, string password, bool caseSensitive = false)
        {
            try
            {
                _account = MTAServer.AddAccount(name, password, caseSensitive);
            }
            catch (MTAException)
            {
                throw new AccountException("The account with the specified name already exists");
            }
            
        }

        /// <summary>
        /// This function copies all of the data from one account to this account
        /// </summary>
        public bool CopyFrom(Account fromAccount)
        {
            return MTAServer.CopyAccountData(_account, fromAccount.MTAAccount);
        }

        /// <summary>
        /// Get an account from some credentials
        /// </summary>
        public static Account Get(string username, string password = null, bool caseSensitive = true)
        {
            try
            {
                return new Account(MTAServer.GetAccount(username, password, caseSensitive));
            }
            catch(MTAException)
            {
                throw new AccountException("No account with these credentials could be found");
            }
        }

        /// <summary>
        /// Get an account from an account ID
        /// </summary>
        public static Account GetByID(int ID)
        {
            try
            {
                return new Account(MTAServer.GetAccountByID(ID));
            }
            catch (MTAException)
            {
                throw new AccountException("No account with this ID found");
            }
        }

        /// <summary>
        /// Returns an array of all existing accounts
        /// </summary>
        public static Account[] All
        {
            get
            {
                MTAAccount[] array = MTAShared.GetArrayFromTable(MTAServer.GetAccounts(), "account");
                Account[] accounts = new Account[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    accounts[i] = new Account(array[i]);
                }
                return accounts;
            }
        }



        /// <summary>
        /// Returns an array of all accounts that were logged onto from a serial
        /// </summary>
        public static Account[] GetAccountsBySerial(string serial)
        {
            dynamic[] array = MTAShared.GetArrayFromTable(MTAServer.GetAccountsBySerial(serial), "account");
            Account[] accounts = new Account[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                accounts[i] = new Account((MTAAccount)array[i]);
            }
            return accounts;
        }

        /// <summary>
        /// Returns an array containing all accounts that were logged onto from specified IP-address.
        /// </summary>
        public static Account[] GetAccountsByIP(string ip)
        {
            dynamic[] array = MTAShared.GetArrayFromTable(MTAServer.GetAccountsByIP(ip), "account");
            Account[] accounts = new Account[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                accounts[i] = new Account((MTAAccount)array[i]);
            }
            return accounts;
        }

        /// <summary>
        /// Returns an array containing all accounts with specified dataName and value (
        /// </summary>
        public static Account[] GetAccountsByData(string key, string value)
        {
            dynamic[] array = MTAShared.GetArrayFromTable(MTAServer.GetAccountsByData(key, value), "account");
            Account[] accounts = new Account[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                accounts[i] = new Account((MTAAccount)array[i]);
            }
            return accounts;
        }

        /// <summary>
        /// Returns a dictionary of all the data stored in this account
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, string> AllData
        {
            get
            {
                return MTAShared.GetDictionaryFromTable(MTAServer.GetAllAccountData(_account), "System.String", "System.String");
            }
        }

        /// <summary>
        /// This function retrieves a string that has been stored using SetData.
        /// </summary>
        public string GetData(string key)
        {
            return MTAServer.GetAccountData(_account, key);
        }

        /// <summary>
        /// This function sets a string to be stored in an account.
        /// </summary>
        public bool SetData(string key, string value)
        {
            return MTAServer.SetAccountData(_account, key, value);
        }

        /// <summary>
        /// Removes this account from the server
        /// </summary>
        public bool Remove()
        {
            return MTAServer.RemoveAccount(_account);
        }

        /// <summary>
        /// This function checks to see if an account is a guest account. 
        /// </summary>
        public bool IsGuestAccount
        {
            get
            {
                return MTAServer.IsGuestAccount(_account);
            }
        }

        /// <summary>
        /// Get the username of this account
        /// </summary>
        public string Name
        {
            get
            {
                return MTAServer.GetAccountName(_account);
            }
        }

        /// <summary>
        /// Get the ID of the account
        /// </summary>
        public int ID
        {
            get
            {
                return MTAServer.GetAccountID(_account);
            }
        }

        /// <summary>
        /// Get the IP of the account
        /// </summary>
        public string IP
        {
            get
            {
                return MTAServer.GetAccountIP(_account);
            }
        }

        /// <summary>
        /// Get the serial of this account
        /// </summary>
        public string Serial
        {
            get
            {
                return MTAServer.GetAccountSerial(_account);
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
                    return (Player) ElementManager.Instance.GetElement(MTAServer.GetAccountPlayer(_account));
                }
                catch (MTAException)
                {
                    throw new AccountException("No player can be found using this account");
                }
            }
        }

        /// <summary>
        /// Sets the name of an account
        /// </summary>
        public bool SetName(string name, bool caseSensitive = false)
        {
            return MTAServer.SetAccountName(_account, name, caseSensitive);
        }

        /// <summary>
        /// Used to set the password of this account, encrypted with sha256
        /// </summary>
        public bool SetPassword(string value)
        {
            return MTAServer.SetAccountPassword(_account, value);
        }

        /// <summary>
        /// Returns the identifiable string user.{name}
        /// </summary>
        public string ACLIdentifier
        {
            get
            {
                return "user." + Name;
            }
        }

        /// <summary>
        /// Check if the object has access to a given action
        /// </summary>
        public bool HasPermissionTo(string action, bool defaultPermission = true)
        {
            return MTAServer.HasObjectPermissionTo(ACLIdentifier, action, defaultPermission);
        }

        /// <summary>
        /// Check if the object is in a certain ACL group
        /// </summary>
        public bool IsInACLGroup(ACLGroup group)
        {
            return MTAServer.IsObjectInACLGroup(ACLIdentifier, group.ACL);
        }
    }
}
