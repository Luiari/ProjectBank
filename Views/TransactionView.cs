using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectBank.Views
{
    class TransactionView
    {        
        public static void Run()
        {
            Console.Clear();

            string[] options = new string[Session.User.AccList.Count];
            for (int i = 0; i < Session.User.AccList.Count; i++)
            {
                options[i] = $"{Session.User.AccList[i].accName}    {Session.User.AccList[i].amount} sek";
            }

            ViewUI fromSelect = new ViewUI("Make a transaction", options, "from Account");
            int selectedOption = fromSelect.Run();
            Accounts fromAcc = Session.User.AccList[selectedOption];

            Console.Clear();

            ViewUI toSelect = new ViewUI("Make a transaction", options, "to Account");
            selectedOption = toSelect.Run();
            Accounts toAcc = Session.User.AccList[selectedOption];

            Console.Clear();
            Console.WriteLine(fromAcc.accName + " --> " + toAcc.accName);
            double amount;
            while(true)
            {
                Console.Write("Amount: ");
                amount = Double.Parse(Console.ReadLine());
                if (amount <= fromAcc.amount)
                {
                    break;
                }
                Console.WriteLine("Not enough money on " + toAcc.accName);
            }
                
            
            

            MakeTransaction(fromAcc, toAcc);

            MyAccountsView.Run();


            void MakeTransaction(Accounts from, Accounts to)
            {
                
                from.amount -= amount;
                to.amount += amount;
            }

        }
    }
}
