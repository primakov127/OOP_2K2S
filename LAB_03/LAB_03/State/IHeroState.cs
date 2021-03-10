using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_03.State
{
    interface IHeroState
    {
        void InputHandler(Hero hero, ConsoleKey key);
        void Update(Hero hero, IHeroState newState);
    }
}
