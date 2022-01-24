using Microsoft.EntityFrameworkCore;

namespace BioticApi.Models
{
    public class BioticDbContext : DbContext
    {
        public BioticDbContext(DbContextOptions<BioticDbContext> options) 
            : base(options)
        {

        }

        public DbSet<BioticUser> BioticUsers { get; set; }
    }
}
