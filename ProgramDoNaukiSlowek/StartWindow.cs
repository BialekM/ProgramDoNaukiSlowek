using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramDoNaukiSlowek
{
    public partial class StartWindow : Form
    {
        SingleWord singleWordWindow;
        MyFile myfile;
        public StartWindow()
        {
            InitializeComponent();
        }

        private void buttonStartStudy_Click(object sender, EventArgs e)
        {
            comboBoxChoseLanguage_SelectedIndexChanged(sender, e);
            myfile = new MyFile();
            this.Hide();
            SingleWord.ListOfWords = myfile.CreatelistOfWords(2);
            singleWordWindow = new SingleWord();
            singleWordWindow.Show();
        }

        private void buttonContinueStudy_Click(object sender, EventArgs e)
        {
            comboBoxChoseLanguage_SelectedIndexChanged(sender, e);
            myfile = new MyFile();
            this.Dispose();
            SingleWord.ListOfWords = myfile.CreatelistOfWords(2);
            myfile.LoadListOfWord(SingleWord.ListOfWords);
            singleWordWindow = new SingleWord();
            singleWordWindow.Show();
        }

        private void comboBoxChoseLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxChoseLanguage.Text == "Z Polskiego na Angielski")
            {
                SingleWord.IsPolish = true;
            }
            else
            {
                SingleWord.IsPolish = false;
            }
        }
    }
}
