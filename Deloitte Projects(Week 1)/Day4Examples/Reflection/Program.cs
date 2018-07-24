using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using EmpLibrary;



namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Type tt = typeof(Employee);
            ConstructorInfo[] ci = tt.GetConstructors();

            foreach(var c in ci)
            {
                Console.WriteLine("Constructor :" + c.Name);
                Console.WriteLine("Is Public?: " + c.IsPublic);
                ParameterInfo[] pi = c.GetParameters();

                foreach(var p in pi)
                {
                    Console.WriteLine("Type: " + p.ParameterType);
                    Console.WriteLine("Position: " + p.Position);
                    Console.WriteLine("DefValue: " + p.DefaultValue);
                    Console.WriteLine("_______________________________");

                }
                MethodInfo[] mi = tt.GetMethods();
                foreach(var m in mi)
                {
                    Console.WriteLine("**************************");
                    
                    Console.WriteLine("Method Name: " + m.Name);
                    Console.WriteLine("Module Name: " + m.Module);
                    Console.WriteLine("Return type: " + m.ReturnType);
                    Console.WriteLine("IsPublic: " + m.IsPublic);
                }
                MemberInfo[] fi = tt.GetMembers();

                foreach(var f in fi)
                {
                    Console.WriteLine("##########################");
                    Console.WriteLine(f.Name);
                    Console.WriteLine(f.Module);
                    Console.WriteLine(f.MemberType);
                    Console.WriteLine(f.DeclaringType)
                        ;
                }

            }
        }
    }
}
