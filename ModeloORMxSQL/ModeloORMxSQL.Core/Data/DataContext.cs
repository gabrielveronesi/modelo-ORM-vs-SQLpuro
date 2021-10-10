using Microsoft.EntityFrameworkCore;
using ModeloORMxSQL.Core.Models;

namespace ModeloORMxSQL.Core.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {}

        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //Carga inicial para o banco
            builder.ApplyConfiguration(new CargaInicialConfiguration());
        }
    }
}