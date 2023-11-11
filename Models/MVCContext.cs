using Microsoft.EntityFrameworkCore;

namespace ModelVieController.Models
{
    public class MVCContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public MVCContext(DbContextOptions<MVCContext> options) : base(options) { }
    }
}
