using System.Reflection;
using Microsoft.EntityFrameworkCore;
using TrackerServer.model;

namespace TrackerServer.DAL
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        { }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Subject> Subjects{ get; set; }
        public DbSet<PublicEvent> PublicEvents { get; set; }
        public DbSet<Country> Countries { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            //  optionsBuilder.UseMySql("Server=192.168.0.160; Database=Tracker;User=benoit;Password=password;",      
            //    mysqlOptions =>      
            //      mysqlOptions.ServerVersion(new ServerVersion(new Version(5, 5, 57), ServerType.MariaDb))); 
            
            
            
        }
              
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        
        
    }
}