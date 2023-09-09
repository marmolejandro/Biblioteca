using System.ComponentModel.DataAnnotations;

namespace PruebaIngresoBibliotecario.Domain.Entities
{
    public class User
    {
        [Key]
        public string IdentificacionUsuario { get; set; }
        public UserType TipoUsuario { get; set; }
    }
}
