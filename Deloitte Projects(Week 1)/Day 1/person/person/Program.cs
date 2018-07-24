using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime firstDate = new DateTime(1996, 7, 16);

            human a=new human("Arnav","Jaithalya","48arnav@gmail.com",firstDate);


            a.CalculateAge(firstDate);

            a.Sunsign(firstDate);

            a.Birthday(firstDate);

        }
    }
}
