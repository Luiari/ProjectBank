using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectBank.Views
{
    class AdminDashboard
    {
        string Username;
        public static void Run(List<User> users)
        {
            Console.Clear();

            

            string[] options = { "Customers", "Create new customer", "See transactions", "Log out" };
            AdminView adminviewUI = new AdminView("Home", options, $"Welcome. Inlogged as Admin!");
            int selectedOptions = adminviewUI.Run();
            switch (selectedOptions)
            {
                case 0:
                    AdminCustomerView.Run(users);
                    break;
                case 1:
                    CreateCustomerView.Run(users);
                    break;
                case 2:
                    //Open SeeTrasactionsView
                    break;
                case 3:
                    LogOut();
                    break;
            }
            void LogOut()
            {
                //LogInView.Run();
            }
            
        }
    }
}
