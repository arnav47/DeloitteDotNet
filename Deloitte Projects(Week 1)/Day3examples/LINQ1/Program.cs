using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lambda;

namespace LINQ1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> emp = new List<Employee>
        {
            new Employee { EmpId=100,name="Martin",dept="IT",salary=350000 },
            new Employee { EmpId=110,name="freeman",dept="IT",salary=450400 },
            new Employee { EmpId=120,name="Tantui",dept="EC",salary=550500 },
            new Employee { EmpId=130,name="Clark",dept="EC",salary=650600 }
            };

            var data = from t in emp
                       select t;
            foreach (var d in data)
            {
                Console.WriteLine(d.EmpId + " " + d.dept + "  " + d.name + " " + d.salary);
            }


            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");


            var data1 = (from t in emp
                         where t.EmpId == 100
                         select t).SingleOrDefault();

            if (data1 == null)
            {
                Console.WriteLine("no such entry");

            }
            else
                Console.WriteLine(data1.EmpId + " " + data1.dept + "  " + data1.name + " " + data1.salary);




            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            var data2 = from t in emp
                        where t.dept == "IT" && t.salary > 50000
                        select t;

            foreach ( var d in data2)
            {

                Console.WriteLine(d.EmpId + " " + d.dept + "  " + d.name + " " + d.salary);
            }

            var d3 = from t in emp
                     orderby t.name ascending
                     select t.name;

            foreach(var d in d3)
            {
                Console.WriteLine(d);
            }

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");


            var d4 = from t in emp
                     select new { EmpName = t.name, EmpSalary = t.salary };

            foreach (var d in d4)

                Console.WriteLine(d.EmpName + " " + d.EmpSalary);


            Console.WriteLine("~~~~~~~~~~~~~~~~~~Group by~~~~~~~~~~~~~~~~~~~~~~~");


            var data5 = from t in emp
                        group t by t.dept into grp
                        select new { DeptName = grp.Key, EmpCount = grp.Count(), SumSalary = grp.Sum(x => x.salary) };


            foreach (var d in data5)

                Console.WriteLine(d.DeptName + " " + d.EmpCount + " " + d.SumSalary);


            Console.WriteLine("~~~~~~~~~~~~~~~~~~MAX MIN SALARY~~~~~~~~~~~~~~~~~~~~~~~");

            var d6 = from t in emp
                     where t.salary == emp.Max(x => x.salary)
                     select t;

            foreach ( var d in d6)
            {
                Console.WriteLine(d.EmpId + " " + d.dept + "  " + d.name + " " + d.salary);
            }


            var d7 = from t in emp
                     where t.salary == emp.Min(x => x.salary)
                     select t;

            foreach (var d in d7)
            {
                Console.WriteLine(d.EmpId + " " + d.dept + "  " + d.name + " " + d.salary);
            }


        }



    }
}
