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
                    StartQuiz();
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

        private void StartQuiz()
        {
            quizzer.Start(chapters);
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
