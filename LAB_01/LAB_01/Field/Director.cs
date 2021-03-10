using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_01.Field
{
    class Director
    {
        private IBuilder builder;

        public IBuilder Builder
        {
            set { this.builder = value; }
        }

        public void BuildProduct()
        {
            this.builder.addLend();
            this.builder.addRiver();
            this.builder.addSand();
            this.builder.addSea();
            this.builder.addTrees();
        }
    }
}
