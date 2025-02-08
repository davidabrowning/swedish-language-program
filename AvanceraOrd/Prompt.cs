using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvanceraOrd
{
    internal class Prompt
    {
        public int Number { get; set; }
        public string Text { get; set; }
        public Prompt(int number, string text)
        {
            Number = number;
            Text = text;
        }
    }
}
