using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV5
{
    class Notebook
    {
        private List<Note> notes;
        ITheme defaultTheme;
        public Notebook(ITheme theme)
        { 
            this.defaultTheme = theme;
            this.notes = new List<Note>();
        }
        public void AddNote(Note note) { 
            note.Theme= defaultTheme;
            this.notes.Add(note); 
        }
        public void ChangeTheme(ITheme theme)
        {
            foreach (Note note in this.notes)
            {
                note.Theme = theme;
            }
        }
        public void Display()
        {
            foreach (Note note in this.notes)
            {
                note.Show();
                Console.WriteLine("\n");
            }
        }
    }
}
