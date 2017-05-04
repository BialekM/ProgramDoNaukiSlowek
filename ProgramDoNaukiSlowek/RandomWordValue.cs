using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramDoNaukiSlowek
{
    class RandomWordValue
    {
        Random random;
        Word word;

        public int Randomize(List<Word> studyList)
        {
            random = new Random();
            int randomNumber = random.Next(0, studyList.Count());
            Word word = studyList[randomNumber];
            if (SingleWord.finish != SingleWord.ListOfWords.Count)
            {
                while (studyList[randomNumber].Counter == 0)
                {
                    randomNumber = random.Next(0, studyList.Count());
                    word = studyList[randomNumber];
                }
            }
           
            return randomNumber;
        }
    }
}
