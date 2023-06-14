using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace RentCar.Models;

public partial class CarRentContext : DbContext
{
    public CarRentContext()
    {
    }

    //public CarRentContext(DbContextOptions<CarRentContext> options)
    //    : base(options)
    //{
    //}

    public  DbSet<Brand> Brands { get; set; }

    public  DbSet<Car> Cars { get; set; }

    public  DbSet<Customer> Customers { get; set; }

    public  DbSet<Rental> Rentals { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-2DR8RGC;Initial Catalog=CarRent;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    modelBuilder.Entity<Brand>(entity =>
    //    {
    //        entity.HasKey(e => e.Id).HasName("PK__Brands__3214EC27942580CE");

    //        entity.Property(e => e.Id)
    //            .ValueGeneratedNever()
    //            .HasColumnName("ID");
    //        entity.Property(e => e.Name)
    //            .HasMaxLength(50)
    //            .IsUnicode(false);
    //    });

    //    modelBuilder.Entity<Car>(entity =>
    //    {
    //        entity.HasKey(e => e.Id).HasName("PK__Cars__3214EC2746AC8CB1");

    //        entity.Property(e => e.Id)
    //            .ValueGeneratedNever()
    //            .HasColumnName("ID");
    //        entity.Property(e => e.BrandId).HasColumnName("BrandID");
    //        entity.Property(e => e.Model)
    //            .HasMaxLength(50)
    //            .IsUnicode(false);
    //        entity.Property(e => e.RegistrationNumber)
    //            .HasMaxLength(20)
    //            .IsUnicode(false);

    //        entity.HasOne(d => d.Brand).WithMany(p => p.Cars)
    //            .HasForeignKey(d => d.BrandId)
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK__Cars__BrandID__267ABA7A");
    //    });

    //    modelBuilder.Entity<Customer>(entity =>
    //    {
    //        entity.HasKey(e => e.Id).HasName("PK__Customer__3214EC270F53EFC5");

    //        entity.Property(e => e.Id)
    //            .ValueGeneratedNever()
    //            .HasColumnName("ID");
    //        entity.Property(e => e.Email)
    //            .HasMaxLength(100)
    //            .IsUnicode(false);
    //        entity.Property(e => e.FirstName)
    //            .HasMaxLength(50)
    //            .IsUnicode(false);
    //        entity.Property(e => e.LastName)
    //            .HasMaxLength(50)
    //            .IsUnicode(false);
    //        entity.Property(e => e.Phone)
    //            .HasMaxLength(20)
    //            .IsUnicode(false);
    //    });

    //    modelBuilder.Entity<Rental>(entity =>
    //    {
    //        entity.HasKey(e => e.Id).HasName("PK__Rentals__3214EC277C348FB9");

    //        entity.Property(e => e.Id)
    //            .ValueGeneratedNever()
    //            .HasColumnName("ID");
    //        entity.Property(e => e.CarId).HasColumnName("CarID");
    //        entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
    //        entity.Property(e => e.RentalDate).HasColumnType("date");
    //        entity.Property(e => e.ReturnDate).HasColumnType("date");

    //        entity.HasOne(d => d.Car).WithMany(p => p.Rentals)
    //            .HasForeignKey(d => d.CarId)
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK__Rentals__CarID__2B3F6F97");

    //        entity.HasOne(d => d.Customer).WithMany(p => p.Rentals)
    //            .HasForeignKey(d => d.CustomerId)
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK__Rentals__Custome__2C3393D0");
    //    });

    //    OnModelCreatingPartial(modelBuilder);
    //}

    //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
