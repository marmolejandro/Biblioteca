using Microsoft.EntityFrameworkCore;
using PruebaIngresoBibliotecario.Domain.Entities;
using PruebaIngresoBibliotecario.Domain.Interfaces;
using PruebaIngresoBibliotecario.Infrastructure;

namespace PruebaIngresoBibliotecario.Core.Repository
{
    public class LoanRepository : ILoanRepository
    {
        LoanContext _context;
        public LoanRepository(LoanContext context)
        {
            _context = context;
        }

        public async Task<Loan> GetLoanById(Guid Id)
        {
            return await _context.Loan.Where(r => r.Id == Id).FirstOrDefaultAsync();
        }

        public async Task<Loan> SaveLoan(Loan Loan)
        {
            _context.Loan.Add(Loan);
            _context.SaveChanges();
            return Loan;
        }

        public async Task<List<Loan>> GetAll()
        {
            return await _context.Loan.ToListAsync();
        }

        public async Task<List<Loan>> GetLoanByIdUser(string IdUser)
        {
            return await _context.Loan.Where(r => r.IdentificacionUsuario == IdUser).ToListAsync();
        }
    }
}
