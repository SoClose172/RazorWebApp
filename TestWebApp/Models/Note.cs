using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestWebApp.Models
{
    public class Note
    {
        public int ID { get; set; }
        public string HeadLine { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Tag { get; set; }
        public int Number { get; set; }
    }
}


