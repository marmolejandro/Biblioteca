using PruebaIngresoBibliotecario.Api.Models;
using PruebaIngresoBibliotecario.Domain.Entities;
using PruebaIngresoBibliotecario.Domain.Interfaces;

namespace PruebaIngresoBibliotecario.Core.Services
{
    public class LoanService : ILoanService
    {
        ILoanRepository _loanRepository;
        public LoanService(ILoanRepository loanRepository)
        {
            _loanRepository = loanRepository;
        }

        public async Task<DateTime> CalculateDateLoan(UserType UserType)
        {
            return new DateTime();
        }

        public async Task<Loan> GetLoan(Guid Id)
        {
            return new Loan();
        }

        public async Task<Loan> SaveLoan(CreateLoanInDto Loan)
        {
            return new Loan();
        }

        public async Task<bool> ValidateLoan(string IdUser)
        {
            List<Loan> loans = await _loanRepository.GetLoanByIdUser(IdUser);

            return loans.Where(r => (int)r.User.TipoUsuario == 1).ToList().Count == 0;
        }

        public async Task<bool> ValidateUserType(UserType UserType)
        {
            if(!Enum.IsDefined(typeof(UserType), UserType))
                return false;
            
            return true;
        }

        public async Task<bool> ValidateIdUser(string IdUser)
        {
            return IdUser.Length <= 10;
        }
    }
}
