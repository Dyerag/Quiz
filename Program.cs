﻿using System.Security.Principal;


namespace Quiz
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Preamble
            Console.CursorVisible = false;
            ConsoleKey choice;

            GUI.Print("Den her Quiz får alle spørgsmålene og svarende,");
            Thread.Sleep(2000);
            GUI.Print("ved at indlæse json filer der lægges i den givne folder.", 0, 2000);
            GUI.Print("Hvis du gerne vil bruge en anden quiz i dette program,", 0, 2000);
            GUI.Print("skal du bare erstatte json filen i folderen, med den nye quiz.", 0, 2000);
            GUI.Print("Filen skal både være i json format, og opsat på samme måde som vandforbugs spørgsmålene.", 0);
            #endregion

            #region How to play
            GUI.Print("Du vælger dit svar ved at trykke 1, 2, eller 3.");
            Thread.Sleep(2000);
            GUI.Print("Når du er klar, skal du bare trykke noget for at begynde", 0);
            #endregion

            #region The main game
            do
            {
                new Game();
                GUI.Print("Spil igen?");
                GUI.Print("J/N", 0, 1);

                do
                    choice = Console.ReadKey(true).Key;
                while (choice != ConsoleKey.J && choice != ConsoleKey.N);
            } while (choice == ConsoleKey.J);
            #endregion
        }

        /// <summary>
        /// Tells the users the Theme and number of questions
        /// </summary>
        public static void Intro(QuestionList Questions)
        {
            GUI.Print("Det her er en Quiz om emnet: ");
            GUI.Print("Quizzens emne er: ");
            Thread.Sleep(3000);
            Theme(Questions.Theme);

            GUI.Print($"Quizzen har {Questions.Questions.Count} spørgsmål.");
            Thread.Sleep(1000);
            GUI.Print("Klar?", 0);
        }

        /// <summary>
        /// Gives the quiz theme output the flicker
        /// </summary>
        /// <param name="name"></param>
        private static void Theme(string name)
        {
            int height = Console.GetCursorPosition().Top, width = Console.GetCursorPosition().Left;

            for (int i = 0; i < 15; i++)
            {
                GUI.Print(name, height, 100, width, ConsoleColor.Red);
                GUI.Print(name, height, 100, width, ConsoleColor.Yellow);
            }
        }
    }
}