﻿using System;

namespace helloWorld
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\nWhat is your name? ");             var name = Console.ReadLine();             var date = DateTime.Now;             Console.WriteLine($"\nHello, {name} , on {date:d}  at {date:t} !");             Console.Write("\nPress any key to exit...");             Console.ReadKey(true);        }
    }
}
