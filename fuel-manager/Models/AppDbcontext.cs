using Microsoft.EntityFrameworkCore;

namespace fuel_manager.Models
{
    public class AppDbcontext : DbContext
    {
        public AppDbcontext(DbContextOptions options): base(options) 
        {            
        }

        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Consumo> Consumos { get; set; }


    }
}
