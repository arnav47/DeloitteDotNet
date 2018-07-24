using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace XMLinCsharp
{
    class ReadWriteXML
    {
        List<BookInfo> booklist = new List<BookInfo>();

        public ReadWriteXML()
        {
            booklist.Add(new BookInfo { BookId = 123, title = "Harry", category = "fiction", price = 400});
            booklist.Add(new BookInfo { BookId = 153, title = "Republic", category = "Non-fiction", price = 200 });
            booklist.Add(new BookInfo { BookId = 143, title = "Moby", category = "fiction", price = 300 });
           
        }

        public void WriteXML()
        {
            XmlWriter w = XmlWriter.Create(@"c:\Files\BookInfo.xml");
            w.WriteStartDocument();
            w.WriteStartElement("BookInfo");

            foreach(var b in booklist)
            {
                w.WriteStartElement("Books");
                w.WriteAttributeString("BookId", b.BookId.ToString());

                w.WriteStartElement("Description");
                w.WriteElementString("Title", b.title);

                w.WriteElementString("Category", b.category);
                w.WriteEndElement();

                w.WriteElementString("Price", b.price.ToString());
                w.WriteEndElement();



            }
            w.WriteEndElement();
            w.WriteEndDocument();
            w.Close();
            Console.WriteLine("Created");


           
        }

        public void ReadXML()
        {
            XElement xe = XElement.Load("c:\\Files\\BookInfo.xml");
            var data = xe.Elements();

            foreach(var d in data)
            {
                Console.WriteLine(d);
            }

            Console.WriteLine("_______________________________________________________________");
            Console.WriteLine("_______________________________________________________________");

            foreach(var d in data)
            {
                Console.WriteLine(d.Element("Description").Value + "    " + d.Element("Price").Value);
            }

            Console.WriteLine("_______________________________________________________________");
            Console.WriteLine("_______________________________________________________________");

          
            foreach (var d in data)
            {
                Console.WriteLine(d.Element("Description").Element("Title").Value + "     " + d.Element("Price").Value);
            }

            var data2 = from t in xe.Elements("Books")
                        where (int)t.Element("Price") > 500
                        select t;
            Console.WriteLine("_______________________________________________________________");
            Console.WriteLine("_______________________________________________________________");


            foreach (var d in data2)
            {
                Console.WriteLine(d);
            }
        }
    }
}
