using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    class ReadWrite
    {
        public void WriteFile(string fname)
        {
            StreamWriter write = new StreamWriter(fname,true);
            try
            {
                

                Console.WriteLine("Enter Data ");
                string data = Console.ReadLine();

                write.WriteLine(data);
                Console.WriteLine("Data written ");
            }
            catch (IOException io)
            {
                Console.WriteLine(io.Message);
            }

            finally
            {
                write.Close();
            }
        }

        public void ReadFile(string fname)
        {
            StreamReader read = new StreamReader (fname);
            try
            {

                string data = read.ReadToEnd();
                 
                Console.WriteLine("Data : ");
                Console.WriteLine(data);

            }
            catch (IOException io)
            {
                Console.WriteLine(io.Message);
            }

            finally
            {
                read.Close();
            }
        }

    
    }
}


