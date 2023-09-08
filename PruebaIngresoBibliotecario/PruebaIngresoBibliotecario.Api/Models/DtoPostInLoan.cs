using PruebaIngresoBibliotecario.Domain.Entities;

namespace PruebaIngresoBibliotecario.Api.Models
{
    public class DtoPostInLoan
    {
        public string Isbn { get; set; }
        public string IdentificacionUsuario { get; set;}
        public UserType TipoUsuario { get; set;}
    }
}
