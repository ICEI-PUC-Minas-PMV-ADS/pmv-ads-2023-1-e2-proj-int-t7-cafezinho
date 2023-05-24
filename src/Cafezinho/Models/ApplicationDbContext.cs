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
        public DbSet<Dashboard> Dashboard { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().HasData(
                new Cliente()
                {
                    Cpf = "001",
                    Nome = "Admin",
                    Email = "",
                    DtNascimento = new DateTime(2000, 01, 01),
                    Cep = "",
                    Logradouro = "",
                    Numero = "",
                    Complemento = "",
                    Bairro = "",
                    Cidade = "",
                    Estado = "",
                    Senha = "$2a$10$6z4B.MIAncvz0rsrTRnuDORmDZUXXa1hXAXs9Pfa7Twwjylz2qujS",
                    Perfil = Perfil.Administrador,
                }
            );

        }
    }
}
