using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrackerServer.model;

namespace TrackerServer.DAL
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasKey(nameof(Person.Id));
            builder.Property(s => s.Name).HasColumnName(nameof(Person.Name)).IsRequired();
            builder.Property(s => s.ForName).HasColumnName(nameof(Person.ForName)).IsRequired();
            builder.Property(s => s.Email).HasColumnName(nameof(Person.Email)).IsRequired();
            builder.Property(s => s.Job).HasColumnName(nameof(Person.Job));
            builder.Property(s => s.Relation).HasColumnName(nameof(Person.Relation));
            
            
            builder
                .HasOne<Address>(s => s.Address)
                .WithOne(ad => ad.Person)
                .HasForeignKey<Address>(ad => ad.AddressOfPersonId);


            builder
                .HasOne<Country>(s => s.Country).WithMany();
            
            //    modelBuilder.Entity<Person>()
            //      .HasMany(s => s.Telephones);
            
           

          
            builder
                .HasOne<Person>(s => s.CurrentPerson)
                .WithMany(g => g.Family)
                .HasForeignKey(s => s.CurrentPersonId);

        }
    }
}