//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookShopOnline_ProjectSem3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class OrderDetail
    {
        public int OrderDetailsID { get; set; }
        //[Required(ErrorMessage = "ProductName can't be empty")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "BookID can't be empty")]
        public Nullable<int> BookID { get; set; }
        [Required(ErrorMessage = "Quantity can't be empty")]
        public Nullable<int> Quantity { get; set; }
        //[Required(ErrorMessage = "Price can't be empty")]
        public Nullable<decimal> Price { get; set; }
        [Required(ErrorMessage = "OrderID can't be empty")]
        public Nullable<int> OrderID { get; set; }
        //[Required(ErrorMessage = "EmployeeID can't be empty")]
        public Nullable<int> EmployeeID { get; set; }
        [Required(ErrorMessage = "UserID can't be empty")]
        public Nullable<int> UserID { get; set; }

        public virtual Book Book { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Order Order { get; set; }
        public virtual User User { get; set; }
    }
}
