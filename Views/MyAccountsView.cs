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

            Console.WriteLine("test");

            string[] options = { "Exit" };
            ViewUI viewUI = new ViewUI("My Accounts", options, $"Allkonto: 15 000sek\nSparkonto: 103 000sek");

            
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