using PruebaIngresoBibliotecario.Api.Models;
using PruebaIngresoBibliotecario.Domain.Entities;

namespace PruebaIngresoBibliotecario.Domain.Interfaces
{
    public interface ILoanService
    {
        public Task<Loan> GetLoan(Guid Id);
        public Task<CreateLoanOutDto> SaveLoan(CreateLoanInDto Loan);
    }
}
