using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_01.Field
{
    class Field1Builder : IBuilder
    {
        private BattleField field = new BattleField();

        public Field1Builder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this.field = new BattleField();
        }

        public void addLend()
        {
            this.field.Add("a lot of lend");
        }

        public void addRiver()
        {
            this.field.Add("Dnepr river");
        }

        public void addSand()
        {
            this.field.Add("some sand in some places");
        }

        public void addSea()
        {
            
        }

        public void addTrees()
        {
            this.field.Add("many trees");
        }

        public BattleField GetField()
        {
            BattleField result = this.field;
            this.Reset();
            return result;
        }
    }
}
