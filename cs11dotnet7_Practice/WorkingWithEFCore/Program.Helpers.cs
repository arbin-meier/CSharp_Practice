﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithEFCore
{
    partial class Program
    {
        static void SectionTitle(string title)
        {
            ConsoleColor previousColor = ForegroundColor;
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("*");
            WriteLine($"* {title}");
            WriteLine("*");
            ForegroundColor = previousColor;
        }

        static void Fail(string message)
        {
            ConsoleColor previousColor = ForegroundColor;
            ForegroundColor = ConsoleColor.Red;
            WriteLine($"Fail > {message}");
            ForegroundColor = previousColor;
        }

        static void Info(string message)
        {
            ConsoleColor previousColor = ForegroundColor;
            ForegroundColor = ConsoleColor.Cyan;
            WriteLine($"Info > {message}");
            ForegroundColor = previousColor;
        }
    }
}
