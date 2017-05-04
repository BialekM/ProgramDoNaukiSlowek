using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace ProgramDoNaukiSlowek
{
    class MyFile
    {
        Encoding enc = Encoding.GetEncoding("Windows-1250");
        readonly string sourcePath = (AppDomain.CurrentDomain.BaseDirectory+"/slowka.txt");
        readonly string saveSourcePath = (AppDomain.CurrentDomain.BaseDirectory + "/slowkaZapisane.txt");
        public List<Word> listOfWords = new List<Word>();
        private StreamWriter streamWriter;
        private StreamReader streamReader;
        private SingleWord singleWord;
        public MyFile()
        {
        }

        public List<Word> CreatelistOfWords(int numberOfReply)
        {
            if (!File.Exists(sourcePath))
            {
                File.Create(sourcePath);
            }
            StreamReader streamReader = new StreamReader(sourcePath, enc);
            string linia = "cokolwiek";
            int j = 0;
            bool isPolish = true;
            while (linia != null)
            {
                List<string> listOfPolishNames = new List<string>();
                List<string> listOfEnglishNames = new List<string>();

                Word word;
                string polishWord = null;
                string englishWord = null;
                j = 0;
                isPolish = true;
                linia = streamReader.ReadLine();
                if (linia == null)
                {
                    return listOfWords;
                }
                int liniaLength = linia.Length;
                for (int i = 0; i < linia.Length; i++)
                {
                    char temp = linia[i];
                    if (linia[i].ToString().Equals("-"))
                    {
                        for (int counter = j; counter < i; counter++)
                        {
                            string temp1 = linia[counter].ToString();
                            if (!(linia[counter].ToString().Equals(",")) && !(linia[counter].ToString().Equals("-")))
                            {
                                polishWord = polishWord + linia[counter];
                            }

                        }
                        listOfPolishNames.Add(polishWord);
                        polishWord = null;
                        isPolish = false;
                        j = i;
                    }

                    if ((linia[i].ToString().Equals(",") && isPolish == true))
                    {
                        for (int counter = j; counter < i; counter++)
                        {
                            if (!(linia[counter].ToString().Equals(",")) && !(linia[counter].ToString().Equals("-")))
                            {
                                polishWord = polishWord + linia[counter];
                            }
                        }
                        listOfPolishNames.Add(polishWord);
                        polishWord = null;
                        j = i;
                    }
                    if (linia[i].ToString().Equals(",") && isPolish == false)
                    {
                        for (int counter = j; counter < i; counter++)
                        {
                            if (!(linia[counter].ToString().Equals(",")) && !(linia[counter].ToString().Equals("-")))
                            {
                                englishWord = englishWord + linia[counter];
                            }

                        }
                        listOfEnglishNames.Add(englishWord);
                        englishWord = null;
                        j = i;
                    }

                    if (linia[i].ToString().Equals("."))
                    {
                        for (int counter = j; counter < i; counter++)
                        {
                            if (!(linia[counter].ToString().Equals(",")) && !(linia[counter].ToString().Equals("-")))
                            {
                                englishWord = englishWord + linia[counter];
                            }
                        }
                        listOfEnglishNames.Add(englishWord);
                        word = new Word(listOfPolishNames, listOfEnglishNames, numberOfReply);
                        listOfWords.Add(word);
                    }
                }
            }
            streamReader.Close();
            return listOfWords;
        }

        public void SaveListOfWord()
        {
            if (!File.Exists(sourcePath))
            {
                File.Create(sourcePath);
            }
            streamWriter = new StreamWriter(saveSourcePath, false);
            streamWriter.Flush();
            foreach (Word t in SingleWord.ListOfWords)
            {
                streamWriter.WriteLine(t.Counter);
            }
            streamWriter.Close();
        }

        public void LoadListOfWord()
        {
            streamReader = new StreamReader(saveSourcePath,enc);
            if (!File.Exists(sourcePath))
            {
                File.Create(sourcePath);
            }
            for (int i = 0; i < SingleWord.ListOfWords.Count; i++)
            {
                string line = streamReader.ReadLine();
                SingleWord.ListOfWords[i].Counter=Int32.Parse(line);
            }
            streamReader.Close();       
        }
    }

}
