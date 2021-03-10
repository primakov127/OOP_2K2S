using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_02.Decorator
{
    class TextHasDescription : Text
    {
        public TextHasDescription(string content, string description) : base(content + " | description: " + description)
        {
        }

    }
}
