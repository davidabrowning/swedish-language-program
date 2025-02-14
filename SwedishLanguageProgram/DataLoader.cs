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

        // Private readonly fields
        private readonly string sectionSeparator = "===";
        private readonly string[] chapterNums = { "1" };
        private readonly string[] exerciseLetters = { "b", "c" };
        private readonly string promptSeparator = "\n";
        private readonly string promptNumberSeparator = ".";
        private readonly string promptBlankOriginal = "_";
        private readonly string promptBlankFinal = "____________";

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
            foreach (string chapterNum in chapterNums)
            {
                string wordBox = LoadWordBox(chapterNum);
                List<Exercise> exercises = LoadExercises(chapterNum);
                chapters.Add(new Chapter(chapterNum, wordBox, exercises));
            }
            return chapters;
        }

        /// <summary>
        /// Loads a chapter's word list from a database object.
        /// </summary>
        /// <param name="chapterNum">The chapter number.</param>
        /// <returns>A string representation of the chapters word list.</returns>
        private string? LoadWordBox(string chapterNum)
        {
            return database.GetWordBox(chapterNum);
        }

        /// <summary>
        /// Loads a list of chapter exercises from a database object.
        /// </summary>
        /// <param name="chapterNum">The chapter number.</param>
        /// <returns>A list of the chapter's exercises.</returns>
        private List<Exercise> LoadExercises(string chapterNum)
        {
            List<Exercise> sections = new List<Exercise>();
            foreach (string sectionSubtitle in exerciseLetters)
            {
                string sectionTitle = $"{chapterNum}{sectionSubtitle}";
                Exercise section = LoadExerciseFromDatabaseObject(sectionTitle);
                if (section != null)
                {
                    sections.Add(section);
                }
            }
            return sections;
        }

        private Exercise? LoadExerciseFromDatabaseObject(string exerciseTitle)
        {
            Exercise exercise = new Exercise(exerciseTitle);
            string exerciseFullText = database.GetExercise(exerciseTitle);
            string[] exerciseTextAreas = exerciseFullText.Split(sectionSeparator);
            if(exerciseTextAreas.Length == 2)
            {
                exercise.Questions = LoadPrompts(exerciseTextAreas[0]);
                exercise.Answers = LoadPrompts(exerciseTextAreas[1]);
            }
            return exercise;
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
