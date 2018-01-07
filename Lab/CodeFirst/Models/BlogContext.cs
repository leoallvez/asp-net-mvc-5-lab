
using System.Data.Entity;

namespace CodeFirst.Models
{
    public class BlogContext : DbContext
    {
        public BlogContext() : base("name=BlogContext")
        {
            //Database.Connection.ConnectionString = @"data source=LEO-ALVES\SQLEXPRESS;initial catalog=BlogBDLivro;Integrated Security=SSPI";
        }
        public DbSet<Post> Post { get; set; }

        public DbSet<Category> Category { get; set; }
    }
}