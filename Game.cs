using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
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
            #region Premade variables
            int questionNumber = 1;
            "".Print();
            int top = Console.GetCursorPosition().Top;
            string playerAnswer = string.Empty;
            #endregion
            foreach (Question inqury in Questions.Questions)
            {
                GUI.Print(questionNumber++.ToString() + "/" + Questions.Questions.Count.ToString(), top, 1);
                PlayText(inqury.Ask,1);

                int choice = 1;
                foreach (string option in inqury.Options)
                {
                    $"{choice}. {option}".Print(Console.GetCursorPosition().Top + 2, 500);
                    choice++;
                }

                do
                    switch (Console.ReadKey(true).Key)
                    {
                        case ConsoleKey.D1:
                        case ConsoleKey.NumPad1:
                            playerAnswer = inqury.Options[0];
                            break;

                        case ConsoleKey.D2:
                        case ConsoleKey.NumPad2:
                            playerAnswer = inqury.Options[1];
                            break;

                        case ConsoleKey.D3:
                        case ConsoleKey.NumPad3:
                            playerAnswer = inqury.Options[2];
                            break;

                        default:
                            playerAnswer = string.Empty;
                            break;
                    }
                while (playerAnswer == string.Empty);

                if (playerAnswer == inqury.Answer)
                {
                    inqury.RightChoice.Print(Console.GetCursorPosition().Top + 2, 1000);
                    Questions.TotalCorrectAnswers++;
                }
                else
                    inqury.WrongChoice.Print(Console.GetCursorPosition().Top + 2, 1000);


                PlayText(inqury.Explanation);
                Console.ReadKey(true);
                Transition();

                top = Console.GetCursorPosition().Top + 2;
            }
            Finish();
        }

        /// <summary>
        /// Writes the explanation if a question so it fits in the window.
        /// </summary>
        /// <param name="explain"></param>
        private void PlayText(string explain,int nextLine=2)
        {
            //17 words
            int top = Console.GetCursorPosition().Top+nextLine;
            Queue<string> splitexplanation = new(explain.Split(' '));
            while (splitexplanation.Count > 0)
            {
                GUI.Print(splitexplanation.Dequeue() + " ", top, 1);
                for (int i = 0; i < 10 && splitexplanation.Count > 0; i++)
                    GUI.Print(splitexplanation.Dequeue() + " ", top, 1, Console.GetCursorPosition().Left);

                top++;
            }
        }

        /// <summary>
        /// Makes a clear indication of the split between two questions
        /// </summary>
        /// <returns></returns>
        private static void Transition()
        {
            int Line = Console.GetCursorPosition().Top + 2;

            Console.SetCursorPosition(0, Line);
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("-");
            }

            return;
        }

        private void Finish()
        {
            "Tillyke!".Print(Console.GetCursorPosition().Top+2,1000);
            $"Du svarede {Questions.TotalCorrectAnswers} ud af {Questions.Questions.Count} spørgsmål rigtigt.".Print(0);
            "Tak fordi du spillede".Print(0);
        }
    }
}
