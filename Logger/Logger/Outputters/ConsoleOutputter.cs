using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class ConsoleOutputter : Outputter
    {

        public ConsoleOutputter()
        {

        }

        public Outputter getInstance()
        {
            return this;
        }

        public OutputType getOutputType()
        {
            return OutputType.Console;
        }

        public void WriteLog(Level lvl, string value)
        {
            Console.WriteLine(lvl.ToString() + ": " + value + " WHEN: " + DateTime.Now);
        }
    }
}
