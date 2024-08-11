using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace Core.Context
{
    public class DbCoreContext : DbContext
    {
        public DbSet<CarbonEmissionEntities> CarbonEmissionEntities { get; set;}
        public DbCoreContext(DbContextOptions<DbCoreContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("MemoryDataBase");
        }
        public void Seeder()
        {
            if (!CarbonEmissionEntities.Any())
            {
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "SeederDate", "carbon_emissions.json");
                var jsonData = File.ReadAllText(filePath);
                var carbonEmissions = JsonSerializer.Deserialize<List<CarbonEmissionEntities>>(jsonData);

                if (carbonEmissions != null && carbonEmissions.Any())
                {
                    CarbonEmissionEntities.AddRange(carbonEmissions);
                    SaveChanges();
                }
            }
        }
    }
}
