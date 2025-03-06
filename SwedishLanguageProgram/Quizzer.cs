using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwedishLanguageProgram
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
                PerformChapterQuiz(chapter);
        }

        private void PerformChapterQuiz(Chapter chapter)
        {
            printer.PrintChapterTitle(chapter.Number);
            foreach (Exercise exercise in chapter.Exercises)
                PerformExerciseQuiz(exercise, chapter.WordBox);
        }

        private void PerformExerciseQuiz(Exercise exercise, string wordBox)
        {
            int questionsAsked = 0;
            int correctAnswers = 0;

            printer.PrintExerciseTitle(exercise.Name);
            foreach (Prompt question in exercise.Questions)
            {
                Prompt? answer = exercise.GetAnswer(question.Number);
                PerformQuestionQuiz(question, answer, wordBox, ref questionsAsked, ref correctAnswers);

            }
            printer.PrintExerciseSummary(correctAnswers, questionsAsked);
        }

        private void PerformQuestionQuiz(Prompt question, Prompt answer, string wordBox, ref int questionsAsked, ref int correctAnswers)
        {
            if (questionsAsked % 5 == 0)
                printer.PrintWordBox(wordBox);

            printer.PrintQuestion(question.Text);
            string userInput = Console.ReadLine().ToLower();

            questionsAsked++;
            if (userInput.Length > 1 && answer.Text.ToLower().Contains(userInput))
            {
                printer.PrintCorrectAnswer(answer.Text);
                correctAnswers++;
            }
            else
            {
                printer.PrintIncorrectAnswer(answer.Text);
            }
        }
    }
}
