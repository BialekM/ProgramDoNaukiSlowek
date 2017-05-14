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
    public partial class SingleWord : Form
    {
        private SingleWord singleWord;
        
        public static List<Word> ListOfWords { get; set; }
        private RandomWordValue rwv;
        private readonly int randomNumber;
        private bool areYouCorrectAnswer = false;
        private bool areYouInCorrectAnswer = false;
        private bool buttonCheckPresed = false;
        public static  int finish = 0;
        public static bool IsPolish;

        public SingleWord()
        {
            InitializeComponent();
            textBoxAnswer.Focus();
            foreach (Word word in ListOfWords)
            {
                if (word.Counter == 0)
                {
                    finish += 1;
                }
            }
            if (finish == ListOfWords.Count)
            {
                MessageBox.Show("Gratulacje jestes nauczony");
            }
            rwv = new RandomWordValue();
            randomNumber = rwv.Randomize(ListOfWords);
            labelNumberOfRepeatValue.Text = ListOfWords[randomNumber].Counter.ToString();
            if (IsPolish == true)
            {
                for (int i = 0; i < ListOfWords[randomNumber].PolishName.Count; i++)
                {
                    textBoxWord.Text += ListOfWords[randomNumber].PolishName[i] + "\r\n";
                }
            }
            else
            {
                for (int i = 0; i < ListOfWords[randomNumber].EnglishName.Count; i++)
                {
                    textBoxWord.Text += ListOfWords[randomNumber].EnglishName[i] + "\r\n";
                }
            }

        }

        private void buttonCorrectAnswer_Click(object sender, EventArgs e)
        {
            string Message= "Poprawna odpowiedz to \r\n";
            if (IsPolish == true)
            {
                foreach (string t in ListOfWords[randomNumber].EnglishName)
                {
                    Message = Message + t + "\r\n";
                }
            }
            else
            {
                foreach (string t in ListOfWords[randomNumber].PolishName)
                {
                    Message = Message + t + "\r\n";
                }
            }

            MessageBox.Show(Message);
            ListOfWords[randomNumber].Counter += 2;
            labelNumberOfRepeatValue.Text = ListOfWords[randomNumber].Counter.ToString();
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            bool correctAnswer = false;
            if (IsPolish == true)
            {
                for (int i = 0; i < ListOfWords[randomNumber].EnglishName.Count; i++)
                {
                    if (textBoxAnswer.Text.Equals(ListOfWords[randomNumber].EnglishName[i]))
                    {
                        correctAnswer = true;
                    }
                }
            }
            else
            {
                for (int i = 0; i < ListOfWords[randomNumber].PolishName.Count; i++)
                {
                    if (textBoxAnswer.Text.Equals(ListOfWords[randomNumber].PolishName[i]))
                    {
                        correctAnswer = true;
                    }
                }
            }

            if (correctAnswer)
            {
                if (!areYouCorrectAnswer)
                {
                    ListOfWords[randomNumber].Counter -= 1;
                    labelNumberOfRepeatValue.Text = ListOfWords[randomNumber].Counter.ToString();
                    labelGoodBad.BackColor = Color.ForestGreen;
                    labelGoodBad.Text = "Dobra odpowiedz";
                    areYouCorrectAnswer = true;
                }
                else
                {
                    MessageBox.Show("Już odpowiedziałeś na to pytanie");
                }

            }
            else
            {
                if (!areYouInCorrectAnswer)
                {
                    ListOfWords[randomNumber].Counter += 2;
                    labelNumberOfRepeatValue.Text = ListOfWords[randomNumber].Counter.ToString();
                    labelGoodBad.BackColor = Color.Red;
                    labelGoodBad.Text = "Zła odpowiedz";
                    areYouInCorrectAnswer = true;
                }

            }
            buttonCheckPresed = true;
        }


        private void TextBoxAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               buttonCheck_Click(sender,e);
            }

            if (e.KeyCode == Keys.ShiftKey)
            {
                buttonNextWord_Click(sender,e);
            }
        }

        private void buttonNextWord_Click(object sender, EventArgs e)
        {
            if (!buttonCheckPresed)
            {
                ListOfWords[randomNumber].Counter += 2;
            }
            singleWord = new SingleWord();

            this.Hide();
            foreach (Word word in ListOfWords)
            {
                if (word.Counter == 0)
                {
                    finish += 1;
                }
            }
            if (finish == ListOfWords.Count)
            {
                MessageBox.Show("Gratulacje jestes nauczony");
            }
            singleWord.Show();
        }

        private void SaveToFile_Click(object sender, EventArgs e)
        {
            MyFile file = new MyFile();
            file.SaveListOfWord(ListOfWords);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            MyFile file = new MyFile();
            file.SaveListOfWord(ListOfWords);
            Application.Exit();

        }
    }
}
