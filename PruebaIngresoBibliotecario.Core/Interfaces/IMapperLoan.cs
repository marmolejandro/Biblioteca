using PruebaIngresoBibliotecario.Api.Models;
using PruebaIngresoBibliotecario.Domain.Entities;

namespace PruebaIngresoBibliotecario.Core.Interfaces
{
    public interface IMapperLoan
    {
        Loan CreateLoanInDtoToLoan(CreateLoanInDto newLoan, DateTime returnDate);
        CreateLoanOutDto LoanToCreateLoanOutDto(Loan Loan);
    }
}
