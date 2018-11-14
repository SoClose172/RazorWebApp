using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TestMVCWebApp.Models
{
    public class Note
    {
        public int ID { get; set; }
        public string HeadLine { get; set; }

        //[Display(Name = "Data")]
       // [DataType(DataType.Date)]

        public string Tag { get; set; }
        public DateTime Data { get; set; }
        public int Number { get; set; }
    }
}
