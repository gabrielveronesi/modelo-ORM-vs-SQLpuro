using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModeloORMxSQL.Core.Models;
using ModeloORMxSQL.Core.Services;

namespace ModeloORMxSQL.Api.Controllers
{
    [ApiController]
    [Route("sql/clientes")]
    public class SQLController : MainController
    {
        private readonly ClienteService  _clienteService;
        public SQLController(ClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        /// <summary>
        /// Listar estabelecimentos com select em SQL Puro
        /// </summary>
        [HttpGet]
        [Route("listar-clientes-sql")]
        public ActionResult<List<Cliente>> ListarClientesSQL()
        {
            var listarClientes =  _clienteService.ListarClientesComSQL();
            
            if (listarClientes == null)
            {
                return Resposta(false, "Não foi localizado clientes");
            }

            return Resposta(true, new { listarClientes });
        }
    }
}