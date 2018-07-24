using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_2
{
    class nomatchexception : Exception
    {
        public nomatchexception(string message) : base(message)
        {
            message = "No Match!";                                                                                                      
        }
    }
}
