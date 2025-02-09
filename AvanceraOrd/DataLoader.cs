using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace AvanceraOrd
{
    internal class DataLoader
    {
        // Private constants
        private const string wordBoxFilename = "TextFiles/Words/{0}.txt";
        private const string exerciseFilename = "TextFiles/Exercises/{0}.txt";

        // Private fields
        private int[] chapterNums = { 1 };
        private string[] exerciseLetters = { "b" };

        // Public properties

        // Methods
        public List<Chapter> LoadChapters()
        {
            List<Chapter> chapters = new List<Chapter>();
            foreach (int chapterNum in chapterNums)
            {
                // Create chapter
                Chapter chapter = new Chapter(chapterNum);

                // Load wordbox
                chapter.WordBox = LoadWordBox(chapterNum);

                // Load sections
                chapter.Exercises = LoadExercises(chapterNum);

                // Add the new chapter
                chapters.Add(chapter);
            }
            return chapters;
        }
        private string LoadWordBox(int chapterNum)
        {
            try
            {
                return File.ReadAllText(String.Format(wordBoxFilename, chapterNum));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"OBS: Lyckades inte läsa in kapitel {chapterNum}s ordruta.");
                Console.WriteLine(ex.Message);
                return "";
            }
        }
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

        private List<Prompt> LoadPrompts(string textArea)
        {
            List<Prompt> prompts = new List<Prompt>();
            string[] textLines = textArea.Split("\n");
            foreach (string textLine in textLines)
            {
                int indexOfFirstPeriod = textLine.IndexOf(".");
                if (indexOfFirstPeriod == -1)
                {
                    continue;
                }
                string promptNumAsString = textLine.Substring(0, indexOfFirstPeriod);
                string promptText = textLine.Substring(indexOfFirstPeriod + 1);
                if (int.TryParse(promptNumAsString, out int promptNum)) {
                    promptText = promptText.Replace("_", "____________");
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
