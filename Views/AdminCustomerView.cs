using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectBank.Views
{
    public class AdminCustomerView
    {
        
        public static void Run()
        {



            string[] options = { "Exit" };
            AdminViewUI viewUI = new AdminViewUI("Customers", options);

            

            int selectedOption = viewUI.Run();
            switch (selectedOption)
            {
                case 0:
                    AdminCustomerView.Run();
                    break;
            }
           
        }
    }
}
