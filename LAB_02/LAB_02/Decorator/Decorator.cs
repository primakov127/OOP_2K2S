using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_02.Decorator
{
    abstract class Decorator : Text
    {
        protected Text text;

        public Decorator(string content,Text text) : base(content)
        {
            this.text = text;
        }
    }
}
