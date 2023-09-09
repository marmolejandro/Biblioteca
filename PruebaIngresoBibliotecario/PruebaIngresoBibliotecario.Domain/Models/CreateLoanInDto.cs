using PruebaIngresoBibliotecario.Domain.Entities;

namespace PruebaIngresoBibliotecario.Api.Models
{
    public class CreateLoanInDto
    {
        public Guid Isbn { get; set; }
        public string IdentificacionUsuario { get; set;}
        public UserType TipoUsuario { get; set;}
    }
}
