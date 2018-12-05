using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;


namespace CSharpCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(49, 20);
            Console.SetBufferSize(49, 20);
            //try
            //{
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.OutputEncoding = Encoding.UTF8;
                Type typeModule = typeof(Modules);
                MethodInfo[] myArrayMethodInfo = typeModule.GetMethods(); //Получение всех методов класса Modules
                List<string> Exercises = new List<string>();    
                                                                
                for (int i = 0; i < myArrayMethodInfo.Length; i++)
                {
                    Exercises.Add(myArrayMethodInfo[i].Name);
                }

                Exercises.RemoveRange(Exercises.Count - 4, 4); //Убираем 4 класса, которые не являются пользовательскими
                                                               //На самом деле, я просто не знал, как заставить GetMethods возвращать только созданные мною классы

            //Game game = new Game();
            //Menu.Item Item = new Menu.Item(myArrayMethodInfo);
            Menu item = new Menu(Exercises, myArrayMethodInfo);
            Console.ReadKey();
            //}
            //catch
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("Что-то пошло не так, окно сейчас закроется.");
            //    Console.ReadKey();
            //}
        }


    }
}
