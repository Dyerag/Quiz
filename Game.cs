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
            

            Program.Intro(Questions);
            Play();
        }

        public void Play()
        {
            int questionNumber = 0;
            "".Print();
            int top = Console.GetCursorPosition().Top;

            foreach (Question item in Questions.Questions)
            {
                GUI.Print(questionNumber + 1.ToString() + "/" + Questions.Questions.Count.ToString(), top);
                item.Ask.Print(0);

                int choice = 0;
                foreach (string option in item.Options)
                    $"{choice+1}. {option}".Print(0);

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:

                        break;
                }

                top = Transition();
            }

        }

        private static int Transition()
        {
            int Line = Console.GetCursorPosition().Top + 2;
            Console.BackgroundColor = ConsoleColor.White;

            Console.SetCursorPosition(0, Line);
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write(" ");
            }

            Console.BackgroundColor = ConsoleColor.Black;
            Line = +2;

            return Line;
        }
    }
}
