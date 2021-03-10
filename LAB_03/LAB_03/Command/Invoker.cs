using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_03.Command
{
    class Invoker
    {
        private ICommand command;

        public Invoker(ICommand command)
        {
            SetCommand(command);
        }

        public void SetCommand(ICommand command)
        {
            this.command = command;
        }

        public void DoSmth()
        {
            command.Execute();
        }
    }
}
