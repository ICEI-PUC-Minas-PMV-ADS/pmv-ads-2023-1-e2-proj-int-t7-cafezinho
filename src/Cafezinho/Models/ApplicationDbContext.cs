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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().HasData(
                new Cliente()
                {
                    Cpf = "001",
                    Nome = "Admin",
                    Email = "",
                    DtNascimento = DateTime.Now,
                    Cep = "",
                    Logradouro = "",
                    Numero = "",
                    Complemento = "",
                    Bairro = "",
                    Cidade = "",
                    Estado = "",
                    Senha = BCrypt.Net.BCrypt.HashPassword("1234"),
                    Perfil = Perfil.Administrador,
                }
            );

        }
    }
}
