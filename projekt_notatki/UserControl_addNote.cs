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
    public partial class UserControl_addNote : UserControl
    {

        Note note;
        string title;
        string content;
        DateTime date;
        string category;

        public UserControl_addNote()
        {
            InitializeComponent();
        }

        public UserControl_addNote(Note note)
        {
            InitializeComponent();



        }

        private void comboBox_chooseCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UserControl_addNote_Load(object sender, EventArgs e)
        {

        }

        private void button_addNote_Click(object sender, EventArgs e)
        {

            if (textBox_addTitle.Text == "" || richTextBox_addContent.Text == "" || comboBox_chooseCategory.Text == "")
            {
                MessageBox.Show("Podaj poprawne dane!","Błąd");
            }
            else
            {
                MessageBox.Show("Dodano nową notatkę!","Nowa notatka");


                title = textBox_addTitle.Text;
                content = richTextBox_addContent.Text;
                category = comboBox_chooseCategory.Text;
                date = DateTime.Now;

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

                textBox_addTitle.Text = null;
                richTextBox_addContent.Text = null;
                comboBox_chooseCategory.Text = null;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
