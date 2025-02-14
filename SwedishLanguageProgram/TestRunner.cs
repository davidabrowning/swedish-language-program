using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwedishLanguageProgram
{
    internal class TestRunner
    {
        private Printer printer;
        public TestRunner()
        {
            printer = new Printer();
        }
        public void RunTests()
        {
            printer.PrintPageTitle("Running all tests");
        }
    }
}
