using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Configurations
{
    public class Prescription_MedicationConfiguration : IEntityTypeConfiguration<Prescription_Medicament>
    {
        public void Configure(EntityTypeBuilder<Prescription_Medicament> builder)
        {
            builder.HasKey(e => new { e.IdMedicament, e.IdPrescription });

            builder.Property(e => e.Dose)
                .IsRequired(false);

            builder.Property(e => e.Details)
                .IsRequired(true)
                .HasMaxLength(100);
        }
    }
}