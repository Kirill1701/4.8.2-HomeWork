using System;

namespace _4._8._2_HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк: ");
            int lines = int.Parse(Console.ReadLine());      // Переменная строки
            Console.Write("Введите количество столбцов: ");
            int columns = int.Parse(Console.ReadLine());    // Переменная столбцы

            int[,] matrix = new int[lines, columns];        // Задание массива из полученных чисел
            int[,] matrix2 = new int[lines, columns];

            Random r = new Random();

            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = r.Next(100);             // Ограничение случайных чисел до 100
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n ");

            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix2[i, j] = r.Next(100);
                    Console.Write($"{matrix2[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nСумма массивов matrix и matrix2: ");

            int[,] matrix3 = new int[lines, columns];

            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix3[i, j] = matrix[i, j] + matrix2[i, j];
                    Console.Write($"{matrix3[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
