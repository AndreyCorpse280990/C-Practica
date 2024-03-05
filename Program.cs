using System;
using System.Runtime.InteropServices.ComTypes;

namespace C_Practica
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 1
            Task1(args);

            // Задание 2
            int[] arr = new int[5];
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0, 100);
            }
            Task2(arr, random);

            // Задание 3
            Task3();


            // Задание 4
            Date date1 = new Date(31, 12, 2024);
            Console.WriteLine($"Создана дата: {date1}");

            date1.Next();
            Console.WriteLine($"Дата после увеличения на один день: {date1}");

            int daysFromStart = date1.ToDays();
            Console.WriteLine($"Количество дней  c 01.01.0000: {daysFromStart}");

            Date date2 = new Date(31, 12, 2024);
            int dateOffset = date1.DateOffset(date2);
            Console.WriteLine($"Разница между {date1} и {date2} в днях: {dateOffset}");



        }

        // Пользователь вводит целое неотрицательное число. Программа должна посчитать общее количество цифр в числе, а также количество нулей в этом числе. 
        static void Task1(string[] args)
        {
            Console.WriteLine("Введите неотрицательное целое число:");
            string input = Console.ReadLine();
            uint number = 0;

            if (uint.TryParse(input, out number))
            {
                int countDigits = 0;
                int countZeros = 0;

                // Проверяем, если введенное число равно 0
                if (number == 0)
                {
                    countDigits = 1;
                    countZeros = 1;
                }
                else
                {
                    while (number > 0)
                    {
                        // последняя цифра числа
                        uint digit = number % 10;

                        countDigits++;

                        if (digit == 0)
                        {
                            countZeros++;
                        }

                        number /= 10;
                    }
                }

                Console.WriteLine($"Общее количество цифр в числе: {countDigits}");
                Console.WriteLine($"Количество нулей в числе: {countZeros}");
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите неотрицательное целое число.");
            }
        }



        //Создать одномерный массив случайных чисел. На его основе создать новый одномерный массив, состоящий из сумм соседних элементов исходного массива.
        //В случае нечетной длины исходного массива последнее число суммируется с нулем. 
        static void Task2(int[] arr, Random random)
        {
            bool isEvenLength = arr.Length % 2 == 0; // если массив нечётный
            int newLength = 0;

            newLength = arr.Length / 2;
            if (!isEvenLength) 
            {
                newLength++;
            }

            int[] newArr = new int[newLength];

            for (int i = 0; i < newLength - 1; i++)
            {
                newArr[i] = arr[2 * i] + arr[2 * i + 1];
            }

            if (!isEvenLength)
            {
                newArr[newLength - 1] = arr[arr.Length - 1];
            }

            Console.WriteLine("Исходный массив:");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine("\nНовый массив, состоящий из сумм соседних элементов:");
            foreach (int num in newArr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }



    /* 
    Задание 3. 
    Создать зубчатый двумерный массив по следующему правилу: 
    1 
    1 2 
    1 2 3 
    1 2 3 4 
    1 2 3 4 5 … n 
    n вводится пользователем. 
    */

    static void Task3() 
        {
            Console.WriteLine("Введите число n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[][] jaggedArray = new int[n][];

            // Заполнение массива
            for (int i = 0; i < n;i++)
            {
                jaggedArray[i] = new int[i + 1];

                for(int j = 0; j <= i; j++)
                {
                    jaggedArray[i][j] = j + 1;
                }
            }

            Console.WriteLine("Зубчатый двумерный массив:");
            // вывод в консоль
            foreach (int[] row in jaggedArray)
            {
                foreach (int num in row)
                {
                    Console.Write(num);
                }
                Console.WriteLine();
            }
        }
    }
}
