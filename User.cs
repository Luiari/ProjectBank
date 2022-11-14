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

        List<Accounts> AccList = new List<Accounts>();

        public void AddAcc(Accounts A)
        {
            AccList.Add(A);
        }

        public List<Accounts> GetAccList()
        {
            return AccList;
        }

    }
}
