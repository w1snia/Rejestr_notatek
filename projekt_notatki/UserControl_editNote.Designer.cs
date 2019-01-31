namespace projekt_notatki
{
    partial class UserControl_editNote
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_editTitle = new System.Windows.Forms.TextBox();
            this.richTextBox_editContent = new System.Windows.Forms.RichTextBox();
            this.comboBox_editCategory = new System.Windows.Forms.ComboBox();
            this.button_editNote = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_editTitle
            // 
            this.textBox_editTitle.Location = new System.Drawing.Point(93, 32);
            this.textBox_editTitle.Name = "textBox_editTitle";
            this.textBox_editTitle.Size = new System.Drawing.Size(100, 20);
            this.textBox_editTitle.TabIndex = 0;
            this.textBox_editTitle.TextChanged += new System.EventHandler(this.textBox_editTitle_TextChanged);
            // 
            // richTextBox_editContent
            // 
            this.richTextBox_editContent.Location = new System.Drawing.Point(94, 58);
            this.richTextBox_editContent.Name = "richTextBox_editContent";
            this.richTextBox_editContent.Size = new System.Drawing.Size(100, 60);
            this.richTextBox_editContent.TabIndex = 1;
            this.richTextBox_editContent.Text = "";
            this.richTextBox_editContent.TextChanged += new System.EventHandler(this.richTextBox_editContent_TextChanged);
            // 
            // comboBox_editCategory
            // 
            this.comboBox_editCategory.FormattingEnabled = true;
            this.comboBox_editCategory.Items.AddRange(new object[] {
            "Home",
            "Work"});
            this.comboBox_editCategory.Location = new System.Drawing.Point(208, 32);
            this.comboBox_editCategory.Name = "comboBox_editCategory";
            this.comboBox_editCategory.Size = new System.Drawing.Size(86, 21);
            this.comboBox_editCategory.TabIndex = 2;
            this.comboBox_editCategory.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button_editNote
            // 
            this.button_editNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_editNote.Location = new System.Drawing.Point(208, 58);
            this.button_editNote.Name = "button_editNote";
            this.button_editNote.Size = new System.Drawing.Size(86, 59);
            this.button_editNote.TabIndex = 3;
            this.button_editNote.Text = "EDYTUJ";
            this.button_editNote.UseVisualStyleBackColor = false;
            this.button_editNote.Click += new System.EventHandler(this.button_editNote_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Edytuj tytuł: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(3, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Edytuj treść:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(199, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Edytuj kategorie:";
            // 
            // UserControl_editNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_editNote);
            this.Controls.Add(this.comboBox_editCategory);
            this.Controls.Add(this.richTextBox_editContent);
            this.Controls.Add(this.textBox_editTitle);
            this.Name = "UserControl_editNote";
            this.Size = new System.Drawing.Size(320, 134);
            this.Load += new System.EventHandler(this.UserControl_editNote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_editTitle;
        private System.Windows.Forms.RichTextBox richTextBox_editContent;
        private System.Windows.Forms.ComboBox comboBox_editCategory;
        private System.Windows.Forms.Button button_editNote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
