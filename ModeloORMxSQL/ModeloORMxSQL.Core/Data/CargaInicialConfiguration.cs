using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ModeloORMxSQL.Core.Models;

namespace ModeloORMxSQL.Core.Data
{
    public class CargaInicialConfiguration : IEntityTypeConfiguration<Cliente>
    {
         public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Cliente> builder)
        {
                builder.HasData(new Cliente()
                {
                    Id = 1,
                    Nome = "Gabriel Veronesi"
                    });

                builder.HasData(new Cliente()
                {
                    Id = 2,
                    Nome = "Vitor Hugo"
                });

                builder.HasData(new Cliente()
                {
                    Id = 3,
                    Nome = "Mariana Camargo"
                });
        }
    }
}