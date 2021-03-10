using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_01.Field
{
    class DesertBuilder : IBuilder
    {
        private BattleField field = new BattleField();

        public DesertBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this.field = new BattleField();
        }

        public void addLend()
        {
            this.field.Add("some lend");
        }

        public void addRiver()
        {
            this.field.Add("Nile river");
        }

        public void addSand()
        {
            this.field.Add("a lot of send");
        }

        public void addSea()
        {
            this.field.Add("sea on the border of the desert");
        }

        public void addTrees()
        {
            this.field.Add("cactus");
        }

        public BattleField GetField()
        {
            BattleField result = this.field;
            this.Reset();
            return result;
        }
    }
}
