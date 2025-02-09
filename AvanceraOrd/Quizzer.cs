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

        /// <summary>
        /// Starts the quizzer.
        /// </summary>
        /// <param name="chapters">Chapters to include in the quiz.</param>
        public void Start(List<Chapter> chapters)
        {
            foreach (Chapter chapter in chapters)
            {
                PerformChapterQuiz(chapter);
            }
            printer.Reset();
        }

        /// <summary>
        /// Quizzes the user on one chapter.
        /// </summary>
        /// <param name="chapter">The chapter for the quiz.</param>
        private void PerformChapterQuiz(Chapter chapter)
        {
            printer.PrintChapterTitle(chapter.Number);
            foreach (Exercise exercise in chapter.Exercises)
            {
                PerformExerciseQuiz(exercise, chapter.WordBox);
            }
        }

        /// <summary>
        /// Quizzes the user on one exercise.
        /// </summary>
        /// <param name="exercise">The exercise for the quiz.</param>
        /// <param name="wordBox">The chapter's word list.</param>
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

        /// <summary>
        /// Quizzes the user on one question. Updates counters for questions asked and correct answers.
        /// </summary>
        /// <param name="question">The question to ask.</param>
        /// <param name="answer">The answer to the question.</param>
        /// <param name="wordBox">The chapter's word list.</param>
        /// <param name="questionsAsked">The number of questions asked so far in this exercise.</param>
        /// <param name="correctAnswers">The number of correct answers so far in this exercise.</param>
        private void PerformQuestionQuiz(Prompt question, Prompt answer, string wordBox, ref int questionsAsked, ref int correctAnswers)
        {
            if (questionsAsked % 5 == 0)
            {
                printer.PrintWordBox(wordBox);
            }

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
    }
}
