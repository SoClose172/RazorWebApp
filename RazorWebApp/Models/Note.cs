using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;


namespace RazorWebApp.Models
{
    public class Note
    {
        public int ID { get; set; }
        public string HeadLine { get; set; }
        public string Tag { get; set; }
        public DateTime Data { get; set; }
        public int Number { get; set; }
        public virtual Owner Owner { get; set; }



    }
    public class Owner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Note> Notes { get; set; }
    }
}
