using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Projeto.Infra.Data.Contracts;
using Projeto.Infra.Data.Entities;
using Projeto.Presentation.Api.Models;

namespace Projeto.Presentation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] ClienteCadastroModel model,
            [FromServices] IClienteRepository repository,
            [FromServices] IMapper mapper)
        {
            var cliente = mapper.Map<Cliente>(model);
            repository.Create(cliente);

            return Ok();
        }
        [HttpPut]
        public IActionResult Put([FromBody] ClienteEdicaoModel model,
            [FromServices] IClienteRepository repository,
            [FromServices] IMapper mapper)
        {
            var cliente = mapper.Map<Cliente>(model);
            repository.Update(cliente);

            return Ok();
        }

        [HttpDelete("{idCliente}")]
        public IActionResult Delete(Guid idCliente,
            [FromServices] IClienteRepository repository)
        {
            repository.Remove(idCliente);
            return Ok();
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<ClienteConsultaModel>), 200)]
        public IActionResult GetAll([FromServices] IClienteRepository repository)
        {
            repository.SelectAll();

            return Ok();
        }

       
        [HttpGet("{idCliente}")]
        [ProducesResponseType(typeof(ClienteConsultaModel), 200)]
        public IActionResult GetById(Guid idCliente, [FromServices] IClienteRepository repository)
        {
            repository.SelectById(idCliente);

            return Ok();
        }

    }
}