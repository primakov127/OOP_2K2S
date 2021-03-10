using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_02.Decorator
{
    class ColorDecorator : Decorator
    {
        public ColorDecorator(string color, Text text) : base(text.Content + color, text)
        {

        }

    }
}
