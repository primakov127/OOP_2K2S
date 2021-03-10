using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkWithCollection.Classes;

namespace WorkWithCollection.Command
{
    class Commands
    {

        public List<Circle> generateList(int count)
        {
            List<Circle> circles = new List<Circle>();
            for (var i = 0; i < count; i++)
            {
                System.Threading.Thread.Sleep(50);
                circles.Add(new Circle());
            }
            return circles;
        }

        public void ShowList(ListView list, List<Circle> count)
        {
            list.Clear();
                foreach (Circle item in count)
                {
                    list.Items.Add(item.ToString());
                }
        }

        public void SortList(ListView view, List<Circle> circles, Comparison<Circle> comp)
        {
            if (circles != null)
            {
                circles.Sort(comp);
                ShowList(view, circles);
            }
        }

        public void ShowAnswer(TextBox textBox, Circle circle)
        {
            textBox.Text = Convert.ToString(circle.getRadius());
        }
    }
}
