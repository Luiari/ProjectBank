using System;
using System.Collections.Generic;
using System.Text;
namespace ProjectBank.Views
{
    public class MyAccountsView
    {
        public static void Run()
        {
            Console.Clear();

            string accountList = Session.User.GetAccList()[0].accName;

            //foreach (var item in Session.User.GetAccList())
            //{
            //    accountList = "Savings account";

            //}

            string[] options = { "Exit" };
            ViewUI viewUI = new ViewUI("My Accounts", options, accountList);
            

            
            int selectedOption = viewUI.Run();
            switch (selectedOption)
            {
                case 0:
                    DashboardView.Run();
                    break;
            }
        }
    }
}