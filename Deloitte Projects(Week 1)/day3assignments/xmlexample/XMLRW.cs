using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace xmlexample
{
    class XMLRW
    {
       
            List<parts> partlist = new List<parts>();

            public XMLRW()
            {
                partlist.Add(new parts { item = "Motherboard", manufacturer = "Harry", model = "P3FB", cost = 123 });
                partlist.Add(new parts { item = "Video Card", manufacturer = "ATI", model = "Pro Wonder", cost = 163 });
                partlist.Add(new parts { item = "Sound Card", manufacturer = "Creative labs", model = "Blaster live", cost = 80 });
                partlist.Add(new parts { item = "Monitor", manufacturer = "LG", model = "995E", cost = 290 });
            }

            public void WriteXML()
            {
                XmlWriter w = XmlWriter.Create(@"c:\Files\PartsInfo.xml");
                w.WriteStartDocument();
                w.WriteStartElement("PARTS");

                foreach (var b in partlist)
                {

                    w.WriteStartElement("PART");
                    w.WriteElementString("ITEM", b.item);
                   
                    w.WriteElementString("MANUFACTURER", b.manufacturer);
                    
                    w.WriteElementString("MODEL", b.model);
                    

                    w.WriteElementString("COST", b.cost.ToString());
                    w.WriteEndElement();



                }
                w.WriteEndElement();
                w.WriteEndDocument();
                w.Close();
                Console.WriteLine("Created");



            }
        public void ReadXML()
        {
            XElement xe = XElement.Load("c:\\Files\\PartsInfo.xml");
            var data = xe.Elements();

            foreach (var d in data)
            {
                Console.WriteLine(d);
            }

            Console.WriteLine("_______________________________________________________________");
            Console.WriteLine("_______________________________________________________________");


           

            //Console.WriteLine("_______________________________________________________________");
            //Console.WriteLine("_______________________________________________________________");



            var data2 = from t in xe.Elements("PART")
                        where (int)t.Element("COST") > 150
                        select t;
          


            foreach (var d in data2)
            {
                Console.WriteLine(d);
            }


            Console.WriteLine("_______________________________________________________________");
            Console.WriteLine("_______________________________________________________________");


            foreach (var d in data)
            {
                Console.WriteLine(d.Element("ITEM").Value + "    " + d.Element("COST").Value);
            }



        }
    }
}