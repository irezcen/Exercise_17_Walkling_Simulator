using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie_7
{
    class MoveWest:Move
    {
        public override void Execute(int currentTime)
        {
            if (currentTime > 16 && currentTime < 21)
            {
                Console.WriteLine("Uwaga na słońce");
            }
            Console.WriteLine("Poruszasz się na zachód");
        }
        public override string ToString()
        {
            return "MoveWest";
        }
    }
}
