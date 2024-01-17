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

        }
        // todo add a constructor, that writes the stuff from the beginning of the code, most likely by pointing to another method
        // Todo have the constructor setup the questionlist object
        static public void Play()
        {

        }
        
        internal void intro()
        {
            GUI.Print("Det her er en Quiz om emnet: ");
            Thread.Sleep(3000);
            // todo Add the Ability to see what the theme of the questions json file is about
            Theme("Vandforbrug!");

            // todo Add the ability to see how many questions there are
            GUI.Print("Quizzen har 6 spørgsmål.");
            Console.ReadKey(true);
        }

        /// <summary>
        /// Gives the quiz theme the flicker
        /// </summary>
        /// <param name="name"></param>
        static private void Theme(string name)
        {
            int height = Console.GetCursorPosition().Top, width = Console.GetCursorPosition().Left;

            for (int i = 0; i < 15; i++)
            {
                GUI.Print(name, height, width, 100, ConsoleColor.Red);
                GUI.Print(name, height, width, 100, ConsoleColor.Yellow);
            }
        }
    }
}
