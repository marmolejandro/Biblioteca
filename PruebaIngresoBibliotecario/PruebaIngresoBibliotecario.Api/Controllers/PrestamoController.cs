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
        ILoanService _loanService;
        public PrestamoController(ILoanService loanService)
        {
            _loanService = loanService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateLoan(CreateLoanInDto newLoan)
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
