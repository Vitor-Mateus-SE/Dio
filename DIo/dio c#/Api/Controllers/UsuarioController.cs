using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
namespace ModuloAPI.Controlelrs
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioControleler
    {
        [HttpGet("ObterDataHoraAtual]")]

        public class UsuarioControleler : ControllerBase
        {
            public IActionResult ObterDataHora()
            {
                var obj = new
                {
                    Data = DateTime.Now.ToLongDateString(),
                    Hora = DateTime.Now.ToShortDateString()
                };
                return Ok(obj);
            }
        }
    }
}