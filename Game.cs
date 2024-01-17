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
        public QuestionList GameQuestions { get; set; }
        public Game()
        {
            IO setup = new();
            GameQuestions = setup.FileFetch();
            var text = setup.FileFetch();
            Console.WriteLine(text);
            Program.Intro(GameQuestions);
            Play();

        }
        
        // Todo have the constructor setup the questionlist object
        static public void Play()
        {

        }
        

    }
}
