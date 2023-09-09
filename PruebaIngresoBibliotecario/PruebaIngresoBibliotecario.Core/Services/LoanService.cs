using PruebaIngresoBibliotecario.Api.Models;
using PruebaIngresoBibliotecario.Core.Repository;
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

        public async Task<Loan> GetLoan(Guid Id)
        {
            return await _loanRepository.GetLoanById(Id);
        }

        public async Task<CreateLoanOutDto> SaveLoan(CreateLoanInDto newLoan)
        {
            Loan loanSaved = await _loanRepository.SaveLoan( await ConvertToLoan(newLoan) );

            CreateLoanOutDto _loanOut = new CreateLoanOutDto();
            _loanOut.Id = loanSaved.Id;
            _loanOut.FechaMaximaDevolucion = loanSaved.FechaMaximaDevolucion;

            return _loanOut;
        }


        public async Task<DateTime> CalculateReturnDate(UserType UserType)
        {
            var weekend = new[] { DayOfWeek.Saturday, DayOfWeek.Sunday };

            DateTime returnDate = DateTime.Now;

            int returnDays = (int)(ReturnDays)Enum.Parse(typeof(ReturnDays), UserType.ToString());

            for (int i = 0; i < returnDays;)
            {
                returnDate = returnDate.AddDays(1);
                i = weekend.Contains(returnDate.DayOfWeek) ? i : ++i;
            }

            return returnDate;
        }


        public async Task<bool> ValidateLoan(string IdUser)
        {
            List<Loan> loans = await _loanRepository.GetLoanByIdUser(IdUser);

            return loans.Where(r => (int)r.TipoUsuario == 1).ToList().Count == 0;
        }

        public async Task<bool> ValidateUserType(UserType UserType)
        {
            if(!Enum.IsDefined(typeof(UserType), UserType))
                return false;
            
            return true;
        }

        public async Task<bool> ValidateSizeIdUser(string IdUser)
        {
            return IdUser.Length <= 10;
        }

        public async Task<Loan> ConvertToLoan(CreateLoanInDto newLoan)
        {
            DateTime returnDate = await this.CalculateReturnDate(newLoan.TipoUsuario);

            Loan loan = new Loan();
            loan.Id = new Guid();
            loan.IdentificacionUsuario = newLoan.IdentificacionUsuario;
            loan.TipoUsuario = newLoan.TipoUsuario;
            loan.Isbn = newLoan.Isbn;
            loan.FechaMaximaDevolucion = returnDate;

            return loan;
        }
    }
}
