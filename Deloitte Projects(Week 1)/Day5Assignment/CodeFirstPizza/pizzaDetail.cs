using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace CodeFirstPizza
{
    class pizzaDetail
    {

        [Key]
        public int PizzaId { get; set; }
        [Required]
        public string Pname { get; set; }
        [Required]
        public string Toppings { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public string Size { get; set; }
        [Required]
        public int price { get; set; }
        

      

    }
}
