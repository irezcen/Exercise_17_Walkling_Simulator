using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Zadanie_7
{
    class Simulator
    {
        private Memory memory;
        private PerformAction performAction;
        private Stack<Move> moves;
        public void Memorize()
        {
            moves = memory.Memorize();
        }
        public void PerformAction()
        {
            performAction = new PerformAction();
            performAction.Action(moves);
        }
        public void SaveToTXT()
        {
            var movesToTxt = new List<string>();
            foreach(Move el in moves)
            {
                movesToTxt.Add(el.ToString());
            }
            File.WriteAllLines("log.txt", movesToTxt);
        }
        public Simulator()
        {
            memory = new Memory();
        }
    }
}
