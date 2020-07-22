using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrackerServer.model;

namespace TrackerServer.DAL
{
    public class PublicEventConfiguration : IEntityTypeConfiguration<PublicEvent>
    {
        public void Configure(EntityTypeBuilder<PublicEvent> builder)
        {
            builder.HasKey(nameof(PublicEvent.Id));
            builder.Property(s => s.Description).HasColumnName(nameof(PublicEvent.Description)).IsRequired();
            builder.Property(s => s.Peoples).HasColumnName(nameof(PublicEvent.Peoples)).IsRequired();
            builder.Property(s => s.NameEvent).HasColumnName(nameof(PublicEvent.NameEvent)).IsRequired();
            builder.Property(s => s.TypeEvent).HasColumnName(nameof(PublicEvent.TypeEvent)).IsRequired();
            builder.Property(s => s.DateTimeEvent).HasColumnName(nameof(PublicEvent.DateTimeEvent)).IsRequired();
            builder.Property(s => s.PossibleGroundZeroBySubject).HasColumnName(nameof(PublicEvent.PossibleGroundZeroBySubject)).IsRequired();
            builder.HasMany<Person>();

        }
    }
}