using Microsoft.EntityFrameworkCore;
using SimpleBlog.Models.BlogViewModels;

namespace SimpleBlog.Persistence
{
    public class SimpleBlogContext : DbContext
    {
        public SimpleBlogContext (DbContextOptions<SimpleBlogContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Category { get; set; }

        public DbSet<SimpleBlog.Models.BlogViewModels.CategoryViewModel> CategoryViewModel { get; set; }
    }
}
