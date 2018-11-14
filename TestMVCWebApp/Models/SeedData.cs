using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace TestMVCWebApp.Models
{
    public class SeedData
    {
        public static void Initialize (IServiceProvider serviceProvider)
        {
            using (var context = new TestMVCWebAppContext(
                serviceProvider.GetRequiredService<DbContextOptions<TestMVCWebAppContext>>()))
            {
                //Если уже есть заметки то новые не добавляются
                if (context.Note.Any())
                {
                    return;  //DB has been seeded
                }
                context.Note.AddRange(
                    new Note
                    {
                        HeadLine = "FirstNote",
                        Tag = "First",
                        Data = DateTime.Parse("1989-1-11"),
                        Number = 1
                    },
                    new Note
                    {
                        HeadLine = "SecondNote",
                        Tag = "Second",
                        Data = DateTime.Parse("1989-1-11"),
                        Number = 2
                    },
                    new Note
                    {
                        HeadLine = "ThirdNote",
                        Tag = "Third",
                        Data = DateTime.Parse("1989-1-11"),
                        Number = 3
                    }

                    );
                context.SaveChanges();
            }
        }
    }
}
