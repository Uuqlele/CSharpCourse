using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{
    public class Character
    {
        public enum Roles
        {
            warrior,
            magician,
            thief,
        }
        public int HitPoints { get; set; }
        public int Damage { get; set; }
        public int Exp = 0;
        public int Level = 1;
        public Roles Role = 0;

        public Character()
        {
            CreateCharacter();
        }

        public void CreateCharacter()
        {
            Console.Clear();
            int roleMenu = Menu.CreateMenu("Выберите персонажа (хп/урон):",
                new List<string>() { "1. Воин (25/4)",
                                     "2. Маг (15/6)",
                                     "3. Вор (20/5)" });
            switch (roleMenu)
            {
                case (int)Roles.warrior:
                    Role = Roles.warrior;
                    HitPoints = 25;
                    Damage = 4;
                    break;
                case (int)Roles.magician:
                    Role = Roles.magician;
                    HitPoints = 15;
                    Damage = 6;
                    break;
                case (int)Roles.thief:
                    Role = Roles.thief;
                    HitPoints = 20;
                    Damage = 5;
                    break;
                default:
                    Console.WriteLine("Несуществующая опция.");
                    break;
            }
            Console.WriteLine($"Создан персонаж! Его характеристики: {HitPoints} хп, {Damage} урон.");
        }

        public int Experience(int exp, int level)
        {
            return level;
        }

        /// <summary>
        /// Используется в битве. 
        /// Принимает на вход ХП противника, вычитает из него урон нашего героя и возвращает ХП противника.
        /// </summary>
        /// <param name="enemyHP">ХП противника</param>
        /// <returns>ХП противника</returns>
        public int Attack(Monster monster)
        {
            monster.HitPoints -= Damage;
            Console.Write("Вы атаковали монстра и нанесли {0} урона. \nЗдоровье монстра: ", Damage);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("{0}", monster.HitPoints);
            Console.ForegroundColor = ConsoleColor.Red;
            return monster.HitPoints;
        }

        public void UseAbility(ref Monster monster)
        {
            switch (Role)
            {
                case (int)Roles.warrior: //Сильная атака
                    monster.HitPoints -= Damage * 2;
                    Console.Write("Вы атакуете монстра на {0} дмг. \nЗдоровье монстра: ", Damage * 2);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("{0}", monster.HitPoints);
                    Console.ReadLine();
                    break;
                case Roles.magician: //Вылечить себя
                    HitPoints += Damage / 2;
                    Console.Write("Вы лечите себя на {0} хп. \nВаше здоровье: ", Damage / 2);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("{0}", HitPoints);
                    Console.ReadLine();
                    break;
                case Roles.thief:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Вор пока что ничего не умеет :)\n");
                    break;
                default:
                    Console.WriteLine("Несуществующая опция.");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
