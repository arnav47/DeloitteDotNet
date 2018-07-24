using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binarySerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            //PersonInfo pi = new PersonInfo("Clark", 53);

            SerializeData sd = new SerializeData();
            //sd.SaveData(pi);

            PersonInfo pi = new PersonInfo();
            pi.show();
            pi = sd.GetData();
            pi.show();
        }
    }
}
