using Microsoft.EntityFrameworkCore;
using WebAdaptation4.Model;

namespace WebAdaptation4.DBase
{
    public class ApplicationContext : DbContext
    {
        public DbSet<MisterOne> Users { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        /*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                "server=localhost;user=root;password=SaraParker206;database=TestPD;",
                new MySqlServerVersion(new Version(8, 0, 11))
            );
        }
        */
    }
}
