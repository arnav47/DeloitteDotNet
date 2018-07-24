using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20newfeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            employee emp = new employee();
            emp.ShowData();
            employee emp2 = new employee(111,"King","Royal",-5);
            emp2.ShowData();
        }
    }
}
