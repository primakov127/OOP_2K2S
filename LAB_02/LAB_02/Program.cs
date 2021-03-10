using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LAB_02.Adapter;
using LAB_02.Decorator;
using LAB_02.Composite;

namespace LAB_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Adapter
            Hero max = new Hero("Maxim");
            HeroMoveAdapter maxA = new HeroMoveAdapter(max);
            maxA.moveToXY(14, 5);

            //  Decorator
            Text text1 = new TextHasDescription("Simple sentence", "some description");
            text1 = new ColorDecorator(" | color: RED", text1);
            text1 = new FontDecorator(" | font: Times New Roman" ,text1);
            Console.WriteLine(text1.Content);
            

            //  Composite
            var obj1 = new Car("car1");
            var obj2 = new Window("window1");
            var obj3 = new Door("door1");
            var obj4 = new Window("window2");
            var map = new Map();
            map.AddComponent(obj1);
            map.AddComponent(obj2);
            map.AddComponent(obj3);
            map.AddComponent(obj4);
            map.Draw();
            Console.WriteLine(map.Find("door1") != null ? map.Find("door1").Title : "Not found");
        }
    }
}
