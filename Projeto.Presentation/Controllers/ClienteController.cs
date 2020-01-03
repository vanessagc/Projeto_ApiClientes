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
        private readonly ClienteApplicationService _clienteApplicationService = new ClienteApplicationService();

        public ClienteController()
        {
        }
        [HttpPost]
        public IActionResult Post(ClienteEnderecoModel model)
        {

            _clienteApplicationService.Create(model);
            
            return Ok();
        }
        [HttpPut]
        public IActionResult Put(ClienteEnderecoModel model)
        {
            _clienteApplicationService.Update(model);

            return Ok();
        }

        [HttpDelete("{idCliente}")]
        public IActionResult Delete(Guid idCliente)
        {
            _clienteApplicationService.Remove(idCliente);

            return Ok();
        }

        [HttpGet]
        public IEnumerable<ClienteEnderecoModel> GetAll()
        {
            return _clienteApplicationService.SelectAll();

        }

       
        [HttpGet("{idCliente}")]
        public ClienteEnderecoModel GetById(Guid idCliente)
        {

            return _clienteApplicationService.SelectById(idCliente);

        }

        [HttpGet("{cpf}")]
        public ClienteEnderecoModel GetByCpf(string cpf)
        {

            return _clienteApplicationService.SelectByCpf(cpf);

        }
    }
}