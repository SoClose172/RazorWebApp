using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestWebApp.Models;

namespace TestWebApp.Models
{
    public class TestWebAppContext : DbContext
    {
        public TestWebAppContext (DbContextOptions<TestWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<TestWebApp.Models.Note> Note { get; set; }
        //public DbSet<Notes> notes { get; set; }
    }
}
