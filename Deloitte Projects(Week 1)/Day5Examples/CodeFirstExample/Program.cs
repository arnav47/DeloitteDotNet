using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstExample
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeInfo e1 = new EmployeeInfo { name = "Deepa", Dept = "Training", salary = 45000 };
            EmployeeInfo e2 = new EmployeeInfo { name = "Arnav", Dept = "Accounts", salary = 22000 };
            CodeDBEntities db = new CodeDBEntities();
            db.EmployeeInfoes.Add(e1);
            db.EmployeeInfoes.Add(e2);

            var res = db.SaveChanges();

            if(res>0)
            {
                Console.WriteLine("Data Inserted");
            }

        }
    }
}
