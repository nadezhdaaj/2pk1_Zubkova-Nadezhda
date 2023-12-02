namespace PZ_12
{
    internal class Program
    {
      
    
        static char[,] Picture(int n)
        {
            char[,] array = new char[n, n];

            // заполняем нижним подчеркиванием
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = '_';
                }
            }
            // заполняем главную и побочную диагонали символом '*'
            for (int i = 0; i < n; i++)
            {
                array[i, i] = '*'; // координаты главной строки
                array[i, n - i - 1] = '*'; //координаты побочной строки
            }

            // заполняем пересечение диагоналей символом 'o'
            array[n / 2, n / 2] = 'o'; //центр массива, его позиция

            return array;
        }

        static void Main(string[] args)
        {
            int n = 7;
            char[,] matrix = Picture(n);

            // Вывод на консоль
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }

}


       
