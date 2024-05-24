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
    public class SupplierConfiguration : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.HasKey(S => S.ID);
            builder.Property(S=> S.Name).HasMaxLength(50).IsRequired(false);
            builder.Property(S => S.Phone).HasMaxLength(50).IsRequired(false);
            builder.Property(S => S.Company).HasMaxLength(50).IsRequired(false);
            builder.Property(S => S.Email).HasMaxLength(50).IsRequired(false);
            builder.Property(S => S.Image).IsRequired(false);
            builder.Property(S => S.Address).IsRequired(false);
            builder.Property(S => S.Notes).IsRequired(false);
            builder.Property(S => S.isActive).IsRequired(false);

        }
    }
}
