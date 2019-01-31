using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_notatki
{
    public class Note : NoteCategory
    {
        string id;
        string title;
        string content;
        DateTime date;
        //private string category;

        public Note(string title, string content, Category category, DateTime date)
        {
            Id = Guid.NewGuid().ToString();
            Category = category;
            Title = title;
            Content = content;
            Date = date;
        }

        public string Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string Content { get => content; set => content = value; }
        public DateTime Date { get => date; set => date = value; }
    }
}
