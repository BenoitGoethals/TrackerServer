using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Pomelo.EntityFrameworkCore.MySql.Storage;
using TrackerServer.model;
using Xunit;

namespace TestProjectTracker
{
    
    public class SubjectTest
    {
        private  readonly DbContextOptionsBuilder<TestContext>  optionsBuilder = new DbContextOptionsBuilder<TestContext>();
        public SubjectTest()
        {
            optionsBuilder .UseMySql("Server=192.168.0.160; Database=TrackerTest;User=benoit;Password=password;",      
                mysqlOptions =>      
                    mysqlOptions.ServerVersion(new ServerVersion(new Version(5, 5, 57), ServerType.MariaDb)));

        }

        [Fact]
        public void SaveSubject()
        {
            Person person = new Person()
            {
                Name = "Goethals",
                ForName = "benoit",
                Address = new Address()
                {
                    City = "Gent",
                    Country = new Country() {Name = "France"},
                    Nr = "13",
                    Street = "noor",
                    ZipCode = new ZipCode(){City = "dendermonde",Code = "9200"}

                },
                Country = new Country() {Name = "Belgie"},
                Email = "benoit.goethals@gmail.com",
                Job = "family",
                Family = null,
                //      Telephones = new List<string>(){"056765445","056876756"},
                Relation = Relation.Cousin,
                BirthDate = DateTime.Now,
                NationalNbr = "045674534"
            };

            Subject subject = new Subject()
            {
                DossierNr = "Dossier",
                Person = person,
                Symtoms = new Symptoms() {Fatigue = true},
                CoronaTest = DateTime.Now,
                CoronatTstPositive = true,
                ExtraInformation = "test",
                FirstSigns = DateTime.Now,
                StatusSubject = StatusSubject.Quaritaine,
                PublicEvents = new List<PublicEvent>()
                {
                    new PublicEvent()
                    {
                        Description = "feest",
                        Peoples = 59,
                        NameEvent = "testfeest",
                        TypeEvent = TypeEvent.Party,
                        DateTimeEvent = DateTime.Now,
                        KnownPerson = new List<Person>()
                        {
                            new Person()
                            {
                                Name = "Goethals",
                                ForName = "liv",
                                Address = new Address()
                                {
                                    City = "Gent",
                                    Country = new Country() {Name = "France"},
                                    Nr = "13",
                                    Street = "noor",
                                    ZipCode = new ZipCode(){City = "dendermonde",Code = "9200"}

                                },
                                Country = new Country() {Name = "Belgie"},
                                Email = "benoit.goethals@gmail.com",
                                Job = "family",
                                Family = null,
                                //       Telephones = new List<string>(){"056765445","056876756"},
                                Relation = Relation.Father,
                                BirthDate = DateTime.Now,
                                NationalNbr = "045674534"
                            }

                        },
                        PossibleGroundZeroBySubject = false
                    }
                }
            };
            using (var context = new TestContext(optionsBuilder.Options))
            {
                
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                context.Subjects.Add(subject);
                context.SaveChanges();
                
                
            }
        }




    }
}