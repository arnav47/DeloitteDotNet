using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirstExample
{
    class CodeDBEntities:DbContext
    {
        public DbSet<EmployeeInfo> EmployeeInfoes { get; set; } 

        public CodeDBEntities():base("MyDB")
        {

        }


    }
}
