using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace RazorApp.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorAppContext(
                serviceProvider.GetRequiredService<DbContextOptions<RazorAppContext>>()))
            {
                // Look for any movies.
                if (context.Note.Any())
                {
                    return;   // DB has been seeded
                }

                context.Note.AddRange(
                    new Note
          
                    {
                        Name = "When Harry Met Sally",
                        Date = DateTime.Parse("1989-2-12"),
                        Tag  = "Romantic Comedy",
                        Number  = 7
                    },

                    new Note
                    {
                        Name = "Ghostbusters ",
                        Date = DateTime.Parse("1984-3-13"),
                        Tag = "Comedy",
                        Number = 8
                    }

                    
                    
                );
                context.SaveChanges();
            }
        }
    }
}
