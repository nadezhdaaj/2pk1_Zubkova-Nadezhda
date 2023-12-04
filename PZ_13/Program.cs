using System.Collections;
using System.Collections.Generic;

namespace PZ_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 3.            2 45 
            Console.WriteLine("Вывод чисел в порядке убывания");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            // Вызываем рекурсивную функцию
            PrintRange(a, b);
        }

        // Рекурсивная функция PrintRange
        static void PrintRange(int a, int b)
        {
            // Если a равно b, то выводим a и завершаем рекурсию

            if (a == b)
            {
                Console.Write(a + " ");
                return;
            }
            // Иначе вызываем рекурсивно PrintRange с аргументами a+1 и b
            PrintRange(a + 1, b);
            // После завершения рекурсии выводим a
            Console.Write(a + " ");
        }



        /* static void Main(string[] args)
        {  // Задача 2. Геометрическая прогрессия. 
            static void Main(string[] args)
            {
                int n;
                Console.Write("Введите значение n: ");
                n = Convert.ToInt32(Console.ReadLine());
                double b1 = 7, q = -0.2;
                Console.WriteLine("b_{0} = {1} ", n, GeometricProgression(b1, q, n));
            }
            static double GeometricProgression(double b, double q, int n)
            {
                if (n < 0)
                    return 0;
                else
                    return GeometricProgression(b, q, n - 1) * q + b;
            }
        }   */



        /* static void Main(string[] args)
        { // Задача 1. Арифметическая прогрессия.
            Console.WriteLine("Введите количество элементов прогрессии: ");
            int n = Convert.ToInt32(Console.ReadLine()); 
            int first = -1000; // первый элемент прогрессии
            int step = -100; // шаг прогрессии
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{i + 1}) {Progression(first, step, i)}\t");
            }
        }
        // Функция для вычисления n-го члена арифметической прогрессии
        static int Progression(int first, int last, int n)
        {
            if (n == 0)
                return first;
            else
                return Progression(first, last, n - 1) + last;
        }   */
    
    }
}