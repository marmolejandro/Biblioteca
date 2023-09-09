using Microsoft.AspNetCore.Mvc;
using PruebaIngresoBibliotecario.Api.Models;
using PruebaIngresoBibliotecario.Domain.Entities;
using PruebaIngresoBibliotecario.Domain.Interfaces;
using PruebaIngresoBibliotecario.Domain.Models;

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
            var Response = await _loanService.SaveLoan(newLoan);

            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> SearchLoan(Guid id)
        {
            Loan loan = await _loanService.GetLoan(id);

            if (loan == null)
            {
                ResponseBase Result = new ResponseBase();
                Result.message = $"El prestamo con id {id} no existe";

                return BadRequest(Result);
            }

            return Ok(loan);
        }
    }
}
