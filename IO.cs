using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class IO
    {
        private string _filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Questions");

        public string? FilePath { get =>_filePath; }

        public IO()
        {
            if(!File.Exists(FilePath))
                Directory.CreateDirectory(FilePath);
        }
    }
}
