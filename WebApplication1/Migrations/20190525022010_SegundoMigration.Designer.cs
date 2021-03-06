﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Models;

namespace WebApplication1.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20190525022010_SegundoMigration")]
    partial class SegundoMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
