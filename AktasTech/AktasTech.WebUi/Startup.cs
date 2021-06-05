using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using AktasTech.Business.Abstract;
using AktasTech.Business.Concrete;
using AktasTech.DataAccess.Abstract;
using AktasTech.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AktasTech.WebUi.Services.Abstract;
using AktasTech.WebUi.Services.Concrete;
using AktasTech.WebUi.Models;

namespace AktasTech.WebUi
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddMvc();
            services.AddSession();
            services.AddScoped<IUrunlerService, UrunlerManager>();
            services.AddScoped<IUrunlerDAL, EfUrunlerDAL>();
            services.AddScoped<IKategoriService, KategorilerManager>();
            services.AddScoped<IKategorilerDAL, EfKategorilerDal>();
            services.AddSingleton<ISepetSessionService, SepetSessionService>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddScoped<ISepetService, SepetService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseHttpsRedirection();
            app.UseSession();
            app.UseStaticFiles();
            app.UseFileServer();
            //app.UseNodeModules(env.ContentRootPath);
            app.UseRouting();
            

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Urunler}/{action=Urun}/{id?}");
            });
        }
    }
}
