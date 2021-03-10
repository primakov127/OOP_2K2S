using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using LAB_05.Classes;

namespace LAB_05
{
    public partial class Form2 : Form
    {
        List<string> data = new List<string>();
        public Form2(List<Discipline> list)
        {
            InitializeComponent();
            foreach (Discipline item in list)
            {
                data.Add(item.ToString());
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(comboBox1.Text) && !String.IsNullOrEmpty(textBox1.Text))
            {
                switch (comboBox1.Text)
                {
                    case "по Лектору":
                        search(new Regex("Имя лектора:.*" + textBox1.Text));
                        break;
                    case "по Семестру":
                        search(new Regex("Семестр:" + textBox1.Text));
                        break;
                    case "по Курсу":
                        search(new Regex("Курс:" + textBox1.Text));
                        break;
                    default:
                        break;
                }
            }
        }

        private void search(Regex reg)
        {
            label1.Text = "";
            foreach (var str in data)
            {
                if (reg.IsMatch(str))
                    label1.Text += "\n" + str;
            }
        }
    }
}
