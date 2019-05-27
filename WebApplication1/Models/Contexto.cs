using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Carro> Carros { get; set; }
        public DbSet<Tarefas> Tarefas { get; set; }
        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<Moedas> Moedas { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Cliente2> Cliente2 { get; set; }
        public DbSet<Cliente3> Cliente3 { get; set; }
        public DbSet<Person> Person { get; set; }

        public DbSet<Alunos> Alunos { get; set; }
        public DbSet<Materias> Materias { get; set; }

        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Fornecedor>().HasKey(x => x.FornecedorId);

            modelBuilder.Entity<Fornecedor>().Property(x => x.Nome).HasColumnName("Nome").HasColumnType("ntext").HasMaxLength(50).IsRequired();

            modelBuilder.Entity<Fornecedor>().Property(x => x.Idade).HasColumnName("Idade").HasColumnType("int").IsRequired(false);

            modelBuilder.Entity<Fornecedor>().Property(x => x.Peso).HasColumnName("Peso").HasColumnType("float").IsRequired(false);

            modelBuilder.Entity<Fornecedor>().ToTable("Fornecedor");
        }
    }
}
