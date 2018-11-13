using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorApp.Models
{
    public class Note
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Tag { get; set; }
        public DateTime Date { get; set; }
        public int Number { get; set; }


    }
}
