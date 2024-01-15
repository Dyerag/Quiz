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

                GUI.Print("En json fil med spørgsmålene til en quiz, skal lægges i folderen. Filen skal også navn gives " + FileName);
            }
        }

        public QuestionList FileCheck()
        {
            while (true)
            {
                if (!File.Exists(Path.Combine(FilePath, FileName)))
                {
                    GUI.Print("Filen med spørgsmålene findes ikke");
                    Thread.Sleep(3000);
                    GUI.Print("Enten var ingen blevet lagt i, eller også er den ikke navngivet rigtigt", 4000);
                    GUI.Print("Læg venlist Filen i folderen, inden du fortsætter", 0);
                }
                else
                {
                    Thread.Sleep(3000);
                    return FileFetch();
                }
            }
        }

        public QuestionList FileFetch()
        {
            return new QuestionList();
        }
    }
}
