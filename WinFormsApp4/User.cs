using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp4
{
    internal class User
    {
        // class properties
		private string _username = string.Empty;
		private string _password = string.Empty;
        private string _rule = string.Empty;

        // class constructor
        public User(string username, string password, string rule)
        {
            this._username = username;
            this._password = password;
            this._rule = rule;
        }
        
        // method getter & setter
        public string Username
		{
			get { return _username; }
			set { _username = value; }
		}
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public string Rule
        {
            get { return _rule; }
            set { _rule = value; }
        }

    }
}
