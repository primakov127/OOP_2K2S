using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LAB_10
{
    public class MyCommands
    {
        private static RoutedUICommand exit;

        static MyCommands()
        {
            InputGestureCollection inputs = new InputGestureCollection();
            inputs.Add(new KeyGesture(Key.E, ModifierKeys.Control, "Ctrl + E"));
            exit = new RoutedUICommand("Exit", "Exit", typeof(MyCommands), inputs);
        }

        public static RoutedUICommand Requery
        {
            get { return exit; }
        }
    }
}
