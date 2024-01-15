using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Quiz;

namespace Quiz
{
    public class IO
    {
        // This field is technically reduntant, as the code make get the directory,
        // could have either been attached to the property, or put in the constructor.
        private string _filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Quiz");

        public string? FilePath { get => _filePath; }
        public string? FileName { get; } = "Questions.json";

        public IO()
        {
            if (!File.Exists(FilePath))
            {
                GUI.Print($"Quiz folder findes ikke. Skaber folder på {Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}");
                Thread.Sleep(4000);
                //todo notify user that they need to put a file in it. Aswell as what to name the file
                Directory.CreateDirectory(FilePath);
            }
        }

        public void FileCheck()
        {
            if (!File.Exists(Path.Combine(FilePath,FileName)))
            {

            }
        }
    }
}
