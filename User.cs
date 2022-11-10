using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectBank
{
    class User
    {
        public string _Username = "Marre";
        public string _Password = "Cykel";
        bool isLocked = false;

        public string Username
        {
            get { return _Username; } set { _Username = "Marre"; }
        }
        public string Password
        {
            get { return _Password; } set { _Password = "Cykel"; }
        }

        
    }
}
