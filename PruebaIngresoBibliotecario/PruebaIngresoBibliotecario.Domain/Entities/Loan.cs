using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaIngresoBibliotecario.Domain.Entities
{
    public class Loan
    {
        public Guid Id { get; set; }

       public User User { get; set; }

        public Book Book { get; set; }

        public DateTime FechaMaximaDevolucion { get; set; }
    }
}
