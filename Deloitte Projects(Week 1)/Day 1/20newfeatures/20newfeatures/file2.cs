using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20newfeatures
{
    partial class employee
    {
        public employee()
        {
            id = 777;
            name = "James";
            dept = "CID";
            salary = 175000;

        }

        public employee(int id,string name,string dept,double salary)
        {
            this.id = id;
            this.name = name;
            this.dept = dept;
            this.salary = salary;

        }
    }
}
