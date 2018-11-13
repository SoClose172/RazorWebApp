using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RazorApp.Models
{
    public class RazorAppContext : DbContext
    {
        public RazorAppContext (DbContextOptions<RazorAppContext> options)
            : base(options)
        {
        }

        public DbSet<RazorApp.Models.Note> Note { get; set; }
    }
}
