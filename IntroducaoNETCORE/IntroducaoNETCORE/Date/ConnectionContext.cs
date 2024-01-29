using IntroducaoNETCORE.Model;
using Microsoft.EntityFrameworkCore;

namespace IntroducaoNETCORE.Date
{
    public class ConnectionContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.Use
        
    }
}
