namespace projekt_notatki
{
    partial class UserControl_showNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_showNote));
            this.label_showTitle = new System.Windows.Forms.Label();
            this.label_showContent = new System.Windows.Forms.Label();
            this.label_showCategory = new System.Windows.Forms.Label();
            this.label_Date = new System.Windows.Forms.Label();
            this.button_deleteNote = new System.Windows.Forms.Button();
            this.button_editNote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_showTitle
            // 
            this.label_showTitle.AutoSize = true;
            this.label_showTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_showTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_showTitle.Location = new System.Drawing.Point(3, 4);
            this.label_showTitle.Name = "label_showTitle";
            this.label_showTitle.Size = new System.Drawing.Size(55, 22);
            this.label_showTitle.TabIndex = 0;
            this.label_showTitle.Text = "Tytuł";
            this.label_showTitle.Click += new System.EventHandler(this.label_showTitle_Click);
            // 
            // label_showContent
            // 
            this.label_showContent.AutoSize = true;
            this.label_showContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_showContent.Location = new System.Drawing.Point(13, 26);
            this.label_showContent.Name = "label_showContent";
            this.label_showContent.Size = new System.Drawing.Size(37, 15);
            this.label_showContent.TabIndex = 1;
            this.label_showContent.Text = "Treść";
            this.label_showContent.Click += new System.EventHandler(this.label_showContent_Click);
            // 
            // label_showCategory
            // 
            this.label_showCategory.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_showCategory.AutoSize = true;
            this.label_showCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_showCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_showCategory.Location = new System.Drawing.Point(648, 9);
            this.label_showCategory.Name = "label_showCategory";
            this.label_showCategory.Size = new System.Drawing.Size(61, 13);
            this.label_showCategory.TabIndex = 2;
            this.label_showCategory.Text = "Kategoria";
            this.label_showCategory.Click += new System.EventHandler(this.label_showCategory_Click);
            // 
            // label_Date
            // 
            this.label_Date.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_Date.AutoSize = true;
            this.label_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_Date.Location = new System.Drawing.Point(641, 22);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(32, 13);
            this.label_Date.TabIndex = 3;
            this.label_Date.Text = "data";
            this.label_Date.Click += new System.EventHandler(this.label_Date_Click);
            // 
            // button_deleteNote
            // 
            this.button_deleteNote.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_deleteNote.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_deleteNote.BackgroundImage")));
            this.button_deleteNote.Location = new System.Drawing.Point(643, 43);
            this.button_deleteNote.Name = "button_deleteNote";
            this.button_deleteNote.Size = new System.Drawing.Size(30, 30);
            this.button_deleteNote.TabIndex = 4;
            this.button_deleteNote.UseVisualStyleBackColor = true;
            this.button_deleteNote.Click += new System.EventHandler(this.button_deleteNote_Click);
            // 
            // button_editNote
            // 
            this.button_editNote.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_editNote.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_editNote.BackgroundImage")));
            this.button_editNote.Location = new System.Drawing.Point(679, 43);
            this.button_editNote.Name = "button_editNote";
            this.button_editNote.Size = new System.Drawing.Size(30, 30);
            this.button_editNote.TabIndex = 5;
            this.button_editNote.UseVisualStyleBackColor = true;
            this.button_editNote.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserControl_showNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.button_editNote);
            this.Controls.Add(this.button_deleteNote);
            this.Controls.Add(this.label_Date);
            this.Controls.Add(this.label_showCategory);
            this.Controls.Add(this.label_showContent);
            this.Controls.Add(this.label_showTitle);
            this.Name = "UserControl_showNote";
            this.Size = new System.Drawing.Size(712, 90);
            this.Load += new System.EventHandler(this.UserControl_showNote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_showTitle;
        private System.Windows.Forms.Label label_showContent;
        private System.Windows.Forms.Label label_showCategory;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.Button button_deleteNote;
        private System.Windows.Forms.Button button_editNote;
    }
}
