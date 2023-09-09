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
            if (!await _loanService.ValidateUserType(newLoan.TipoUsuario) ||
                !await _loanService.ValidateSizeIdUser(newLoan.IdentificacionUsuario))
            {
                return BadRequest();
            }
            else if (!await _loanService.ValidateLoan(newLoan.IdentificacionUsuario))
            {
                ResultLoanDto Result = new ResultLoanDto();
                Result.message = $"El usuario con identificación {newLoan.IdentificacionUsuario} ya tiene un libro prestado por lo cual no se le puede registrar otro prestamo";

                return BadRequest(Result);
            }

            return Ok(await _loanService.SaveLoan(newLoan));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> SearchLoan(Guid id)
        {
            Loan loan = await _loanService.GetLoan(id);

            if (loan == null)
            {
                ResultLoanDto Result = new ResultLoanDto();
                Result.message = $"El prestamo con id {id} no existe";

                return BadRequest(Result);
            }

            return Ok(loan);
        }
    }
}
