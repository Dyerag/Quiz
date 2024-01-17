using System.Security.Principal;


namespace Quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Pre amble
            Console.CursorVisible = false;

            //todo move som of the prints here, to the constructor in game
            GUI.Print("Det her Quiz program får alle spørgsmålene og svarende,");
            Thread.Sleep(2000);
            GUI.Print("ved at indlæse json filen der lægges i den givne folder.",0,2000);
            GUI.Print("Hvis du gerne vil bruge en anden quiz i dette program,", 0, 2000);
            GUI.Print("skal du bare erstatte json filen i folderen, med den nye quiz.",0,2000);
            GUI.Print("Også i json format, og opsat på samme måde", 0);
            #endregion

            #region How to play
            GUI.Print("Du vælger dit svar ved at trykke A, B, eller C.",0);
            GUI.Print("Alternativt kan du også bruge 1, 2, eller 3.", 0);
            GUI.Print("Når du er klar, skal du bare trykke noget for at begynde", 0);
            #endregion

            Game.Play();
        }
    }
}