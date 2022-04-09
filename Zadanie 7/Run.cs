using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie_7
{
    class Run
    {
        private Simulator simulator;
        private CloseGame close;
        public void StartSimulation()
        {
            while (true)
            {
                Console.WriteLine("Witaj w moim symulatorze chodzenia. Poruszanie przy pomocy WASD, Zatwierdź>>enter, cofnij>>BACKSPACE");
                simulator.Memorize();
                simulator.PerformAction();
                simulator.SaveToTXT();
                close.Close();
            }
        }
        public Run()
        {
            simulator = new Simulator();
            close = new CloseGame();
        }
    }
}
