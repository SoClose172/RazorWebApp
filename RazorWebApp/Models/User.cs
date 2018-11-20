using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace RazorWebApp.Models
{
    public class User : IdentityUser
    {
        public virtual List<Note> Notes { get; set; }//Mifort: Связь с заметками
    }
}