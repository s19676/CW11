using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Configurations
{
    public class PrescriptionConfigurations : IEntityTypeConfiguration<Prescription>
    {
        public void Configure(EntityTypeBuilder<Prescription> builder)
        {
            builder.HasKey(e => e.IdPrescription);

            builder.Property(e => e.Date)
                .IsRequired(true);

            builder.Property(e => e.DueDate)
                .IsRequired(true);

            builder.Property(e => e.IdPatient)
                .IsRequired(true);

            builder.Property(e => e.IdDoctor)
                .IsRequired(true);
        }
    }
}