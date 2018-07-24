using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            List<PizzaOrder> po = new List<PizzaOrder>
            {

                new PizzaOrder {OrderID=rnd.Next(10,250),OrderDate=DateTime.Now,Type="Veg", Size='M',Toppings="onion",Quantity=2,Price=500 },

            new PizzaOrder { OrderID = rnd.Next(10,250), OrderDate = DateTime.Now, Type = "Veg", Size = 'S', Toppings = "corn", Quantity = 1, Price = 300 },

            new PizzaOrder { OrderID = rnd.Next(10,250), OrderDate = DateTime.Now, Type = "Non-Veg", Size = 'M', Toppings = "chicken", Quantity = 2, Price = 750 },

              new PizzaOrder { OrderID = rnd.Next(10,250), OrderDate = DateTime.Now, Type = "Non-Veg", Size = 'L', Toppings = "egg", Quantity = 3, Price = 900 }
            };

            foreach (var e in po)
            {
                Console.WriteLine(e.OrderID + " " + e.OrderDate + "  " + e.Type + " " + e.Size + "  " + e.Toppings + "  " + e.Quantity + "  " + e.Price );
            }


            Console.WriteLine(" _______________________________________________ ");


            var data = po.OrderByDescending(x => x.Size).OrderBy( y => y.Type);
            foreach (var y in data)
            {
                Console.WriteLine(y.OrderID + "  " + y.Type + " " + y.Size + "  " + y.Toppings + "  " + y.Quantity + "  " + y.Price);

            }


            Console.WriteLine(" ____________Anonymous____________ ");


            var data2 = po.OrderByDescending(x => x.Size).OrderBy(y => y.Type).Select(z => new { s = z.Size, t = z.Type });
            foreach (var y in data2)
            {
                Console.WriteLine(y.s + "   " + y.t);

            }

            Console.WriteLine(" ___________________Money Collection by type____________________");



            var grp = po.GroupBy(ax => ax.Type).Select(ax => new { T = ax.Key, PizzaCount = ax.Sum(y=>y.Quantity), sumMoney = ax.Sum(ay => ay.Price) });
            {
                foreach (var g in grp)
                {
                    Console.WriteLine(g.T + " " + g.PizzaCount + "  " + g.sumMoney);
                }
            }

            Console.WriteLine(" _______________________________________________________________");
            Console.WriteLine(" ___________________Money Collection by Size____________________");

            var grp2 = po.GroupBy(ax => ax.Size).Select(ax => new { T = ax.Key, PizzaCount = ax.Sum(y => y.Quantity), sumMoney = ax.Sum(ay => ay.Price) });
            {
                foreach (var g in grp2)
                {
                    Console.WriteLine(g.T + " " + g.PizzaCount + "  " + g.sumMoney);
                }
            }

            Console.WriteLine(" _______________________________________________________________");
            Console.WriteLine(" ____________________PizzaSize=’M’______________________________");


            var med = po.Where(a => a.Size == 'M');
            {

                foreach( var e in med)
                Console.WriteLine(  e.Type + "  " + e.Toppings);
            }

            Console.WriteLine(" _______________________________________________________________");
            Console.WriteLine(" ____________________Pizza Most Expensive_______________________");


            var pmax = po.Where(x => x.Price ==  po.Max(y => y.Price));
            {

                foreach (var e in pmax)
                    Console.WriteLine(e.OrderID + " " + e.OrderDate + "  " + e.Type + " " + e.Size + "  " + e.Toppings + "  " + e.Quantity + "  " + e.Price);
            }

           
            Console.WriteLine(" _______________________________________________________________");
            Console.WriteLine(" ____________________Pizza Least Expensive______________________");

            var pmin = po.Where(x => x.Price == po.Min(y => y.Price));
            {

                foreach (var e in pmin)
                    Console.WriteLine(e.OrderID + " " + e.OrderDate + "  " + e.Type + " " + e.Size + "  " + e.Toppings + "  " + e.Quantity + "  " + e.Price);
            }
        }



    }
}
