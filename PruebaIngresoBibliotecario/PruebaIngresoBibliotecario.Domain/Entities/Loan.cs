using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaIngresoBibliotecario.Domain.Entities
{
    public class Loan
    {
        public string Id { get; set; }

        public UserType TipoUsuario { get; set; }

        public string IdentificacionUsuario { get; set; }

        public Guid Isbn { get; set; }

        public DateTime FechaMaximaDevolucion { get; set; }
    }
}
