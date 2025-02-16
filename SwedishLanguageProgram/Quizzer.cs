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
        public void PerformChapterQuiz(Chapter chapter)
        {
            printer.PrintChapterTitle(chapter.Name);
            foreach (ProblemSet problemSet in chapter.ProblemSets)
            {
                PerformProblemSetRandomQuiz(problemSet, chapter.WordList);
            }
            printer.PrintContinueConfirmation();
        }

        /// <summary>
        /// Quizzes the user on one problem set.
        /// </summary>
        /// <param name="problemSet">The problemSet for the quiz.</param>
        /// <param name="wordBox">The chapter's word list.</param>
        private void PerformProblemSetRandomQuiz(ProblemSet problemSet, List<string> wordList)
        {
            int questionsAsked = 0;
            int correctAnswers = 0;
            printer.PrintProblemSetTitle(problemSet.Name);
            List<int> questionNumbers = problemSet.RandomizedOrderList;
            foreach (int questionNumber in questionNumbers)
            {
                Prompt question = problemSet.GetQuestion(questionNumber);
                Prompt answer = problemSet.GetAnswer(questionNumber);
                PerformQuestionQuiz(question, answer, wordList, ref questionsAsked, ref correctAnswers);
            }
            printer.PrintProblemSetSummary(correctAnswers, questionsAsked);
            printer.PrintContinueConfirmation();
        }

        /// <summary>
        /// Quizzes the user on one question. Updates counters for questions asked and correct answers.
        /// </summary>
        /// <param name="question">The question to ask.</param>
        /// <param name="answer">The answer to the question.</param>
        /// <param name="wordBox">The chapter's word list.</param>
        /// <param name="questionsAsked">The number of questions asked so far in this problemSet.</param>
        /// <param name="correctAnswers">The number of correct answers so far in this problemSet.</param>
        private void PerformQuestionQuiz(Prompt question, Prompt answer, List<string> wordList, ref int questionsAsked, ref int correctAnswers)
        {
            if (questionsAsked % 5 == 0)
            {
                printer.PrintWordList(wordList);
            }

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
