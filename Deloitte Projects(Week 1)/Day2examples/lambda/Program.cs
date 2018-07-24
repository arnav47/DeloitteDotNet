using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 0, -1, 4, 5, 7, 9, -2, 3, 2, 10 };

            foreach (var a in arr.Where(n => n > 5))
            {

                Console.WriteLine(a);
            }

            string[] cities = { "Mumbai", "Chennai", "Pune", "Hyd", "Delhi" };

            foreach (var c in cities.Where(g => g.StartsWith("P")))
            {
                Console.WriteLine(c);
            }


            foreach (var x in cities.Where(g => g.Contains("e")))
            {
                Console.WriteLine("-----------");
                Console.WriteLine(x);
            }

            var results = cities.Where(x => x.Contains("e"));
            Console.WriteLine(results.Count());


            List<Employee> emp = new List<Employee>
        {
            new Employee { EmpId=100,name="Martin",dept="IT",salary=350000 },
            new Employee { EmpId=110,name="freeman",dept="IT",salary=450400 },
            new Employee { EmpId=120,name="Tantui",dept="EC",salary=550500 },
            new Employee { EmpId=130,name="Clark",dept="EC",salary=650600 }
            };

            foreach (var e in emp)
            {
                Console.WriteLine(e.EmpId + " " + e.dept + "  " + e.name);
            }
            Console.WriteLine("-----------");
            Console.WriteLine("-----------");

            var data = emp.Where(x => x.EmpId == 100).SingleOrDefault();
            {

                Console.WriteLine(data.EmpId + " " + data.dept + "  " + data.name);
            }

            Console.WriteLine("-----------");
            Console.WriteLine("-----------");

            var d = emp.Where(x => x.dept == "IT");

            {
                foreach (var de in d)
                {

                    Console.WriteLine(de.EmpId + " " + de.dept + "  " + de.name);
                }
            }
            Console.WriteLine("-----------");
            Console.WriteLine("-----------");

            Console.WriteLine("Sorted in Asc order");

            var data4 = emp.OrderBy(x => x.name).Select(y => y.name);
            foreach (var y in data4)
            {
                Console.WriteLine(y);

            }


            Console.WriteLine("-----------******ANONYNOMOUS*******------------");
            var data5 = emp.Select(ee => new { EmpName = ee.name, EmpSalary = ee.salary });

            foreach (var ee in data5)
            {
                Console.WriteLine(ee.EmpName);

            }


            Console.WriteLine("-----SUMMARY count dept wise salary------");

            var grp = emp.GroupBy(ax => ax.dept).Select(ax => new { DeptName = ax.Key, EmpCount = ax.Count(), sumSalary = ax.Sum(ay => ay.salary) });

            foreach (var g in grp)
            {
                Console.WriteLine(g.DeptName + " " + g.EmpCount + "" + g.sumSalary);
            }

            Console.WriteLine( emp.Max(x=>x.salary));


            var maxsal = emp.Where(x => x.salary == emp.Max(y => y.salary));

            foreach(var dq in maxsal)
            {
                Console.WriteLine(dq.name +"   "+dq.salary);
            }
        }


    }
    }

