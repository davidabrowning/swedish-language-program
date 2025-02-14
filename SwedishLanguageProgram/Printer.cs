using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwedishLanguageProgram
{
    internal class Printer
    {
        private ConsoleColor defaultTextColor = ConsoleColor.White;

        public void Reset()
        {
            Console.ForegroundColor = defaultTextColor;
        }

        public void PrintPageTitle(string title)
        {
            Console.Clear();
            Console.ForegroundColor = defaultTextColor;
            Console.WriteLine($"===== {title.ToUpper()} =====");
        }

        public void PrintChapterTitle(int chapterNum)
        {
            Console.ForegroundColor = defaultTextColor;
            Console.WriteLine($"===== KAPITEL {chapterNum} =====");
        }

        public void PrintExerciseTitle(string sectionTitle)
        {
            Console.ForegroundColor = defaultTextColor;
            Console.WriteLine($"\n[{sectionTitle}]");
        }

        public void PrintWordBox(string wordBox)
        {
            Console.ForegroundColor = defaultTextColor;
            Console.WriteLine($"\n{wordBox}");
        }

        public void PrintQuestion(string question)
        {
            Console.ForegroundColor = defaultTextColor;
            Console.Write($"\n{question}     ");
        }

        public void PrintExerciseSummary(int correct, int total)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\nSammanfattning: {correct} / {total}.");
        }

        public void PrintCorrectAnswer(string answer)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            PrintAnswer(answer);
        }

        public void PrintIncorrectAnswer(string answer)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            PrintAnswer(answer);
        }

        public void PrintAnswer(string answer)
        {
            Console.WriteLine($"{answer}");
        }

        public void PrintWarning(string warning)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(warning);
        }
    }
}
