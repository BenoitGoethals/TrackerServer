using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrackerServer.model;

namespace TrackerServer.DAL
{
    public class TelephoneConfiguration: IEntityTypeConfiguration<Telephone>
    {
        public void Configure(EntityTypeBuilder<Telephone> builder)
        {
            builder.HasKey(nameof(Telephone.Id));
            builder.Property(s => s.CountryCode).HasColumnName(nameof(Telephone.CountryCode)).IsRequired();
            builder.Property(s => s.Nbr).HasColumnName(nameof(Telephone.Nbr)).IsRequired();
        }
    }
}