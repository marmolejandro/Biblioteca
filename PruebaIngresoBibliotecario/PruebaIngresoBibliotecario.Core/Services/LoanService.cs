using PruebaIngresoBibliotecario.Domain.Entities;
using PruebaIngresoBibliotecario.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public async Task<bool> ValidateLoan(Loan Loan)
        {
            return true;
        }

        public async Task<Loan> GetLoan(Guid Id)
        {
            return new Loan();
        }

        public async Task<Loan> CreateLoan(Loan Loan)
        {
            return new Loan();
        }
    }
}
