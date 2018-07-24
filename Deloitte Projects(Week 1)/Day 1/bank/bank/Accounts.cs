using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    class Accounts
    {
        int accNo;
        string name;
        string type;
        char TType;
        int amount;
        public double balance;

        public Accounts(int accNo, string name, string type, double balance)
        {
            this.accNo = accNo;
            this.name = name;
            this.type = type;
            this.balance = balance;

        }
        public Accounts()
        {
            accNo = 47;
            name = "Arnav";
            type = "Savings";
            balance = 500000;

        }

        public int Credit(int a)
        {

            amount = a;
            balance = balance + amount;
            return 0;
        }

        public int debit(int a)
        {

            amount = a;
            balance = balance - amount;
            return 0;
        }

      

    }

   
}
