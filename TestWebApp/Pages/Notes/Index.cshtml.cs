using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TestWebApp.Models;

namespace TestWebApp.Pages.Notes
{
    public class IndexModel : PageModel
    {
        private readonly TestWebApp.Models.TestWebAppContext _context;

        public IndexModel(TestWebApp.Models.TestWebAppContext context)
        {
            _context = context;
        }

        public IList<Note> Note { get;set; }
        public string SearchString { get; set; }
        public  ServiceFilterAttribute  Tag { get; set; }
        public string NoteTag { get; set; }

        public async Task OnGetAsync(string searchString)
        {
           var Notes = from m in _context.Note
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                Notes = Notes.Where(s => s.Tag.Contains(searchString)); //search for Note Tag
            }

            Note = await Notes.ToListAsync();
            SearchString = searchString;
           //Note = await _context.Note.ToListAsync();
        }
    }
}
