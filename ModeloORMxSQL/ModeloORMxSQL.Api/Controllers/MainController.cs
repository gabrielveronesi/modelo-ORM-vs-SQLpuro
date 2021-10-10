using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ModeloORMxSQL.Api.Controllers
{
    public abstract class MainController : ControllerBase
    {
        protected ActionResult Resposta(bool condicao, object resultado)
        {
            if (condicao)
            {
                return Ok(new
                {
                    Success = condicao,
                    Data = resultado,
                });
            }
            else
            {
                return BadRequest(new
                {
                    Success = condicao,
                    Data = resultado,
                });
            }
        }
    }
}
