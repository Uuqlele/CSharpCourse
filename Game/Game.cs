using System;
using System.Collections.Generic;

namespace CSharpCourse
{
    class Game
    {
        public enum MenuActions
        {
            createHero,
            exit,
            thirdMenuPoint,
            fourthMenuPoint
        }

        private Character TheHero { get; set; }
        public int selected = 0;
        
        /// <summary>
        /// Точка старта игры.
        /// </summary>
        public Game()
        {
            StartGame();
            MainAction();
        }

        /// <summary>
        /// Старт игры. На данный момент можно лишь выйти и создать персонажа.
        /// </summary>
        public void StartGame()
        {
            while (true)
            {
                selected = Menu.CreateMenu("Игра началась, выберите желаемое действие:",
                    new List<string>() { "1. Создать персонажа",
                                         "2. Выйти" });
                switch (selected)
                {
                    case (int)MenuActions.createHero:
                        TheHero = new Character();
                        break;
                    case (int)MenuActions.exit:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Несуществующая опция.");
                        break;
                }
                break;
            }
        }

        /// <summary>
        /// Функция основного действия персонажа. Можно либо начать битву, либо выйти.
        /// </summary>
        public void MainAction()
        {
            while (true)
            {
                while (true)
                {
                    Console.Clear();
                    selected = Menu.CreateMenu("Выберите желаемое действие:",
                        new List<string>() { "1. Начать бой",
                                             "2. Выйти" });
                    switch (selected)
                    {
                        case 0:
                            BattleLogic battle = new BattleLogic(TheHero);
                            break;
                        case 1:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Несуществующая опция.");
                            break;
                    }
                    break;
                }
                if (TheHero.HitPoints <= 0)
                {
                    break;
                }
            }
        }
    }
}
