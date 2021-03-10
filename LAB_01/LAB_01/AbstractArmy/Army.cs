using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LAB_01.Warriors;

namespace LAB_01.AbstractArmy
{
    class Army
    {
        public List<Archer> archers;
        public List<Horseman> horsemans;
        public List<Infantryman> infantrymans;

        public Army(List<Archer> archers, List<Horseman> horsemans, List<Infantryman> infantrymans)
        {
            this.archers = archers;
            this.horsemans = horsemans;
            this.infantrymans = infantrymans;
        }
    }
}
