//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CustomerMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_customer
    {
        public tbl_customer()
        {
            this.tbl_order = new HashSet<tbl_order>();
        }
    
        public int customerID { get; set; }
        public string customerName { get; set; }
    
        public virtual ICollection<tbl_order> tbl_order { get; set; }
    }
}
