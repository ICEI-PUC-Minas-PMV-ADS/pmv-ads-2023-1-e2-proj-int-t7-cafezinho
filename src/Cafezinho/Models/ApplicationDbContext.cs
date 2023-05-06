using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cafezinho.Models;

namespace Cafezinho.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Ativo> Ativos { get; set; }
        public DbSet<Registro> Registros { get; set; }
        public DbSet<Carteira> Carteira { get; set; }
    }
}
