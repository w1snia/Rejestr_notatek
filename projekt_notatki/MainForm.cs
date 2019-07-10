using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt_notatki
{
    public partial class MainForm : Form
    {
        public static List<Note> notes = new List<Note>();

        public static UserControl activeUC;
        public static Panel activeContent;

        
        


        public MainForm()
        {
            InitializeComponent();
            activeContent = content;

            JsonData.getNotesFromJson();

            clearContent();
            createListOfNotes();

        


        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            JsonData.setNotesToJson();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_showNotes_Click(object sender, EventArgs e)
        {
            clearContent();
            createListOfNotes();
        
        }

        public static void clearContent()
        {
            activeContent.Controls.Clear();
            activeUC = new displayNotes();
            activeUC.Width = activeContent.Width;
            activeUC.Dock = DockStyle.Fill;
            activeUC.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right);
            activeContent.Controls.Add(activeUC);
        }

        public static void createListOfNotes()
        {
            int offsetY = 20;
            foreach (Note note in JsonData.allNotes)
            {
                UserControl_showNote showNote = new UserControl_showNote(note);
                showNote.Width = activeUC.Width - 40;
                showNote.Location = new Point(20, offsetY);
                showNote.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right);
                activeUC.Controls.Add(showNote);
                offsetY += 95;
            }
        }

        public static void createListOfHomeNotes()
        {
            int offsetY = 20;
            foreach (Note note in JsonData.allNotes)
            {
                if (note.Category.Equals(Category.Home))
                {
                    UserControl_showNote showNote = new UserControl_showNote(note);
                    showNote.Width = activeUC.Width - 40;
                    showNote.Location = new Point(20, offsetY);
                    showNote.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right);
                    activeUC.Controls.Add(showNote);
                    offsetY += 95;
                }
            }
        }

        public static void createListOfWorkNotes()
        {
            int offsetY = 20;
            foreach (Note note in JsonData.allNotes)
            {

                if (note.Category.Equals(Category.Work))
                {
                    UserControl_showNote showNote = new UserControl_showNote(note);
                    showNote.Width = activeUC.Width - 40;
                    showNote.Location = new Point(20, offsetY);
                    showNote.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right);
                    activeUC.Controls.Add(showNote);
                    offsetY += 95;
                }
            }
        }

        private void content_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearContent();
            createListOfHomeNotes();
        }

        private void button_showWorkNotes_Click(object sender, EventArgs e)
        {
            clearContent();
            createListOfWorkNotes();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label_Date_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString("dddd, dd MMMM");
            string time = DateTime.Now.ToString("HH:mm:ss");
            label_Date.Text = date;
            label_Time.Text = time;

        }

        private void userControl_addNote1_Load(object sender, EventArgs e)
        {

        }
    }
}
