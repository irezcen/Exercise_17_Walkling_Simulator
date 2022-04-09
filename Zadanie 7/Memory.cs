using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie_7
{
    class Memory
    {
        private Stack<Move> moves;
        public Stack<Move> Memorize()
        {
            moves.Clear();
            while (true)
            {
                Console.WriteLine("Gdzie chcesz iść?");
                var key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.W:
                        Console.WriteLine("północ");
                        moves.Push(new MoveNorth());
                        break;
                    case ConsoleKey.S:
                        Console.WriteLine("południe");
                        moves.Push(new MoveSouth());
                        break;
                    case ConsoleKey.A:
                        Console.WriteLine("zachód");
                        moves.Push(new MoveWest());
                        break;
                    case ConsoleKey.D:
                        Console.WriteLine("wschód");
                        moves.Push(new MoveEast());
                        break;
                    case ConsoleKey.Backspace:
                        Console.WriteLine("Pomyłka? Nie ma problemu.");
                        if(moves.Count == 0)
                        {
                            break;
                        }
                        moves.Pop();
                        break;
                    case ConsoleKey.Enter:
                        Console.WriteLine("\nRuszajmy:");
                        var reverseMoves = new Stack<Move>();
                        foreach (Move el in moves)
                        {
                            reverseMoves.Push(el);
                        }
                        return reverseMoves;
                    default:
                        Console.WriteLine("Nie rozumiem...");
                        break;
                }
            }

        }
        public Memory()
        {
            moves = new Stack<Move>();
        }
    }
}
