using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person
{
    public class human
    {
        string fname, lname, email;
        DateTime DOB;

    
        public human (string f,string l,string e,DateTime d)
        {
            fname = f;
            lname = l;
            email = e;
            DOB = d;

        }

        public human(string f, string l, string e)
        {
            fname = f;
            lname = l;
            email = e;
            DOB = DateTime.Now;

        }

        public human(string f, string l, DateTime d)
        {
            fname = f;
            lname = l;
            email = "arnav@gmail.com";
            DOB = d;

        }
        public void CalculateAge(DateTime DOB)
        {
            int years = DateTime.Now.Year - DOB.Year;

            if ((DOB.Month > DateTime.Now.Month) || (DOB.Month == DateTime.Now.Month && DOB.Day > DateTime.Now.Day))
                years--;

            if(years>=18)
            {
                Console.WriteLine("Adult!");

            }
            else
            {
                Console.WriteLine("Not Adult!");
            }

            
        }
        //monthwise
        public void Sunsign(DateTime DOB)
        {
            if(DOB.Month==1)
            {
                Console.WriteLine("Aquarius");
            }

            else if (DOB.Month == 2)
            {
                Console.WriteLine("Pisces");
            }

            else if (DOB.Month == 3)
            {
                Console.WriteLine("Aries");
            }

            else if (DOB.Month == 4)
            {
                Console.WriteLine("Taurus");
            }

            else if (DOB.Month == 5)
            {
                Console.WriteLine("Gemini");
            }

            else if (DOB.Month == 6)
            {
                Console.WriteLine("Cancer");
            }

            else if (DOB.Month == 7)
            {
                Console.WriteLine("Leo");
            }

            else if (DOB.Month == 8)
            {
                Console.WriteLine("Virgo");
            }

            else if (DOB.Month == 9)
            {
                Console.WriteLine("Libra");
            }

            else if (DOB.Month == 10)
            {
                Console.WriteLine("Scorpio");
            }

            else if (DOB.Month == 11)
            {
                Console.WriteLine("Sagittarius");
            }

            else if (DOB.Month == 12)
            {
                Console.WriteLine("Capricorn");
            }


        }

       public void Birthday(DateTime DOB)
        {
            if ((DOB.DayOfYear )== DateTime.Now.DayOfYear)
                {
                Console.WriteLine("HAPPY BIRTHDAY!");
            }

            else
            {
                Console.WriteLine("TODAY is NOT your Birthday");
            }

            
        }
       
    }
}
