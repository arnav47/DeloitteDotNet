using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xmlExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //xmlser pi = new xmlser("Martin", 22);
            Serialize s = new Serialize();
            //s.SaveData(pi);

            xmlser pnew = new xmlser();
            pnew.show();
            pnew = s.GetData();
            pnew.show();

        }
    }
}
