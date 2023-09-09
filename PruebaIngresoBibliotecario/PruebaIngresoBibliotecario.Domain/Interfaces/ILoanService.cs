using PruebaIngresoBibliotecario.Api.Models;
using PruebaIngresoBibliotecario.Domain.Entities;

namespace PruebaIngresoBibliotecario.Domain.Interfaces
{
    public interface ILoanService
    {
        public Task<Loan> GetLoan(Guid Id);
        public Task<CreateLoanOutDto> SaveLoan(CreateLoanInDto Loan);

        public Task<DateTime> CalculateReturnDate(UserType UserType);

        public Task<bool> ValidateLoan(string IdUser);
        public Task<bool> ValidateUserType(UserType UserType);
        public Task<bool> ValidateSizeIdUser(string IdUser);
    }
}
