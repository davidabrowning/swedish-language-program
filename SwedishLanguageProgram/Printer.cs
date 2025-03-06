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

        public void Clear() => Console.Clear();
        public void Print(string text, ConsoleColor textColor)
        {
            Console.ForegroundColor = textColor;
            Console.Write(text);
            Console.ForegroundColor = defaultTextColor;
        }
        public void Print(string text) => Print(text, defaultTextColor);
        public void PrintLine(string text, ConsoleColor textColor) => Print($"{text}\n", textColor);
        public void PrintLine(string text) => PrintLine(text, defaultTextColor);
        public void PrintPageTitle(string text)
        {
            Clear();
            PrintLine($"===== {text.ToUpper()} =====");
        }
        public void PrintChapterTitle(int num) => PrintLine($"===== KAPITEL {num} =====");
        public void PrintExerciseTitle(string text) => PrintLine($"\n[{text}]");
        public void PrintWordBox(string text) => PrintLine($"\n{text}");
        public void PrintQuestion(string text) => Print($"\n{text}     ");
        public void PrintExerciseSummary(int correct, int total) 
            => PrintLine($"\nSammanfattning: {correct} / {total}.", ConsoleColor.Cyan);
        public void PrintCorrectAnswer(string text) => PrintLine(text, ConsoleColor.Green);
        public void PrintIncorrectAnswer(string text) => PrintLine(text, ConsoleColor.Red);
        public void PrintWarning(string text) => PrintLine(text, ConsoleColor.Yellow);
    }
}
