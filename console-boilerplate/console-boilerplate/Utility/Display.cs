using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console_boilerplate.Utility
{
    class Display
    {
        public static void Print(string text, System.ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);

        }
    }
}
