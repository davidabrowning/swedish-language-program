using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvanceraOrd
{
    internal class Chapter
    {
        // Properties
        public int Number { get; private set; }
        public string WordBox { get; private set; }
        public List<Exercise> Exercises { get; private set; }

        // Constructor
        public Chapter(string chapterNumber, string wordBox, List<Exercise> exercises) 
        {
            Number = Convert.ToInt32(chapterNumber);
            WordBox = wordBox;
            Exercises = exercises;
        }
    }
}
