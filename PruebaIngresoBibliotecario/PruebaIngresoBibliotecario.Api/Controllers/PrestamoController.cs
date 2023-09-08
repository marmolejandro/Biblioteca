using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PruebaIngresoBibliotecario.Api.Models;
using PruebaIngresoBibliotecario.Domain.Entities;
using PruebaIngresoBibliotecario.Domain.Interfaces;

namespace PruebaIngresoBibliotecario.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrestamoController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> CreateLoan(CreateLoanInDto loan)
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> SearchLoan(string id)
        {         
            return Ok();
        }

    }
}
