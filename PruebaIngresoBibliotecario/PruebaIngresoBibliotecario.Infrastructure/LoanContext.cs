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
    public class LoanContext : DbContext
    {

        private readonly IConfiguration _config;
        public DbSet<Loan> Loan { get; set; }

        public LoanContext(DbContextOptions<LoanContext> options, IConfiguration config) : base(options)
        { 
            _config = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(_config.GetSection("DataBaseName").ToString());
        }
        public async Task CommitAsync()
        {
            await SaveChangesAsync().ConfigureAwait(false);
        }
    }
}
