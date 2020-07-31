using System.Collections.Generic;
using System.IO;
using Csv;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrackerServer.model;

namespace TrackerServer.DAL
{
    public class ZipcodeConfiguration : IEntityTypeConfiguration<ZipCode>
    {
        public void Configure(EntityTypeBuilder<ZipCode> builder)
        {
            builder.HasKey(nameof(ZipCode.Id));
            builder.Property(s => s.Code).HasColumnName(nameof(ZipCode.Code)).IsRequired();
            builder.Property(s => s.City).HasColumnName(nameof(ZipCode.City)).IsRequired();

            var codes = new List<ZipCode>();
            var csv = File.ReadAllText("zipcodes_alpha_nl.csv");
            int counter = 0;
            foreach (var line in CsvReader.ReadFromText(csv))
            {
                // Header is handled, each line will contain the actual row data

                codes.Add(new ZipCode()
                {
                    Id = ++counter,
                    Code = line["Postcode"], City = line["Plaatsnaam"] + " " + line["Hoofdgemeente"]
                });
            }
            
            builder.HasData(codes);
        }
    }
}