using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class FileOutputter : Outputter
    {
        private string documentsPath;
        public FileOutputter()
        {
            documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }

        public Outputter GetInstance()
        {
            return this;
        }

        public OutputType GetOutputType()
        {
            return OutputType.File;
        }

        public void WriteLog(Level lvl, string value)
        {
            File.AppendAllText(documentsPath + @"\LoggerOutputText.txt", lvl.ToString()
               + ": "  + value + " WHEN: " + DateTime.Now + Environment.NewLine);
        }


    }
}
