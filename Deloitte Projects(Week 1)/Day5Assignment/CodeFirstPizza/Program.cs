using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstPizza
{
    class Program
    {
        static void Main(string[] args)
        {
            pizzaDetail p1 = new pizzaDetail { PizzaId = 5, Pname = "Supreme", Toppings = "onion", price = 540, Size = "m", Type = "veg" };
            pizzaDetail p2 = new pizzaDetail { PizzaId = 54, Pname = "fantasy", Toppings = "chicken", price = 740, Size = "m", Type = "Non-veg" };
            pizzaDetail p3 = new pizzaDetail { PizzaId = 567, Pname = "nacho", Toppings = "onion", price = 840, Size = "L", Type = "veg" };
            pizzaDetail p4 = new pizzaDetail { PizzaId = 545, Pname = "Supreme", Toppings = "capsicum", price = 140, Size = "s", Type = "veg" };

            PizzaDBEnities db = new PizzaDBEnities();
            db.PizzaDetails.Add(p1);
            db.PizzaDetails.Add(p2);
            db.PizzaDetails.Add(p3);
            db.PizzaDetails.Add(p4);

            var res = db.SaveChanges();

            if (res > 0)
            {
                Console.WriteLine("Data Inserted");
            }





        }
    }
}
