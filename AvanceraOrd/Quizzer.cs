using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvanceraOrd
{
    internal class Quizzer
    {
        public void Start(List<Section> sections)
        {
            foreach(Section section in sections)
            {
                int questionsAsked = 0;
                int correctAnswers = 0;
                Console.WriteLine($"===== Sektion {section.Name} =====");
                foreach (Prompt question in section.Questions)
                {
                    Prompt? answer = section.GetAnswer(question.Number);

                    Console.WriteLine($"Fråga: {question.Text}");
                    Console.Write("Ditt svar: ");
                    string userInput = Console.ReadLine();
                    Console.WriteLine($"Svar: {answer.Text}");
                    Console.WriteLine("");

                    questionsAsked++;
                    if (userInput.Equals(answer.Text))
                    {
                        correctAnswers++;
                    }
                }
                Console.WriteLine($"Sammanfattning: {correctAnswers} / {questionsAsked}");
            }
        }
    }
}
