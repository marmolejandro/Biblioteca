using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PruebaIngresoBibliotecario.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaIngresoBibliotecario.Infrastructure
{
    public class Context : DbContext
    {

        private readonly IConfiguration _config;
        public DbSet<Loan> Loan { get; set; }

        public Context(DbContextOptions<Context> options, IConfiguration config) : base(options)
        { 
            _config = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "LoanDb");
        }
    }
}
