using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace API_pasantia.models;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<MovInv> MovInvs { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<TipoMovInv> TipoMovInvs { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("PK__Category__19093A2B5169DF37");

            entity.ToTable("Category");

            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.NombreCategoria)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MovInv>(entity =>
        {
            entity.HasKey(e => e.MovInvId).HasName("PK__MovInv__130B6EBB0566830B");

            entity.ToTable("MovInv");

            entity.Property(e => e.MovInvId).HasColumnName("MovInvID");
            entity.Property(e => e.FechaMov).HasColumnType("datetime");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.TipoMovInvId).HasColumnName("TipoMovInvID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Product).WithMany(p => p.MovInvs)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__MovInv__ProductI__4336F4B9");

            entity.HasOne(d => d.TipoMovInv).WithMany(p => p.MovInvs)
                .HasForeignKey(d => d.TipoMovInvId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__MovInv__TipoMovI__451F3D2B");

            entity.HasOne(d => d.User).WithMany(p => p.MovInvs)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__MovInv__UserID__442B18F2");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__Product__B40CC6EDBACB076B");

            entity.ToTable("Product");

            entity.HasIndex(e => e.CodigoProducto, "UQ__Product__785B009FE06BE052").IsUnique();

            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.CodigoProducto)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.NombreProducto)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Precio).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Category).WithMany(p => p.Products)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Product__Categor__3B95D2F1");
        });

        modelBuilder.Entity<TipoMovInv>(entity =>
        {
            entity.HasKey(e => e.TipoMovInvId).HasName("PK__TipoMovI__7082B5B7EB362B1E");

            entity.ToTable("TipoMovInv");

            entity.Property(e => e.TipoMovInvId).HasColumnName("TipoMovInvID");
            entity.Property(e => e.NombreMov)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__User__1788CCACC40E2015");

            entity.ToTable("User");

            entity.HasIndex(e => e.NombreUsuario, "UQ__User__6B0F5AE0BD8596B7").IsUnique();

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.Contrasena)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Correo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.NombreUsuario)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
