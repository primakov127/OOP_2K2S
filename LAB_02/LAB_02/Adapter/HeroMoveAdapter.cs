using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_02.Adapter
{
    class HeroMoveAdapter : IMoveXY
    {
        private readonly Hero hero;

        public HeroMoveAdapter(Hero hero)
        {
            this.hero = hero;
        }

        public void moveToXY(int x, int y)
        {
            if ( x > 0)
            {
                hero.GoRight(x);
            }
            else if ( x < 0)
            {
                hero.GoLeft(x);
            }

            if (y > 0)
            {
                hero.GoDown(y);
            }
            else if (y < 0)
            {
                hero.GoUp(y);
            }

        }
    }
}
