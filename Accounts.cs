using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectBank
{
    public class Accounts
    {
        public string accName;
        public int accNum;
        public double amount;

        public Accounts(string accName, int accNum, double amount)
        {
            this.accName = accName;
            this.accNum = accNum;
            this.amount = amount;
        }
    }
}
