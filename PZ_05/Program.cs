using System.Reflection.Metadata.Ecma335;

namespace PZ_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Числовая последовательность Фибоначчи");
            Console.Write("Введите число A, при условии, что A > 1: ");
            int A = int.Parse(Console.ReadLine());

            int b = 1;
            int c = 1;
            int count = 2;

            while (c < A)
            {
                int temp = c;
                c = c + b;
                b = temp;
                count = count + 1;
            }

            if (c == A)
            {
                Console.WriteLine($"Данное число является {count}-ым числом Фибоначчи");
            }
            else
            {
                Console.WriteLine("-1");
            }


        }
               

        }
    }
