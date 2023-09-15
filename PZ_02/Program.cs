using System.ComponentModel.Design;

namespace PZ_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Найдите значение выражения");

            double m, x, s, t, v;
            Console.WriteLine("Введите значение для m");
            m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение для x");
            x = Convert.ToDouble(Console.ReadLine());
            if (m < 0) //начало цикла, условие 1 для s
            {
                s = m - (m * Math.Pow(x, 2)) / (x + 1); //действия если данное условие истина
            }

            else 
                s = -10.6 * x; //выполняемые операции, если условие не соответствует истине
            
            if (s <= -1) //начало другого цикла, для t
            {
                t = m * s + (Math.Sin(x)) + m; //соответсвенное действие для него
            }
            else         
                t = s - Math.Pow(Math.Cos(s / x), 2); //операция, если условие ложь
            v = x + 3 * m * s - s * t;
            v = Math.Round(v, 2);//округление
            Console.Write("Значение уравнения равно: " + v);

                    
        }
    }
}