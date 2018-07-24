using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class PizzaOrder
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public String Type { get; set; }
        public char Size { get; set; }
        public string Toppings { get; set; }

        public int Quantity { get; set; }
        public int Price { get; set; }

    }
}
