using System.Text.RegularExpressions;

namespace Задача_для_закрепления
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст: ");
            string a = Console.ReadLine();
            Regex s = new Regex(@"\b\d{ 4 }\b");
            string result = s.Replace(a, "****");
            Console.WriteLine("Изменённый текст: ");
            }


        }
    }
}