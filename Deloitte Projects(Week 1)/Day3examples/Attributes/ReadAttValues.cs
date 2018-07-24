using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    class ReadAttValues
    {
        public void ReadAttribute(Type t)
        {
           DevInfo di= (DevInfo)Attribute.GetCustomAttribute(t, typeof(DevInfo) );
            if (di==null)
                {
                Console.WriteLine("No attributes");
            }
            else
            {
                Console.WriteLine(di.EmpID + "  " + di.name +  "," + di.Pname + " " + di.DOC + " ," + di.message);
            }


        }
    }
}
