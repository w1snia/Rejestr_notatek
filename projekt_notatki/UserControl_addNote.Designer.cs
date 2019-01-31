namespace projekt_notatki
{
    partial class UserControl_addNote
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
            this.richTextBox_addContent = new System.Windows.Forms.RichTextBox();
            this.textBox_addTitle = new System.Windows.Forms.TextBox();
            this.label_title = new System.Windows.Forms.Label();
            this.label_content = new System.Windows.Forms.Label();
            this.button_addNote = new System.Windows.Forms.Button();
            this.comboBox_chooseCategory = new System.Windows.Forms.ComboBox();
            this.label_addCategory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox_addContent
            // 
            this.richTextBox_addContent.Location = new System.Drawing.Point(50, 29);
            this.richTextBox_addContent.Name = "richTextBox_addContent";
            this.richTextBox_addContent.Size = new System.Drawing.Size(277, 64);
            this.richTextBox_addContent.TabIndex = 0;
            this.richTextBox_addContent.Text = "";
            // 
            // textBox_addTitle
            // 
            this.textBox_addTitle.Location = new System.Drawing.Point(50, 3);
            this.textBox_addTitle.Name = "textBox_addTitle";
            this.textBox_addTitle.Size = new System.Drawing.Size(123, 20);
            this.textBox_addTitle.TabIndex = 1;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_title.Location = new System.Drawing.Point(0, 4);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(49, 17);
            this.label_title.TabIndex = 2;
            this.label_title.Text = "Tytuł:";
            // 
            // label_content
            // 
            this.label_content.AutoSize = true;
            this.label_content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_content.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_content.Location = new System.Drawing.Point(-5, 46);
            this.label_content.Name = "label_content";
            this.label_content.Size = new System.Drawing.Size(54, 17);
            this.label_content.TabIndex = 3;
            this.label_content.Text = "Treść:";
            // 
            // button_addNote
            // 
            this.button_addNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_addNote.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addNote.Location = new System.Drawing.Point(333, 56);
            this.button_addNote.Name = "button_addNote";
            this.button_addNote.Size = new System.Drawing.Size(121, 37);
            this.button_addNote.TabIndex = 4;
            this.button_addNote.Text = "DODAJ";
            this.button_addNote.UseVisualStyleBackColor = false;
            this.button_addNote.Click += new System.EventHandler(this.button_addNote_Click);
            // 
            // comboBox_chooseCategory
            // 
            this.comboBox_chooseCategory.FormattingEnabled = true;
            this.comboBox_chooseCategory.Items.AddRange(new object[] {
            "Home",
            "Work"});
            this.comboBox_chooseCategory.Location = new System.Drawing.Point(333, 29);
            this.comboBox_chooseCategory.Name = "comboBox_chooseCategory";
            this.comboBox_chooseCategory.Size = new System.Drawing.Size(121, 21);
            this.comboBox_chooseCategory.TabIndex = 5;
            this.comboBox_chooseCategory.SelectedIndexChanged += new System.EventHandler(this.comboBox_chooseCategory_SelectedIndexChanged);
            // 
            // label_addCategory
            // 
            this.label_addCategory.AutoSize = true;
            this.label_addCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_addCategory.Location = new System.Drawing.Point(351, 9);
            this.label_addCategory.Name = "label_addCategory";
            this.label_addCategory.Size = new System.Drawing.Size(83, 17);
            this.label_addCategory.TabIndex = 6;
            this.label_addCategory.Text = "Kategoria:";
            this.label_addCategory.Click += new System.EventHandler(this.label1_Click);
            // 
            // UserControl_addNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_addCategory);
            this.Controls.Add(this.comboBox_chooseCategory);
            this.Controls.Add(this.button_addNote);
            this.Controls.Add(this.label_content);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.textBox_addTitle);
            this.Controls.Add(this.richTextBox_addContent);
            this.Name = "UserControl_addNote";
            this.Size = new System.Drawing.Size(459, 100);
            this.Load += new System.EventHandler(this.UserControl_addNote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_addContent;
        private System.Windows.Forms.TextBox textBox_addTitle;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_content;
        private System.Windows.Forms.Button button_addNote;
        private System.Windows.Forms.ComboBox comboBox_chooseCategory;
        private System.Windows.Forms.Label label_addCategory;
    }
}
