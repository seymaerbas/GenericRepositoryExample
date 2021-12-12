
using GenericRepositoryExampla.Api.Helpers;
using GenericRepositoryExampla.Entities.Repositories;
using GenericRepositoryExample.Business.Abstract;
using GenericRepositoryExample.Business.Concrete;
using GenericRepositoryExample.DataAccsess;
using GenericRepositoryExample.DataAccsess.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryExampla.Api
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


            services.AddSwaggerDocument();
            services.AddControllers();
            services.AddTransient < GenericHelperMethods>() ;
            services.AddScoped<IUnitOfWork, UnitOfWork>(); //ayný olan her request için ayný sonucu oluþtururum
            services.AddTransient<IUserServices, UserServices>();
            services.AddTransient<IProfileServices, ProfileService>();
            services.AddTransient<IContentServices, ContentServices>();
            services.AddTransient<ICategoryServices, CategoryServices>();
            services.AddDbContext<GenericDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddDefaultIdentity<IdentityUser>().AddRoles<IdentityRole>().AddEntityFrameworkStores<GenericDbContext>();
            services.AddControllers();
            //services.AddTransient //her talebi farký algýlar yeni sonuç oluþtururu
            //services.AddSingleton    //request ne olursa olsun ayný sonuç oluþtur
            services.AddMvc().AddRazorPagesOptions(opt=>opt.Conventions.AddPageRoute("/UserLogin",""));
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(opt => opt.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateAudience = true,//Token deðerini kimlerin-hangi uygulamalarýn kullanýcýðýný belirler
                ValidateIssuer = true,//oluþturulan token deðerini kim daðýtmýþtýr
                ValidateLifetime = true,//Oluþturulan token deðerinin yaþam süresi
                ValidateIssuerSigningKey = true, //Üretilen token deðerinin uygulamamýza ait olup olmadýðý ile alakalý security key'i
                ValidIssuer = Configuration["Token:Issuer"], //
                ValidAudience = Configuration["Token:Audince"],
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Token:Securitykey"])),
                ClockSkew = TimeSpan.Zero //Token süresinin uzatýlmasýný saðlar
            });
            services.AddRazorPages();
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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            //    app.UseHttpsRedirection();
            //    //app.UseStaticFiles(new StaticFileOptions
            //    //{
            //    //    FileProvider = new PhysicalFileProvider(
            //    //         Path.Combine(env.ContentRootPath, "Pages")),
            //    //    RequestPath = "/Pages"
            //    //});
            
            //    app.UseRouting();
            app.UseOpenApi();
            app.UseSwaggerUi3();
            //    app.UseAuthorization();
            //    app.UseEndpoints(endpoints =>
            //    {
            //        endpoints.MapControllers();
            //        endpoints.MapRazorPages();
            //    });
            //}
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            //app.UseStaticFiles(new StaticFileOptions
            //{
            //    FileProvider = new PhysicalFileProvider(
            //    Path.Combine(env.ContentRootPath, "Pages")),
            //    RequestPath = "/Pages"
            //});
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapRazorPages();
            });
        }
    }
}
