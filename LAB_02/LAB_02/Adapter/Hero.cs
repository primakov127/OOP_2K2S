using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_02.Adapter
{
    class Hero : IGo
    {
        public Hero(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public void GoDown(int stepsCount)
        {
            Console.WriteLine(stepsCount + " steps down");
        }

        public void GoLeft(int stepsCount)
        {
            Console.WriteLine(stepsCount + " steps left");
        }

        public void GoRight(int stepsCount)
        {
            Console.WriteLine(stepsCount + " steps right");
        }

        public void GoUp(int stepsCount)
        {
            Console.WriteLine(stepsCount + " steps up");
        }
    }
}
