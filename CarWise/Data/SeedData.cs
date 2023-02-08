using Microsoft.EntityFrameworkCore;
using CarWise.Models;
using System;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace CarWise.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AppDbContext( serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>()))
            {
                context.Database.EnsureCreated();

                if(context.Users.Any())
                {
                    return; // dane już zostały dodane do bazy danych
                }

                var user = new Users()
                {
                    Username = "Michał",
                    Password = "Brózda",
                };

                context.Users.Add(user);
                context.SaveChanges();

                /* do uzupełnienia */
            }
        } 
    
    }
}
