using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _Store_Management.Models
{
    public class User
    {
        [Key]
        public int userId { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string passwordHash { get; set; }
        [Required]
        public string fName { get; set; }
        [Required]
        public string lName { get; set; }

        public int productId { get; set; }
        public virtual Product Products { get; set; }
    }
}
