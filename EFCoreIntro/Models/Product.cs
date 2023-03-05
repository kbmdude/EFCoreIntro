using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreIntro.Models
{
    public class Product
    {
        // key attribute to mark it as a key attribute :D
        [Key]
        public int Id { get; set; }

        // mi a gecim az a (null!)?
        // in .NET 6 all projects enable nullable reference types by default
        // EFC would initizalize the stuff by adding the [Required] attribute
        // but here with null! (null-forgiving operator) we tell the compiler not to warn us about anything
        public string Name { get; set; } = null!;

        // mark the Price as a decimal value of 6 numerals length and 2 decimals
        [Column(TypeName = "decimal(6,2)")]
        public decimal Price { get; set; }
    }
}
