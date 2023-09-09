using PruebaIngresoBibliotecario.Api.Models;
using PruebaIngresoBibliotecario.Domain.Entities;

namespace PruebaIngresoBibliotecario.Domain.Interfaces
{
    public interface ILoanService
    {
        public Task<DateTime> CalculateDateLoan(UserType UserType);
        public Task<Loan> GetLoan(Guid Id);
        public Task<Loan> SaveLoan(CreateLoanInDto Loan);

        public Task<bool> ValidateLoan(string IdUser);
        public Task<bool> ValidateUserType(UserType UserType);
        public Task<bool> ValidateIdUser(string IdUser);
    }
}
