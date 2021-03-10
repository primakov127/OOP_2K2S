using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_03.State
{
    class Hero
    {
        private IHeroState state = new StayState();

        public Hero(string name)
        {
            Name = name;
        }

        public void Update(ConsoleKey key)
        {
            state.InputHandler(this, key);
        }

        public void ChangeState(IHeroState newState)
        {
            state = newState;
        }

        public string Name { get; set; }

        public void ShowState()
        {
            Console.WriteLine(Name + " " + state.ToString());
        }
    }
}
