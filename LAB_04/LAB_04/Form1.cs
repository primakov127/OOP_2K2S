﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LAB_04.Classes;
using LAB_04.Command;

namespace LAB_04
{
    public partial class Form1 : Form
    {
        Commands command;

        public Form1()
        {
            InitializeComponent();
            command = new Commands(label1, textBox1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            command.commandClear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            command.commandRemove();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            command.inputNumber(8);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            command.inputOperator("/");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            command.inputNumber(1);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text)) { }
            else { command.inputNumber(0); };
        }

        private void button14_Click(object sender, EventArgs e)
        {
            command.inputNumber(2);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            command.inputNumber(3);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            command.inputNumber(4);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            command.inputNumber(5);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            command.inputNumber(6);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            command.inputNumber(7);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            command.inputNumber(9);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            command.inputOperator("+");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            command.inputOperator("-");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            command.equally();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            command.inputOperator("*");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            command.setMemmory();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            command.insertMemmory();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            command.clearMemmory();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            command.changeSign();
        }
    }
}
