using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace AvanceraOrd
{
    /// <summary>
    /// Loads word practice data from files.
    /// </summary>
    internal class DataLoader
    {
        // Private constants and readonlys
        private const string wordBoxFilename = "TextFiles/Words/{0}.txt";
        private const string exerciseFilename = "TextFiles/Exercises/{0}.txt";
        private const string promptSeparator = "\n";
        private const string promptNumberSeparator = ".";
        private const string promptBlankOriginal = "_";
        private const string promptBlankFinal = "____________";
        private readonly int[] chapterNums = { 1 };
        private readonly string[] exerciseLetters = { "b" };

        /// <summary>
        /// Loads all chapters from files.
        /// </summary>
        /// <returns>A list of chapters.</returns>
        public List<Chapter> LoadChapters()
        {
            List<Chapter> chapters = new List<Chapter>();
            foreach (int chapterNum in chapterNums)
            {
                string wordBox = LoadWordBox(chapterNum);
                List<Exercise> exercises = LoadExercises(chapterNum);
                chapters.Add(new Chapter(chapterNum, wordBox, exercises));
            }
            return chapters;
        }

        /// <summary>
        /// Loads a chapter's word list from a file.
        /// </summary>
        /// <param name="chapterNum">The chapter number.</param>
        /// <returns>A string representation of the chapters word list.</returns>
        private string LoadWordBox(int chapterNum)
        {
            try
            {
                return File.ReadAllText(String.Format(wordBoxFilename, chapterNum));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"OBS: Lyckades inte läsa in kapitel {chapterNum}s ordlista.");
                Console.WriteLine(ex.Message);
                return "";
            }
        }

        /// <summary>
        /// Loads a list of chapter exercises from a file.
        /// </summary>
        /// <param name="chapterNum">The chapter number.</param>
        /// <returns>A list of the chapter's exercises.</returns>
        public List<Exercise> LoadExercises(int chapterNum)
        {
            List<Exercise> sections = new List<Exercise>();
            foreach (string sectionSubtitle in exerciseLetters)
            {
                string sectionTitle = $"{chapterNum}{sectionSubtitle}";
                Exercise section = LoadExercise(sectionTitle);
                if (section != null)
                {
                    sections.Add(section);
                }
            }
            return sections;
        }

        /// <summary>
        /// Loads an exercise from a file.
        /// </summary>
        /// <param name="exerciseTitle">The exercise's title.</param>
        /// <returns>The loaded exercise object.</returns>
        private Exercise? LoadExercise(string exerciseTitle)
        {
            try
            {
                Exercise exercise = new Exercise(exerciseTitle);

                string exerciseFullText = File.ReadAllText(String.Format(exerciseFilename, exerciseTitle));
                string[] exerciseTextArea = exerciseFullText.Split("===");
                exercise.Questions = LoadPrompts(exerciseTextArea[0]);
                exercise.Answers = LoadPrompts(exerciseTextArea[1]);

                return exercise;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
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
