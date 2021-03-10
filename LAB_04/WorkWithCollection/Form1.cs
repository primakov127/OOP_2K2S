using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkWithCollection.Command;
using WorkWithCollection.Classes;

namespace WorkWithCollection
{
    public partial class Form1 : Form
    {
        Commands command = new Commands();
        List<Circle> circles;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void generate_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                command.ShowList(listView1, circles = command.generateList(Convert.ToInt32(textBox1.Text)));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            command.SortList(listView1, circles, (a, b) => a.getRadius().CompareTo(b.getRadius()));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            command.SortList(listView1, circles, (a, b) => b.getRadius().CompareTo(a.getRadius()));
        }

        private void min_Click(object sender, EventArgs e)
        {
            command.ShowAnswer(textBox1, circles.Min());
        }

        private void max_Click(object sender, EventArgs e)
        {
            command.ShowAnswer(textBox1, circles.Max());
        }

        private void count_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(circles.Count);
        }
    }
}
