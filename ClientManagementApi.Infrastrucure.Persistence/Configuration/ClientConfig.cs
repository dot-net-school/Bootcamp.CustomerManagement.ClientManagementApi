using ClientManagementApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagementApi.Infrastrucure.Persistence.Configuration
{
    public class ClientConfig : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.Property(c => c.FirstName)
            .HasMaxLength(50)
            .IsRequired();

            builder.Property(c => c.LastName)
            .HasMaxLength(80)
            .IsRequired();

            builder.Property(c => c.Email)
            .IsRequired();

            //Sample : +989121234567
            builder.Property(c => c.PhoneNumber)
            .HasMaxLength(13);

            builder.Property(c => c.DateOfBirth)
            .IsRequired();

            builder.OwnsOne(c => c.Address);

            builder.Property(c => c.CreatedAt)
            .HasDefaultValue(DateTime.Now);

            builder.Property(c => c.MaritalStatus)
            .IsRequired();

            builder.Property(c => c.Gender)
            .IsRequired();

            builder.OwnsMany(c => c.Degrees);

            builder.OwnsMany(c => c.Jobs);

            builder.Property(c => c.NationalId)
           .HasMaxLength(10);

            builder.Property(c => c.PassportId)
           .HasMaxLength(15);











        }
    }
}
