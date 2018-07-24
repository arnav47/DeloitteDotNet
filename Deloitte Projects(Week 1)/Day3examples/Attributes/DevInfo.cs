using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{

    [AttributeUsage(AttributeTargets.Class|AttributeTargets.Method|AttributeTargets.Constructor|AttributeTargets.Property,AllowMultiple = true)]
    class DevInfo:Attribute
    {
        public int EmpID { get; set; }

        public string name { get; set; }
        public string Pname { get; set; }

        public string DOC { get; set; }
        public string message { get; set; }

    }
}
