using PruebaIngresoBibliotecario.Domain.Entities;

namespace PruebaIngresoBibliotecario.Domain.Interfaces
{
    public interface ILoanRepository
    {
        public Task<Loan> GetLoanById(Guid Id);
        public Task<Loan> SaveLoan(Loan Loan);
        public Task<List<Loan>> GetAll();
        public Task<List<Loan>> GetLoanByIdUser(string IdUser);
    }
}
