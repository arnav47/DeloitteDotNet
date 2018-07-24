using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20newfeatures
{
    partial class employee
    {
        public void ShowData()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Name " + name);
            Console.WriteLine("Salary " + salary);
        }
    }
}
