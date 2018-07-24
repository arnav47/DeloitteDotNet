using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;


namespace CodeFirstPizza
{
    class PizzaDBEnities : DbContext
    {
        public DbSet<pizzaDetail> PizzaDetails { get; set; }

        public PizzaDBEnities():base("MyDB")
        {                                 

        }


    }
}
   

