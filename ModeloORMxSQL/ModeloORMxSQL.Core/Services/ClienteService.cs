using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModeloORMxSQL.Core.Models;
using ModeloORMxSQL.Core.Repositories;

namespace ModeloORMxSQL.Core.Services
{
    public class ClienteService
    {
        private readonly ClienteRepository _clienteRepository;

        public ClienteService(ClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task<List<Cliente>> ListarClientesComORM()
        {
            var clientes = await _clienteRepository.ListarClientesCadastradosComORM();

            return clientes;
        }

        public List<Cliente> ListarClientesComSQL()
        {
            var clientes =  _clienteRepository.ListarClientesCadastradosComSQL();

            return clientes;
        }
    }
}