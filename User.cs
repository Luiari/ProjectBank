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

        public List<Accounts> AccList = new List<Accounts>();

        public void AddAcc(Accounts A)
        {
            AccList.Add(A);
        }

        public string GetAccList()
        {
            
            string accountList = "";
            foreach (var item in AccList)
            {
                accountList += $"{item.accName}\n" +
                               $"{item.accNum}            {item.amount} sek\n" +
                               $"-------------------------------\n";
            }

            return accountList;
        }

        
            

    }
}
