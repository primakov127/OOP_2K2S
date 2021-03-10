using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LAB_01.Warriors;
using LAB_01.Warriors.Greek_Warriors;

namespace LAB_01.Factories
{
    class GreekArmyFactory : ArmyFactory
    {
        public override List<Archer> createArchers(int count)
        {
            List<Archer> archers = new List<Archer>();
            for (var i = 0; i < count; i++)
            {
                archers.Add(new GreekArcher());
            }
            return archers;
        }

        public override List<Horseman> createHorsemans(int count)
        {
            List<Horseman> horsemans = new List<Horseman>();
            for (var i = 0; i < count; i++)
            {
                horsemans.Add(new GreekHorseman());
            }
            return horsemans;
        }

        public override List<Infantryman> createInfantrys(int count)
        {
            List<Infantryman> infantrymans = new List<Infantryman>();
            for (var i = 0; i < count; i++)
            {
                infantrymans.Add(new GreekInfantryman());
            }
            return infantrymans;
        }
    }
}
