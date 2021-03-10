﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_03.State
{
    class RunRightState : IHeroState
    {
        public void InputHandler(Hero hero, ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.LeftArrow:
                    Update(hero, new StayState());
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
            return "run right";
        }
    }
}
