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
        static public void Print(string text, int height, int width,ConsoleColor color = ConsoleColor.White, int pause = 0)
        {
            Console.SetCursorPosition(width, height);
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ForegroundColor = ConsoleColor.White;
            exit(pause); 
        }

        static public void Print(string text, int pause = 0)
        {
            Console.Clear();
            Console.SetCursorPosition(15, 2);
            Console.Write(text);
            exit(pause);
        }

        private static void exit(int pause)
        {
            if (pause == 0)
            {
                Console.ReadKey();
            }
            else
            {
                Thread.Sleep(pause);
            }
        }

    }
}
