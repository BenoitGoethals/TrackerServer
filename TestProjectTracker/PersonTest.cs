using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Pomelo.EntityFrameworkCore.MySql.Storage;
using TrackerServer.model;
using Xunit;

namespace TestProjectTracker
{
    public class PersonTest
    {
        private  readonly DbContextOptionsBuilder<TestContext>  optionsBuilder = new DbContextOptionsBuilder<TestContext>();
        public PersonTest()
        {
            optionsBuilder .UseMySql("Server=192.168.0.160; Database=TrackerTest;User=benoit;Password=password;",      
                mysqlOptions =>      
                    mysqlOptions.ServerVersion(new ServerVersion(new Version(5, 5, 57), ServerType.MariaDb)));

        }

        [Fact]
        public void SaveTest()
        {
            using (var context = new TestContext( optionsBuilder.Options) )
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                for (int i = 0; i < 10; i++)
                {
                    
             
                Person person=new Person()
                {
                    Name = "Goethals"+i,
                    ForName = "benoit"+i,
                    Address = new Address()
                    {
                        City = "Gent",
                        Country = new Country(){Name = "France"},
                        Nr = "13",
                        Street = "noor",
                        ZipCode = new ZipCode(){City = "dendermonde",Code = "9200"}
                    
                    },
                    Country = new Country(){Name = "Belgie"},
                    Email = "benoit.goethals@gmail.com",
                    Job = "family",
                    Family = null,
                    //      Telephones = new List<string>(){"056765445","056876756"},
                    Relation = Relation.Cousin,
                    BirthDate = DateTime.Now,
                    NationalNbr = "045674534"
                    
                    
                    
                };
                context.Persons.Add(person);
                }
                context.SaveChanges();


            }
        }
    }
}