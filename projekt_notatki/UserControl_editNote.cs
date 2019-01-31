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
    public partial class UserControl_editNote : UserControl
    {
        Note note;
        string title;
        string content;
        DateTime date;
        string category;

        public UserControl_editNote(Note note)
        {
            InitializeComponent();

            this.note = note;

            string category = note.Category.ToString();
            textBox_editTitle.Text = note.Title;
            richTextBox_editContent.Text = note.Content;
            comboBox_editCategory.Text = category;

        }

        private void textBox_editTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox_editContent_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UserControl_editNote_Load(object sender, EventArgs e)
        {

        }

        private void button_editNote_Click(object sender, EventArgs e)
        {


            JsonData.allNotes.Remove(JsonData.allNotes.Find(t => t.Id.Contains(note.Id)));


            title = textBox_editTitle.Text;
            content = richTextBox_editContent.Text;
            category = comboBox_editCategory.Text;
            date = DateTime.Now;

            

            if (textBox_editTitle.Text == "" || richTextBox_editContent.Text == "" || comboBox_editCategory.Text == "")
            {
                MessageBox.Show("Podaj poprawne dane!");
            }
            else
            {
                MessageBox.Show("Notatka edytowana!");

                if (category == "Home")
                {
                    note = new Note(title, content, Category.Home, date);
                    // JsonData.homeNotes.Add(note);
                    JsonData.allNotes.Add(note);
                    MainForm.clearContent();
                    MainForm.createListOfNotes();
                }

                if (category == "Work")
                    {
                note = new Note(title, content, Category.Work, date);
                // JsonData.workNotes.Add(note);
                JsonData.allNotes.Add(note);
                MainForm.clearContent();
                MainForm.createListOfNotes();
                    }
                Parent.Hide();
         }
        }
    }
}
