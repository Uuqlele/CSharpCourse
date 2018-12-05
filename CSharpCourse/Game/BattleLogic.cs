using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{
    /// <summary>
    /// 
    /// </summary>
    public class BattleLogic
    {
        enum BattleActions
        {
            attack,
            defence,
            ability
        }

        public BattleLogic(Character theHero)
        {
            Console.Clear();
            Monster monster = new Monster();
            Console.WriteLine("Битва началась!\n");
            BattleStep(monster, theHero);
        }

        /// <summary>
        /// Рекурсивная функция процесса битвы по шагам. 
        /// </summary>
        /// <param name="monster"></param>
        /// <param name="theHero"></param>
        public void BattleStep(Monster monster, Character theHero)
        {
            if (theHero.HitPoints <= 0) //условие выхода из рекурсии
            {
                Console.WriteLine("Битва окончена.");
                Console.ReadKey();
                Console.Clear();
            }
            else if (monster.HitPoints <= 0)
            {
                Console.WriteLine("Битва окончена.");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                int selected = Menu.CreateMenu($"Герой ({theHero.HitPoints}, {theHero.Damage}) " +
                                        $"против Монстра ({monster.HitPoints}, {monster.Damage})\n" +
                                               "\nВыберите желаемое действие:",
                           new List<string>() {"1. Атаковать.",
                                            "2. Заблокировать удар.",
                                            "3. Применить способность." });
                switch (selected)
                {
                    case (int)BattleActions.attack:
                        monster.HitPoints = theHero.Attack(monster, theHero);
                        theHero.HitPoints = monster.Attack(theHero, monster);
                        break;
                    case (int)BattleActions.ability:
                        theHero.UseAbility(ref monster, ref theHero);
                        theHero.HitPoints = monster.Attack(theHero, monster);
                        break;
                    case (int)BattleActions.defence:
                        break;
                    default:
                        Console.WriteLine("Несуществующая опция.");
                        break;
                }
                BattleStep(monster, theHero); //рекурсивный вызов следующего шага битвы
            }
        }
    }
}
