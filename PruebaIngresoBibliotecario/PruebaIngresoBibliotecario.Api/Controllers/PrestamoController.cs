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
        public IServicesLoan Services;

        public PrestamoController(IServicesLoan _Services)
        {
            Services = _Services;
        }

        [HttpPost]
        public async Task<IActionResult> CreateLoan(CreateLoanInDto Loan)
        {
            List<CreateLoanOutDto >LoanOut = new List<CreateLoanOutDto>();

            return Ok(LoanOut);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> SearchLoan(string Id)
        {
            List<Loan> LoanOut = new List<Loan>() ;
            

            return Ok(LoanOut);
        }

    }
}
