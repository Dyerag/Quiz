using System.Security.Principal;


namespace Quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            GUI.Print("Det her er en Quiz om emnet: ");
            Thread.Sleep(3000);
            //todo add the Ability to see what the questions in the json file is about, to desplay here
            Theme("Vandforbrug!");
            GUI.Print("Quizen har 6 spørgsmål");
            



        }

        static private void Theme(string name)
        {
            int height = Console.GetCursorPosition().Top, width = Console.GetCursorPosition().Left;
            for (int i = 0; i < 20; i++)
            {
                GUI.Print(name,height,width, ConsoleColor.Green);
                Thread.Sleep(100);
                GUI.Print(name,height,width, ConsoleColor.Yellow);
                Thread.Sleep(100);
            }
        }
    }
}