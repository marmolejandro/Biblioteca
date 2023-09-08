using PruebaIngresoBibliotecario.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaIngresoBibliotecario.Domain.Interfaces
{
    public interface ILoanRepository
    {
        public Task<Loan> SearchLoan(Guid Id);
        public Task<Loan> CreateLoan(Loan Loan);
        public Task<List<Loan>> GetAll(Loan Loan);
    }
}
