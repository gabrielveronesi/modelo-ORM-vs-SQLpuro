using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
            
            //teste1
            

            return Resposta(true, new { listarClientes });
        }

        /// <summary>
        /// Realizar agendamento passando um cliente e horario
        /// </summary>
        /// <param name="Id">Identificador do cliente que vai agendar</param>
        /// <param name="DataAgendamento">Horário do agendamento 2021-03-25 00:00:00</param>
        [HttpPost]
        [Route("agendamento-orm")]
        public ActionResult AgendamentoORM([Required] int Id, 
                                           [Required] DateTime DataAgendamento)
        {
            var agendamentoCalculado = DataAgendamento.AddMinutes(40);

            return Resposta(true, new {
                Cliente       = "Gabriel",
                HorarioInicio = DataAgendamento,
                HorarioFim    = agendamentoCalculado,
                });;
        }
    }
}