using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace NonGenericCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList al = new ArrayList();
            //al.Add(12);
            //al.Add("Hello");
            //al.Add("c");
            //al.Add(12);
            //Console.WriteLine("After Adding:");

            //foreach (object t in al)
            //    Console.WriteLine(t);

            //al.Insert(0, "New");
            //al.Insert(2, "Second new");

            //Console.WriteLine(" After Inserting:");

            //foreach (object t in al)
            //    Console.WriteLine(t);

            //al.Remove(12);
            //al.RemoveAt(2);

            //Console.WriteLine(" After Removing:");

            //foreach (object t in al)
            //    Console.WriteLine(t);

            //Console.WriteLine("Specific Data: " + al[1]);

            Hashtable ht = new Hashtable();

            ht.Add("IN", "India");
            ht.Add("US", "America");
            ht.Add("UK", "United Kingdom");

            IDictionaryEnumerator ide = ht.GetEnumerator();

            while(ide.MoveNext())
            {
                Console.WriteLine(ide.Key + " , " + ide.Value);

            }

            List<String> cities = new List<string>();
            cities.Add("Mysore");
            cities.Add("Bangalore");
            cities.Add("Chennai");
            cities.Add("Mumbai");
            cities.Add("Jaipur");

            foreach( string t in cities)
            {
                Console.WriteLine(t);
            }

            Dictionary<String, String> country = new Dictionary<string, string>();
            country.Add("In", "India");
            country.Add("US", "America");
            country.Add("UK", "United Kingdom");


            foreach (KeyValuePair<string,string> kvp in country)
                Console.WriteLine(kvp.Key + "   " + kvp.Value);

        }
    }
}
