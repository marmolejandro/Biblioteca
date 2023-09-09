using Microsoft.AspNetCore.Mvc;
using PruebaIngresoBibliotecario.Api.Models;
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
            if (!await _loanService.ValidateUserType(newLoan.TipoUsuario) ||
                !await _loanService.ValidateIdUser(newLoan.IdentificacionUsuario))
            {
                return BadRequest();
            }
            else if (!await _loanService.ValidateLoan(newLoan.IdentificacionUsuario))
            {
                string message = $@"El usuario con identificación {newLoan.IdentificacionUsuario} 
                ya tiene un libro prestado por lo cual no se le puede registrar otro prestamo";

                return BadRequest(message);
            }

            _loanService.SaveLoan(newLoan);

            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> SearchLoan(string id)
        {         
            return Ok();
        }
    }
}
