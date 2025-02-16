using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwedishLanguageProgram
{
    internal class PracticeSession
    {

        // Fields
        private DataLoader dataLoader;
        private Quizzer quizzer;
        private List<Chapter> chapters;
        private Printer printer;

        // Properties
        
        // Constructors
        public PracticeSession()
        {
            dataLoader = new DataLoader();
            quizzer = new Quizzer();
            chapters = new List<Chapter>();
            printer = new Printer();
        }

        /// <summary>
        /// Starts the practice session.
        /// </summary>
        public void Start()
        {
            chapters = dataLoader.LoadChapters();
            ShowMainMenu();
        } 

        private void ShowMainMenu()
        {
            printer.PrintPageTitle("Main menu");
            printer.PrintInfo("[1] Genomför ett kapitelprov");
            printer.PrintInfo("[2] Visa resultaten");
            printer.PrintInfo("[9] Avsluta programmet");
            HandleMainMenuInput();
        }

        private void HandleMainMenuInput()
        {
            switch (Console.ReadLine().Trim())
            {
                case "1":
                    ShowChapterMenu();
                    break;
                case "2":
                    ShowResults();
                    break;
                case "9":
                    Quit();
                    break;
                default:
                    printer.PrintWarning("Oväntad inmatning. Försök igen.");
                    printer.PrintContinueConfirmation();
                    break;
            }
        }

        private void ShowChapterMenu()
        {
            printer.PrintPageTitle("Kapitelmeny");
            for (int i = 0; i < chapters.Count; i++)
            {
                printer.PrintInfo($"[{i + 1}] Kapitel {chapters[i].Name}");
            }
            printer.PrintInfo("[9] Tillbaka till huvudmenyn");
            HandleChapterMenuInput();
        }

        private void HandleChapterMenuInput()
        {
            switch (Console.ReadLine().Trim())
            {
                case "1":
                    StartQuiz(chapters[0]);
                    break;
                case "2":
                    StartQuiz(chapters[1]);
                    break;
                case "9":
                    ShowMainMenu();
                    break;
                default:
                    printer.PrintWarning("Oväntad inmatning. Försök igen.");
                    printer.PrintContinueConfirmation();
                    break;
            }
        }

        private void StartQuiz(Chapter chapter)
        {
            quizzer.PerformChapterQuiz(chapter);
            printer.PrintContinueConfirmation();
            ShowMainMenu();
        }

        private void ShowResults()
        {
            Console.WriteLine("Showing results...");
            printer.PrintContinueConfirmation();
            ShowMainMenu();
        }

        private void Quit()
        {
            Console.WriteLine("Programmet avslutas. Tack och hej då!");
            printer.PrintContinueConfirmation();
        }
    }
}
