using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class IO
    {
        // This field is technically reduntant, as the code make get the directory,
        // could have either been attached to the property, or put in the constructor.
        private string _filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Questions");

        public string? FilePath { get => _filePath; }

        public IO()
        {
            if (!File.Exists(FilePath))
            {
                //todo notify user that the folder has been made, and they need to put a file in it. Aswell as what to name th file
                Directory.CreateDirectory(FilePath);
            }
        }
    }
}
