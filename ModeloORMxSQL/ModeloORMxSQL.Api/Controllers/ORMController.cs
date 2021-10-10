using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModeloORMxSQL.Core.Models;
using ModeloORMxSQL.Core.Repositories;
using ModeloORMxSQL.Core.Services;

namespace ModeloORMxSQL.Api.Controllers
{
    [ApiController]
    [Route("orm/clientes")]
    public class ORMController : MainController
    {
        //TIRAR O REPOSITORIO DA CONTROLLER!
        private readonly ORMService  _ormService;
        private readonly ORMRepository _ormRepository;
        public ORMController(ORMService ormService,
                             ORMRepository ormRepository)
        {
            _ormService = ormService;
            _ormRepository = ormRepository;
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

        /// <summary>
        /// Listar todos os estabelecimentos de um cliente
        /// </summary>
        [HttpGet]
        [Route("list-user")]
        public async Task<ActionResult<List<Cliente>>> ListarClientesTeste()
        {
            var establishments = await _ormRepository.ListarClientesCadastrados();
            return establishments;
        }
    }
}