using Garage2._0_Group5.Data;
using Microsoft.EntityFrameworkCore;

namespace Garage2._0_Group5.Extensions
{
    public static class WebAppExtensions
    {

        public static async Task SeedDataAsync(this IApplicationBuilder app)
        {
            using (var scope = app.ApplicationServices.CreateScope())
            {
                var serviceProvider = scope.ServiceProvider;
                var db = serviceProvider.GetRequiredService<Garage2_0_Group5Context>();

                await db.Database.EnsureDeletedAsync();
                await db.Database.MigrateAsync();

                try
                {
                    await SeedData.InitAsync(db);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    throw;
                }
            }
        }
    }
}
