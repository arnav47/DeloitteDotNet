using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstExample
{


    public class EmployeeInfo //poco classes
    {
        [Key]
        public int EmpId { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string Dept { get; set; }
        [Required]
        [Range(minimum: 10000, maximum: 50000, ErrorMessage = "Salary Error")]
        public double salary { get; set; }
      
       
    }
}
