namespace projekt_notatki
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button_showNotes = new System.Windows.Forms.Button();
            this.content = new System.Windows.Forms.Panel();
            this.button_showHomeNotes = new System.Windows.Forms.Button();
            this.button_showWorkNotes = new System.Windows.Forms.Button();
            this.label_Date = new System.Windows.Forms.Label();
            this.label_Time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.userControl_addNote1 = new projekt_notatki.UserControl_addNote();
            this.SuspendLayout();
            // 
            // button_showNotes
            // 
            this.button_showNotes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.button_showNotes, "button_showNotes");
            this.button_showNotes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_showNotes.Name = "button_showNotes";
            this.button_showNotes.UseVisualStyleBackColor = false;
            this.button_showNotes.Click += new System.EventHandler(this.button_showNotes_Click);
            // 
            // content
            // 
            resources.ApplyResources(this.content, "content");
            this.content.BackColor = System.Drawing.SystemColors.ControlLight;
            this.content.Name = "content";
            this.content.Paint += new System.Windows.Forms.PaintEventHandler(this.content_Paint);
            // 
            // button_showHomeNotes
            // 
            this.button_showHomeNotes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.button_showHomeNotes, "button_showHomeNotes");
            this.button_showHomeNotes.Name = "button_showHomeNotes";
            this.button_showHomeNotes.UseVisualStyleBackColor = false;
            this.button_showHomeNotes.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_showWorkNotes
            // 
            this.button_showWorkNotes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.button_showWorkNotes, "button_showWorkNotes");
            this.button_showWorkNotes.Name = "button_showWorkNotes";
            this.button_showWorkNotes.UseVisualStyleBackColor = false;
            this.button_showWorkNotes.Click += new System.EventHandler(this.button_showWorkNotes_Click);
            // 
            // label_Date
            // 
            resources.ApplyResources(this.label_Date, "label_Date");
            this.label_Date.Name = "label_Date";
            this.label_Date.Click += new System.EventHandler(this.label_Date_Click);
            // 
            // label_Time
            // 
            resources.ApplyResources(this.label_Time, "label_Time");
            this.label_Time.Name = "label_Time";
            this.label_Time.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // userControl_addNote1
            // 
            resources.ApplyResources(this.userControl_addNote1, "userControl_addNote1");
            this.userControl_addNote1.Name = "userControl_addNote1";
            this.userControl_addNote1.Load += new System.EventHandler(this.userControl_addNote1_Load);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.label_Time);
            this.Controls.Add(this.label_Date);
            this.Controls.Add(this.button_showWorkNotes);
            this.Controls.Add(this.button_showHomeNotes);
            this.Controls.Add(this.content);
            this.Controls.Add(this.button_showNotes);
            this.Controls.Add(this.userControl_addNote1);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControl_addNote userControl_addNote1;
        private System.Windows.Forms.Button button_showNotes;
        private System.Windows.Forms.Panel content;
        private System.Windows.Forms.Button button_showHomeNotes;
        private System.Windows.Forms.Button button_showWorkNotes;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.Label label_Time;
        private System.Windows.Forms.Timer timer1;
    }
}

