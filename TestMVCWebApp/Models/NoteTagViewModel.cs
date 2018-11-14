using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TestMVCWebApp.Models
{
    public class NoteTagViewModel
    {
        public List<Note> Notes; // список заметок
        public SelectList Tag; //лист со списком тэгов 
        public string NoteTag { get; set; }  // содержит выбранный тэг
        public string SearchString { get; set; } // содержит текст который пользователь вводит в поиск
    }
}
