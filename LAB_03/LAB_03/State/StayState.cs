using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_03.State
{
    class StayState : IHeroState
    {
        public void InputHandler(Hero hero, ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    Update(hero, new JumpState());
                    break;
                case ConsoleKey.DownArrow:
                    Update(hero, new DownState());
                    break;
                case ConsoleKey.RightArrow:
                    Update(hero, new RunRightState());
                    break;
                case ConsoleKey.LeftArrow:
                    Update(hero, new RunLeftState());
                    break;
                default:
                    break;

            }
        }

        public void Update(Hero hero, IHeroState newState)
        {
            hero.ChangeState(newState);
        }

        public override string ToString()
        {
            return "stay";
        }
    }
}
