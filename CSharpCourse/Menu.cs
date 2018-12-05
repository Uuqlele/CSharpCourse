using System;
using System.Collections.Generic;
using System.Reflection;

namespace CSharpCourse
{

    class Menu
    {

        /// <summary>
        /// Основное динамическое управляемое меню выбора упражнения.
        /// При вызове выводит названия всех доступных упражнений из класса Modules, и через бесконечный цикл ожидает нажатие клавиш выбора упражнения.
        /// </summary>
        /// <param name="names">Строковые названия функций</param>
        /// <param name="methods">Метаданные методов</param>
        public Menu(List<string> names, MethodInfo[] methods)
        {
            ConsoleKey key;
            int selected = 0;

            names.Add("The Game");

            while (true)
            {
                string mainTitle = "Курс C#\n";
                int width = Console.WindowWidth;
                int padding = width / 2 + mainTitle.Length / 2;
                Console.WriteLine("{0," + padding + "}", mainTitle);
                Console.ForegroundColor = ConsoleColor.White;
                for (int i = 0; i < names.Count; i++)
                {
                    padding = width / 2 + names[i].Length / 2; //Расчёт отступа от левого края консоли для центрирования пункта меню
                    if (i == selected) 
                    {
                        if (i == names.Count - 1) //Отображение последнего выбранного элемента
                        {
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("\n{0," + padding + "}\t\t{1}", names[i], names[i].Length < 16 ? "\t" : "");
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else //Отображение выбранного элемента
                        {
                            Console.BackgroundColor = ConsoleColor.DarkCyan;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("{0," + padding + "}\t\t{1}", names[i], names[i].Length < 16 ? "\t" : "");
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                    else
                    {
                        if (i == names.Count - 1) //Отображение последнего элемента
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\n{0," + padding + "}\t\t", names[i]);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else //Отображение не выбранных элементов
                        {
                            Console.WriteLine("{0," + padding + "}", names[i]); 
                        }
                    }
                } //Форматированый вывод и внешний вид элементов управления

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("\n  Вверх - ↑, Вниз - ↓, Выбор упражнения - Enter\n");
                key = Console.ReadKey().Key;
                Console.Clear();
                selected = MenuLogic(selected, key, names);
                if (key == ConsoleKey.Enter)
                {
                    if (names[selected] == "The Game")
                    {
                        Game game = new Game();
                    }
                    else
                    {
                        methods[selected].Invoke(methods, null);
                        Console.Clear();
                    }
                }
            }
        }

        /// <summary>
        /// Функция создающая управляемое меню. Возвращает выбранный пункт. Первый пункт имеет нулевой индекс.
        /// </summary>
        /// <param name="title">Заголовок меню</param>
        /// <param name="names">Список пунктов меню</param>
        /// <returns>Номер выбранного пункта</returns>
        public static int CreateMenu(string title, List<string> names)
        {
            ConsoleKey key;
            int selected = 0;
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(title + "\n");
                Console.ForegroundColor = ConsoleColor.White;
                for (int i = 0; i < names.Count; i++)
                {
                    if (i == selected) //Отображение выбранного элемента
                    {
                        Console.BackgroundColor = ConsoleColor.DarkCyan;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine(names[i]);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else Console.WriteLine(names[i]);
                }

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("\nВверх - ↑, Вниз - ↓, Выбор пункта - Enter\n");
                key = Console.ReadKey().Key;
                Console.Clear();

                selected = MenuLogic(selected, key, names);
                if (key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    return selected;
                }
            }
        }

        /// <summary>
        /// Логика определения выбранного элемента через нажатие стрелок.
        /// </summary>
        /// <param name="selected">Прошлый выбранный пункт</param>
        /// <param name="key">Нажатая кнопка</param>
        /// <param name="names">Список пунктов</param>
        /// <returns>Выбранный пункт</returns>
        private static int MenuLogic(int selected, ConsoleKey key, List<string> names)
        {
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    if (selected == 0) //Если выбран нулевой элемент - перейти на последний элемент массива
                    {
                        selected = names.Count - 1;
                        return selected;
                    }
                    else //Во всех остальных случаях выбрать предыдущий элемент
                    {
                        selected--;
                        return selected;
                    }
                case ConsoleKey.DownArrow:
                    if (selected == names.Count - 1) //В случае, если элемент является последним - перейти на первый элемент
                    {
                        selected = 0;
                        return selected;
                    }
                    else //В остальных случаях - перейти на следующий элемент
                    {
                        selected++;
                        return selected;
                    }
                default: return selected;
            }
        }
    }
}
