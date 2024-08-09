using Game_Catalog.Models;
using Microsoft.EntityFrameworkCore;

namespace Game_Catalog.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options)
            : base(options)
        {
        }
        public DbSet<Games> Games { get; set; }
    }
}
