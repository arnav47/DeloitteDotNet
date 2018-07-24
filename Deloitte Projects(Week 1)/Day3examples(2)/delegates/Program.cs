using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
    class Program
    {

        public delegate void SMS(string m); 
        static void Main(string[] args)
        {
            schoolgroups sg = new schoolgroups();
            Collegegroups cg = new Collegegroups();
            Deloittegroups dg = new Deloittegroups();


            SMS sms = sg.Message;
            sms += cg.Message;
            sms += dg.Message;

            sms("Good Afternoon");

            sms -= sg.Message;
            sms -= dg.Message;

            sms("Alumini meet");

            sms -= cg.Message;
            sms += dg.Message;

            sms("Dotnet training");

        }
    }
}
