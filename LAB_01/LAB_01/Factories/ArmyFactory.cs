using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LAB_01.Warriors;

namespace LAB_01.Factories
{
    abstract class ArmyFactory
    {
        public abstract List<Archer> createArchers(int count);

        public abstract List<Horseman> createHorsemans(int count);

        public abstract List<Infantryman> createInfantrys(int count);
    }
}
