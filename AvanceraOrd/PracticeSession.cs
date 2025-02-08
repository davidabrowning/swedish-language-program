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
        private List<Section> sections;

        // Properties
        
        // Constructors
        public PracticeSession()
        {
            dataLoader = new DataLoader();
            quizzer = new Quizzer();
            sections = new List<Section>();
        }

        // Methods
        public void Start()
        {
            sections = dataLoader.LoadSections();
            quizzer.Start(sections);
        } 
    }
}
