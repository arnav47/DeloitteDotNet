using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atts
{


        [AttributeUsage(AttributeTargets.Method)]
        class MethodInfo : Attribute
        {
            public int parameters { get; set; }

            public string Mname { get; set; }
            public string ReturnType { get; set; }
            public string message { get; set; }
        }
        }
   
