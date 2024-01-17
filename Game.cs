using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    /// <summary>
    /// The actual game
    /// </summary>
    public class Game
    {
        public QuestionList Questions { get; set; }
        public Game()
        {
            IO setup = new();
            Questions = setup.FileFetch();
            var text = setup.FileFetch();
            Console.WriteLine(text);
            Program.Intro(Questions);
            Play();

        }
        
        static public void Play()
        {

        }
        

    }
}
