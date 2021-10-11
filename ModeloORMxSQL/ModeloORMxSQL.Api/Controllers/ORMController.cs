using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModeloORMxSQL.Core.Models;
using ModeloORMxSQL.Core.Services;

namespace ModeloORMxSQL.Api.Controllers
{
    [ApiController]
    [Route("orm/clientes")]
    public class ORMController : MainController
    {
        private readonly ClienteService  _clienteService;
        public ORMController(ClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        /// <summary>
        /// Listar estabelecimentos com select em ORM
        /// </summary>
        [HttpGet]
        [Route("listar-clientes-orm")]
        public async Task<ActionResult<List<Cliente>>> ListarClientesORM()
        {
            var listarClientes = await _clienteService.ListarClientesComORM();
            
            if (listarClientes == null)
            {
                return Resposta(false, "Não foi localizado clientes");
            }

            return Resposta(true, new { listarClientes });
        }
    }
}