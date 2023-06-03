using System;
using System.Collections.Generic;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace Data;

public partial class MichaelABdContext : DbContext
{
    public MichaelABdContext()
    {
    }

    public MichaelABdContext(DbContextOptions<MichaelABdContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TbChofer> TbChofers { get; set; }

    public virtual DbSet<TbLicenciaChofer> TbLicenciaChofers { get; set; }

    public virtual DbSet<TbTipoLicencium> TbTipoLicencia { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:dbINA");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TbChofer>(entity =>
        {
            entity.HasKey(e => e.Cedula).HasName("PK__tbChofer__415B7BE4BFFAEEC7");

            entity.ToTable("tbChofers");

            entity.Property(e => e.Cedula)
                .HasMaxLength(12)
                .IsFixedLength()
                .HasColumnName("cedula");
            entity.Property(e => e.Apellido1)
                .HasMaxLength(12)
                .IsFixedLength()
                .HasColumnName("apellido1");
            entity.Property(e => e.Apellido2)
                .HasMaxLength(12)
                .IsFixedLength()
                .HasColumnName("apellido2");
            entity.Property(e => e.Nombre)
                .HasMaxLength(12)
                .IsFixedLength()
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<TbLicenciaChofer>(entity =>
        {
            entity.HasKey(e => new { e.IdLicencia, e.IdTipoLicencia }).HasName("PK__tbLicenc__3213E83FD6450157");

            entity.ToTable("tbLicenciaChofer");

            entity.Property(e => e.IdLicencia)
                .HasMaxLength(12)
                .IsFixedLength()
                .HasColumnName("idLicencia");
            entity.Property(e => e.IdTipoLicencia)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("idTipoLicencia");
            entity.Property(e => e.FechaEmicion)
                .HasColumnType("date")
                .HasColumnName("fechaEmicion");
            entity.Property(e => e.FechaVenc)
                .HasColumnType("date")
                .HasColumnName("fechaVenc");

            entity.HasOne(d => d.IdLicenciaNavigation).WithMany(p => p.TbLicenciaChofers)
                .HasForeignKey(d => d.IdLicencia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbLicenciaChofer_tbChofers");

            entity.HasOne(d => d.IdTipoLicenciaNavigation).WithMany(p => p.TbLicenciaChofers)
                .HasForeignKey(d => d.IdTipoLicencia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbLicenciaChofer_tbTipoLicencia");
        });

        modelBuilder.Entity<TbTipoLicencium>(entity =>
        {
            entity.HasKey(e => e.IdTipoLicencia).HasName("PK__tbTipoLi__1BC84C6CD569C428");

            entity.ToTable("tbTipoLicencia");

            entity.Property(e => e.IdTipoLicencia)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("idTipoLicencia");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estado).HasColumnName("estado");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
