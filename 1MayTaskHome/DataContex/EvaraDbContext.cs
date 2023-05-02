using _1MayTaskHome.Models;
using Microsoft.EntityFrameworkCore;

namespace _1MayTaskHome.DataContex
{
    public class EvaraDbContext:DbContext
    {
        public EvaraDbContext(DbContextOptions<EvaraDbContext> options):base(options)
        {
            
        }
       public DbSet<Slider> Sliders { get; set; }
       public DbSet<Color> Colors { get; set; }
       public DbSet<Product> Products { get; set; }
       public DbSet<Catagory> Catagories { get; set; }

    }
}
