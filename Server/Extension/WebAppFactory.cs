using System;
using System.Linq;
using Infrastructure.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BugTracker.Server.Extension
{
    public class WebAppFactory<T> : WebApplicationFactory<Startup>
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureServices(collection =>
            {
                var description = collection.SingleOrDefault(
                    d => d.ServiceType == typeof(DbContextOptions<ApplicationDbContext>)
                );

                if (description != null)
                    collection.Remove(description);

                var serviceProvider = new ServiceCollection()
                    .AddEntityFrameworkInMemoryDatabase()
                    .BuildServiceProvider();

                collection.AddDbContext<ApplicationDbContext>(options =>
                {
                    options.UseInMemoryDatabase("InMemory");
                    options.UseInternalServiceProvider(serviceProvider);
                });
                var sp = collection.BuildServiceProvider();
                using (var scope = sp.CreateScope())
                {
                    using (var appContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>())
                    {
                        try
                        {
                            appContext.Database.EnsureCreated();
                        }
                        catch (Exception ex)
                        {
                            //Log errors or do anything you think it's needed
                            throw;
                        }
                    }
                }
            });
        }
    }
}
