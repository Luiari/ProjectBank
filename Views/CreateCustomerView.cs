using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectBank.Views
{
    class CreateCustomerView
    {
       
        public static void Run(List<User> users)
        {
            Console.Clear();

            Console.WriteLine("Create Customer");

            Console.Write("User Name:");
            string username = Console.ReadLine();
            Console.Write("Password:");
            string pw = Console.ReadLine();

            users.Add(new User(username, pw));
            AdminDashboard.Run(users);
        }
    }
}
