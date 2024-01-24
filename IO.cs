using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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
        // This field is technically reduntant, as the code for the directory could have either been attached to the property,
        // or put in the constructor, But i'll leave it here anyway
        private string _fileDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Quiz spørgsmål");

        public string FileDir { get => _fileDir; }
        // todo maybe let the program grab any json file in the folder, instead of having to give it a dedicated name
        // todo have the program check if the file is valid for the quiz

        public IO()
        {
            if (!Directory.Exists(FileDir))
            {
                GUI.Print($"Quiz folder findes ikke. Skaber folder på {FileDir}");
                Thread.Sleep(4000);
                Directory.CreateDirectory(FileDir);

                GUI.Print("En json fil med spørgsmålene til quizzen, skal lægges i folderen.");
                Thread.Sleep(2000);
            }
        }

        /// <summary>
        /// Loads the Json file
        /// </summary>
        /// <returns></returns>
        public QuestionList FileFetch()
        {
            FileCheck();

            string json = File.ReadAllText(FileChoose());
            return JsonSerializer.Deserialize<QuestionList>(json);
        }

        /// <summary>
        /// Checks if the json file exists
        /// </summary>
        private void FileCheck()
        {

            for (int i = 0; i < 5; i++)
            {
                List<string> Files = new(Directory.GetFiles(FileDir));
                //just to check wether its the second time it's trying to find the files
                bool check = false;
                if (Files.Count == 0)
                {
                    GUI.Print("Spørgsmålene findes ikke i folderen.");
                    Thread.Sleep(2000);
                    GUI.Print("Enten var ingen blevet lagt i, eller .", 0, 2000);
                    GUI.Print("Læg venlist Filen i folderen, inden du fortsætter.", 0, 2000);
                    GUI.Print($"den ligger i {_fileDir}", 0, 0);

                    check = true;
                }
                else
                {
                    if (check)
                    {
                        GUI.Print("Henter Spørgsmålene");
                        Thread.Sleep(2000);
                    }
                    
                    return;
                }
            }

            GUI.Print("Det ser ud til at noget er galt. programmet bliver derfor lukket");
            Environment.Exit(0);
        }

        //Todo allow the program to randomly choose with json file to use when theres multiple in the folder
        /// <summary>
        /// Randomly chooses the quiz
        /// </summary>
        /// <returns></returns>
        private string FileChoose()
        {
            Random rnd = new();
            List<string> files = new(Directory.GetFiles(FileDir));

            return files[rnd.Next(0,files.Count)];
        }
    }
}
