using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace SwedishLanguageProgram
{
    /// <summary>
    /// Loads word practice data from data source.
    /// </summary>
    internal class DataLoader
    {
        // Constants
        private const string wordListNumberSeparator = ".";
        private const string sectionSeparator = "===";
        private const string promptSeparator = "\n";
        private const string promptNumberSeparator = ".";
        private const string promptBlankOriginal = "_";
        private const string promptBlankFinal = "____________";

        // Private readonly fields
        private readonly string[] chapterNames = { "1" };
        private readonly string[] problemSetLetters = { "b", "c" };

        // Private fields
        private Printer printer;
        private Database database;

        public DataLoader()
        {
            printer = new Printer();
            database = new Database();
        }

        /// <summary>
        /// Loads all chapters from data source.
        /// </summary>
        /// <returns>A list of chapters.</returns>
        public List<Chapter> LoadChapters()
        {
            List<Chapter> chapters = new List<Chapter>();
            foreach (string chapterName in chapterNames)
            {
                List<string> wordList = LoadWordList(chapterName);
                List<ProblemSet> problemSet = LoadProblemSets(chapterName);
                chapters.Add(new Chapter(chapterName, wordList, problemSet));
            }
            return chapters;
        }

        /// <summary>
        /// Loads a chapter's word list from a database object.
        /// </summary>
        /// <param name="chapterNum">The chapter number.</param>
        /// <returns>A string representation of the chapters word list.</returns>
        private List<string> LoadWordList(string chapterNum)
        {
            List<string> wordList = new List<string>();
            string textArea = database.GetWordList(chapterNum);
            string[] textLines = textArea.Split("\n");
            foreach (string textLine in textLines)
            {
                int indexOfFirstPeriod = textLine.IndexOf(wordListNumberSeparator);
                if (indexOfFirstPeriod == -1)
                {
                    continue;
                }
                string word = textLine.Substring(indexOfFirstPeriod + 1).Trim();
                wordList.Add(word);
            }
            return wordList;
        }

        /// <summary>
        /// Loads a list of chapter problemSet from a database object.
        /// </summary>
        /// <param name="chapterNum">The chapter number.</param>
        /// <returns>A list of the chapter's problemSet.</returns>
        private List<ProblemSet> LoadProblemSets(string chapterNum)
        {
            List<ProblemSet> sections = new List<ProblemSet>();
            foreach (string sectionSubtitle in problemSetLetters)
            {
                string sectionTitle = $"{chapterNum}{sectionSubtitle}";
                ProblemSet section = LoadProblemSetFromDatabaseObject(sectionTitle);
                if (section != null)
                {
                    sections.Add(section);
                }
            }
            return sections;
        }

        private ProblemSet? LoadProblemSetFromDatabaseObject(string problemSetTitle)
        {
            ProblemSet problemSet = new ProblemSet(problemSetTitle);
            string rawText = database.GetProblemSet(problemSetTitle);
            string[] textAreas = rawText.Split(sectionSeparator);
            if(textAreas.Length == 2)
            {
                problemSet.Questions = LoadPrompts(textAreas[0]);
                problemSet.Answers = LoadPrompts(textAreas[1]);
            }
            return problemSet;
        }

        /// <summary>
        /// Parses a string textarea into individual prompts (questions or answers).
        /// </summary>
        /// <param name="textArea">The textarea to parse.</param>
        /// <returns>A list of prompt objects.</returns>
        private List<Prompt> LoadPrompts(string textArea)
        {
            List<Prompt> prompts = new List<Prompt>();
            string[] textLines = textArea.Split(promptSeparator);
            foreach (string textLine in textLines)
            {
                int indexOfFirstPeriod = textLine.IndexOf(promptNumberSeparator);
                if (indexOfFirstPeriod == -1)
                {
                    continue;
                }
                string promptNumAsString = textLine.Substring(0, indexOfFirstPeriod);
                string promptText = textLine.Substring(indexOfFirstPeriod + 1);
                if (int.TryParse(promptNumAsString, out int promptNum)) {
                    promptText = promptText.Replace(promptBlankOriginal, promptBlankFinal);
                    Prompt prompt = new Prompt(promptNum, promptText.Trim());
                    prompts.Add(prompt);
                }
                else
                {
                    continue;
                }
            }
            return prompts;
        }
    }
}
