using Microsoft.EntityFrameworkCore;

namespace SimpleBlog.Persistence
{
    public class SimpleBlogContext : DbContext
    {
        public SimpleBlogContext (DbContextOptions<SimpleBlogContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Category { get; set; }
    }
}
