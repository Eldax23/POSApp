using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POSApp.DB.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSApp.DB.Configurations
{
    class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> e)
        {

            e.HasKey(P => P.ID);
            e.Property(P => P.Name).HasMaxLength(50).IsRequired(false);
            e.Property(P => P.Notes).IsRequired(false);
            e.Property(P => P.Code).HasMaxLength(50).IsRequired(false);
            e.Property(P => P.Price).IsRequired(false);
            e.Property(P => P.Quantity).IsRequired(false);
            e.Property(P => P.Image).IsRequired(false);
            


        }
    }
}
