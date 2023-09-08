using PruebaIngresoBibliotecario.Domain.Entities;

namespace PruebaIngresoBibliotecario.Api.Models
{
    public class CreateLoanInDto
    {
        public string Isbn { get; set; }
        public string IdentificacionUsuario { get; set;}
        public UserType TipoUsuario { get; set;}
    }
}
