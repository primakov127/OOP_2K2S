using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LAB_01.Factories;
using LAB_01.AbstractArmy;

namespace LAB_01
{
    class Admin
    {
        private static Admin instance;

        private Admin() { }

        public static Admin getInstance()
        {
            if (instance == null)
                return new Admin();
            return instance;
        }

        public Army createArmy(int ArchersCount, int HorsemanCount, int InfantrymanCount, ArmyFactory army)
        {
            return new Army(army.createArchers(ArchersCount), army.createHorsemans(HorsemanCount), army.createInfantrys(InfantrymanCount));
        }
    }
}
