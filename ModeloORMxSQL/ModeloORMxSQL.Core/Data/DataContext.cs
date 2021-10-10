using Microsoft.EntityFrameworkCore;
using ModeloORMxSQL.Core.Models;

namespace ModeloORMxSQL.Core.Data
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
        }
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Teste_ORM_SQL;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //Carga inicial para o banco
            builder.ApplyConfiguration(new CargaInicialConfiguration());
        }
    }
}