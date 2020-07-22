using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrackerServer.model;

namespace TrackerServer.DAL
{
    public class AddresssConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(nameof(Address.Id));
            builder.Property(s => s.City).HasColumnName(nameof(Address.City)).IsRequired();
            builder.Property(s => s.Nr).HasColumnName(nameof(Address.Nr)).IsRequired();
            builder.Property(s => s.Street).HasColumnName(nameof(Address.Street)).IsRequired();
            builder.Property(s => s.ZipCode).HasColumnName(nameof(Address.ZipCode)).IsRequired();
            builder.Property(s => s.Nr).HasColumnName(nameof(Address.Nr)).IsRequired();
            builder.HasOne<Country>(s => s.Country);
        }
    }
}