using LENSLOOK.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LENSLOOK.Context
{
    internal class LENSLOOKDbContext : DbContext
    {
        public LENSLOOKDbContext() :base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = . ; Database = LENSLOOK ; Trusted_Connection = true");
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Userphnoes> Userphnoes { get; set;}
        public DbSet<Doctors> Doctors { get; set; }
        public DbSet<Doctorsphones> Doctorsphones { get; set; }
        public DbSet<Rates> Rates { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Delivery>  Deliveries { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
        public DbSet<Reviews> Reviews { get; set; }
        public DbSet<Vendors> Vendors { get; set; }
        public DbSet<VendorPhone> VendorPhones { get; set; }
        public DbSet<VendorProduct> VendorProducts { get; set; }
        public DbSet<Products> Products { get; set; }






        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Userphnoes>()
                        .HasKey(up => new { up.UID, up.Uphone });

            modelBuilder.Entity<Userphnoes>()
                        .HasOne(up => up.users)
                        .WithMany(u => u.UserPhones)
                        .HasForeignKey(up => up.UID);

            modelBuilder.Entity<Doctorsphones>()
                        .HasKey(up => new { up.DID, up.Dphone });

            modelBuilder.Entity<Doctorsphones>()
                        .HasOne(up => up.Doctors)
                        .WithMany(u => u.DoctorPhones)
                        .HasForeignKey(up => up.DID);

            
            modelBuilder.Entity<Rates>()
                        .HasKey(r => new { r.UID, r.DID });

            modelBuilder.Entity<Rates>()
                        .HasOne(r => r.Users)
                        .WithMany(u => u.Rates)
                        .HasForeignKey(r => r.UID);

            modelBuilder.Entity<Rates>()
                        .HasOne(r => r.Doctors)
                        .WithMany(d => d.Rates)
                        .HasForeignKey(r => r.DID);

            modelBuilder.Entity<Users>()
                        .HasMany(u => u.Doctors)
                        .WithMany(d => d.Users)
                        .UsingEntity(j => j.ToTable("Examinations"));

            modelBuilder.Entity<Booking>()
                        .HasKey(b => new { b.UID, b.DID, b.SID });

            modelBuilder.Entity<Booking>()
                        .HasOne(b => b.Users)
                        .WithMany(u => u.Bookings)
                        .HasForeignKey(b => b.UID);

            modelBuilder.Entity<Booking>()
                        .HasOne(b => b.Doctors)
                        .WithMany(d => d.Bookings)
                        .HasForeignKey(b => b.DID);

            modelBuilder.Entity<Booking>()
                        .HasOne(b => b.Services)
                        .WithMany(s => s.Bookings)
                        .HasForeignKey(b => b.SID);

            modelBuilder.Entity<VendorPhone>()
                        .HasKey(vp => new { vp.VID, vp.Vphone });

            modelBuilder.Entity<VendorPhone>()
                        .HasOne(vp => vp.vendors)
                        .WithMany(v => v.VendorPhones)
                        .HasForeignKey(vp => vp.VID);

            modelBuilder.Entity<VendorProduct>()
                        .HasKey(dp => new { dp.VID, dp.PID });

            modelBuilder.Entity<VendorProduct>()
                        .HasOne(vp => vp.Vendors)
                        .WithMany(v => v.vendorProducts)
                        .HasForeignKey(vp => vp.VID);

            modelBuilder.Entity<VendorProduct>()
                        .HasOne(VP => VP.products)
                        .WithMany(P => P.vendorProducts)
                        .HasForeignKey(vp => vp.PID);

            modelBuilder.Entity<Reviews>()
                        .HasKey(r => new { r.PID, r.UID });

            modelBuilder.Entity<Reviews>()
                        .HasOne(r => r.Users)
                        .WithMany(u => u.Reviews)
                        .HasForeignKey(r => r.UID);

            modelBuilder.Entity<Reviews>()
                        .HasOne(r => r.products)
                        .WithMany(p => p.Reviews)
                        .HasForeignKey(r => r.PID);

            modelBuilder.Entity<OrderProduct>()
                        .HasKey(op => new { op.OID, op.PID });

            modelBuilder.Entity<OrderProduct>()
                        .HasOne(op => op.Orders)
                        .WithMany(o => o.OrderProduct)
                        .HasForeignKey(op => op.OID);

            modelBuilder.Entity<OrderProduct>()
                        .HasOne(op => op.products)
                        .WithMany(P => P.OrderProduct)
                        .HasForeignKey(op => op.PID);
        }

    }
}
