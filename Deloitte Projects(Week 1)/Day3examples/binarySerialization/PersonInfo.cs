using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binarySerialization
{
    [Serializable]
    class PersonInfo
    {
        string name;
        int age;

        public PersonInfo()
        {

        }
        public PersonInfo(string name,int age)
        {
            this.name = name;
            this.age = age;

        }

        public void show()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("age: " + age);
        }
    }
}
