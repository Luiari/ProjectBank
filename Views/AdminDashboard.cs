using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectBank.Views
{
    public class AdminDashboard
    {
        string Username;
        public static void Run()
        {
            Console.Clear();
            string[] options = { "Customers", "Create new customer", "See transactions", "Log out" };
            AdminViewUI adminviewUI = new AdminViewUI("Home", options, $"Welcome. Inlogged as Admin!");
            int selectedOptions = adminviewUI.Run();
            switch (selectedOptions)
            {
                case 0:
                    AdminCustomerView.Run();
                    break;
                case 1:
                    //Open CreateCustomerView
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
