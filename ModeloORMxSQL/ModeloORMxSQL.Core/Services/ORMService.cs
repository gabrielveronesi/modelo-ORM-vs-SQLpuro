using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public async Task ListarClientes()
        {
            await _ormRepository.ListarClientesCadastrados();
        }
    }
}