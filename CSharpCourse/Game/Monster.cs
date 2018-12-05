using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{
    public class Monster
    {
        public int HitPoints { get; set; }
        public int Damage { get; set; }

        /// <summary>
        /// Монстр имеет ХП и ДМГ, которые при создании задаются в некотором промежутке рандомно.
        /// </summary>
        public Monster()
        {
            Random random = new Random();
            HitPoints = random.Next(5, 15);
            Damage = random.Next(1, 5);
            Console.WriteLine("Создан монстр, его хп и урон: {0}, {1}", HitPoints, Damage);
        }
        /// <summary>
        /// Функция используемая в битве. 
        /// На вход получает нашего героя и созданного перед битвой монстра, вычитает из него урон монстра и возвращает ХП героя.
        /// </summary>
        /// <param name="enemyHP"></param>
        /// <returns></returns>
        public int Attack(Character theHero, Monster monster)
        {
            theHero.HitPoints -= monster.Damage;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Монстр атаковует вас и наносит {0} урона. \nВаше здоровье: ", monster.Damage, theHero.HitPoints);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("{0}", theHero.HitPoints);

            return theHero.HitPoints;
        }
    }
}
