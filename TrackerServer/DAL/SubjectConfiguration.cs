using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrackerServer.model;

namespace TrackerServer.DAL
{
    public class SubjectConfiguration : IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder.HasKey(nameof(Subject.Id));
            builder.Property(s => s.CoronaTest).HasColumnName(nameof(Subject.CoronaTest)).HasDefaultValue(DateTime.Now).IsRequired();
            builder.Property(s => s.CoronatTstPositive).HasColumnName(nameof(Subject.CoronatTstPositive)).IsRequired();
            builder.Property(s => s.DossierNr).HasColumnName(nameof(Subject.DossierNr)).IsRequired();
            builder.Property(s => s.ExtraInformation).HasColumnName(nameof(Subject.ExtraInformation)).IsRequired();
            builder.Property(s => s.FirstSigns).HasColumnName(nameof(Subject.FirstSigns)).HasDefaultValue(DateTime.Now).IsRequired();
            builder.Property(s => s.StatusSubject).HasColumnName(nameof(Subject.StatusSubject)).IsRequired();
            builder.HasOne<Person>(p => p.Person);
            builder.HasOne<Symptoms>(p => p.Symtoms);
            builder.HasMany<PublicEvent>();
        }
    }
}