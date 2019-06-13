using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace StartmanSA.Models
{
    //classe context do programa
    public partial class StartmanSAContext : DbContext
    {
        public StartmanSAContext()
        {
        }

        public StartmanSAContext(DbContextOptions<StartmanSAContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Logs> Logs { get; set; }
        public virtual DbSet<Materiaprima> Materiaprima { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //connection string do banco de dados
                optionsBuilder.UseSqlServer("Server=LAPTOP-RG5S275I;Database=StartmanSA;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Logs>(entity =>
            {
                entity.ToTable("logs");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DiaAlteracao).HasColumnType("datetime");

                entity.Property(e => e.Encarregado)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MateriaPrima)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Materiaprima>(entity =>
            {
                entity.ToTable("materiaprima");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });
        }
    }
}
