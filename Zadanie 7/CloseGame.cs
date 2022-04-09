using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie_7
{
    class CloseGame
    {
        public void Close()
        {
            Console.WriteLine("Zagraj jeszcze raz>>ENTER\nWyjdź z gry>>ESC");
            var key = Console.ReadKey(true);
            switch (key.Key)
            {
                case ConsoleKey.Enter:
                    Console.WriteLine();
                    break;
                case ConsoleKey.Escape:
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Klawisz nieznany");
                    this.Close();
                    break;
            }
        }
    }
}
