using PruebaIngresoBibliotecario.Api.Models;
using PruebaIngresoBibliotecario.Core.Interfaces;
using PruebaIngresoBibliotecario.Domain.Entities;
using PruebaIngresoBibliotecario.Domain.Interfaces;
using PruebaIngresoBibliotecario.Domain.Models;

namespace PruebaIngresoBibliotecario.Core.Services
{
    public class LoanService : ILoanService
    {
        ILoanRepository _loanRepository;
        IMapperLoan _mapperLoan;
        public LoanService(ILoanRepository loanRepository, IMapperLoan mapperLoan)
        {
            _loanRepository = loanRepository;
            _mapperLoan = mapperLoan;
        }

        public async Task<Loan> GetLoan(Guid Id)
        {
            return await _loanRepository.GetLoanById(Id);
        }

        public async Task<CreateLoanOutDto> SaveLoan(CreateLoanInDto newLoan)
        {
            if (!ValidateUserType(newLoan.TipoUsuario) ||
                !ValidateSizeIdUser(newLoan.IdentificacionUsuario))
            {
                return BadRequest();
            }
            else if (!await ValidateLoan(newLoan.IdentificacionUsuario))
            {
                ResponseBase Result = new ResponseBase();
                Result.message = $"El usuario con identificación {newLoan.IdentificacionUsuario} ya tiene un libro prestado por lo cual no se le puede registrar otro prestamo";

                return BadRequest(Result);
            }

            DateTime returnDate = CalculateReturnDate(newLoan.TipoUsuario);

            Loan loanMapped = _mapperLoan.CreateLoanInDtoToLoan(newLoan, returnDate);
            Loan loanSaved = await _loanRepository.SaveLoan(loanMapped);

            CreateLoanOutDto loanOutMapped = _mapperLoan.LoanToCreateLoanOutDto(loanSaved);

            return loanOutMapped;
        }


        private DateTime CalculateReturnDate(UserType UserType)
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


        private async Task<bool> ValidateLoan(string IdUser)
        {
            List<Loan> loans = await _loanRepository.GetLoanByIdUser(IdUser);

            return loans.Where(r => (int)r.TipoUsuario == 1).ToList().Count == 0;
        }

        private bool ValidateUserType(UserType UserType)
        {
            if(!Enum.IsDefined(typeof(UserType), UserType))
                return false;
            
            return true;
        }

        private bool ValidateSizeIdUser(string IdUser)
        {
            return IdUser.Length <= 10;
        }
    }
}
