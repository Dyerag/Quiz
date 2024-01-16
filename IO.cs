using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Quiz;


namespace Quiz
{
    public class IO
    {
        // This field is technically reduntant, as the code make get the directory,
        // could have either been attached to the property, or put in the constructor.
        private string _fileDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Quiz");

        public string FileDir { get => _fileDir; }
        public string FileName { get; } = "Questions.json";

        public IO()
        {
            if (!File.Exists(FileDir))
            {
                GUI.Print($"Quiz folder findes ikke. Skaber folder på {FileDir}");
                Thread.Sleep(4000);
                Directory.CreateDirectory(FileDir);

                GUI.Print("En json fil med spørgsmålene til quizzen, skal lægges i folderen.");
                    GUI.Print("Filen skal også navn gives " + FileName,0,0);
            }
        }

        /// <summary>
        /// Checks if the json file exists
        /// </summary>
        private void FileCheck()
        {
            while (true)
            {
                if (!File.Exists(Path.Combine(FileDir, FileName)))
                {
                    GUI.Print("Filen med spørgsmålene findes ikke.");
                    Thread.Sleep(3000);
                    GUI.Print("Enten var ingen blevet lagt i folderen, eller også er den ikke navngivet rigtigt.", 0,4000);
                    GUI.Print("Læg venlist Filen i folderen, inden du fortsætter.", 0,3000);
                    GUI.Print($"Husk at filen skal kaldes \"{FileName}\"",0,0);
                }
                else
                {
                    GUI.Print("Henter Spørgsmålene");
                    Thread.Sleep(3000);
                    return;
                }
            }
        }

        /// <summary>
        /// Loads the Json file
        /// </summary>
        /// <returns></returns>
        public QuestionList FileFetch()
        {
            FileCheck();

            string json = File.ReadAllText(Path.Combine(FileDir, FileName));
            QuestionList quiz = JsonSerializer.Deserialize<QuestionList>(json);
            return quiz;
        }
    }
}
