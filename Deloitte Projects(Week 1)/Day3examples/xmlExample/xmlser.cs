using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace xmlExample
{
    [XmlRoot]
   public class xmlser
    {
        [XmlElement]
        public string name { get; set; }
        [XmlElement]
        public int age { get; set; }

        public xmlser(string n, int a)
        {
            name = n;
            age = a;

        }
        public xmlser ()
        {

        }

        public void show()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
        }
    }
}
