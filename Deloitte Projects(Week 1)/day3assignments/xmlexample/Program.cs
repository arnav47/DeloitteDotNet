﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace xmlexample
{
    class Program
    {
        static void Main(string[] args)
        {
            XMLRW xml = new XMLRW();
            xml.WriteXML();

            xml.ReadXML();
        }
    }
}
