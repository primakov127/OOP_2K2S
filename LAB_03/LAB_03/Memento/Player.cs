using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_03.Memento
{
    class Player
    {
        private string name;
        private int patrons = 10; // кол-во патронов
        private int lives = 5; // кол-во жизней

        public Player(string name)
        {
            this.name = name;
        }

        public void Shoot()
        {
            if (patrons > 0)
            {
                patrons--;
                Console.WriteLine($"{name} | Производим выстрел. Осталось {patrons} патронов");
            }
            else
                Console.WriteLine($"{name} | Патронов больше нет");
        }
        // сохранение состояния
        public Memento SaveState()
        {
            Console.WriteLine($"{name} | Сохранение игры. Параметры: {patrons} патронов, {lives} жизней");
            return new Memento(patrons, lives);
        }

        // восстановление состояния
        public void RestoreState(Memento memento)
        {
            this.patrons = memento.Patrons;
            this.lives = memento.Lives;
            Console.WriteLine($"{name} | Восстановление игры. Параметры: {patrons} патронов, {lives} жизней");
        }

        public void getAmmo(int count)
        {
            this.patrons += count;
        }
    }
}
