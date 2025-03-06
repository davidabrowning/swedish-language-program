using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwedishLanguageProgram
{
    internal class PracticeSession
    {
        private DataLoader dataLoader;
        private Quizzer quizzer;
        private List<Chapter> chapters;

        public PracticeSession()
        {
            dataLoader = new DataLoader();
            quizzer = new Quizzer();
            chapters = new List<Chapter>();
        }

        public void Start()
        {
            chapters = dataLoader.LoadChapters();
            quizzer.Start(chapters);
        } 
    }
}
