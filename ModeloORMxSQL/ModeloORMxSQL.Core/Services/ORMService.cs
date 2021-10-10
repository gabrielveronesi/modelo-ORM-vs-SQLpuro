using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModeloORMxSQL.Core.Models;
using ModeloORMxSQL.Core.Repositories;

namespace ModeloORMxSQL.Core.Services
{
    public class ORMService
    {
        private readonly ORMRepository _ormRepository;

        public ORMService(ORMRepository ormRepository)
        {
            _ormRepository = ormRepository;
        }

        public async Task<List<Cliente>> ListarClientes()
        {
            var clientes = await _ormRepository.ListarClientesCadastrados();

            return clientes;
        }
    }
}