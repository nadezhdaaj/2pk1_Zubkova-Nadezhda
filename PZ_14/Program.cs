using System;
using System.IO;
using System.Threading.Channels;

namespace PZ_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число x со значением не более 100: ");
            int x = int.Parse(Console.ReadLine());

            while (x > 100)
            {
                Console.Write("Некорректное число!!! Введите x заново :) ");
                x = int.Parse(Console.ReadLine());
            }

            // Формирование строк символов "*"
            string[] lines = new string[x];
            int half = x / 2;
            for (int i = 0; i < half; i++)
            {
                lines[i] = new string('*', i + 1);
                Console.WriteLine(lines[i]);
            }
            for (int i = half; i < x; i++)
            {
                lines[i] = new string('*', x - i);
                Console.WriteLine(lines[i]);
            }

            // Запись строк в файл
            using (StreamWriter writer = new StreamWriter("File PZ_14.txt"))
            {
                foreach (string line in lines)
                {
                    writer.WriteLine(line);
                }
                Console.ReadLine();
            }
        }  
    }
} 
    
