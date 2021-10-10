using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ModeloORMxSQL.Core.Data;
using ModeloORMxSQL.Core.Models;

namespace ModeloORMxSQL.Core.Repositories
{
    public class ORMRepository
    {
        private readonly DataContext _context;
        public ORMRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Cliente>> ListarClientesCadastrados()
        {
            var clientes = await _context.Clientes.ToListAsync();
            
            return clientes;
        }
    }
}