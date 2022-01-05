using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _Store_Management.Models
{
    public class Admin
    {

        [Key]
        public int userId { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string passwordHash { get; set; }
        public int catId { get; set; }
        public virtual CategoryViewModel Category { get; set; }

        public int productId { get; set; }
        public virtual  Product Products { get; set; }

        public int StockId { get; set; }
        public virtual Stock Stocks { get; set; }
    }
}
