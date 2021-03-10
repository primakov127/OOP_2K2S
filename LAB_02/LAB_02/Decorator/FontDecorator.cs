using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_02.Decorator
{
    class FontDecorator : Decorator
    {
        public FontDecorator(String font, Text text) : base(text.Content + font, text)
        {

        }

    }
}
