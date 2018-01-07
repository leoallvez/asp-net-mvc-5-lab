using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CodeFirst.Models
{
    public class Category
    { 
        [Key]
        public int CategoryId { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Post> Posts { get; set; }

    }
}