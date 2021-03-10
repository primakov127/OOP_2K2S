using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_03.Command
{
    class JumpCommand : ICommand
    {
        public void Execute() { Jump(); }

        private void Jump()
        {
            Console.WriteLine("Jump");
        }
    }
}
