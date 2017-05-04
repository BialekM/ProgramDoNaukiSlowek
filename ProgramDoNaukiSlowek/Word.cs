using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramDoNaukiSlowek
{
    public class Word
    {
        public List<string> PolishName{ get; set; }
        public List<string> EnglishName { get; set; }
        public int Counter { get; set; }

        public Word(List<string> polishName, List<string> englishName, int counter)
        {
            PolishName = polishName;
            EnglishName = englishName;
            this.Counter = counter;
        }
    }
}
