using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DevWebReceitas.Application.Dtos.Receita;
using DevWebReceitas.Application.Interfaces;
using DevWebReceitas.Domain.Filters;
using DevWebReceitas.Services.Api.Errors;
using Microsoft.AspNetCore.Mvc;

namespace DevWebReceitas.Services.Api.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class ReceitaController : ControllerBase
    {
        private readonly IReceitaService _service;

        public ReceitaController(IReceitaService receitaService)
        {
            _service = receitaService;
        }

        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Create([FromForm] ReceitaInsertDto item)
        {
            try
            {
                var code = await Task.Run(() => _service.Create(item));
                return CreatedAtAction(nameof(Find), new { code });
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new Error(ex.Message));
            }            
            catch (Exception ex)
            {
                return StatusCode(500, new Error(ex.Message));
            }
        }

        [HttpPut]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Update([FromForm] ReceitaDto item)
        {
            try
            {
                await Task.Run(() => _service.Update(item));
                return Ok();
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new Error(ex.Message));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpDelete("{codigo}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> Remove(Guid codigo)
        {
            try
            {
                await Task.Run(() => _service.Remove(codigo));
                return Ok();
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new Error(ex.Message));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new Error(ex.Message));
            }
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<ReceitaDto>), 200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> Find([FromQuery] ReceitaFilter filter)
        {
            try
            {
                return Ok(await Task.Run(() => _service.List(filter)));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new Error(ex.Message));
            }
        }

        [HttpGet("{codigo}")]
        [ProducesResponseType(typeof(ReceitaDto), 200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        [Consumes("application/json")]
        public async Task<IActionResult> Find(Guid codigo)
        {
            try
            {
                return Ok(await Task.Run(() => _service.FindByCode(codigo)));
            }
            catch (ArgumentException ex)
            {
                return NotFound(new Error(ex));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new Error(ex));
            }
        }

        [HttpGet("{codigoReceita}/Imagem")]
        [ProducesResponseType(typeof(ReceitaDto), 200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> Imagem(Guid codigoReceita)
        {
            try
            {
                byte[] img = await Task.Run(() => _service.FindImageByCode(codigoReceita));
                return File(img, "image/png");
            }
            catch (ArgumentException ex)
            {
                return NotFound(new Error(ex.Message));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new Error(ex));
            }
        }

        [HttpPut("{codigoReceita}/Like")]
        [ProducesResponseType(typeof(ReceitaDto), 200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> Like(Guid codigoReceita)
        {
            try
            {
                await Task.Run(() => _service.Like(codigoReceita));
                return Ok();
            }
            catch (ArgumentException ex)
            {
                return NotFound(new Error(ex.Message));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new Error(ex));
            }
        }

        [HttpPut("{codigoReceita}/Dislike")]
        [ProducesResponseType(typeof(ReceitaDto), 200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> Dislike(Guid codigoReceita)
        {
            try
            {
                await Task.Run(() => _service.Dislike(codigoReceita));
                return Ok();
            }
            catch (ArgumentException ex)
            {
                return NotFound(new Error(ex.Message));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new Error(ex));
            }
        }
    }
}