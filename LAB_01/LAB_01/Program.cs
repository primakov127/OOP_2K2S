using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LAB_01.AbstractArmy;
using LAB_01.Factories;
using LAB_01.Field;

namespace LAB_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n-----------------------AbstractoryFactories pattern-----------------------\n");

            Admin cr = Admin.getInstance();

            Army greekarmy = cr.createArmy(12, 5, 20, new GreekArmyFactory());
            Army romanarmy = cr.createArmy(11, 6, 21, new RomanArmyFactory());

            greekarmy.archers.ElementAt(2).info();
            greekarmy.horsemans.ElementAt(2).info();
            greekarmy.infantrymans.ElementAt(2).info();

            romanarmy.archers.ElementAt(2).info();
            romanarmy.horsemans.ElementAt(2).info();
            romanarmy.infantrymans.ElementAt(2).info();

            Console.WriteLine("\n\n-----------------------Builder pattern-----------------------\n");

            Director director = new Director();
            DesertBuilder desertbuilder = new DesertBuilder();
            Field1Builder field1builder = new Field1Builder();

            director.Builder = desertbuilder;
            director.BuildProduct();
            Console.WriteLine(desertbuilder.GetField().ToString());

            director.Builder = field1builder;
            director.BuildProduct();
            Console.WriteLine(field1builder.GetField().ToString());

            director.Builder = desertbuilder;
            director.BuildProduct();
            BattleField field1 = desertbuilder.GetField();
            Console.WriteLine(field1.ToString());
            BattleField field2 = (BattleField)field1.Clone();
            Console.WriteLine(field2.ToString());

        }
    }
}
