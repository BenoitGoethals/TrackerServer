using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrackerServer.model;

namespace TrackerServer.DAL
{
    public class SymptomsConfiguration : IEntityTypeConfiguration<Symptoms>
    {
        public void Configure(EntityTypeBuilder<Symptoms> builder)
        {
            builder.HasKey(nameof(Symptoms.Id));
            builder.Property(s => s.Fatigue).HasColumnName(nameof(Symptoms.Fatigue)).IsRequired();
            builder.Property(s => s.Fever).HasColumnName(nameof(Symptoms.Fever)).IsRequired();
            builder.Property(s => s.Mucus).HasColumnName(nameof(Symptoms.Mucus)).IsRequired();
            builder.Property(s => s.AdryCough).HasColumnName(nameof(Symptoms.AdryCough)).IsRequired();
            builder.Property(s => s.LossOfAppetite).HasColumnName(nameof(Symptoms.LossOfAppetite)).IsRequired();
            builder.Property(s => s.ShortnessOfBreath).HasColumnName(nameof(Symptoms.ShortnessOfBreath)).IsRequired();
            builder.Property(s => s.ExtraInfo).HasColumnName(nameof(Symptoms.ExtraInfo));
        }
    }
}