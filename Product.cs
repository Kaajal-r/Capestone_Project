using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _Store_Management.Models
{
    public class Product
    {
        public int productId { get; set; }
        [DisplayName("ProductId")]
        public string productName { get; set; }
        [Required]
        public string productDescription { get; set; }
        [Required]
        public float productPrice { get; set; }
        [Required]
        public int catId { get; set; }
        public virtual CategoryViewModel Category { get; set; }
    }
}
