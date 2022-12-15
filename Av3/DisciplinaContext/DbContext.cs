using Av3.Models;
using Microsoft.EntityFrameworkCore;


namespace Av3.Data
{
    public class DbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbContext(DbContextOptions<DbContext> options)
            : base(options)
        {

        }

        public DbSet<Disciplina> Disciplinas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", false, true).Build();

            optionsBuilder.UseSqlServer(configuration.GetConnectionString("ServerConnection"));


        }
    }
}
