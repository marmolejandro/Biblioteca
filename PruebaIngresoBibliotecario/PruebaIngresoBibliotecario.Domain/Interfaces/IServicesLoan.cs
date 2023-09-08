using PruebaIngresoBibliotecario.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaIngresoBibliotecario.Domain.Interfaces
{
    public interface IServicesLoan
    {
        public Task<bool> ValidateLoan(Loan _Loan);
        public Loan SearchLoan(string Id);
        public Loan CreateLoan(Loan _Loan);
    }
}
