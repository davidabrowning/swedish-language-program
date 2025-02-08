using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvanceraOrd
{
    internal class PracticeSession
    {

        // Fields
        private DataLoader dataLoader;
        private Quizzer quizzer;
        private List<Chapter> chapters;

        // Properties
        
        // Constructors
        public PracticeSession()
        {
            dataLoader = new DataLoader();
            quizzer = new Quizzer();
            chapters = new List<Chapter>();
        }

        // Methods
        public void Start()
        {
            chapters = dataLoader.LoadChapters();
            quizzer.Start(chapters);
        } 
    }
}
