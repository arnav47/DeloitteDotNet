using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsExample
{
    class Class1
    {
        string name;
        int age;
        string email;

        public void GetData()
        {
            Console.WriteLine("Enter Name: ");
            name = Console.ReadLine();

            Console.WriteLine("Enter Age: ");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Email id: ");
            email = Console.ReadLine();

        }

        public void ShowData()
        {
            Console.WriteLine("Name: "+name);
           

            Console.WriteLine("Age: "+age);
        

            Console.WriteLine("Email id: "+email);

        }

        public Class1()
        {
            name = "default";
            age = 99;
            email = "Def@ult.com";
        }

        public Class1(string name,int age,string email)
        {
            this.name = name;
            this.age = age;
            this.email = email;
        }

        ~Class1()
        {
            GC.Collect();
            Console.WriteLine("Destroyed");
        }
    }
}
