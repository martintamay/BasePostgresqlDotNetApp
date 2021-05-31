using Microsoft.EntityFrameworkCore;
using ServicesTrackerAPI.Models.Bean;

namespace ServicesTrackerAPI.Models.Context {
    public class BaseContext : DbContext {
        public BaseContext(DbContextOptions<BaseContext> options)
           : base(options) {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=127.0.0.1;Database=services_tracker_bd;Username=postgres;Password=humberto1");

        public DbSet<ClientB> Clients { get; set; }
    }
}
