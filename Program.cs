using System.Security.Principal;


namespace Quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            new IO();
            GUI.Print("Det her er en Quiz om emnet: ");
            Thread.Sleep(3000);
            // todo Add the Ability to see what the theme of the questions json file is about
            Theme("Vandforbrug!");

            // todo Add the ability to see how many questions there are
            GUI.Print("Quizzen har 6 spørgsmål.");
            Console.ReadKey(true);

            GUI.Print("Du vælger dit svar ved at trykke A, B, eller C.",0);
            GUI.Print("Alternativt kan du også bruge 1, 2, eller 3.", 0);
            GUI.Print("Når du er klar, skal du bare trykke noget for at begynde", 0);
            
            Game.Play();
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