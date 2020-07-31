using System;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using TrackerServer.DAL;
using TrackerServer.model;

namespace TestProjectTracker
{
    public class TestContext:DbContext
    {
        public TestContext(DbContextOptions<TestContext> options)
            : base(options)
        { }

     

        public DbSet<Person> Persons { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Subject> Subjects{ get; set; }
        public DbSet<PublicEvent> PublicEvents { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<ZipCode> ZipCodes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
           
            
            
        }
              
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TrackerServer.DAL.ZipcodeConfiguration).Assembly);
        }
    }
}