using Microsoft.EntityFrameworkCore;

namespace Pro11WA.Models
{
    public class AppDbContext : DbContext
    {
        //   F i e l d s   &   P r o p e t r i e s

        public DbSet<Manufacturers> Manufacturers { get; set; }
        public DbSet<Furnace> Furnaces { get; set; }

        //   C o n s t r u c t o r s

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        //   M e t h o d s
    }

}
