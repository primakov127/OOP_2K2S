using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithCollection.Classes
{
    class Circle : IComparable<Circle>
    {
        private int radius;
        private Random rand = new Random((int)DateTime.Now.Ticks);
        
        public Circle()
        {
            this.radius = rand.Next(1, 40);
        }

        public int CompareTo(Circle obj)
        {
            if (this.getRadius() > obj.getRadius())
                return 1;
            if (this.getRadius() < obj.getRadius())
                return -1;
            else
                return 0;
        }

        public int getRadius()
        {
            return this.radius;
        }

        public override string ToString()
        {
            return $"Радиус круга = {radius}";
        }
    }
}
