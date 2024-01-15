using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    static public class GUI
    {
        static public void Print(string text, int height,  int pause = 0, int width = 15, ConsoleColor color = ConsoleColor.White)
        {
            if (height == 0)
                height = Console.GetCursorPosition().Top + 1;

            Console.SetCursorPosition(width, height);
            Console.ForegroundColor = color;

            Console.Write(text);
            Console.ForegroundColor = ConsoleColor.White;
            
            if (pause == 0)
            {
                Console.ReadKey(true);
            }
            else
            {
                Thread.Sleep(pause);
            }
        }

        /// <summary>
        /// Clears the window, aswell as set the cursor position to it's default
        /// </summary>
        /// <param name="text"></param>
        static public void Print(string text)
        {
            Console.Clear();
            Console.SetCursorPosition(15, 2);
            Console.Write(text);
        }
    }
}
