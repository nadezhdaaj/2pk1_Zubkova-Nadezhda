using System;
namespace PZ_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение: ");
            string text = Console.ReadLine();
            int count = 0;
                foreach (string word in text.Split(' ')); //разбираем предложение на слова, используя пробел
                {
                if (word[0] == 'о' && word[word.Lenght() - 1] == 'о') //проверяем каждое слово, заканчивается и начинается  ли оно на "о"
                {
                    count++;   // если да, увеличиваем счётчик
                }
                }
                Console.WriteLine($"Количество слов, начинающихся и заканчивающих на о равно {count}");
        }
    }
}