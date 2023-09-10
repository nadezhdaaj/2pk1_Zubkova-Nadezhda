namespace PZ_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //выводим сообщения на консоль с просьбой ввести поочерёдно переменные
            //конвертируем переменные в числа с плавующей запятой двойной точности
            
            Console.WriteLine("Введите число a");
            double a=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число c");
            double c = Convert.ToDouble(Console.ReadLine());
            //создаём переменные result1 и result2, в которые будут определяться значения 
            double result1, result2;
            //используем класс Math
            result1 = (Math.Log(5) / (Math.Sin(c)) - (Math.Sqrt(Math.Abs(-2.5 - Math.Pow(a, 2)))));
            result2 = ((Math.Pow(10,3)*(a-b))/Math.Cos(b))+(Math.Pow(Math.Abs(-5-Math.Pow(a, 2)), 1/3)-(2.5*c));
            //result для итогового значения
            double result = result1 - result2;
            //вывод ответа на консоль
            Console.WriteLine("Итоговое значение равно: " + result);
           


        }
    }
}