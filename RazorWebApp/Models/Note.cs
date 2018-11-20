using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorWebApp.Models
{
    public class Note
    {
        public int ID { get; set; }
        public string HeadLine { get; set; }
        public string Tag { get; set; }
        public DateTime Data { get; set; }
        public int Number { get; set; }


        public virtual User User { get; set; } //Mifort: Связь с юзером
    }
}