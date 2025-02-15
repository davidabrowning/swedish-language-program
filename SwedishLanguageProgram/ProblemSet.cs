using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwedishLanguageProgram
{
    internal class ProblemSet
    {
        public string Name { get; set; }
        
        public List<Prompt> Questions { get; set; }
        public List<Prompt> Answers { get; set; }
        public List<int> RandomizedOrderList { get { return GetRandomizedOrderList(); } }
        public ProblemSet(string name)
        {
            Name = name;
            Questions = new List<Prompt>();
            Answers = new List<Prompt>();
        }

        /// <summary>
        /// Given a number, returns the corresponding question.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <returns>The corresponding question.</returns>
        public Prompt? GetQuestion(int number)
        {
            foreach (Prompt question in Questions)
            {
                if (question.Number == number)
                {
                    return question;
                }
            }
            return null;
        }

        /// <summary>
        /// Given a number, returns the corresponding answer.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <returns>The corresponding answer.</returns>
        public Prompt? GetAnswer(int number)
        {
            foreach (Prompt answer in Answers)
            {
                if (answer.Number == number)
                {
                    return answer;
                }
            }
            return null;
        }

        private List<int> GetRandomizedOrderList()
        {
            List<int> randomizedOrderList = new List<int>();
            Random random = new Random();
            for (int i = 0; i < Questions.Count; i++)
            {
                randomizedOrderList.Add(i);
            }
            for (int i = 0; i < Questions.Count; i++)
            {
                int randomIndex = random.Next(0, Questions.Count);
                int temp = randomizedOrderList[i];
                randomizedOrderList[i] = randomizedOrderList[randomIndex];
                randomizedOrderList[randomIndex] = temp;
            }
            return randomizedOrderList;
        }
    }
}
