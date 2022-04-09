using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie_7
{
    class PerformAction
    {
        int currentTime;
        public void Action(Stack<Move> moves)
        {
            foreach (Move el in moves)
            {
                el.Execute(currentTime);
            }
            Console.WriteLine();
        }
        public PerformAction()
        {
            var rand = new Random();
            currentTime = rand.Next(0, 23);
        }
    }
}
