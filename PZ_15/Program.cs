using System.Text;

namespace PZ_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите полный путь к каталогу: ");
            string directoryPath = Console.ReadLine();

            // Проверяем, существует ли указанный каталог
            if (!Directory.Exists(directoryPath))
            {
                Console.WriteLine("Указанный каталог не существует");
                return;
            }

            // Получаем список текстовых файлов в указанном каталоге
            string[] files = Directory.GetFiles(directoryPath, "*.txt");

            // Обрабатываем каждый файл
            foreach (string file in files)
            {
                // Получаем информацию о файле
                FileInfo fileInfo = new FileInfo(file);

                // Проверяем размер файла
                if (fileInfo.Length < 10240) // 10 Кб = 10 * 1024 байт
                {
                    // Открываем файл для записи данных (произвольных)
                    using (StreamWriter writer = new StreamWriter(file, true))
                    {
                        // Записываем данные в файл
                        writer.WriteLine("Произвольные данные");
                    }

                    Console.WriteLine($"Данные успешно записаны в файл {file}");
                }
            }

            // Выводим список обновленных файлов
            Console.WriteLine("\nОбновленный список файлов:");

            foreach (string file in files)
            {
                FileInfo updatedFileInfo = new FileInfo(file);
                Console.WriteLine($"Название файла: {file}");
                Console.WriteLine($"Размер файла: {updatedFileInfo.Length} байт");
                Console.WriteLine();
            }
        }
    }
}