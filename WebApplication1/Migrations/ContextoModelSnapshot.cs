﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Models;

namespace WebApplication1.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication1.Models.Alunos", b =>
                {
                    b.Property<int>("AlunosId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome");

                    b.HasKey("AlunosId");

                    b.ToTable("Alunos");
                });

            modelBuilder.Entity("WebApplication1.Models.Carro", b =>
                {
                    b.Property<int>("CarroId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Ano");

                    b.Property<string>("Marca");

                    b.Property<string>("Nome");

                    b.HasKey("CarroId");

                    b.ToTable("Carros");
                });

            modelBuilder.Entity("WebApplication1.Models.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConfirmarEmail")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("Idade");

                    b.Property<DateTime>("Nascimento");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("ClienteId");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("WebApplication1.Models.Cliente2", b =>
                {
                    b.Property<int>("Clente2Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Idade");

                    b.Property<string>("Nome");

                    b.HasKey("Clente2Id");

                    b.ToTable("Cliente2");
                });

            modelBuilder.Entity("WebApplication1.Models.Cliente3", b =>
                {
                    b.Property<int>("Cliente3Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Idade");

                    b.Property<string>("Nome");

                    b.HasKey("Cliente3Id");

                    b.ToTable("Cliente3");
                });

            modelBuilder.Entity("WebApplication1.Models.Fornecedor", b =>
                {
                    b.Property<int>("FornecedorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Idade")
                        .HasColumnName("Idade")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("Nome")
                        .HasColumnType("ntext")
                        .HasMaxLength(50);

                    b.Property<double?>("Peso")
                        .HasColumnName("Peso")
                        .HasColumnType("float");

                    b.HasKey("FornecedorId");

                    b.ToTable("Fornecedor");
                });

            modelBuilder.Entity("WebApplication1.Models.Materias", b =>
                {
                    b.Property<int>("MateriaisId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome");

                    b.HasKey("MateriaisId");

                    b.ToTable("Materias");
                });

            modelBuilder.Entity("WebApplication1.Models.Moedas", b =>
                {
                    b.Property<int>("MoedasId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome");

                    b.Property<int>("Quantidade");

                    b.HasKey("MoedasId");

                    b.ToTable("Moedas");
                });

            modelBuilder.Entity("WebApplication1.Models.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .HasColumnName("PessoaId")
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnName("Idade")
                        .HasColumnType("int");

                    b.Property<string>("CPF")
                        .HasColumnName("CPF")
                        .HasColumnType("ntext");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnName("Nascimento")
                        .HasColumnType("date");

                    b.Property<string>("Name")
                        .HasColumnName("Nome")
                        .HasColumnType("ntext");

                    b.HasKey("PersonId");

                    b.ToTable("Pessoa1");
                });

            modelBuilder.Entity("WebApplication1.Models.Pessoa", b =>
                {
                    b.Property<int>("PessoaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Idade");

                    b.Property<string>("Nome");

                    b.HasKey("PessoaId");

                    b.ToTable("Pessoa");
                });

            modelBuilder.Entity("WebApplication1.Models.Tarefas", b =>
                {
                    b.Property<string>("TarefasId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descrição");

                    b.Property<DateTime>("Fim");

                    b.Property<string>("Importancia");

                    b.Property<DateTime>("Inicio");

                    b.Property<string>("Nome");

                    b.HasKey("TarefasId");

                    b.ToTable("Tarefas");
                });
#pragma warning restore 612, 618
        }
    }
}
