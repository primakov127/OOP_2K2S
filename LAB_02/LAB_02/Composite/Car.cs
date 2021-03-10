using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_02.Composite
{
    class Car : IComponent
    {
        private string engine = "carEngine";

        public Car(string title)
        {
            Title = title;
        }


        public string Title { get; set; }

        public void Draw()
        {
            Console.Write(Title + ":" + engine);
        }

        public IComponent Find(string title)
        {
            return this.Title == title ? this : null;
        }
    }
}
