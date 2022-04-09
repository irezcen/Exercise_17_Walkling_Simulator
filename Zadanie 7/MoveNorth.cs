using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie_7
{
    class MoveNorth:Move
    {
        public override void Execute(int currentTime)
        {
            if (currentTime > 20 || currentTime < 6)
            {
                Console.WriteLine("Piękny księżyc świeci tej nocy");
            }
            Console.WriteLine("Poruszasz się na północ");
        }
        public override string ToString()
        {
            return "MoveNorth";
        }
    }
}
