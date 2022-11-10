using System;
using System.Collections.Generic;
using System.Text;
namespace ProjectBank.Views
{
    public class DashboardView
    {
        string Username;
        public static void Run()
        {                      
            Console.Clear();
            string[] options = { "My Accounts", "Create Account", "Make a transaction", "Log out" };
            ViewUI viewUI = new ViewUI("Home", options, $"Welcome to ananas bank!");
            int selectedOption = viewUI.Run();
            switch (selectedOption)
            {
                case 0:
                    MyAccountsView.Run();
                    break;
                case 1:
                    //Open CreateAccountView
                    break;
                case 2:
                    //Open MakeTrasactionView
                    break;
                case 3:
                    LogOut();
                    break;
            }

            void LogOut()
            {
                LogInView.Run();
            }
        }
    }
}