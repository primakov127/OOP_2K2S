using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LAB_03.Command;
using LAB_03.State;
using LAB_03.Memento;
using LAB_03.Observer;

namespace LAB_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Command
            var KeyJ = new Invoker(new JumpCommand());
            var KeyF = new Invoker(new FireCommand());
            ConsoleKeyInfo key;
            while (true)
            {
                key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.J:
                        KeyJ.DoSmth();
                        break;
                    case ConsoleKey.F:
                        KeyF.DoSmth();
                        break;
                    default:
                        break;
                }
                if (key.Key == ConsoleKey.Escape)
                    break;
            }

            //  State
            Hero hero = new Hero("Max");
            ConsoleKeyInfo keyInfo;
            while (true)
            {
                keyInfo = Console.ReadKey(true);
                hero.Update(keyInfo.Key);
                hero.ShowState();
                if (keyInfo.Key == ConsoleKey.Escape)
                    break;

            }

            //  Memento
            Player player = new Player("Max");
            player.Shoot();
            GameHistory game = new GameHistory();
            game.History.Push(player.SaveState());
            player.Shoot();
            player.RestoreState(game.History.Pop());
            player.Shoot();

            //  Observer
            Ammo ammo = new Ammo();
            Player newPlayer = new Player("Danil");
            ammo.GiveAmmo += player.getAmmo;
            ammo.GiveAmmo += newPlayer.getAmmo;
            player.Shoot();
            newPlayer.Shoot();
            ammo.giveAmmoEverybody(10);
            player.Shoot();
            newPlayer.Shoot();
        }
    }
}
