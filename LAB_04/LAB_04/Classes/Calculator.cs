using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LAB_04.Interfaces;

namespace LAB_04.Classes
{
    class Calculator : ICalculatecs
    {
        private int a = 0;
        private int memory = 0;

        public void SetA(int a)
        {
            this.a = a;
        }

        public void ClearA()
        {
            this.a = 0;
        }

        public int Division(int b)
        {
            return a / b;
        }

        public void SetMemory(int memory)
        {
            this.memory = memory;
        }

        public int MemoryShow()
        {
            return this.memory;
        }

        public void MemoryClear()
        {
            this.memory = 0;
        }

        public int Multiplication(int b)
        {
            return a * b;
        }

        public int Subtraction(int b)
        {
            return a - b;
        }

        public int Sum(int b)
        {
            return a + b;
        }
    }
}
