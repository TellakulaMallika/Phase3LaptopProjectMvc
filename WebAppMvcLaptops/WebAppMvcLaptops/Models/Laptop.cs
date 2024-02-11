using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAppMvcLaptops.Models
{
    [Table("Laptop")]
    public class Laptop
    {
        [Key]
        public int Id { get; set; } 
        public string Name { get; set; }
        public double Price { get; set; }
        public string RamSize { get; set; }
        
    }
}