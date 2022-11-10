using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectBank
{
    public class User
    {
        public string Username; 
        public string password;
        bool isLocked = false;

        public User(string username, string password)
        {
            this.Username = username;
            this.password = password;
        }

        
    }
}
