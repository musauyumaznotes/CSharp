using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RouteYapilanmasi3.Constraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RouteYapilanmasi3
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
        {
            services.Configure<RouteOptions>(options => options.ConstraintMap.Add("custom", typeof(CustomConstraint)));
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapControllerRoute("Default3","{controller=Home}/{action=Index}/{id:custom}/{x:alpha:length(12)?}/{y:int?}");
                //endpoints.MapControllerRoute("Default2","anasayfa",new {controller ="Home",action ="Index"});
                //endpoints.MapControllerRoute("Default","{controller=Personel}/musa/{action=Index}");
                //endpoints.MapControllerRoute("Default","{action}/ahmet/{controller}");
                //endpoints.MapControllerRoute("Default","{action}/{controller}");
                //endpoints.MapDefaultControllerRoute();
                endpoints.MapControllers();
            });
        }
    }
}
