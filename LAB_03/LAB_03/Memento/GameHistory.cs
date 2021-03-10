using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_03.Memento
{
    class GameHistory
    {
        public Stack<Memento> History { get; private set; }
        public GameHistory()
        {
            History = new Stack<Memento>();
        }
    }
}
