using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Pomelo.EntityFrameworkCore.MySql.Storage;
using Microsoft.Extensions.Logging;
using TrackerServer.DAL;
using TrackerServer.Repositorys;

namespace TrackerServer
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {  services.AddDbContext<ApplicationContext>(options => options      
                         .UseMySql("Server=192.168.0.160; Database=Tracker;User=benoit;Password=password;",      
                             mysqlOptions =>      
                                 mysqlOptions.ServerVersion(new ServerVersion(new Version(5, 5, 57), ServerType.MariaDb)))); 
            services.AddLogging(opt =>
            {
                opt.AddConsole();
            });
            services.AddScoped<IRepository,SubjectRepository>();
            services.AddScoped<IZipcodeRepository,ZipcodeRepository>();
            services.AddControllers();
          
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}