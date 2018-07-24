using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
    class schoolgroups
    {
        List<int> phone = new List<int>();

        public schoolgroups()
        {
            Random r = new Random();

            for(int i=0;i<5;i++)
            {
                phone.Add(r.Next(100000, 200000));
            }
        }

        public void Message(string msg)
        {
            foreach(var p in phone)
            {
                Console.WriteLine("School group: " + p + "  : " + msg);
            }
        }
    }

    class Collegegroups
    {
        List<int> phone = new List<int>();

        public Collegegroups()
        {
            Random r = new Random();

            for (int i = 0; i < 5; i++)
            {
                phone.Add(r.Next(200000, 300000));
            }
        }

        public void Message(string msg)
        {
            foreach (var p in phone)
            {
                Console.WriteLine("College group: " + p + "  : " + msg);
            }
        }

    }

    class Deloittegroups
    {

        List<int> phone = new List<int>();

        public Deloittegroups()
        {
            Random r = new Random();

            for (int i = 0; i < 5; i++)
            {
                phone.Add(r.Next(300000, 400000));
            }
        }

        public void Message(string msg)
        {
            foreach (var p in phone)
            {
                Console.WriteLine("Deloitte group: " + p + "  : " + msg);
            }
        }

    }

}
