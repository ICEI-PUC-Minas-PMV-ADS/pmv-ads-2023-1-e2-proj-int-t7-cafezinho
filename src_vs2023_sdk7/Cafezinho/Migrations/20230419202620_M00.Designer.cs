﻿// <auto-generated />
using System;
using Cafezinho.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Cafezinho.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230419202620_M00")]
    partial class M00
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Cafezinho.Models.Ativo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Ticker")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ativos");
                });

            modelBuilder.Entity("Cafezinho.Models.Cliente", b =>
                {
                    b.Property<string>("Cpf")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("cpf");

                    b.Property<string>("CarteiraId")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("carteira_id");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("cep");

                    b.Property<DateTime>("DtNascimento")
                        .HasColumnType("datetime2")
                        .HasColumnName("dt_nascimento");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("email");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("endereco");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nome");

                    b.Property<int>("Perfil")
                        .HasColumnType("int");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("senha");

                    b.HasKey("Cpf");

                    b.ToTable("clientes");
                });
#pragma warning restore 612, 618
        }
    }
}
