using System;
using System.Collections.Generic;
using System.Text;
using ProjectBank.Views;

namespace ProjectBank
{
    class Startup
    {
        public User currentUser;
        
        public static void Run()
        {
            List<User> Users = new List<User>();
            User User1 = new User("Marre", "Cykel");
            User User2 = new User("Antonio", "Bil");
            User User3 = new User("Simon", "Buss");
            User User4 = new User("Admin", "Traktor");

            Accounts Acc1 = new Accounts("Savings account", 1234536123, 80000);
            User1.AddAcc(Acc1);

            Session.User = User1;

            Users.Add(User1);
            Users.Add(User2);
            Users.Add(User3);
            Users.Add(User4);

            LogInView.Run(Users);
        }


    }
}
