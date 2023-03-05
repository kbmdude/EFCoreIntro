using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreIntro.Models
{
    public class Customer
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string? Address { get; set; }

        public string? Email { get; set; }

        public int Mobile { get; set; }

        //navigation property, indicates that the customer has zero or several orders
        // this creates a 1 → many relationship in the database
        public ICollection<Order> Orders { get; set; } = null!;

    }
}
