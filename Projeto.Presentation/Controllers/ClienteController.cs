using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Projeto.Infra.Data.Contracts;
using Projeto.Infra.Data.Entities;
using Projeto.Application.Models;
using Projeto.Application.Services;

namespace Projeto.Presentation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly ClienteApplicationService clienteApplicationService = new ClienteApplicationService();

        [HttpPost]
        public IActionResult Post(ClienteEnderecoModel model)
        {

            clienteApplicationService.Create(model);
            
            return Ok();
        }
        [HttpPut]
        public IActionResult Put(ClienteModel model)
        {
            clienteApplicationService.Update(model);

            return Ok();
        }

        [HttpDelete("{idCliente}")]
        public IActionResult Delete(Guid idCliente)
        {
            clienteApplicationService.Remove(idCliente);

            return Ok();
        }

        [HttpGet]
        public IEnumerable<ClienteModel> GetAll()
        {
            return clienteApplicationService.SelectAll();

        }

       
        [HttpGet("{idCliente}")]
        public ClienteModel GetById(Guid idCliente)
        {

            return clienteApplicationService.SelectById(idCliente);

        }

    }
}