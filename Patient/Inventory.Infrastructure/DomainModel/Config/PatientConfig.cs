using PatientManagement.Domain.Patients;
using PatientManagement.Domain.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PatientManagement.Domain.Transactions;

namespace PatientManagement.Infrastructure.DomainModel.Config
{
    internal class PatientConfig : IEntityTypeConfiguration<Patient>,
        IEntityTypeConfiguration<PatientPhone>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Patient> builder)
        {
            builder.ToTable("patient");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("patientId");

            builder.Property(x => x.Name)
                .HasColumnName("name");

            builder.Property(x => x.BirthDate)
                .HasColumnName("birthDate");

            builder.Property(x => x.Gender)
               .HasColumnName("gender");

           var converter = new ValueConverter<EmailValue, string>(
                emailValue => emailValue.Value, 
                email => new EmailValue(email) 
            );

            builder.Property(x => x.Email)
                .HasConversion(converter)
                .HasColumnName("email");

            builder.HasMany(typeof(Phone), "_phones");

            builder.Ignore("_domainEvents");
            builder.Ignore(x => x.DomainEvents);

        }

        public void Configure(EntityTypeBuilder<PatientPhone> builder)
        {
            builder.ToTable("patientPhone");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("patientPhoneId");

            builder.Property(x => x.Number)
                .HasColumnName("number");
        }
    }
}
