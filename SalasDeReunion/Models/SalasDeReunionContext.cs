using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SalasDeReunion.Models
{
    public partial class SalasDeReunionContext : DbContext
    {
        public SalasDeReunionContext()
        {
        }

        public SalasDeReunionContext(DbContextOptions<SalasDeReunionContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Reservas> Reservas { get; set; }
        public virtual DbSet<Salas> Salas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=SalasDeConferencia;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Reservas>(entity =>
            {
                entity.Property(e => e.HoraFin).HasColumnType("datetime");

                entity.Property(e => e.HoraInicio).HasColumnType("datetime");

                entity.Property(e => e.NombreReserva)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Salas>(entity =>
            {
                entity.HasKey(e => e.SalaId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
