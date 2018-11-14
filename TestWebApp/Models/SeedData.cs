using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace TestWebApp.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new TestWebAppContext(
                serviceProvider.GetRequiredService<DbContextOptions<TestWebAppContext>>()))
            {
                // Look for any movies.
                if (context.Note.Any())
                {
                    return;   // DB has been seeded
                }

                context.Note.AddRange(

                    new Note
                    {
                        HeadLine = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Tag = "Romantic Comedy",
                        Number = 1
                    },
                    new Note
                    {
                        HeadLine = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Tag = "Romantic Comedy",
                        Number = 2
                    },
                    new Note
                    {
                        HeadLine = " Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Tag = " Comedy",
                        Number = 3
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}








