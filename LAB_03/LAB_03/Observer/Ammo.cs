using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_03.Observer
{
    class Ammo
    {
        public delegate void giveAmmo(int count);
        public event giveAmmo GiveAmmo;

        public void giveAmmoEverybody(int count)
        {
            GiveAmmo?.Invoke(count);
            Console.WriteLine($"Все получили по {count} патронов");
        }
        
    }
}
