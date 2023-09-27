using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Одномерный массив");
        int[] array = new int[20];
        Random random = new Random(); //генератор случайных чисел
        for (int i = 0; i < array.Length; i++) // заполнение массива случайными числами
        {
            array[i] = random.Next(0, 20); 
        }
        var uElements = new System.Collections.Generic.Dictionary<int, int>(); // уникальные числа в массиве
        for (int i = 0; i < array.Length; i++) // считаем 
        {
            int number = array[i];

            if (uElements.ContainsKey(number))
            {
                uElements[number]++;
            }
            else
            {
                uElements[number] = 1;
            }
        }
        foreach (var count in uElements)
        {
            Console.WriteLine($"Число {count.Key} встречается {count.Value} раза");
        }

        
    }
}
