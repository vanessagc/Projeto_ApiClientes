using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Projeto.Application.Models;
using Projeto.Application.Contracts;
using Projeto.Presentation.Api.Validations;

namespace Projeto.Presentation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromServices]IClienteApplicationService service, ClienteEnderecoModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelStateValidaton.GetErrors(ModelState));
            try
            {
                service.Create(model);
                return Ok();
            }
            catch(Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
        [HttpPut]
        public IActionResult Put([FromServices]IClienteApplicationService service, ClienteEnderecoModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelStateValidaton.GetErrors(ModelState));
            try
            {
                service.Update(model);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpDelete("{idCliente}")]
        public IActionResult Delete([FromServices]IClienteApplicationService service, ClienteEnderecoModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelStateValidaton.GetErrors(ModelState));
            try
            {
                service.Remove(model);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet]
        public IActionResult Get([FromServices]IClienteApplicationService service)
        {
            try
            {
                return Ok(service.SelectAll());
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }


        [HttpGet("{idCliente}")]
        public IActionResult Get([FromServices]IClienteApplicationService service, Guid idCliente)
        {

            if (!ModelState.IsValid)
                return BadRequest(ModelStateValidaton.GetErrors(ModelState));
            try
            {
                service.SelectById(idCliente);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet("{cpf}")]
        public IActionResult GetByCpf([FromServices]IClienteApplicationService service, string cpf)
        {

            if (!ModelState.IsValid)
                return BadRequest(ModelStateValidaton.GetErrors(ModelState));
            try
            {
                service.SelectByCpf(cpf);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet("{nome}")]
        public IActionResult Get([FromServices]IClienteApplicationService service, string nome)
        {

            if (!ModelState.IsValid)
                return BadRequest(ModelStateValidaton.GetErrors(ModelState));
            try
            {
                service.SelectByNome(nome);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}