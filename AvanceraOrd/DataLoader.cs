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
        private const string filename = "TextFiles/{0}.txt";

        // Private fields
        private string[] sectionTitles = { "1a" };

        // Public properties

        // Methods
        public List<Section> LoadSections()
        {
            List<Section> sections = new List<Section>();
            foreach (string sectionTitle in sectionTitles)
            {
                Section section = LoadSection(sectionTitle);
                if (section != null)
                {
                    sections.Add(section);
                }
            }
            return sections;
        }

        private Section? LoadSection(string title)
        {
            try
            {
                Section section = new Section(title);

                string fileText = File.ReadAllText(String.Format(filename, title));
                string[] fileTextAreas = fileText.Split("===");
                section.Questions = LoadPrompts(fileTextAreas[0]);
                section.Answers = LoadPrompts(fileTextAreas[1]);

                return section;
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
                string[] promptComponents = textLine.Split(".");
                if (int.TryParse(promptComponents[0], out int promptNum)) {
                    Prompt prompt = new Prompt(promptNum, promptComponents[1].Trim());
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
