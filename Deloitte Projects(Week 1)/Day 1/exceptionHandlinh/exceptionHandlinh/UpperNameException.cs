using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionHandlinh
{
    class UpperNameException:Exception
    {
        string msg;

        public UpperNameException()
        {
            msg = "Name has to pe in upper case";

        }
        public UpperNameException(string m)
        {
            msg = m;

        }

        public override string Message
        {
            get
            {
                return msg;
            }
        }
    }
}
