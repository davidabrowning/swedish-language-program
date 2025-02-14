using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwedishLanguageProgram
{
    internal class Chapter
    {
        // Properties
        public string Name { get; private set; }
        public List<string> WordList { get; private set; }
        public List<ProblemSet> ProblemSets { get; private set; }

        // Constructor
        public Chapter(string name, List<string> wordList, List<ProblemSet> problemSets) 
        {
            Name = name;
            WordList = wordList;
            ProblemSets = problemSets;
        }
    }
}
