using Microsoft.EntityFrameworkCore;

namespace SimpleBlog.Persistence
{
    public class BlogDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }

        public BlogDbContext(DbContextOptions options)
            : base(options)
        {

        }
    }
}
