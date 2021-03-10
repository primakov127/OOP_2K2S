using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace LAB_04.Command
{
    class Commands
    {
        private string memmory = "";
        private DataTable table = new DataTable();
        private Label label;
        private TextBox textBox;
        private bool isAnswer = false;

        public Commands(Label label, TextBox textBox)
        {
            this.label = label;
            this.textBox = textBox;
        }

        // Очиста всех полей
        public void commandClear()
        {
            label.Text = "";
            textBox.Text = "";
            this.isAnswer = false;
        }

        // Удаление последнего символа вводимого числа
        public void commandRemove()
        {
            if (!String.IsNullOrEmpty(textBox.Text))
            {
                textBox.Text = textBox.Text.Remove(textBox.Text.Count() - 1);
            }
        }

        public void inputNumber(int number)
        {
            if (isAnswer)
            {
                commandClear();
            }
            textBox.Text += number;
        }

        public void inputOperator(string oper)
        {
            if (!String.IsNullOrEmpty(textBox.Text) && !isAnswer)
            {
                label.Text += $"{textBox.Text} {oper} ";
                textBox.Text = "";
            }
        }

        public void equally()
        {
            if (!isAnswer && !String.IsNullOrEmpty(label.Text))
            {
                if (!String.IsNullOrEmpty(textBox.Text))
                {
                    label.Text += textBox.Text;
                }
                else
                {
                    label.Text = label.Text.Remove(label.Text.Count() - 3);
                }
                try
                {
                    textBox.Text = Convert.ToString(table.Compute(label.Text, string.Empty));
                    label.Text += " =";
                }
                catch (Exception e)
                {
                    textBox.Text = e.Message;
                }
                isAnswer = true;
            }
        }

        public void setMemmory()
        {
            if (!String.IsNullOrEmpty(textBox.Text))
            {
                this.memmory = textBox.Text;
                textBox.Text = "";
            }
            if (isAnswer) { commandClear(); }
        }

        public void insertMemmory()
        {
            if (!String.IsNullOrEmpty(this.memmory))
            {
                textBox.Text = memmory;
            }
        }

        public void clearMemmory()
        {
            this.memmory = "";
        }

        public void changeSign()
        {
            if (!isAnswer && !String.IsNullOrEmpty(textBox.Text))
            {
                textBox.Text = Convert.ToString((Convert.ToInt32(textBox.Text) * -1));
            }
        }
    }
}
