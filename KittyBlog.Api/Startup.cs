using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Configuration;
using KittyBlog.DAL;
using Microsoft.EntityFrameworkCore; //EF
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;

namespace KittyBlog.Api
{
    public class Startup
    {
        //public Startup(IConfiguration configuration)
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            Configuration = builder.Build();
            //Configuration = configuration;
        }

        public IConfiguration Configuration { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var sqlConnectionString = Configuration.GetConnectionString("KittyBlogSqliteDatabase");
            services.AddDbContext<PostContext>(options =>
                options.UseSqlite(
                    sqlConnectionString,
                    b => b.MigrationsAssembly("AspNetCoreMultipleProject")
                )

                //options.UseSqlite(sqlConnectionString)
            );
            services.AddScoped<IDAL.IPostProvider, DAL.PostProvider>();
            //services.AddMvc();
            services.AddMvc().AddJsonOptions(options =>
            {
                options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            }).SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
        //public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        //{
        //    loggerFactory.AddConsole();
        //    loggerFactory.AddDebug();

        //    app.UseStaticFiles();

        //    app.UseMvc();
        //}
    }
}
