using System;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Pomelo.EntityFrameworkCore.MySql.Storage;
using TrackerServer.DAL;
using Xunit;

namespace TestProjectTracker
{
    public class ZipCodeTest
    {
        private  readonly DbContextOptionsBuilder<TestContext>  optionsBuilder = new DbContextOptionsBuilder<TestContext>();
        public ZipCodeTest()
        {
            optionsBuilder .UseMySql("Server=192.168.0.160; Database=TrackerTest;User=benoit;Password=password;",      
                mysqlOptions =>      
                    mysqlOptions.ServerVersion(new ServerVersion(new Version(5, 5, 57), ServerType.MariaDb)));

        }

        [Fact]
        public void LoadZipCode()
        {
            

            using (var context = new TestContext( optionsBuilder.Options) )
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                
                Assert.True( context.ZipCodes.Count()>10);
               
             
            }
    
          
        }
        
        [Fact]
        public void GetByCodeZipCode()
        {
            using (var context = new TestContext( optionsBuilder.Options) )
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                
                Assert.Contains("DENDERMONDE", context.ZipCodes.FirstOrDefault(b => b.Code.Equals("9200")).City);
               
             
            }
        }
        
       
    }
}