using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaIngresoBibliotecario.Domain.Entities
{
    public class User
    {
        public string IdentificacionUsuario { get; set; }
        public UserType TipoUsuario { get; set; }
    }
}
