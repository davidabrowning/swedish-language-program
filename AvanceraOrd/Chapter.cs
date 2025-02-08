using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvanceraOrd
{
    internal class Chapter
    {
        // Properties
        public int Number { get; private set; }
        public string WordBox { get; set; }
        public List<Section> Sections { get; set; }

        // Constructor
        public Chapter(int number) 
        {
            Number = number;
            WordBox = "";
            Sections = new List<Section>();
        }
    }
}
