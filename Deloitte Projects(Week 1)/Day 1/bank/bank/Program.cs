using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Accounts acc1 = new Accounts();

            Console.WriteLine("Enter Transaction Type");
            string TTYpe = Console.ReadLine();

            Console.WriteLine("Enter Transaction Amount");
            int amount =int.Parse( Console.ReadLine());

            
            if (TTYpe=="d")
            {
                acc1.Credit(amount);
            }

            else if (TTYpe == "w")
            {
                acc1.debit(amount);
            }

            Console.WriteLine("Balance is: "+ acc1.balance );

        }


    }
}
