using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SIP.Application.Interfaces;

namespace SIP.Services.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnderecoController : ControllerBase
    {
        private readonly IServiceViaCep _service;

        public EnderecoController(IServiceViaCep service)
        {
            _service = service;
        }

        [HttpGet("GetAddress/{zipCode}")]
        public IActionResult GetAddress(string zipCode)
        {
            try
            {
                var result = _service.Search(zipCode);
                return Ok(result);
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet("GetAddress/{stateInitials}/{city}/{address}")]
        public IActionResult GetAddress(string stateInitials, string city, string address)
        {
            try
            {
                return Ok(_service.Search(stateInitials, city, address));
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet("GetAddressAsync/{zipCode}")]
        public async Task<IActionResult> GetAddressAsync(string zipCode)
        {
            try
            {
                return Ok(await _service.SearchAsync(zipCode));
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet("GetAddressAsync/{stateInitials}/{city}/{address}")]
        public async Task<IActionResult> GetAddressAsync(string stateInitials, string city, string address)
        {
            try
            {
                return Ok(await _service.SearchAsync(stateInitials, city, address));
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

    }
}
