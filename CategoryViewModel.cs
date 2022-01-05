using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _Store_Management.Models
{
    public class CategoryViewModel
    {
        [Key]
        public int catId { get; set; }
        [Required]
        public string catName { get; set; }
        [Required]
        public string catDescription { get; set; }

    }
}
