using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst.Models
{
    public class Post
    {
        public long PostId { get; set; }

        public string Title { get; set; }

        public string Resume { get; set; }

        public string Content { get; set; }

        public DateTime Date { get; set; }

        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]

        public virtual Category Category { get; set; }
    }
}