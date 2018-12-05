using System;


namespace CSharpCourse
{
    class Modules
    {
        /// <summary>
        /// Упражнение 1. Запрашивает два числа, сравнивает их и выводит в консоль результат сравнения.
        /// </summary>
        public static void ComparisonOfNumbers()
        {
            Console.WriteLine("Упражнение 1. Запрашивает два числа, сравнивает их и выводит в консоль результат сравнения.\n" +
                "\nEnter two numbers to compare:");
            int FirstNumber = Convert.ToInt32(Console.ReadLine()),
                SecondNumber = Convert.ToInt32(Console.ReadLine());
            if (FirstNumber < SecondNumber)
                Console.WriteLine("The first number ({0}) is less than the second ({1}).", FirstNumber, SecondNumber);
            else if (FirstNumber > SecondNumber)
                Console.WriteLine("The first number ({0}) is higher than the second ({1}).", FirstNumber, SecondNumber);
            else Console.WriteLine("Two numbers are equal.");
            Console.ReadLine();
        }
        /// <summary>
        /// Упражнение 2. Запрашивает число с клавиатуры, проверяет на вхождение в диапазон (5, 10).
        /// </summary>
        public static void EnteringTheRange()
        {
            /*Упражнение 2
              Напишите консольную программу, в которую пользователь вводит с клавиатуры число. 
              Если число одновременно больше 5 и меньше 10, то программа выводит "Число больше 5 и меньше 10". 
              Иначе программа выводит сообщение "Неизвестное число".*/
            Console.WriteLine("Упражнение 2. Запрашивает число с клавиатуры, проверяет на вхождение в диапазон (5, 10).\n" +
                "\nEnter the number:");
            int Number = Convert.ToInt32(Console.ReadLine());
            if (Number > 5 && Number < 10)
                Console.WriteLine("Number more than 5 and less than 10.");
            else Console.WriteLine("Unknown number.");
            Console.ReadLine();
        }
        /// <summary>
        /// Упражнение 3. Запрашивает число, проверяет на равенство с 5 или 10.
        /// </summary>
        public static void EqualityTest()
        {
            /*Упражнение 3
             Напишите консольную программу, в которую пользователь вводит с клавиатуры число. 
             Если число либо равно 5, либо равно 10, то программа выводит "Число либо равно 5, либо равно 10". 
             Иначе программа выводит сообщение "Неизвестное число".*/
            Console.WriteLine("Упражнение 3. Запрашивает число, проверяет на равенство с 5 или 10.\n" +
                "\nEnter the number:");
            int Number = Convert.ToInt32(Console.ReadLine());
            if (Number == 5 || Number == 10) Console.WriteLine("The number is either 5 or 10.");
            else Console.WriteLine("Unknown number.");
            Console.ReadLine();
        }
        /// <summary>
        /// Упражнение 4. Считает сумму вклада с начисленными процентами в зависимости от его размера.
        /// </summary>
        /// <returns>Возвращает сумму вклада.</returns>
        public static double AmountOfDeposit()
        {
            /*Упражнение 4
            В банке в зависимости от суммы вклада начисляемый процент по вкладу может отличаться.
            Напишите консольную программу, в которую пользователь вводит сумму вклада.Если сумма вклада меньше 100, то начисляется 5%. 
            Если сумма вклада от 100 до 200, то начисляется 7%. Если сумма вклада больше 200, то начисляется 10%. 
            В конце программа должна выводить сумму вклада с начисленными процентами.*/
            Console.WriteLine("Упражнение 4. Считает сумму вклада с начисленными процентами в зависимости от его размера.\n" +
                "\nВведите сумму вклада:");
            double Deposit = Convert.ToDouble(Console.ReadLine());
            if (Deposit < 100)
                Deposit += Deposit * 0.05; //В случае если вклад меньше 100, добавляем к нему 5%
            else if (Deposit >= 100 && Deposit <= 200)
                Deposit += Deposit * 0.07; //В случае если вклад меньше 200, но больше 100, добавляем к нему 7%
            else Deposit += Deposit * 0.1; //В остальных случаях добавляем к вкладу 10%
            Console.WriteLine("Сумма вклада на данный момент: {0}", Deposit);
            Console.ReadLine();
            return Deposit; //Возвращаем сумму вклада, это для следующего задания, чтобы не дублировать код
        }
        /// <summary>
        /// Упражнение 5. Дополнение к упражнению 5. Вызывает код 4-ого уражнения и добавляет к его сумме бонус 15.
        /// </summary>
        public static void AmountOfDepositBonus()
        {
            /*Упражнение 5
            Изменим предыдущую задачу. Допустим, банк периодически начисляет по всем вкладам кроме процентов бонусы. 
            И, допустим, сейчас банк решил доначислить по всем вкладам 15 единиц вне зависимости от их суммы. 
            Измените программу таким образом, чтобы к финальной суме дочислялись бонусы.*/
            Console.WriteLine("Упражнение 5. Дополнение к упражнению 5. Вызывает код 4-ого уражнения и добавляет к его сумме бонус 15.\n");
            int bonus = 15;
            double Deposit = AmountOfDeposit() + bonus;
            Console.WriteLine("Сумма вклада после добавления бонуса: {0}", Deposit);
            Console.ReadLine();
        }
        /// <summary>
        /// Упражнение 6 и 7. Калькулятор.
        /// </summary>
        public static void Calculator()
        {
            /*Упражнение 6
            Напишите консольную программу, которая выводит пользователю сообщение "Введите номер операции: 1.Сложение 2.Вычитание 3.Умножение". 
            Рядом с названием каждой операции указан ее номер, например, операция вычитания имеет номер 2. 
            Пусть пользователь вводит в программу номер операции, и в зависимости от номера операции программа выводит ему название операции.
            Для определения операции по введенному номеру используйте конструкцию switch...case.
            Если введенное пользователем число не соответствует никакой операции(например, число 120), то выведите пользователю сообщение о том, что операция неопределена.*/
            /*Упражнение 7
            Измените предыдущую программу.
            Пусть пользователь кроме номера операции вводит два числа, и в зависимости от номера операции с введенными числами 
            выполняются определенные действия(например, при вводе числа 3 числа умножаются).Результа операции выводиться на консоль.*/
            Console.WriteLine("Упражнение 6 и 7. Калькулятор." +
                "\nВведите два числа:");
            int a = Convert.ToInt32(Console.ReadLine()),
                b = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            Console.WriteLine("Выберите операцию: \n 1. Сложение \n 2. Вычитание \n 3. Умножение");
            int UserTask = Convert.ToInt32(Console.ReadLine());
            switch (UserTask) //В соотв. с введённым значением через консоль - вызываем необходимый кейс
            {
                case 1: //Сложение
                    Console.WriteLine("Вы выбрали сложение.");
                    result = a + b;
                    Console.WriteLine("Result is {0}", result);
                    Console.ReadLine();
                    break;
                case 2: //Вычитание
                    Console.WriteLine("Вы выбрали вычитание.");
                    result = a - b;
                    Console.WriteLine("Result is {0}", result);
                    Console.ReadLine();
                    break;
                case 3: // Умножение
                    Console.WriteLine("Вы выбрали умножение.");
                    result = a * b;
                    Console.WriteLine("Результат равен {0}", result);
                    Console.ReadLine();
                    break;
                default: //В случае некорректного ввода
                    Console.WriteLine("Такой операции в данном калькуляторе нет.");
                    Console.ReadLine();
                    break;
            }
        }
        /// <summary>
        /// Упражнение 1. Запрашивает сумму вклада и количество месяцев, и выводит конечную сумму вклада с учётом начисления процентов за каждый месяц.
        /// </summary>
        public static void DepositAmountPercentage()
        {
            /*Упражнение 1
            За каждый месяц банк начисляет к сумме вклада 7 % от суммы.
            Напишите консольную программу, в которую пользователь вводит сумму вклада и количество месяцев.
            А банк вычисляет конечную сумму вклада с учетом начисления процентов за каждый месяц.
            Для вычисления суммы с учетом процентов используйте цикл for. 
            Для ввода суммы вклада используйте выражение Convert.ToDecimal(Console.ReadLine())(сумма вклада будет представлять тип decimal).*/
            Console.WriteLine("Упражнение 1. Запрашивает сумму вклада и количество месяцев, и выводит конечную сумму вклада с учётом начисления процентов за каждый месяц.\n" +
                "\nEnter amount of deposit:");
            decimal Deposit = Convert.ToDecimal(Console.ReadLine()); //Тип decimal является числом с плавающей точкой, но с повышенной точностью в сравнении с double
            Console.WriteLine("Enter number of months:");
            int Months = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= Months; i++) //Цикл for, который считает начиная с первого месяца, и заканчивая месяцем введённым пользователем
            {
                Deposit += Deposit * 0.07M; //Добавление 7% к вкладу, от накопленной суммы
                Console.WriteLine("{0} mounth, deposit is {1}", i, Deposit);
                Console.ReadLine();
            }

        }
        /// <summary>
        /// Упражнение 2. Запрашивает сумму вклада и количество месяцев, и выводит конечную сумму вклада с учётом начисления процентов за каждый месяц (отличается реализацией в коде).
        /// </summary>
        public static void DepositAmountPercentage2()
        {
            /*Упражнение 2
            Перепишите предыдущую программу, только вместо цикла for используйте цикл while.*/
            Console.WriteLine("Упражнение 2. Запрашивает сумму вклада и количество месяцев, " +
                "и выводит конечную сумму вклада с учётом начисления процентов за каждый месяц " +
                "(отличается реализацией в коде).\n" +
                "\nВведите сумму вклада:");
            decimal Deposit = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Введите количество месяцев:");
            int Months = Convert.ToInt32(Console.ReadLine());
            while (Months > 0) //Цикл срабатывающий столько раз, сколько введено месяцев пользователем
            {
                Deposit += Deposit * 0.07M;
                Console.WriteLine("{0} месяцев, вклад равен {1}", Months, Deposit);
                Console.ReadLine();
                Months--;
            }
        }
        /// <summary>
        /// Упражнение 3. Выводит на консоль таблицу умножения.
        /// </summary>
        public static void MultiplicationTable()
        {
            /*Упражнение 3
            Напишите программу, которая выводит на консоль таблицу умножения*/
            Console.WriteLine("Упражнение 3. Выводит на консоль таблицу умножения.\n");
            for (int i = 1; i < 10; i++) //Стобцы
            {
                for (int j = 1; j < 10; j++) //Строки
                {
                    Console.Write($"{i * j}\t"); //Форматированный вывод текста
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        /// <summary>
        /// Упражнение 4. Запрашивает ввод двух чисел, пока оба вводимых числа не окажутся в диапазоне от 0 до 10. Умножает данные числа. 
        /// </summary>
        public static void MultiplicationOfNumbers()
        {
            /*Упражнение 4
            Напишите программу, в которую пользователь вводит два числа и выводит результат их умножения. 
            При этом программа должны запрашивать у пользователя ввод чисел, пока оба вводимых числа не окажутся в диапазоне от 0 до 10. 
            Если введенные числа окажутся больше 10 или меньше 0, то программа должна вывести пользователю о том, 
            что введенные числа недопустимы, и повторно запросить у пользователя ввод двух чисел. 
            Если введенные числа принадлежат диапазону от 0 до 10, то программа выводит результат умножения.
            Для организации ввода чисел используйте бесконечный цикл while и оператор break*/
            Console.WriteLine("Упражнение 4. Запрашивает ввод двух чисел, пока оба вводимых числа не окажутся в диапазоне от 0 до 10. Умножает данные числа. \n" +
                "\nВведите два числа от 0 до 10:");
            int a = Convert.ToInt32(Console.ReadLine()),
                b = Convert.ToInt32(Console.ReadLine());
            while (a < 0 || a > 10 || b < 0 || b > 10) //Проверка на вхождение двух чисел в диапазон [0, 10]
            {
                Console.WriteLine("Неподходящие числа, попробуйте ещё раз:");
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"{a} * {b} = {a * b}");
            Console.ReadLine();
        }
        /// <summary>
        /// Запрашивает размерность одномерного массива, заполняет его случайными значениями. 
        /// Сортирует массив либо по возрастанию, либо по убыванию.
        /// </summary>
        public static void ArraySorting()
        {
            Console.Write("Запрашивает длинну одномерного массива, заполняет его случайными цифрами. \nСортирует массив либо по возрастанию, либо по убыванию.\n" +
                "\nЗадайте длинну массива: ");
            Console.ForegroundColor = ConsoleColor.White;
            int[] array = new int[Convert.ToInt32(Console.ReadLine())];
            Random random = new Random();
            Console.Write("[");
            for (int el = 0; el < array.Length; el++)
            {
                array[el] = random.Next(-100, 100);
                Console.Write(array[el] + (el == array.Length - 1 ? "" : ", "));
            }
            Console.WriteLine("]\n");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Выберите сортировку:\n" +
            "1. По возрастанию [1, 2, 40, 100]\n" +
            "2. По убыванию [100, 40, 2, 1]\n");
            int buf = 0;

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                    {
                        for (int j = 0; j < array.Length; j++) //Сортировка по возрастанию
                        {
                            for (int i = 0; i < array.Length - 1; i++)
                            {
                                if (array[i] > array[i + 1])
                                {
                                    buf = array[i];
                                    array[i] = array[i + 1];
                                    array[i + 1] = buf;
                                }
                            }
                        }
                        break;
                    }
                case ConsoleKey.D2:
                    {
                        for (int j = 0; j < array.Length; j++) //Сортировка по убыванию
                        {
                            for (int i = 0; i < array.Length - 1; i++)
                            {
                                if (array[i] < array[i + 1])
                                {
                                    buf = array[i];
                                    array[i] = array[i + 1];
                                    array[i + 1] = buf;
                                }
                            }
                        }
                        break;
                    }
            }
            Console.WriteLine("Отсортированный массив: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("[");
            for (int el = 0; el < array.Length; el++)
            {
                Console.Write(array[el] + (el == array.Length - 1 ? "" : ", "));
            }
            Console.Write("]");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.ReadKey();
        }
        /// <summary>
        /// Запрашивает размерность двумерного массива, заполняет его случайными значениями. 
        /// Может подсчитать количество элементов в массиве, либо подсчитать количество заданных элементов
        /// </summary>
        public static void TwoDimensionalArray
()
        {
            Random random = new Random();
            Console.WriteLine("Установите размерность массива.\nДлинна строки:");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Количество столбцов:");
            int columns = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[row, columns];
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < columns; i++)
            {
                Console.Write("|");
                for (int j = 0; j < row; j++)
                {
                    array[i, j] = random.Next(-100, 100);
                    Console.Write("{0}\t", array[i, j]);
                }
                Console.WriteLine("|");
            }
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nВозможные операции:\n1. Подсчёт количества элементов в массиве.\n2. Поиск заданного элемента в массиве.");
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                    {
                        Console.WriteLine($"\nВы выбрали подсчёт количества элементов: {row * columns}");
                        break;
                    }
                case ConsoleKey.D2:
                    {
                        Console.Write("Введите число которое необходимо найти: ");
                        int number = Convert.ToInt32(Console.ReadLine()), sum = 0;
                        for (int i = 0; i < columns; i++)
                        {
                            for (int j = 0; j < row; j++)
                            {
                                if (number == array[i, j]) sum++;
                            }
                        }
                        Console.WriteLine($"Количество найденных элементов: {sum}");
                        break;
                    }
                default:
                    Console.WriteLine("Вы выбрали несуществующую операцию.");
                    break;
            }
            Console.ReadKey();
        }
    }  //Упражнения
}
