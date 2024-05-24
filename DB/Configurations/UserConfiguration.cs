using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.VisualBasic.ApplicationServices;
using POSApp.DB.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSApp.DB.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<UserDB>
    {
        public void Configure(EntityTypeBuilder<UserDB> builder)
        {
            builder.HasKey(X => X.ID);
            builder.Property(X => X.UserName).HasMaxLength(50);
            builder.Property(X => X.Password).HasMaxLength(50);

        }
    }
}
