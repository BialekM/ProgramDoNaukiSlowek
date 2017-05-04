using System.Windows.Forms;

namespace ProgramDoNaukiSlowek
{
    partial class SingleWord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SingleWord));
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.buttonCorrectAnswer = new System.Windows.Forms.Button();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.buttonNextWord = new System.Windows.Forms.Button();
            this.textBoxWord = new System.Windows.Forms.TextBox();
            this.labelGoodBad = new System.Windows.Forms.Label();
            this.labelNumberOfRepeat = new System.Windows.Forms.Label();
            this.labelNumberOfRepeatValue = new System.Windows.Forms.Label();
            this.SaveToFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxAnswer
            // 
            resources.ApplyResources(this.textBoxAnswer, "textBoxAnswer");
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.UseSystemPasswordChar = true;
            //this.textBoxAnswer.KeyPress += new System.Windows.Forms.KeyEventHandler(this.CheckKeys);
            this.textBoxAnswer.KeyDown += new KeyEventHandler(this.TextBoxAnswer_KeyDown);
            // 
            // buttonCorrectAnswer
            // 
            resources.ApplyResources(this.buttonCorrectAnswer, "buttonCorrectAnswer");
            this.buttonCorrectAnswer.Name = "buttonCorrectAnswer";
            this.buttonCorrectAnswer.UseVisualStyleBackColor = true;
            this.buttonCorrectAnswer.Click += new System.EventHandler(this.buttonCorrectAnswer_Click);
            // 
            // buttonCheck
            // 
            resources.ApplyResources(this.buttonCheck, "buttonCheck");
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // buttonNextWord
            // 
            resources.ApplyResources(this.buttonNextWord, "buttonNextWord");
            this.buttonNextWord.Name = "buttonNextWord";
            this.buttonNextWord.UseVisualStyleBackColor = true;
            this.buttonNextWord.Click += new System.EventHandler(this.buttonNextWord_Click);
            // 
            // textBoxWord
            // 
            resources.ApplyResources(this.textBoxWord, "textBoxWord");
            this.textBoxWord.Name = "textBoxWord";
            // 
            // labelGoodBad
            // 
            resources.ApplyResources(this.labelGoodBad, "labelGoodBad");
            this.labelGoodBad.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.labelGoodBad.Name = "labelGoodBad";
            // 
            // labelNumberOfRepeat
            // 
            resources.ApplyResources(this.labelNumberOfRepeat, "labelNumberOfRepeat");
            this.labelNumberOfRepeat.BackColor = System.Drawing.Color.Silver;
            this.labelNumberOfRepeat.Name = "labelNumberOfRepeat";
            // 
            // labelNumberOfRepeatValue
            // 
            resources.ApplyResources(this.labelNumberOfRepeatValue, "labelNumberOfRepeatValue");
            this.labelNumberOfRepeatValue.BackColor = System.Drawing.Color.Silver;
            this.labelNumberOfRepeatValue.Name = "labelNumberOfRepeatValue";
            // 
            // SaveToFile
            // 
            resources.ApplyResources(this.SaveToFile, "SaveToFile");
            this.SaveToFile.Name = "SaveToFile";
            this.SaveToFile.UseVisualStyleBackColor = true;
            this.SaveToFile.Click += new System.EventHandler(this.SaveToFile_Click);
            // 
            // SingleWord
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Controls.Add(this.SaveToFile);
            this.Controls.Add(this.labelNumberOfRepeatValue);
            this.Controls.Add(this.labelNumberOfRepeat);
            this.Controls.Add(this.labelGoodBad);
            this.Controls.Add(this.textBoxWord);
            this.Controls.Add(this.buttonNextWord);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.buttonCorrectAnswer);
            this.Controls.Add(this.textBoxAnswer);
            this.Name = "SingleWord";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.Button buttonCorrectAnswer;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Button buttonNextWord;
        private System.Windows.Forms.TextBox textBoxWord;
        private System.Windows.Forms.Label labelGoodBad;
        private System.Windows.Forms.Label labelNumberOfRepeat;
        private System.Windows.Forms.Label labelNumberOfRepeatValue;
        private System.Windows.Forms.Button SaveToFile;
    }
}