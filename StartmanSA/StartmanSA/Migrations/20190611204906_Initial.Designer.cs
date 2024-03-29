﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StartmanSA.Models;

namespace StartmanSA.Migrations
{
    [DbContext(typeof(StartmanSAContext))]
    [Migration("20190611204906_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StartmanSA.Models.Logs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DiaAlteracao")
                        .HasColumnType("datetime");

                    b.Property<string>("Encarregado")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("MateriaPrima")
                        .IsRequired()
                        .HasMaxLength(300)
                        .IsUnicode(false);

                    b.Property<long>("QuantidadeAlterada");

                    b.HasKey("Id");

                    b.ToTable("logs");
                });

            modelBuilder.Entity("StartmanSA.Models.Materiaprima", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(300)
                        .IsUnicode(false);

                    b.Property<long>("QuantidadeEstoque");

                    b.Property<long>("QuantidadeEstoqueMax");

                    b.HasKey("Id");

                    b.ToTable("materiaprima");
                });
#pragma warning restore 612, 618
        }
    }
}
