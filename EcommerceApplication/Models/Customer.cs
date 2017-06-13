using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceApplication.Models
{
    [Table("Customer")]
    public class Customer
    {
        public Customer()
        {
            CartItems = new HashSet<CartItem>();
            Orders = new HashSet<Order>();
        }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string LastName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public int PostalCode { get; set; }
        public string EmailAddress { get; set; }
        public DateTime? DateEntered { get; set; }
        public virtual ICollection<CartItem> CartItems { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
