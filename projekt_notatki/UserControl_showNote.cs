using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt_notatki
{
    public partial class UserControl_showNote : UserControl
    {

        Note note;        
        //int day;
       // int month;
       // int year;


    
        public UserControl_showNote()
        {
            InitializeComponent();
        }
      


        public UserControl_showNote(Note note)
        {
            InitializeComponent();

            this.note = note;

            //String data = this.note.Date;
            //day = data.Days;
            // month = data.Month;
            //year = data.Year;

           string day = Convert.ToString(note.Date.Day);
           string month = Convert.ToString(note.Date.Month);
           string year = Convert.ToString(note.Date.Year);

            string kategoria = Convert.ToString(note.Category);

            

            label_showTitle.Text = note.Title;
            label_showContent.Text = note.Content;
            label_showCategory.Text = kategoria;
            label_Date.Text = day +"."+ month +"."+ year;
           
            //label_showCategory.Text = note.Category;

        }

        private void UserControl_showNote_Load(object sender, EventArgs e)
        {

        }

        private void label_showCategory_Click(object sender, EventArgs e)
        {

        }

        private void button_deleteNote_Click(object sender, EventArgs e)
        {
           
            JsonData.allNotes.Remove(note);
            MainForm.clearContent();
            MainForm.createListOfNotes();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            edit();
        }

        private void edit()
        {
            EditForm editForm = new EditForm();
            UserControl_editNote editNote = new UserControl_editNote(note);
            editNote.Width = editForm.Width;
            editNote.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right);
            editForm.Controls.Add(editNote);
            editForm.Show();
        }

        private void label_Date_Click(object sender, EventArgs e)
        {

        }

        private void label_showContent_Click(object sender, EventArgs e)
        {

        }

        private void label_showTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
