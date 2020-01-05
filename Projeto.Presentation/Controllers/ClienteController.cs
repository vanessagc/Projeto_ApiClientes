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
        public IActionResult Post([FromServices]IClienteApplicationService service, ClienteModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelStateValidaton.GetErrors(ModelState));
            try
            {
                return Ok(service.Create(model));
            }
            catch(Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
        [HttpPut]
        public IActionResult Put([FromServices]IClienteApplicationService service, ClienteModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelStateValidaton.GetErrors(ModelState));
            try
            {
                return Ok(service.Update(model));
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpDelete]
        public IActionResult Delete([FromServices]IClienteApplicationService service, ClienteModel model)
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


        [HttpGet("id")]
        public IActionResult Get([FromServices]IClienteApplicationService service, Guid id)
        {

            if (!ModelState.IsValid)
                return BadRequest(ModelStateValidaton.GetErrors(ModelState));
            try
            {
                return Ok(service.SelectById(id));
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet("cpf")]
        public IActionResult GetByCpf([FromServices]IClienteApplicationService service, string cpf)
        {

            if (!ModelState.IsValid)
                return BadRequest(ModelStateValidaton.GetErrors(ModelState));
            try
            {
                return Ok(service.SelectByCpf(cpf));
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

    }
}