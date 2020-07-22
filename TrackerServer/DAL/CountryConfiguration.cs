using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrackerServer.model;

namespace TrackerServer.DAL
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
           
            builder.HasKey(nameof(Country.Id));
            builder.Property(s => s.Name).HasColumnName(nameof(Country.Name)).IsRequired();

        }
    }
}