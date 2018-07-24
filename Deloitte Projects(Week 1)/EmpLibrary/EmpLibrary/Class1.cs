using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpLibrary
{
    public class Employee
    {
        int empid;
        string name;

        public int Empid
        {
            get
            {
                return empid;
            }

            set
            {
                this.empid = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public Employee()
        {

        }
        public Employee(string name,int id)
        {
            this.name = name;
            empid = id;

        }


        public void show()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("ID: " + empid);
        }
    }
}

