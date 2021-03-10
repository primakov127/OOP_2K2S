using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_02.Decorator
{
    abstract class Text
    {
        public string Content { get; set; }

        public Text(string content)
        {
            this.Content = content;
        }
    }
}
