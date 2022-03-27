using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BackAplicacion.Models
{
    public partial class PT_JAVIERCALLESContext : DbContext
    {
      
        public virtual DbSet<Cliente> Cliente { get; set; }


        public PT_JAVIERCALLESContext(DbContextOptions<PT_JAVIERCALLESContext> options)
          : base(options)
        {
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.3-servicing-35854");

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PK__cliente__885457EE437F0251");

                entity.ToTable("cliente");

                entity.Property(e => e.IdCliente).HasColumnName("idCliente");

                entity.Property(e => e.FechaIngreso).HasColumnType("datetime");

                entity.Property(e => e.PrimerNombre)
                    .IsRequired()
                    .HasColumnName("primerNombre")
                    .HasMaxLength(50);

                entity.Property(e => e.SegundoNombre)
                    .IsRequired()
                    .HasColumnName("segundoNombre")
                    .HasMaxLength(50);
            });
        }
    }
}
