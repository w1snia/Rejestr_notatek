using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace projekt_notatki
{
    public enum Category
    {
        Home,
        Work
    }

    public class NoteCategory
    {
        Category category;

        public Category Category { get => category; set => category = value; }
    }
}
