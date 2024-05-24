using Microsoft.EntityFrameworkCore;
using POSApp.DB.Configurations;
using POSApp.DB.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSApp.DB.Context
{
    public class poscontext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=SPDB;Integrated Security=True;Encrypt=False");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasKey(C => C.ID);
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new SupplierConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.Entity<Customer>(e =>
            {
                e.Property(C => C.Name).HasMaxLength(50).IsRequired(false);
                e.Property(C => C.Phone).HasMaxLength(50).IsRequired(false);
                e.Property(C => C.Company).HasMaxLength(50).IsRequired(false);
                e.Property(C => C.Email).HasMaxLength(50).IsRequired(false);
                e.Property(C => C.Address).IsRequired(false);
                e.Property(C => C.Notes).IsRequired(false);
                e.Property(P => P.Image).IsRequired(false);
                e.Property(P => P.IsActive).IsRequired(false);


            });
            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<UserDB> Users { get; set; }  

        
        
    }
}
