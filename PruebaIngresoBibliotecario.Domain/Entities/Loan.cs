using PruebaIngresoBibliotecario.Domain.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaIngresoBibliotecario.Domain.Entities
{
    public class Loan
    {
        [Key]
        public Guid Id { get; set; }

        public string IdentificacionUsuario { get; set; }
        public UserType TipoUsuario { get; set; }

        public Guid Isbn { get; set; }
        public DateTime FechaMaximaDevolucion { get; set; }
    }
}
