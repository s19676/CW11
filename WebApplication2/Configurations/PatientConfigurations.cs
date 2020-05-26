
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Configurations
{
    public class PatientConfigurations : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.HasKey(e => e.IdPatient);

            builder.Property(e => e.FirstName)
                .HasMaxLength(100)
                .IsRequired(true);

            builder.Property(e => e.LastName)
                .HasMaxLength(100)
                .IsRequired(true);

            builder.Property(e => e.BirthDate)
                .IsRequired(true);

        }
    }
}