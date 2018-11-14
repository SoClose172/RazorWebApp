using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TestMVCWebApp.Models
{
    public class TestMVCWebAppContext : DbContext
    {
        public TestMVCWebAppContext (DbContextOptions<TestMVCWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<TestMVCWebApp.Models.Note> Note { get; set; }
    }
}
