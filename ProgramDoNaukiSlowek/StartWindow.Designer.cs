namespace ProgramDoNaukiSlowek
{
    partial class StartWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonContinueStudy = new System.Windows.Forms.Button();
            this.buttonStartStudy = new System.Windows.Forms.Button();
            this.comboBoxChoseLanguage = new System.Windows.Forms.ComboBox();
            this.labelChoseLanguage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonContinueStudy
            // 
            this.buttonContinueStudy.Location = new System.Drawing.Point(135, 300);
            this.buttonContinueStudy.Name = "buttonContinueStudy";
            this.buttonContinueStudy.Size = new System.Drawing.Size(386, 91);
            this.buttonContinueStudy.TabIndex = 0;
            this.buttonContinueStudy.Text = "Kontynuuję naukę";
            this.buttonContinueStudy.UseVisualStyleBackColor = true;
            this.buttonContinueStudy.Click += new System.EventHandler(this.buttonContinueStudy_Click);
            // 
            // buttonStartStudy
            // 
            this.buttonStartStudy.Location = new System.Drawing.Point(135, 166);
            this.buttonStartStudy.Name = "buttonStartStudy";
            this.buttonStartStudy.Size = new System.Drawing.Size(386, 91);
            this.buttonStartStudy.TabIndex = 1;
            this.buttonStartStudy.Text = "Zaczynam się uczyć";
            this.buttonStartStudy.UseVisualStyleBackColor = true;
            this.buttonStartStudy.Click += new System.EventHandler(this.buttonStartStudy_Click);
            // 
            // comboBoxChoseLanguage
            // 
            this.comboBoxChoseLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxChoseLanguage.FormattingEnabled = true;
            this.comboBoxChoseLanguage.Items.AddRange(new object[] {
            "Z Polskiego na Angielski",
            "Z Angielskiego na Polski"});
            this.comboBoxChoseLanguage.Location = new System.Drawing.Point(164, 100);
            this.comboBoxChoseLanguage.Name = "comboBoxChoseLanguage";
            this.comboBoxChoseLanguage.Size = new System.Drawing.Size(335, 33);
            this.comboBoxChoseLanguage.TabIndex = 4;
            this.comboBoxChoseLanguage.Text = "Z Polskiego na Angielski";
            this.comboBoxChoseLanguage.SelectedIndexChanged += new System.EventHandler(this.comboBoxChoseLanguage_SelectedIndexChanged);
            // 
            // labelChoseLanguage
            // 
            this.labelChoseLanguage.AutoSize = true;
            this.labelChoseLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelChoseLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelChoseLanguage.Location = new System.Drawing.Point(129, 34);
            this.labelChoseLanguage.Name = "labelChoseLanguage";
            this.labelChoseLanguage.Size = new System.Drawing.Size(430, 33);
            this.labelChoseLanguage.TabIndex = 5;
            this.labelChoseLanguage.Text = "Wybierz z jakiego języka na jaki";
            // 
            // StartWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(641, 403);
            this.Controls.Add(this.labelChoseLanguage);
            this.Controls.Add(this.comboBoxChoseLanguage);
            this.Controls.Add(this.buttonStartStudy);
            this.Controls.Add(this.buttonContinueStudy);
            this.Name = "StartWindow";
            this.Text = "Start Window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonContinueStudy;
        private System.Windows.Forms.Button buttonStartStudy;
        private System.Windows.Forms.ComboBox comboBoxChoseLanguage;
        private System.Windows.Forms.Label labelChoseLanguage;
    }
}

