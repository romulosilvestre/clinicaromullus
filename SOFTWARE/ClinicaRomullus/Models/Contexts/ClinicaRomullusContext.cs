using ClinicaRomullus.Models.Entities;
using Microsoft.EntityFrameworkCore;
namespace ClinicaRomullus.Models.Contexts
{
    public class ClinicaRomullusContext:DbContext
    { 
        private readonly IConfiguration _configuration;
        public ClinicaRomullusContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public DbSet<Medico> Medicos => Set<Medico>();        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("ClinicaRomullusHome"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
         
        }
    }        
}
