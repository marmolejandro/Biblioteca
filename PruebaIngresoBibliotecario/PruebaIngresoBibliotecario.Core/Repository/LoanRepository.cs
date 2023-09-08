using PruebaIngresoBibliotecario.Domain.Entities;
using PruebaIngresoBibliotecario.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaIngresoBibliotecario.Core.Repository
{
    public class LoanRepository : ILoanRepository
    {
        public LoanRepository() { }

        public async Task<Loan> GetLoan(Guid Id)
        {
            return new Loan();
        }

        public async Task<Loan> SaveLoan(Loan Loan)
        {
            return new Loan();
        }

        public async Task<List<Loan>> GetAll(Loan Loan)
        {
            return new List<Loan>();
        }
    }
}
