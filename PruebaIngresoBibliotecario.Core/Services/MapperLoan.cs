﻿using PruebaIngresoBibliotecario.Api.Models;
using PruebaIngresoBibliotecario.Core.Interfaces;
using PruebaIngresoBibliotecario.Domain.Entities;

namespace PruebaIngresoBibliotecario.Core.Services
{
    public class MapperLoan : IMapperLoan
    {
        Loan IMapperLoan.CreateLoanInDtoToLoan(CreateLoanInDto newLoan, DateTime returnDate)
        {
            return new Loan()
            {
                Id = new Guid(),
                IdentificacionUsuario = newLoan.IdentificacionUsuario,
                TipoUsuario = newLoan.TipoUsuario,
                Isbn = newLoan.Isbn,
                FechaMaximaDevolucion = returnDate
            };
        }

        CreateLoanOutDto IMapperLoan.LoanToCreateLoanOutDto(Loan Loan)
        {
            return new CreateLoanOutDto()
            {
                Id = Loan.Id,
                FechaMaximaDevolucion = Loan.FechaMaximaDevolucion
            };
        }
    }
}
