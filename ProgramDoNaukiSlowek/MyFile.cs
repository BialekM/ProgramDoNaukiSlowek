using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProgramDoNaukiSlowek
{
    class MyFile
    {
        private Encoding enc = Encoding.GetEncoding("Windows-1250");

        readonly string sourcePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "slowka.txt");
        readonly string saveSourcePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "slowkaZapisane.txt");

        private List<Word> listOfWords = new List<Word>();

        public List<Word> CreatelistOfWords(int numberOfReply)
        {
            if (!File.Exists(sourcePath))
            {
                File.Create(sourcePath);
            }

            using (StreamReader streamReader = new StreamReader(sourcePath, enc))
            {
                string linia = streamReader.ReadLine();

                while (linia != null)
                {
                    Word word = GetWordFromString(linia, numberOfReply);

                    if (word != null)
                    {
                        listOfWords.Add(word);
                    }

                    linia = streamReader.ReadLine();
                }
            }

            return listOfWords;
        }

        private Word GetWordFromString(string line, int numberOfReply)
        {
            try
            {
                //aa,bb-cc,dd => word("aa,bb","cc,dd",numberOfReply)
                String[] wordsArray = line.Split('-');
                return new Word(wordsArray[0].Split(',').ToList(), wordsArray[1].Split(',').ToList(), numberOfReply);

            }
            catch (Exception exc)
            {
                MessageBox.Show("Error while parsing line:" + line + ". Exc:" + exc.Message);
                return null;
            }
        }

        public void SaveListOfWord(List<Word> words)
        {
            using (var streamWriter = new StreamWriter(saveSourcePath, false))
            {
                foreach (Word t in words)
                {
                    streamWriter.WriteLine(t.Counter);
                }
            }
        }

        public void LoadListOfWord(List<Word> words)
        {
            using (var streamReader = new StreamReader(saveSourcePath, enc))
            {
                for (int i = 0; i < words.Count; i++)
                {
                    string line = streamReader.ReadLine();
                    words[i].Counter = Int32.Parse(line);
                }
            }
        }
    }
}
