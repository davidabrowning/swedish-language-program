using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvanceraOrd
{
    internal class Section
    {
        public string Name { get; set; }
        
        public List<Prompt> Questions { get; set; }
        public List<Prompt> Answers { get; set; }
        public Section(string name)
        {
            Name = name;
            Questions = new List<Prompt>();
            Answers = new List<Prompt>();
        }
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
    }
}
