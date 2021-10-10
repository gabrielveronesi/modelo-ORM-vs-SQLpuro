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
    [Route("orm/clientes")]
    public class ORMController : MainController
    {
        private readonly ORMService  _ormService;
        public ORMController(ORMService ormService)
        {
            _ormService = ormService;
        }

        /// <summary>
        /// Criar novo estabelecimento
        /// </summary>
        [HttpGet]
        [Route("listar-clientes")]
        public ActionResult<List<Cliente>> ListarClientes()
        {
            var listarClientes = _ormService.ListarClientes();
            
            if (listarClientes == null)
            {
                return Resposta(false, "Não foi localizado clientes");
            }

            return Resposta(true, new { listarClientes });
        }
    }
}