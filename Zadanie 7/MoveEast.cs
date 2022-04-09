using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie_7
{
    class MoveEast:Move
    {
        public override void Execute(int currentTime)
        {
            if(currentTime >5 && currentTime < 11)
            {
                Console.WriteLine("Uwaga na słońce");
            }
            Console.WriteLine("Poruszasz się na wschód");
        }
        public override string ToString()
        {
            return "MoveEast";
        }
    }
}
