using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace xmlExample
{
    class Serialize
    {
        FileStream fs = null;
        public void SaveData(xmlser pi)
        {
            
            try
            {
                fs = new FileStream(@"c:\\Files\PersonInfo.xml", FileMode.Create, FileAccess.Write);
                XmlSerializer xs = new XmlSerializer(typeof(xmlser));
                xs.Serialize(fs, pi);
                Console.WriteLine("Data Serialized");


            }

            catch(IOException ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                fs.Close();
            }
        }
        public xmlser GetData()
        {
            xmlser pi = null;
            //FileStream fs = null;
            try
            {
                fs = new FileStream(@"c:\Files\PersonInfo.xml", FileMode.Open, FileAccess.Read);
                XmlSerializer xs = new XmlSerializer(typeof(xmlser));
                pi=(xmlser)xs.Deserialize(fs);


                //xs.Serialize(fs, ps);
                Console.WriteLine("Data Deserialized");


            }

            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                fs.Close();
            }
            return pi;
        }
    }
}
