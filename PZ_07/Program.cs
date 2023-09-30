namespace PZ_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[5, 10];
            Random random = new Random(); // заполняем рандомными числами
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(0, 10);
                }
            }
            
            Console.WriteLine("Введите значение для числа n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int count = 0; // для подсчёта количества вхождений
            for (int i = 0; i < array.GetLength(0); i++) // элементы массива, проверяем совпадение с числом n
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == n)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine($"Элемент со значением {n} встречается {count} раз"); // результат
        }
    }
}