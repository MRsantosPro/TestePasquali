using Microsoft.EntityFrameworkCore;
using PasqualiAPI.Entities;


namespace PasqualiAPI.Helpers
{
    public class DataContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public DataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public virtual DbSet<Pessoa> Pessoas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {

            options.UseSqlServer(Configuration.GetConnectionString("SQLServer"));
        }

    }
}
