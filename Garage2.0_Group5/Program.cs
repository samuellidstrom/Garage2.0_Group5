using Microsoft.EntityFrameworkCore;
using Garage2._0_Group5.Data;
using jsreport.AspNetCore;
using jsreport.Local;
using jsreport.Binary;
using Garage2._0_Group5.Extensions;
using Garage2._0_Group5.AutomapperConfig;

namespace Garage2._0_Group5
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddAutoMapper(typeof(GarageMappings));

            // Add service for the print function
            builder.Services.AddJsReport(new LocalReporting()
            .UseBinary(JsReportBinary.GetBinary())
            .AsUtility()
            .Create());

            builder.Services.AddDbContext<Garage2_0_Group5Context>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("Garage2_0_Group5Context") ?? throw new InvalidOperationException("Connection string 'Garage2_0_Group5Context' not found.")));

            var app = builder.Build();



            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            else
            {
                await app.SeedDataAsync();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Members}/{action=Index}/{id?}");

            app.Run();
        }
    }
}