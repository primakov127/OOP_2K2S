using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_03.Command
{
    class FireCommand : ICommand
    {
        public void Execute() { Fire(); }

        private void Fire()
        {
            Console.WriteLine("Fire");
        }
    }
}
