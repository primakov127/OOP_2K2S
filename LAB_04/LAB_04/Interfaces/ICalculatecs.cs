using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_04.Interfaces
{
    interface ICalculatecs
    {
        // Сохранить А
        void SetA(int a);

        void ClearA();

        int Multiplication(int b);

        int Division(int b);

        int Sum(int b);

        int Subtraction(int b);

        void SetMemory(int memory);

        // Показать содержимое регистра памяти
        int MemoryShow();

        // Стереть содержимое регистра памяти
        void MemoryClear();

    }
}
