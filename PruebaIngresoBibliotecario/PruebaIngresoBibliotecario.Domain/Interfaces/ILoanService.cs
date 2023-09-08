using PruebaIngresoBibliotecario.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaIngresoBibliotecario.Domain.Interfaces
{
    public interface ILoanService
    {
        public Task<bool> ValidateLoan(Loan Loan);
        public Task<Loan> SearchLoan(Guid Id);
        public Task<Loan> CreateLoan(Loan Loan);
    }
}
