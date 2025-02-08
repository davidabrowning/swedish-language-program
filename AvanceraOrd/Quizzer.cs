using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvanceraOrd
{
    internal class Quizzer
    {
        private Printer printer;

        public Quizzer() 
        {
            printer = new Printer();
        }

        public void Start(List<Chapter> chapters)
        {
            foreach (Chapter chapter in chapters)
            {
                printer.PrintChapterTitle(chapter.Number);

                foreach (Section section in chapter.Sections)
                { 

                    printer.PrintSectionTitle(section.Name);

                    int questionsAsked = 0;
                    int correctAnswers = 0;

                    foreach (Prompt question in section.Questions)
                    {
                        if (questionsAsked % 5 == 0)
                        {
                            printer.PrintWordBox(chapter.WordBox);
                        }
                        Prompt? answer = section.GetAnswer(question.Number);

                        printer.PrintQuestion(question.Text);
                        string userInput = Console.ReadLine();

                        questionsAsked++;
                        if (userInput.Length > 1 && answer.Text.Contains(userInput))
                        {
                            printer.PrintCorrectAnswer(answer.Text);
                            correctAnswers++;
                        } 
                        else
                        {
                            printer.PrintIncorrectAnswer(answer.Text);
                        }
                    }

                    printer.PrintSectionSummary(correctAnswers, questionsAsked);
                }
            }
            printer.Reset();
        }
    }
}
