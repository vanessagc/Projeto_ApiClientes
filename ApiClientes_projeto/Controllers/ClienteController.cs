using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Projeto.Presentation.Api.Models;

namespace Projeto.Presentation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] ClienteCadastroModel model)
        {
            return Ok();
        }
        [HttpPut]
        public IActionResult Put([FromBody] ClienteEdicaoModel model)
        {
            return Ok();
        }

        [HttpDelete("{idCliente}")]
        public IActionResult Delete(Guid idCliente)
        {
            return Ok();
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<ClienteCadastroModel>), 200)]
        public IActionResult GetAll()
        {
            return Ok();
        }

       
        [HttpGet("{idCliente}")]
        [ProducesResponseType(typeof(ClienteCadastroModel), 200)]
        public IActionResult GetById(Guid idCliente)
        {
            return Ok();
        }

    }
}