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
            Accounts Acc2 = new Accounts("Allkonto", 1234536124, 5000);
            Accounts Acc3 = new Accounts("Matkonto", 1234536124, 3500);

            User1.AddAcc(Acc1);
            User1.AddAcc(Acc2);
            User1.AddAcc(Acc3);
            

            Session.User = User1;

            Users.Add(User1);
            Users.Add(User2);
            Users.Add(User3);
            Users.Add(User4);

            

            LogInView.Run(Users);
        }


    }
}
