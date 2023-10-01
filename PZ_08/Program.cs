using System;
using System.ComponentModel.Design.Serialization;

namespace PZ_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
               
                Console.WriteLine("Создаём ступенчатый массив: ");
            Random r = new Random();
            double[][] array = new double[10][];
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    array[j] = new double[r.Next(10, 21)]; //заполнение рндомом
                }
            }

            double rndNum;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    rndNum = r.NextDouble() * 100;
                    array[i][j] = rndNum;
                    Console.Write(Math.Round(array[i][j], 2) + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Последние элементы каждой строки массива: ");
            double[] last = new double[7];
            for (int i = 0; i < last.Length; i++)
            {
                last[i] = array[i][^1];
                Console.Write(Math.Round(last[i], 2) + " ");
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Максимальные элементы в каждой строке массива: ");
            for (int i = 0; i < last.Length; i++)
            {
                last[i] = array[i].Max();
                Console.Write(Math.Round(last[i], 2) + " ");
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Смена 1 элемента массива с максимальным");
            for (int i = 0; i < array.Length; i++)
            {
                double b = array[i][0]; // сохраняем первое число каждого элемента массива arr в переменную b
                double c = array[i].Max(); // находим максимальное значение в каждом элементе массива arr и сохраняем его в переменную c
                int n = Array.IndexOf(array[i], c); // находим индекс максимального значения в каждом элементе массива arr и сохраняем его в переменную n
                array[i][0] = c; 
                array[i][n] = b;
            }
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(Math.Round(array[i][j], 2) + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Реверс строки: ");
            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                Array.Reverse(array[i]);
            }
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(Math.Round(array[i][j], 2) + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                double sum = 0;
                for (int j = 0; j < array[i].Length; j++)
                {
                    sum += array[i][j];
                }
                double av = sum / array[i].Length;
                Console.WriteLine($"Среднее значение в строке {i + 1}: " + Math.Round(av, 2));
            }
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                int len = array[i].Length;
                Console.WriteLine($"Количество чисел в строке {i + 1}: " + len);
            }
            Console.WriteLine();
            Console.WriteLine("Вычисления округлены до 2 знаков после запятой");
        }
        }
    }
}