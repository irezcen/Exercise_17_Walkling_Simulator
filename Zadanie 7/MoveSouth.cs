using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie_7
{
    class MoveSouth:Move
    {
        public override void Execute(int currentTime)
        {
            if (currentTime > 10 && currentTime < 16)
            {
                Console.WriteLine("Uwaga na słońce");
            }
            Console.WriteLine("Poruszasz się na południe");
        }
        public override string ToString()
        {
            return "MoveSouth";
        }
    }
}
