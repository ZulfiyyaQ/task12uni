﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK12
{
    internal class Colored
    {
        using System;

	public static class Colored
	{
        public static void Write(string text, ConsoleColor color=ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ResetColor();
        }

        public static void WriteLine(string text, ConsoleColor color=ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
    

