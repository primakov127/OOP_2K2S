using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LAB_03.State;

namespace LAB_03.Memento
{
    class Memento
    {
        public int Patrons { get; private set; }
        public int Lives { get; private set; }

        public Memento(int patrons, int lives)
        {
            this.Patrons = patrons;
            this.Lives = lives;
        }
    }
}
